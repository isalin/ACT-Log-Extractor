namespace ACT_Log_Extractor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_logs = new System.Windows.Forms.GroupBox();
            this.listBox_logs = new System.Windows.Forms.ListBox();
            this.groupBox_formatting = new System.Windows.Forms.GroupBox();
            this.checkBox_names = new System.Windows.Forms.CheckBox();
            this.checkBox_channel = new System.Windows.Forms.CheckBox();
            this.checkBox_timestamps = new System.Windows.Forms.CheckBox();
            this.groupBox_include = new System.Windows.Forms.GroupBox();
            this.groupBox_linkshells = new System.Windows.Forms.GroupBox();
            this.checkBox_linkshell4 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell5 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell8 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell7 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell6 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell3 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell2 = new System.Windows.Forms.CheckBox();
            this.checkBox_linkshell1 = new System.Windows.Forms.CheckBox();
            this.checkBox_tell = new System.Windows.Forms.CheckBox();
            this.checkBox_freeCompany = new System.Windows.Forms.CheckBox();
            this.checkBox_shout = new System.Windows.Forms.CheckBox();
            this.checkBox_yell = new System.Windows.Forms.CheckBox();
            this.checkBox_alliance = new System.Windows.Forms.CheckBox();
            this.checkBox_party = new System.Windows.Forms.CheckBox();
            this.checkBox_say = new System.Windows.Forms.CheckBox();
            this.groupBox_export_settings = new System.Windows.Forms.GroupBox();
            this.radioButton_exportToSeparate = new System.Windows.Forms.RadioButton();
            this.radioButton_exportToSingle = new System.Windows.Forms.RadioButton();
            this.button_exportHTML = new System.Windows.Forms.Button();
            this.button_exportText = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox_logs.SuspendLayout();
            this.groupBox_formatting.SuspendLayout();
            this.groupBox_include.SuspendLayout();
            this.groupBox_linkshells.SuspendLayout();
            this.groupBox_export_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_logs
            // 
            this.groupBox_logs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_logs.Controls.Add(this.listBox_logs);
            this.groupBox_logs.Location = new System.Drawing.Point(12, 12);
            this.groupBox_logs.Name = "groupBox_logs";
            this.groupBox_logs.Size = new System.Drawing.Size(200, 347);
            this.groupBox_logs.TabIndex = 0;
            this.groupBox_logs.TabStop = false;
            this.groupBox_logs.Text = "Logs";
            // 
            // listBox_logs
            // 
            this.listBox_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_logs.FormattingEnabled = true;
            this.listBox_logs.Items.AddRange(new object[] {
            "test 1",
            "test 2",
            "test 3, test 4"});
            this.listBox_logs.Location = new System.Drawing.Point(3, 16);
            this.listBox_logs.Name = "listBox_logs";
            this.listBox_logs.ScrollAlwaysVisible = true;
            this.listBox_logs.Size = new System.Drawing.Size(194, 328);
            this.listBox_logs.TabIndex = 1;
            // 
            // groupBox_formatting
            // 
            this.groupBox_formatting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_formatting.Controls.Add(this.checkBox_names);
            this.groupBox_formatting.Controls.Add(this.checkBox_channel);
            this.groupBox_formatting.Controls.Add(this.checkBox_timestamps);
            this.groupBox_formatting.Location = new System.Drawing.Point(218, 239);
            this.groupBox_formatting.Name = "groupBox_formatting";
            this.groupBox_formatting.Size = new System.Drawing.Size(169, 91);
            this.groupBox_formatting.TabIndex = 1;
            this.groupBox_formatting.TabStop = false;
            this.groupBox_formatting.Text = "Formatting";
            // 
            // checkBox_names
            // 
            this.checkBox_names.AutoSize = true;
            this.checkBox_names.Checked = true;
            this.checkBox_names.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_names.Location = new System.Drawing.Point(7, 68);
            this.checkBox_names.Name = "checkBox_names";
            this.checkBox_names.Size = new System.Drawing.Size(94, 17);
            this.checkBox_names.TabIndex = 2;
            this.checkBox_names.Text = "Sender names";
            this.checkBox_names.UseVisualStyleBackColor = true;
            // 
            // checkBox_channel
            // 
            this.checkBox_channel.AutoSize = true;
            this.checkBox_channel.Checked = true;
            this.checkBox_channel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_channel.Location = new System.Drawing.Point(7, 44);
            this.checkBox_channel.Name = "checkBox_channel";
            this.checkBox_channel.Size = new System.Drawing.Size(156, 17);
            this.checkBox_channel.TabIndex = 1;
            this.checkBox_channel.Text = "Message origin (e.g. \"[FC]\")";
            this.checkBox_channel.UseVisualStyleBackColor = true;
            // 
            // checkBox_timestamps
            // 
            this.checkBox_timestamps.AutoSize = true;
            this.checkBox_timestamps.Checked = true;
            this.checkBox_timestamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_timestamps.Location = new System.Drawing.Point(7, 20);
            this.checkBox_timestamps.Name = "checkBox_timestamps";
            this.checkBox_timestamps.Size = new System.Drawing.Size(82, 17);
            this.checkBox_timestamps.TabIndex = 0;
            this.checkBox_timestamps.Text = "Timestamps";
            this.checkBox_timestamps.UseVisualStyleBackColor = true;
            // 
            // groupBox_include
            // 
            this.groupBox_include.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_include.Controls.Add(this.groupBox_linkshells);
            this.groupBox_include.Controls.Add(this.checkBox_tell);
            this.groupBox_include.Controls.Add(this.checkBox_freeCompany);
            this.groupBox_include.Controls.Add(this.checkBox_shout);
            this.groupBox_include.Controls.Add(this.checkBox_yell);
            this.groupBox_include.Controls.Add(this.checkBox_alliance);
            this.groupBox_include.Controls.Add(this.checkBox_party);
            this.groupBox_include.Controls.Add(this.checkBox_say);
            this.groupBox_include.Location = new System.Drawing.Point(218, 12);
            this.groupBox_include.Name = "groupBox_include";
            this.groupBox_include.Size = new System.Drawing.Size(313, 221);
            this.groupBox_include.TabIndex = 0;
            this.groupBox_include.TabStop = false;
            this.groupBox_include.Text = "Include";
            // 
            // groupBox_linkshells
            // 
            this.groupBox_linkshells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell4);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell5);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell8);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell7);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell6);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell3);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell2);
            this.groupBox_linkshells.Controls.Add(this.checkBox_linkshell1);
            this.groupBox_linkshells.Location = new System.Drawing.Point(212, 15);
            this.groupBox_linkshells.Name = "groupBox_linkshells";
            this.groupBox_linkshells.Size = new System.Drawing.Size(95, 202);
            this.groupBox_linkshells.TabIndex = 7;
            this.groupBox_linkshells.TabStop = false;
            this.groupBox_linkshells.Text = "Linkshells";
            // 
            // checkBox_linkshell4
            // 
            this.checkBox_linkshell4.AutoSize = true;
            this.checkBox_linkshell4.Location = new System.Drawing.Point(5, 88);
            this.checkBox_linkshell4.Name = "checkBox_linkshell4";
            this.checkBox_linkshell4.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell4.TabIndex = 7;
            this.checkBox_linkshell4.Text = "Linkshell #4";
            this.checkBox_linkshell4.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell5
            // 
            this.checkBox_linkshell5.AutoSize = true;
            this.checkBox_linkshell5.Location = new System.Drawing.Point(6, 111);
            this.checkBox_linkshell5.Name = "checkBox_linkshell5";
            this.checkBox_linkshell5.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell5.TabIndex = 6;
            this.checkBox_linkshell5.Text = "Linkshell #5";
            this.checkBox_linkshell5.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell8
            // 
            this.checkBox_linkshell8.AutoSize = true;
            this.checkBox_linkshell8.Location = new System.Drawing.Point(6, 180);
            this.checkBox_linkshell8.Name = "checkBox_linkshell8";
            this.checkBox_linkshell8.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell8.TabIndex = 5;
            this.checkBox_linkshell8.Text = "Linkshell #8";
            this.checkBox_linkshell8.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell7
            // 
            this.checkBox_linkshell7.AutoSize = true;
            this.checkBox_linkshell7.Location = new System.Drawing.Point(6, 157);
            this.checkBox_linkshell7.Name = "checkBox_linkshell7";
            this.checkBox_linkshell7.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell7.TabIndex = 4;
            this.checkBox_linkshell7.Text = "Linkshell #7";
            this.checkBox_linkshell7.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell6
            // 
            this.checkBox_linkshell6.AutoSize = true;
            this.checkBox_linkshell6.Location = new System.Drawing.Point(6, 134);
            this.checkBox_linkshell6.Name = "checkBox_linkshell6";
            this.checkBox_linkshell6.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell6.TabIndex = 3;
            this.checkBox_linkshell6.Text = "Linkshell #6";
            this.checkBox_linkshell6.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell3
            // 
            this.checkBox_linkshell3.AutoSize = true;
            this.checkBox_linkshell3.Location = new System.Drawing.Point(6, 65);
            this.checkBox_linkshell3.Name = "checkBox_linkshell3";
            this.checkBox_linkshell3.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell3.TabIndex = 2;
            this.checkBox_linkshell3.Text = "Linkshell #3";
            this.checkBox_linkshell3.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell2
            // 
            this.checkBox_linkshell2.AutoSize = true;
            this.checkBox_linkshell2.Location = new System.Drawing.Point(6, 42);
            this.checkBox_linkshell2.Name = "checkBox_linkshell2";
            this.checkBox_linkshell2.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell2.TabIndex = 1;
            this.checkBox_linkshell2.Text = "Linkshell #2";
            this.checkBox_linkshell2.UseVisualStyleBackColor = true;
            // 
            // checkBox_linkshell1
            // 
            this.checkBox_linkshell1.AutoSize = true;
            this.checkBox_linkshell1.Location = new System.Drawing.Point(6, 19);
            this.checkBox_linkshell1.Name = "checkBox_linkshell1";
            this.checkBox_linkshell1.Size = new System.Drawing.Size(83, 17);
            this.checkBox_linkshell1.TabIndex = 0;
            this.checkBox_linkshell1.Text = "Linkshell #1";
            this.checkBox_linkshell1.UseVisualStyleBackColor = true;
            // 
            // checkBox_tell
            // 
            this.checkBox_tell.AutoSize = true;
            this.checkBox_tell.Location = new System.Drawing.Point(7, 200);
            this.checkBox_tell.Name = "checkBox_tell";
            this.checkBox_tell.Size = new System.Drawing.Size(43, 17);
            this.checkBox_tell.TabIndex = 6;
            this.checkBox_tell.Text = "Tell";
            this.checkBox_tell.UseVisualStyleBackColor = true;
            this.checkBox_tell.CheckedChanged += new System.EventHandler(this.checkBox_tell_CheckedChanged);
            // 
            // checkBox_freeCompany
            // 
            this.checkBox_freeCompany.AutoSize = true;
            this.checkBox_freeCompany.Location = new System.Drawing.Point(7, 139);
            this.checkBox_freeCompany.Name = "checkBox_freeCompany";
            this.checkBox_freeCompany.Size = new System.Drawing.Size(94, 17);
            this.checkBox_freeCompany.TabIndex = 5;
            this.checkBox_freeCompany.Text = "Free Company";
            this.checkBox_freeCompany.UseVisualStyleBackColor = true;
            // 
            // checkBox_shout
            // 
            this.checkBox_shout.AutoSize = true;
            this.checkBox_shout.Location = new System.Drawing.Point(6, 115);
            this.checkBox_shout.Name = "checkBox_shout";
            this.checkBox_shout.Size = new System.Drawing.Size(54, 17);
            this.checkBox_shout.TabIndex = 4;
            this.checkBox_shout.Text = "Shout";
            this.checkBox_shout.UseVisualStyleBackColor = true;
            // 
            // checkBox_yell
            // 
            this.checkBox_yell.AutoSize = true;
            this.checkBox_yell.Location = new System.Drawing.Point(7, 92);
            this.checkBox_yell.Name = "checkBox_yell";
            this.checkBox_yell.Size = new System.Drawing.Size(43, 17);
            this.checkBox_yell.TabIndex = 3;
            this.checkBox_yell.Text = "Yell";
            this.checkBox_yell.UseVisualStyleBackColor = true;
            // 
            // checkBox_alliance
            // 
            this.checkBox_alliance.AutoSize = true;
            this.checkBox_alliance.Location = new System.Drawing.Point(7, 68);
            this.checkBox_alliance.Name = "checkBox_alliance";
            this.checkBox_alliance.Size = new System.Drawing.Size(63, 17);
            this.checkBox_alliance.TabIndex = 2;
            this.checkBox_alliance.Text = "Alliance";
            this.checkBox_alliance.UseVisualStyleBackColor = true;
            // 
            // checkBox_party
            // 
            this.checkBox_party.AutoSize = true;
            this.checkBox_party.Location = new System.Drawing.Point(7, 44);
            this.checkBox_party.Name = "checkBox_party";
            this.checkBox_party.Size = new System.Drawing.Size(50, 17);
            this.checkBox_party.TabIndex = 1;
            this.checkBox_party.Text = "Party";
            this.checkBox_party.UseVisualStyleBackColor = true;
            // 
            // checkBox_say
            // 
            this.checkBox_say.AutoSize = true;
            this.checkBox_say.Location = new System.Drawing.Point(7, 20);
            this.checkBox_say.Name = "checkBox_say";
            this.checkBox_say.Size = new System.Drawing.Size(44, 17);
            this.checkBox_say.TabIndex = 0;
            this.checkBox_say.Text = "Say";
            this.checkBox_say.UseVisualStyleBackColor = true;
            // 
            // groupBox_export_settings
            // 
            this.groupBox_export_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_export_settings.Controls.Add(this.radioButton_exportToSeparate);
            this.groupBox_export_settings.Controls.Add(this.radioButton_exportToSingle);
            this.groupBox_export_settings.Location = new System.Drawing.Point(393, 239);
            this.groupBox_export_settings.Name = "groupBox_export_settings";
            this.groupBox_export_settings.Size = new System.Drawing.Size(138, 61);
            this.groupBox_export_settings.TabIndex = 2;
            this.groupBox_export_settings.TabStop = false;
            this.groupBox_export_settings.Text = "Export settings";
            // 
            // radioButton_exportToSeparate
            // 
            this.radioButton_exportToSeparate.AutoSize = true;
            this.radioButton_exportToSeparate.Location = new System.Drawing.Point(7, 40);
            this.radioButton_exportToSeparate.Name = "radioButton_exportToSeparate";
            this.radioButton_exportToSeparate.Size = new System.Drawing.Size(103, 17);
            this.radioButton_exportToSeparate.TabIndex = 1;
            this.radioButton_exportToSeparate.Text = "One file per chat";
            this.radioButton_exportToSeparate.UseVisualStyleBackColor = true;
            // 
            // radioButton_exportToSingle
            // 
            this.radioButton_exportToSingle.AutoSize = true;
            this.radioButton_exportToSingle.Checked = true;
            this.radioButton_exportToSingle.Location = new System.Drawing.Point(7, 16);
            this.radioButton_exportToSingle.Name = "radioButton_exportToSingle";
            this.radioButton_exportToSingle.Size = new System.Drawing.Size(113, 17);
            this.radioButton_exportToSingle.TabIndex = 0;
            this.radioButton_exportToSingle.TabStop = true;
            this.radioButton_exportToSingle.Text = "Export to single file";
            this.radioButton_exportToSingle.UseVisualStyleBackColor = true;
            // 
            // button_exportHTML
            // 
            this.button_exportHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exportHTML.Location = new System.Drawing.Point(451, 336);
            this.button_exportHTML.Name = "button_exportHTML";
            this.button_exportHTML.Size = new System.Drawing.Size(80, 23);
            this.button_exportHTML.TabIndex = 3;
            this.button_exportHTML.Text = "Export HTML";
            this.button_exportHTML.UseVisualStyleBackColor = true;
            // 
            // button_exportText
            // 
            this.button_exportText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exportText.Location = new System.Drawing.Point(370, 336);
            this.button_exportText.Name = "button_exportText";
            this.button_exportText.Size = new System.Drawing.Size(75, 23);
            this.button_exportText.TabIndex = 4;
            this.button_exportText.Text = "Export text";
            this.button_exportText.UseVisualStyleBackColor = true;
            this.button_exportText.Click += new System.EventHandler(this.button_exportText_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_refresh.Location = new System.Drawing.Point(218, 336);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 370);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_exportText);
            this.Controls.Add(this.button_exportHTML);
            this.Controls.Add(this.groupBox_export_settings);
            this.Controls.Add(this.groupBox_include);
            this.Controls.Add(this.groupBox_formatting);
            this.Controls.Add(this.groupBox_logs);
            this.MinimumSize = new System.Drawing.Size(559, 409);
            this.Name = "MainForm";
            this.Text = "ACT Log Extractor";
            this.groupBox_logs.ResumeLayout(false);
            this.groupBox_formatting.ResumeLayout(false);
            this.groupBox_formatting.PerformLayout();
            this.groupBox_include.ResumeLayout(false);
            this.groupBox_include.PerformLayout();
            this.groupBox_linkshells.ResumeLayout(false);
            this.groupBox_linkshells.PerformLayout();
            this.groupBox_export_settings.ResumeLayout(false);
            this.groupBox_export_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_logs;
        private System.Windows.Forms.GroupBox groupBox_formatting;
        private System.Windows.Forms.GroupBox groupBox_include;
        private System.Windows.Forms.GroupBox groupBox_linkshells;
        private System.Windows.Forms.GroupBox groupBox_export_settings;
        private System.Windows.Forms.Button button_exportHTML;
        private System.Windows.Forms.Button button_exportText;
        private System.Windows.Forms.Button button_refresh;
        public System.Windows.Forms.ListBox listBox_logs;
        public System.Windows.Forms.CheckBox checkBox_names;
        public System.Windows.Forms.CheckBox checkBox_channel;
        public System.Windows.Forms.CheckBox checkBox_timestamps;
        public System.Windows.Forms.CheckBox checkBox_linkshell4;
        public System.Windows.Forms.CheckBox checkBox_linkshell5;
        public System.Windows.Forms.CheckBox checkBox_linkshell8;
        public System.Windows.Forms.CheckBox checkBox_linkshell7;
        public System.Windows.Forms.CheckBox checkBox_linkshell6;
        public System.Windows.Forms.CheckBox checkBox_linkshell3;
        public System.Windows.Forms.CheckBox checkBox_linkshell2;
        public System.Windows.Forms.CheckBox checkBox_linkshell1;
        public System.Windows.Forms.CheckBox checkBox_tell;
        public System.Windows.Forms.CheckBox checkBox_freeCompany;
        public System.Windows.Forms.CheckBox checkBox_shout;
        public System.Windows.Forms.CheckBox checkBox_yell;
        public System.Windows.Forms.CheckBox checkBox_alliance;
        public System.Windows.Forms.CheckBox checkBox_party;
        public System.Windows.Forms.CheckBox checkBox_say;
        public System.Windows.Forms.RadioButton radioButton_exportToSeparate;
        public System.Windows.Forms.RadioButton radioButton_exportToSingle;
    }
}

