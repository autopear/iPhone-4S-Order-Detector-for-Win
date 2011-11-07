using System.Collections.Generic;

namespace iPhone4S
{
    partial class Form1
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TextBoxHelp = new System.Windows.Forms.TextBox();
            this.CheckSilent = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LabelArea = new System.Windows.Forms.Label();
            this.ComboArea = new System.Windows.Forms.ComboBox();
            this.LabelPageURL = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LabelInterval = new System.Windows.Forms.Label();
            this.TextBoxInterval = new System.Windows.Forms.TextBox();
            this.LabelFollow = new System.Windows.Forms.Label();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.GroupInterval = new System.Windows.Forms.GroupBox();
            this.ComboTimeUnit = new System.Windows.Forms.ComboBox();
            this.GroupSilent = new System.Windows.Forms.GroupBox();
            this.CheckBlackS = new System.Windows.Forms.CheckBox();
            this.CheckBlackM = new System.Windows.Forms.CheckBox();
            this.CheckWhiteS = new System.Windows.Forms.CheckBox();
            this.CheckWhiteM = new System.Windows.Forms.CheckBox();
            this.CheckBlackL = new System.Windows.Forms.CheckBox();
            this.CheckWhiteL = new System.Windows.Forms.CheckBox();
            this.GroupDevice = new System.Windows.Forms.GroupBox();
            this.ButtonSelectInverse = new System.Windows.Forms.Button();
            this.ButtonDeselectAll = new System.Windows.Forms.Button();
            this.ButtonSelectAll = new System.Windows.Forms.Button();
            this.GroupLanguage = new System.Windows.Forms.GroupBox();
            this.RadioSChinese = new System.Windows.Forms.RadioButton();
            this.RadioEnglish = new System.Windows.Forms.RadioButton();
            this.RadioTChinese = new System.Windows.Forms.RadioButton();
            this.LabelWeiBo = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.GroupInterval.SuspendLayout();
            this.GroupSilent.SuspendLayout();
            this.GroupDevice.SuspendLayout();
            this.GroupLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(44, 274);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(90, 52);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start\r\n";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxHelp
            // 
            this.TextBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxHelp.Location = new System.Drawing.Point(314, 38);
            this.TextBoxHelp.Multiline = true;
            this.TextBoxHelp.Name = "TextBoxHelp";
            this.TextBoxHelp.Size = new System.Drawing.Size(181, 214);
            this.TextBoxHelp.TabIndex = 3;
            // 
            // CheckSilent
            // 
            this.CheckSilent.AutoSize = true;
            this.CheckSilent.Location = new System.Drawing.Point(9, 24);
            this.CheckSilent.Name = "CheckSilent";
            this.CheckSilent.Size = new System.Drawing.Size(65, 17);
            this.CheckSilent.TabIndex = 4;
            this.CheckSilent.Text = "Enabled";
            this.CheckSilent.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "iPad Onlie Order Detector";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // LabelArea
            // 
            this.LabelArea.AutoSize = true;
            this.LabelArea.Location = new System.Drawing.Point(15, 12);
            this.LabelArea.Name = "LabelArea";
            this.LabelArea.Size = new System.Drawing.Size(32, 13);
            this.LabelArea.TabIndex = 6;
            this.LabelArea.Text = "Area:";
            // 
            // ComboArea
            // 
            this.ComboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboArea.FormattingEnabled = true;
            this.ComboArea.Items.AddRange(new object[] {
            "Hong Kong",
            "香港",
            "中国",
            "台灣",
            "대한민국",
            "New Zealand"});
            this.ComboArea.Location = new System.Drawing.Point(56, 8);
            this.ComboArea.Name = "ComboArea";
            this.ComboArea.Size = new System.Drawing.Size(78, 21);
            this.ComboArea.TabIndex = 7;
            this.ComboArea.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelPageURL
            // 
            this.LabelPageURL.AutoSize = true;
            this.LabelPageURL.Location = new System.Drawing.Point(140, 12);
            this.LabelPageURL.Name = "LabelPageURL";
            this.LabelPageURL.Size = new System.Drawing.Size(32, 13);
            this.LabelPageURL.TabIndex = 10;
            this.LabelPageURL.Text = "URL:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 20);
            this.textBox3.TabIndex = 11;
            // 
            // LabelInterval
            // 
            this.LabelInterval.AutoSize = true;
            this.LabelInterval.Location = new System.Drawing.Point(6, 21);
            this.LabelInterval.Name = "LabelInterval";
            this.LabelInterval.Size = new System.Drawing.Size(45, 13);
            this.LabelInterval.TabIndex = 12;
            this.LabelInterval.Text = "Interval:";
            // 
            // TextBoxInterval
            // 
            this.TextBoxInterval.Location = new System.Drawing.Point(57, 18);
            this.TextBoxInterval.Name = "TextBoxInterval";
            this.TextBoxInterval.Size = new System.Drawing.Size(37, 20);
            this.TextBoxInterval.TabIndex = 13;
            this.TextBoxInterval.Text = "5";
            // 
            // LabelFollow
            // 
            this.LabelFollow.AutoSize = true;
            this.LabelFollow.Location = new System.Drawing.Point(258, 274);
            this.LabelFollow.Name = "LabelFollow";
            this.LabelFollow.Size = new System.Drawing.Size(85, 13);
            this.LabelFollow.TabIndex = 15;
            this.LabelFollow.Text = "Follow autopear:";
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(442, 7);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(53, 23);
            this.ButtonOpen.TabIndex = 16;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(361, 60);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // GroupInterval
            // 
            this.GroupInterval.Controls.Add(this.ComboTimeUnit);
            this.GroupInterval.Controls.Add(this.LabelInterval);
            this.GroupInterval.Controls.Add(this.TextBoxInterval);
            this.GroupInterval.Location = new System.Drawing.Point(161, 38);
            this.GroupInterval.Name = "GroupInterval";
            this.GroupInterval.Size = new System.Drawing.Size(147, 45);
            this.GroupInterval.TabIndex = 29;
            this.GroupInterval.TabStop = false;
            this.GroupInterval.Text = "Detection Interval";
            // 
            // ComboTimeUnit
            // 
            this.ComboTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTimeUnit.FormattingEnabled = true;
            this.ComboTimeUnit.Items.AddRange(new object[] {
            "H",
            "M",
            "S"});
            this.ComboTimeUnit.Location = new System.Drawing.Point(100, 18);
            this.ComboTimeUnit.Name = "ComboTimeUnit";
            this.ComboTimeUnit.Size = new System.Drawing.Size(37, 21);
            this.ComboTimeUnit.TabIndex = 14;
            this.ComboTimeUnit.SelectedIndexChanged += new System.EventHandler(this.ComboTimeUnit_SelectedIndexChanged);
            // 
            // GroupSilent
            // 
            this.GroupSilent.Controls.Add(this.CheckSilent);
            this.GroupSilent.Location = new System.Drawing.Point(161, 89);
            this.GroupSilent.Name = "GroupSilent";
            this.GroupSilent.Size = new System.Drawing.Size(147, 54);
            this.GroupSilent.TabIndex = 30;
            this.GroupSilent.TabStop = false;
            this.GroupSilent.Text = "Silent Mode";
            // 
            // CheckBlackS
            // 
            this.CheckBlackS.AutoSize = true;
            this.CheckBlackS.Checked = true;
            this.CheckBlackS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBlackS.Location = new System.Drawing.Point(11, 51);
            this.CheckBlackS.Name = "CheckBlackS";
            this.CheckBlackS.Size = new System.Drawing.Size(83, 17);
            this.CheckBlackS.TabIndex = 32;
            this.CheckBlackS.Text = "Black 16GB";
            this.CheckBlackS.UseVisualStyleBackColor = true;
            // 
            // CheckBlackM
            // 
            this.CheckBlackM.AutoSize = true;
            this.CheckBlackM.Checked = true;
            this.CheckBlackM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBlackM.Location = new System.Drawing.Point(97, 51);
            this.CheckBlackM.Name = "CheckBlackM";
            this.CheckBlackM.Size = new System.Drawing.Size(83, 17);
            this.CheckBlackM.TabIndex = 33;
            this.CheckBlackM.Text = "Black 32GB";
            this.CheckBlackM.UseVisualStyleBackColor = true;
            // 
            // CheckWhiteS
            // 
            this.CheckWhiteS.AutoSize = true;
            this.CheckWhiteS.Checked = true;
            this.CheckWhiteS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckWhiteS.Location = new System.Drawing.Point(11, 75);
            this.CheckWhiteS.Name = "CheckWhiteS";
            this.CheckWhiteS.Size = new System.Drawing.Size(84, 17);
            this.CheckWhiteS.TabIndex = 34;
            this.CheckWhiteS.Text = "White 16GB";
            this.CheckWhiteS.UseVisualStyleBackColor = true;
            // 
            // CheckWhiteM
            // 
            this.CheckWhiteM.AutoSize = true;
            this.CheckWhiteM.Checked = true;
            this.CheckWhiteM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckWhiteM.Location = new System.Drawing.Point(97, 75);
            this.CheckWhiteM.Name = "CheckWhiteM";
            this.CheckWhiteM.Size = new System.Drawing.Size(84, 17);
            this.CheckWhiteM.TabIndex = 35;
            this.CheckWhiteM.Text = "White 32GB";
            this.CheckWhiteM.UseVisualStyleBackColor = true;
            // 
            // CheckBlackL
            // 
            this.CheckBlackL.AutoSize = true;
            this.CheckBlackL.Checked = true;
            this.CheckBlackL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBlackL.Location = new System.Drawing.Point(187, 51);
            this.CheckBlackL.Name = "CheckBlackL";
            this.CheckBlackL.Size = new System.Drawing.Size(83, 17);
            this.CheckBlackL.TabIndex = 36;
            this.CheckBlackL.Text = "Black 64GB";
            this.CheckBlackL.UseVisualStyleBackColor = true;
            // 
            // CheckWhiteL
            // 
            this.CheckWhiteL.AutoSize = true;
            this.CheckWhiteL.Checked = true;
            this.CheckWhiteL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckWhiteL.Location = new System.Drawing.Point(187, 75);
            this.CheckWhiteL.Name = "CheckWhiteL";
            this.CheckWhiteL.Size = new System.Drawing.Size(84, 17);
            this.CheckWhiteL.TabIndex = 37;
            this.CheckWhiteL.Text = "White 64GB";
            this.CheckWhiteL.UseVisualStyleBackColor = true;
            // 
            // GroupDevice
            // 
            this.GroupDevice.Controls.Add(this.ButtonSelectInverse);
            this.GroupDevice.Controls.Add(this.ButtonDeselectAll);
            this.GroupDevice.Controls.Add(this.ButtonSelectAll);
            this.GroupDevice.Controls.Add(this.CheckWhiteL);
            this.GroupDevice.Controls.Add(this.CheckBlackS);
            this.GroupDevice.Controls.Add(this.CheckBlackL);
            this.GroupDevice.Controls.Add(this.CheckBlackM);
            this.GroupDevice.Controls.Add(this.CheckWhiteM);
            this.GroupDevice.Controls.Add(this.CheckWhiteS);
            this.GroupDevice.Location = new System.Drawing.Point(18, 149);
            this.GroupDevice.Name = "GroupDevice";
            this.GroupDevice.Size = new System.Drawing.Size(290, 105);
            this.GroupDevice.TabIndex = 38;
            this.GroupDevice.TabStop = false;
            this.GroupDevice.Text = "Select Device";
            // 
            // ButtonSelectInverse
            // 
            this.ButtonSelectInverse.Location = new System.Drawing.Point(187, 19);
            this.ButtonSelectInverse.Name = "ButtonSelectInverse";
            this.ButtonSelectInverse.Size = new System.Drawing.Size(87, 23);
            this.ButtonSelectInverse.TabIndex = 40;
            this.ButtonSelectInverse.Text = "Select Inverse";
            this.ButtonSelectInverse.UseVisualStyleBackColor = true;
            this.ButtonSelectInverse.Click += new System.EventHandler(this.ButtonSelectInverse_Click);
            // 
            // ButtonDeselectAll
            // 
            this.ButtonDeselectAll.Location = new System.Drawing.Point(97, 19);
            this.ButtonDeselectAll.Name = "ButtonDeselectAll";
            this.ButtonDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeselectAll.TabIndex = 39;
            this.ButtonDeselectAll.Text = "Deselect All";
            this.ButtonDeselectAll.UseVisualStyleBackColor = true;
            this.ButtonDeselectAll.Click += new System.EventHandler(this.ButtonDeselectAll_Click);
            // 
            // ButtonSelectAll
            // 
            this.ButtonSelectAll.Location = new System.Drawing.Point(11, 19);
            this.ButtonSelectAll.Name = "ButtonSelectAll";
            this.ButtonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelectAll.TabIndex = 38;
            this.ButtonSelectAll.Text = "Select All";
            this.ButtonSelectAll.UseVisualStyleBackColor = true;
            this.ButtonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // GroupLanguage
            // 
            this.GroupLanguage.Controls.Add(this.RadioSChinese);
            this.GroupLanguage.Controls.Add(this.RadioEnglish);
            this.GroupLanguage.Controls.Add(this.RadioTChinese);
            this.GroupLanguage.Location = new System.Drawing.Point(18, 38);
            this.GroupLanguage.Name = "GroupLanguage";
            this.GroupLanguage.Size = new System.Drawing.Size(122, 105);
            this.GroupLanguage.TabIndex = 39;
            this.GroupLanguage.TabStop = false;
            this.GroupLanguage.Text = "Language";
            // 
            // RadioSChinese
            // 
            this.RadioSChinese.AutoSize = true;
            this.RadioSChinese.Location = new System.Drawing.Point(6, 75);
            this.RadioSChinese.Name = "RadioSChinese";
            this.RadioSChinese.Size = new System.Drawing.Size(73, 17);
            this.RadioSChinese.TabIndex = 2;
            this.RadioSChinese.Text = "简体中文";
            this.RadioSChinese.UseVisualStyleBackColor = true;
            this.RadioSChinese.CheckedChanged += new System.EventHandler(this.RadioSChinese_CheckedChanged);
            // 
            // RadioEnglish
            // 
            this.RadioEnglish.AutoSize = true;
            this.RadioEnglish.Checked = true;
            this.RadioEnglish.Location = new System.Drawing.Point(6, 19);
            this.RadioEnglish.Name = "RadioEnglish";
            this.RadioEnglish.Size = new System.Drawing.Size(59, 17);
            this.RadioEnglish.TabIndex = 0;
            this.RadioEnglish.TabStop = true;
            this.RadioEnglish.Text = "English";
            this.RadioEnglish.UseVisualStyleBackColor = true;
            this.RadioEnglish.CheckedChanged += new System.EventHandler(this.RadioEnglish_CheckedChanged);
            // 
            // RadioTChinese
            // 
            this.RadioTChinese.AutoSize = true;
            this.RadioTChinese.Location = new System.Drawing.Point(6, 47);
            this.RadioTChinese.Name = "RadioTChinese";
            this.RadioTChinese.Size = new System.Drawing.Size(73, 17);
            this.RadioTChinese.TabIndex = 1;
            this.RadioTChinese.Text = "繁體中文";
            this.RadioTChinese.UseVisualStyleBackColor = true;
            this.RadioTChinese.CheckedChanged += new System.EventHandler(this.RadioTChinese_CheckedChanged);
            // 
            // LabelWeiBo
            // 
            this.LabelWeiBo.AutoSize = true;
            this.LabelWeiBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelWeiBo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelWeiBo.Location = new System.Drawing.Point(345, 274);
            this.LabelWeiBo.Name = "LabelWeiBo";
            this.LabelWeiBo.Size = new System.Drawing.Size(136, 13);
            this.LabelWeiBo.TabIndex = 40;
            this.LabelWeiBo.Text = "http://weibo.com/autopear";
            this.LabelWeiBo.Click += new System.EventHandler(this.LabelWeiBo_Click);
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Location = new System.Drawing.Point(297, 300);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(139, 26);
            this.LabelCopyright.TabIndex = 41;
            this.LabelCopyright.Text = "Copyright (C) 2011 autopear\r\nAll rights resvered.";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 345);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelWeiBo);
            this.Controls.Add(this.GroupLanguage);
            this.Controls.Add(this.GroupDevice);
            this.Controls.Add(this.TextBoxHelp);
            this.Controls.Add(this.GroupSilent);
            this.Controls.Add(this.GroupInterval);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.LabelFollow);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LabelPageURL);
            this.Controls.Add(this.ComboArea);
            this.Controls.Add(this.LabelArea);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "iPhone 4S Online Order Detector v1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.GroupInterval.ResumeLayout(false);
            this.GroupInterval.PerformLayout();
            this.GroupSilent.ResumeLayout(false);
            this.GroupSilent.PerformLayout();
            this.GroupDevice.ResumeLayout(false);
            this.GroupDevice.PerformLayout();
            this.GroupLanguage.ResumeLayout(false);
            this.GroupLanguage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox TextBoxHelp;
        private System.Windows.Forms.CheckBox CheckSilent;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label LabelArea;
        private System.Windows.Forms.ComboBox ComboArea;
        private System.Windows.Forms.Label LabelPageURL;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LabelInterval;
        private System.Windows.Forms.TextBox TextBoxInterval;
        private System.Windows.Forms.Label LabelFollow;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.GroupBox GroupInterval;
        private System.Windows.Forms.GroupBox GroupSilent;
        private System.Windows.Forms.CheckBox CheckBlackS;
        private System.Windows.Forms.CheckBox CheckBlackM;
        private System.Windows.Forms.CheckBox CheckWhiteS;
        private System.Windows.Forms.CheckBox CheckWhiteM;
        private System.Windows.Forms.CheckBox CheckBlackL;
        private System.Windows.Forms.CheckBox CheckWhiteL;
        private System.Windows.Forms.GroupBox GroupDevice;
        private System.Windows.Forms.Button ButtonSelectAll;
        private System.Windows.Forms.Button ButtonDeselectAll;
        private System.Windows.Forms.ComboBox ComboTimeUnit;
        private System.Windows.Forms.GroupBox GroupLanguage;
        private System.Windows.Forms.RadioButton RadioSChinese;
        private System.Windows.Forms.RadioButton RadioEnglish;
        private System.Windows.Forms.RadioButton RadioTChinese;
        private System.Windows.Forms.Button ButtonSelectInverse;
        private System.Windows.Forms.Label LabelWeiBo;
        private System.Windows.Forms.Label LabelCopyright;

        public int IntervalUnit;
        public int interval;
        public string URLTemplate = "http://store.apple.com/AREACODE/configure/DEVICECODE/A?select=select&product=DEVICECODE%2FA&cppart=UNLOCKED%2FWW&mco=";
        public string AreaCode = "hk", DeviceSuffix="ZP";
        public string TextBlack = "Black", TextWhite = "White";
        public string DeviceB16, DeviceB32, DeviceB64, DeviceW16, DeviceW32, DeviceW64;
        public List<string> ListURL, ListDevice;
        public string ErrorTitle = "Error", IntervalError = "The interval must be a integer!", AlertPrefix = "Devices below can be ordered now:\r\n\r\n", AlertTitle = "You can order iPhone 4S now!", AlertSuffix = "\r\nPress OK to open the page to order iPhone 4S, or press Cancel to continue running.", DeviceError = "You must select at least one device.";
        public string BalloonTipStart = "Detection started! Double click the icon to show the main window.", BalloonTipNA = "None of your selected device is available for order.";
    }
}
