using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace iPhone4S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBoxHelp.ReadOnly = true;
            interval = 5;
            TextBoxHelp.Text = "1. Select an area where you want to order iPhone 4S from.\r\n\r\n2. Select the device(s) you want to order.\r\n\r\n3. Set the detection interval and the time unit.\r\n\r\n4. You can enable silent mode, which will only warn you when an order is available.";

            ComboArea.SelectedIndex = 0;
            ComboTimeUnit.SelectedIndex = 1;
            RadioEnglish.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListURL != null)
                ListURL.Clear();
            else
                ListURL = new List<string> {};

            if (ListDevice  != null)
                ListDevice.Clear();
            else
                ListDevice = new List<string> {};

            if (CheckBlackS.Checked)
            {
                ListURL.Add(URLTemplate.Replace("AREACODE", AreaCode).Replace("DEVICECODE", "MD234" + DeviceSuffix));
                ListDevice.Add(TextBlack + " 16GB");
            }
            if (CheckBlackM.Checked)
            {
                ListURL.Add(URLTemplate.Replace("AREACODE", AreaCode).Replace("DEVICECODE", "MD241" + DeviceSuffix));
                ListDevice.Add(TextBlack + " 32GB");
            }
            if (CheckBlackL.Checked)
            {
                ListURL.Add(URLTemplate.Replace("AREACODE", AreaCode).Replace("DEVICECODE", "MD257" + DeviceSuffix));
                ListDevice.Add(TextBlack + " 64GB");
            }
            if (CheckWhiteS.Checked)
            {
                ListURL.Add(URLTemplate.Replace("AREACODE", AreaCode).Replace("DEVICECODE", "MD237" + DeviceSuffix));
                ListDevice.Add(TextWhite + " 16GB");
            }
            if (CheckWhiteM.Checked)
            {
                ListURL.Add(URLTemplate.Replace("AREACODE", AreaCode).Replace("DEVICECODE", "MD244" + DeviceSuffix));
                ListDevice.Add(TextWhite + " 32GB");
            }
            if (CheckWhiteL.Checked)
            {
                ListURL.Add(URLTemplate.Replace("AREACODE", AreaCode).Replace("DEVICECODE", "MD260" + DeviceSuffix));
                ListDevice.Add(TextWhite + " 64GB");
            }

            if (ListURL.Count == 0)
            {
                MessageBox.Show(DeviceError, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                interval = Convert.ToInt32(TextBoxInterval.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(IntervalError, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread thread = new Thread(new ThreadStart(ThreadApple));
            this.Hide();
            thread.IsBackground = true;
            thread.Start();
            this.notifyIcon1.BalloonTipText = BalloonTipStart;
            this.notifyIcon1.ShowBalloonTip(5000);
        }

        private void ThreadApple()
        {
            while (true)
            {
                string AlertContent = "";
                for (int i = 0; i < ListURL.Count; i++)
                {
                    //Ready for order
                    if (GetHTTPResponseCode(ListURL[i]) == 200)
                    {
                        AlertContent += "  * iPhone 4S ";
                        AlertContent += ListDevice[i];
                        AlertContent += "\r\n";
                    }
                }

                if (!AlertContent.Equals(""))
                {
                    string soundFileName = "music.mp3";
                    axWindowsMediaPlayer1.URL = soundFileName;
                    if (MessageBox.Show(AlertPrefix + AlertContent + AlertSuffix, AlertTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start(textBox3.Text);
                        Application.Exit();
                    }
                    else
                    {
                        if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                            axWindowsMediaPlayer1.Ctlcontrols.stop();
                    }
                }
                else
                {
                    if (!CheckSilent.Checked)
                    {
                        this.notifyIcon1.BalloonTipText = BalloonTipNA;
                        this.notifyIcon1.ShowBalloonTip(5000);
                    }
                }
                Thread.Sleep(1000 * IntervalUnit * interval);
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private int GetHTTPResponseCode(string url)
        {
            try
            {
                HttpWebRequest PageRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse ServerResponse = (HttpWebResponse)PageRequest.GetResponse();
                ServerResponse.Close();
                return (int)ServerResponse.StatusCode;
            }
            catch (WebException we)
            {
                return (int)((HttpWebResponse)we.Response).StatusCode;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hong Kong English
            if (ComboArea.SelectedIndex == 0)
            {
                AreaCode = "hk";
                DeviceSuffix = "ZP";
            }
            //Hong Kong Chinese
            if (ComboArea.SelectedIndex == 1)
            {
                AreaCode = "hk-zh";
                DeviceSuffix = "ZP";
            }
            //China
            if (ComboArea.SelectedIndex == 2)
            {
                AreaCode = "cn";
                DeviceSuffix = "CH";
            }
            //Taiwan
            if (ComboArea.SelectedIndex == 3)
            {
                AreaCode = "tw";
                DeviceSuffix = "TA";
            }
            //Australia
            if (ComboArea.SelectedIndex == 4)
            {
                AreaCode = "au";
                DeviceSuffix = "X";
            }
            textBox3.Text = "http://store.apple.com/AREACODE/browse/home/shop_iphone/family/iphone/iphone4s".Replace("AREACODE", AreaCode);
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(textBox3.Text);
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            CheckBlackS.Checked = true;
            CheckBlackM.Checked = true;
            CheckBlackL.Checked = true;
            CheckWhiteS.Checked = true;
            CheckWhiteM.Checked = true;
            CheckWhiteL.Checked = true;
        }

        private void ButtonDeselectAll_Click(object sender, EventArgs e)
        {
            CheckBlackS.Checked = false;
            CheckBlackM.Checked = false;
            CheckBlackL.Checked = false;
            CheckWhiteS.Checked = false;
            CheckWhiteM.Checked = false;
            CheckWhiteL.Checked = false;
        }

        private void ButtonSelectInverse_Click(object sender, EventArgs e)
        {
            CheckBlackS.Checked = !CheckBlackS.Checked;
            CheckBlackM.Checked = !CheckBlackM.Checked;
            CheckBlackL.Checked = !CheckBlackL.Checked;
            CheckWhiteS.Checked = !CheckWhiteS.Checked;
            CheckWhiteM.Checked = !CheckWhiteM.Checked;
            CheckWhiteL.Checked = !CheckWhiteL.Checked;
        }

        private void ChangeLocale(int index)
        {
            int TimeUnit = ComboTimeUnit.SelectedIndex;

            //English
            if (index == 0)
            {
                this.Text = "iPhone 4S Online Order Detector v1.0";
                LabelArea.Text = "Area";
                LabelPageURL.Text = "URL:";
                ButtonOpen.Text = "Open";
                GroupDevice.Text = "Select Device";
                ButtonSelectAll.Text = "Select All";
                ButtonDeselectAll.Text = "Deselect All";
                ButtonSelectInverse.Text = "Select Inverse";
                CheckBlackS.Text = "Black 16GB";
                CheckBlackM.Text = "Black 32GB";
                CheckBlackL.Text = "Black 64GB";
                CheckWhiteS.Text = "White 16GB";
                CheckWhiteM.Text = "White 32GB";
                CheckWhiteL.Text = "White 64GB";
                GroupInterval.Text = "Detection Interval";
                LabelInterval.Text = "Interval:";
                ComboTimeUnit.Items.Clear();
                ComboTimeUnit.Items.Add("H");
                ComboTimeUnit.Items.Add("M");
                ComboTimeUnit.Items.Add("S");
                ComboTimeUnit.SelectedIndex = TimeUnit;
                GroupSilent.Text = "Silent Mode";
                CheckSilent.Text = "Enabled";
                GroupLanguage.Text = "Language";
                ButtonStart.Text = "Start";
                TextBlack = "Black";
                TextWhite = "White";
                IntervalError = "The interval must be a integer!";
                ErrorTitle = "Error";
                DeviceError = "You must select at least one device.";
                AlertPrefix = "Devices below can be ordered now:\r\n\r\n";
                AlertTitle = "You can order iPhone 4S now!";
                AlertSuffix = "\r\nPress OK to open the page to order iPhone 4S, or press Cancel to continue running.";
                BalloonTipStart = "Detection started! Double click the icon to show the main window.";
                BalloonTipNA = "None of your selected device is available for order.";
                TextBoxHelp.Text = "1. Select an area where you want to order iPhone 4S from.\r\n\r\n2. Select the device(s) you want to order.\r\n\r\n3. Set the detection interval and the time unit.\r\n\r\n4. You can enable silent mode, which will only warn you when an order is available.";
                LabelFollow.Text = "Follow autopear:";
            }
            //Traditional Chinese
            if (index == 1)
            {
                this.Text = "iPhone 4S 在綫訂購探測 v1.0";
                LabelArea.Text = "地區";
                LabelPageURL.Text = "位址：";
                ButtonOpen.Text = "開啟";
                GroupDevice.Text = "選擇設備";
                ButtonSelectAll.Text = "全選";
                ButtonDeselectAll.Text = "全不選";
                ButtonSelectInverse.Text = "反選";
                CheckBlackS.Text = "黑色 16GB";
                CheckBlackM.Text = "黑色 32GB";
                CheckBlackL.Text = "黑色 64GB";
                CheckWhiteS.Text = "白色 16GB";
                CheckWhiteM.Text = "白色 32GB";
                CheckWhiteL.Text = "白色 64GB";
                GroupInterval.Text = "探測間隔時間";
                LabelInterval.Text = "間隔：";
                ComboTimeUnit.Items.Clear();
                ComboTimeUnit.Items.Add("時");
                ComboTimeUnit.Items.Add("分");
                ComboTimeUnit.Items.Add("秒");
                ComboTimeUnit.SelectedIndex = TimeUnit;
                GroupSilent.Text = "靜默模式";
                CheckSilent.Text = "啟用";
                GroupLanguage.Text = "語言";
                ButtonStart.Text = "開始";
                TextBlack = "黑色";
                TextWhite = "白色";
                IntervalError = "間隔時間必須是整數！";
                ErrorTitle = "錯誤";
                DeviceError = "你必須選擇至少一個設備。";
                AlertPrefix = "下列設備已可訂購：\r\n\r\n";
                AlertTitle = "現已可訂購 iPhone 4S！";
                AlertSuffix = "\r\n點擊確定打開訂購頁面，或點擊取消以繼續執行。";
                BalloonTipStart = "探測開始！雙擊本圖示以顯示窗口。";
                BalloonTipNA = "沒有設備可供訂購。";
                TextBoxHelp.Text = "1. 選擇要訂購 iPhone 4S 的地區；\r\n\r\n2. 選擇要訂購的設備型號；\r\n\r\n3. 設定檢測間隔時間和單位；\r\n\r\n4. 如需只在可訂購時發出提醒，請啟用靜默模式。";
                LabelFollow.Text = "關注 autopear：";
            }
            //Simplified Chinese
            if (index == 2)
            {
                this.Text = "iPhone 4S 在线订购检测 v1.0";
                LabelArea.Text = "地区";
                LabelPageURL.Text = "地址：";
                ButtonOpen.Text = "打开";
                GroupDevice.Text = "选择设备";
                ButtonSelectAll.Text = "全选";
                ButtonDeselectAll.Text = "全不选";
                ButtonSelectInverse.Text = "反选";
                CheckBlackS.Text = "黑色 16GB";
                CheckBlackM.Text = "黑色 32GB";
                CheckBlackL.Text = "黑色 64GB";
                CheckWhiteS.Text = "白色 16GB";
                CheckWhiteM.Text = "白色 32GB";
                CheckWhiteL.Text = "白色 64GB";
                GroupInterval.Text = "探测间隔时间";
                LabelInterval.Text = "间隔：";
                ComboTimeUnit.Items.Clear();
                ComboTimeUnit.Items.Add("时");
                ComboTimeUnit.Items.Add("分");
                ComboTimeUnit.Items.Add("秒");
                ComboTimeUnit.SelectedIndex = TimeUnit;
                GroupSilent.Text = "静默模式";
                CheckSilent.Text = "启用";
                GroupLanguage.Text = "语言";
                ButtonStart.Text = "开始";
                TextBlack = "黑色";
                TextWhite = "白色";
                IntervalError = "间隔时间必须是整数！";
                ErrorTitle = "错误";
                DeviceError = "您必须选择至少一个设备。";
                AlertPrefix = "下列设备已可订购：\r\n\r\n";
                AlertTitle = "现已可订购 iPhone 4S！";
                AlertSuffix = "\r\n点击确定打开订购页面，或点击取消以继续运行。";
                BalloonTipStart = "检测开始！双击本图标以显示窗口。";
                BalloonTipNA = "没有设备可供订购。";
                TextBoxHelp.Text = "1. 选择要订购 iPhone 4S 的地区；\r\n\r\n2. 选择要订购的设备型号；\r\n\r\n3. 设定检测间隔时间和单位；\r\n\r\n4. 如需只在可订购时发出提醒，请启用静默模式。";
                LabelFollow.Text = "关注 autopear：";
            }
        }

        private void RadioEnglish_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLocale(0);
        }

        private void RadioTChinese_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLocale(1);
        }

        private void RadioSChinese_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLocale(2);
        }

        private void ComboTimeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTimeUnit.SelectedIndex == 0)
                IntervalUnit = 3600; //in hour
            if (ComboTimeUnit.SelectedIndex == 1)
                IntervalUnit = 60; //in hour
            if (ComboTimeUnit.SelectedIndex == 2)
                IntervalUnit = 1; //in hour           
        }

        private void LabelWeiBo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://weibo.com/autopear");
        }
    }
}


