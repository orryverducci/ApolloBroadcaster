namespace ShockCast
{
    partial class AddStreamWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStreamWindow));
            this.tabPanel = new System.Windows.Forms.Panel();
            this.serverButton = new ShockCast.UI.MenuButton();
            this.audioButton = new ShockCast.UI.MenuButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl = new ShockCast.UI.HeaderlessTabs();
            this.audioPage = new System.Windows.Forms.TabPage();
            this.khzLabel = new System.Windows.Forms.Label();
            this.kbpsLabel = new System.Windows.Forms.Label();
            this.sampleRateComboBox = new System.Windows.Forms.ComboBox();
            this.sampleRateLabel = new System.Windows.Forms.Label();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.channelLabel = new System.Windows.Forms.Label();
            this.bitrateComboBox = new System.Windows.Forms.ComboBox();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.codecComboBox = new System.Windows.Forms.ComboBox();
            this.codecLabel = new System.Windows.Forms.Label();
            this.inputComboBox = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.audioLabel = new System.Windows.Forms.Label();
            this.serverPage = new System.Windows.Forms.TabPage();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.mountTextBox = new System.Windows.Forms.TextBox();
            this.mountLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.tabPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.audioPage.SuspendLayout();
            this.serverPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPanel.CausesValidation = false;
            this.tabPanel.Controls.Add(this.serverButton);
            this.tabPanel.Controls.Add(this.audioButton);
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(200, 261);
            this.tabPanel.TabIndex = 0;
            // 
            // serverButton
            // 
            this.serverButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.serverButton.BackColor = System.Drawing.Color.Transparent;
            this.serverButton.CausesValidation = false;
            this.serverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverButton.Location = new System.Drawing.Point(0, 32);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(200, 32);
            this.serverButton.TabIndex = 1;
            this.serverButton.Text = "&Server Settings";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.CheckedChanged += new System.EventHandler(this.serverButton_CheckedChanged);
            // 
            // audioButton
            // 
            this.audioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.audioButton.BackColor = System.Drawing.Color.Transparent;
            this.audioButton.CausesValidation = false;
            this.audioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioButton.Location = new System.Drawing.Point(0, 0);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(200, 32);
            this.audioButton.TabIndex = 0;
            this.audioButton.Text = "&Audio Settings";
            this.audioButton.UseVisualStyleBackColor = false;
            this.audioButton.CheckedChanged += new System.EventHandler(this.audioButton_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.CausesValidation = false;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(416, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(497, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.CausesValidation = false;
            this.tabControl.Controls.Add(this.audioPage);
            this.tabControl.Controls.Add(this.serverPage);
            this.tabControl.Location = new System.Drawing.Point(200, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 220);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabStop = false;
            // 
            // audioPage
            // 
            this.audioPage.BackColor = System.Drawing.Color.White;
            this.audioPage.CausesValidation = false;
            this.audioPage.Controls.Add(this.khzLabel);
            this.audioPage.Controls.Add(this.kbpsLabel);
            this.audioPage.Controls.Add(this.sampleRateComboBox);
            this.audioPage.Controls.Add(this.sampleRateLabel);
            this.audioPage.Controls.Add(this.channelTextBox);
            this.audioPage.Controls.Add(this.channelLabel);
            this.audioPage.Controls.Add(this.bitrateComboBox);
            this.audioPage.Controls.Add(this.bitrateLabel);
            this.audioPage.Controls.Add(this.codecComboBox);
            this.audioPage.Controls.Add(this.codecLabel);
            this.audioPage.Controls.Add(this.inputComboBox);
            this.audioPage.Controls.Add(this.inputLabel);
            this.audioPage.Controls.Add(this.audioLabel);
            this.audioPage.Location = new System.Drawing.Point(0, 0);
            this.audioPage.Name = "audioPage";
            this.audioPage.Padding = new System.Windows.Forms.Padding(3);
            this.audioPage.Size = new System.Drawing.Size(384, 220);
            this.audioPage.TabIndex = 0;
            this.audioPage.Text = "Audio Settings";
            // 
            // khzLabel
            // 
            this.khzLabel.AutoSize = true;
            this.khzLabel.Location = new System.Drawing.Point(158, 142);
            this.khzLabel.Name = "khzLabel";
            this.khzLabel.Size = new System.Drawing.Size(27, 15);
            this.khzLabel.TabIndex = 12;
            this.khzLabel.Text = "kHz";
            // 
            // kbpsLabel
            // 
            this.kbpsLabel.AutoSize = true;
            this.kbpsLabel.Location = new System.Drawing.Point(158, 113);
            this.kbpsLabel.Name = "kbpsLabel";
            this.kbpsLabel.Size = new System.Drawing.Size(32, 15);
            this.kbpsLabel.TabIndex = 7;
            this.kbpsLabel.Text = "kbps";
            // 
            // sampleRateComboBox
            // 
            this.sampleRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampleRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sampleRateComboBox.FormattingEnabled = true;
            this.sampleRateComboBox.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "44.1",
            "48",
            "96",
            "192"});
            this.sampleRateComboBox.Location = new System.Drawing.Point(86, 139);
            this.sampleRateComboBox.Name = "sampleRateComboBox";
            this.sampleRateComboBox.Size = new System.Drawing.Size(66, 23);
            this.sampleRateComboBox.TabIndex = 11;
            // 
            // sampleRateLabel
            // 
            this.sampleRateLabel.AutoSize = true;
            this.sampleRateLabel.Location = new System.Drawing.Point(8, 142);
            this.sampleRateLabel.Name = "sampleRateLabel";
            this.sampleRateLabel.Size = new System.Drawing.Size(72, 15);
            this.sampleRateLabel.TabIndex = 10;
            this.sampleRateLabel.Text = "Sample Rate";
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(272, 110);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(100, 23);
            this.channelTextBox.TabIndex = 9;
            this.channelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.channelTextBox_KeyPress);
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Location = new System.Drawing.Point(210, 113);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(56, 15);
            this.channelLabel.TabIndex = 8;
            this.channelLabel.Text = "Channels";
            // 
            // bitrateComboBox
            // 
            this.bitrateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateComboBox.CausesValidation = false;
            this.bitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitrateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bitrateComboBox.FormattingEnabled = true;
            this.bitrateComboBox.Location = new System.Drawing.Point(86, 110);
            this.bitrateComboBox.Name = "bitrateComboBox";
            this.bitrateComboBox.Size = new System.Drawing.Size(66, 23);
            this.bitrateComboBox.TabIndex = 6;
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.Location = new System.Drawing.Point(8, 113);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(41, 15);
            this.bitrateLabel.TabIndex = 5;
            this.bitrateLabel.Text = "Bitrate";
            // 
            // codecComboBox
            // 
            this.codecComboBox.CausesValidation = false;
            this.codecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.codecComboBox.Location = new System.Drawing.Point(86, 81);
            this.codecComboBox.Name = "codecComboBox";
            this.codecComboBox.Size = new System.Drawing.Size(286, 23);
            this.codecComboBox.TabIndex = 4;
            this.codecComboBox.SelectedIndexChanged += new System.EventHandler(this.codecComboBox_SelectedIndexChanged);
            // 
            // codecLabel
            // 
            this.codecLabel.AutoSize = true;
            this.codecLabel.CausesValidation = false;
            this.codecLabel.Location = new System.Drawing.Point(8, 84);
            this.codecLabel.Name = "codecLabel";
            this.codecLabel.Size = new System.Drawing.Size(41, 15);
            this.codecLabel.TabIndex = 3;
            this.codecLabel.Text = "Codec";
            // 
            // inputComboBox
            // 
            this.inputComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputComboBox.CausesValidation = false;
            this.inputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputComboBox.Location = new System.Drawing.Point(86, 52);
            this.inputComboBox.Name = "inputComboBox";
            this.inputComboBox.Size = new System.Drawing.Size(286, 23);
            this.inputComboBox.TabIndex = 2;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.CausesValidation = false;
            this.inputLabel.Location = new System.Drawing.Point(8, 55);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(35, 15);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input";
            // 
            // audioLabel
            // 
            this.audioLabel.AutoSize = true;
            this.audioLabel.CausesValidation = false;
            this.audioLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioLabel.Location = new System.Drawing.Point(6, 9);
            this.audioLabel.Name = "audioLabel";
            this.audioLabel.Size = new System.Drawing.Size(146, 30);
            this.audioLabel.TabIndex = 0;
            this.audioLabel.Text = "Audio settings";
            // 
            // serverPage
            // 
            this.serverPage.BackColor = System.Drawing.Color.White;
            this.serverPage.CausesValidation = false;
            this.serverPage.Controls.Add(this.passwordTextBox);
            this.serverPage.Controls.Add(this.passwordLabel);
            this.serverPage.Controls.Add(this.portTextBox);
            this.serverPage.Controls.Add(this.portLabel);
            this.serverPage.Controls.Add(this.mountTextBox);
            this.serverPage.Controls.Add(this.mountLabel);
            this.serverPage.Controls.Add(this.urlTextBox);
            this.serverPage.Controls.Add(this.urlLabel);
            this.serverPage.Controls.Add(this.typeComboBox);
            this.serverPage.Controls.Add(this.typeLabel);
            this.serverPage.Controls.Add(this.serverLabel);
            this.serverPage.Location = new System.Drawing.Point(0, 0);
            this.serverPage.Name = "serverPage";
            this.serverPage.Padding = new System.Windows.Forms.Padding(3);
            this.serverPage.Size = new System.Drawing.Size(384, 220);
            this.serverPage.TabIndex = 1;
            this.serverPage.Text = "Server Settings";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(86, 139);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(286, 23);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(8, 142);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // portTextBox
            // 
            this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portTextBox.Location = new System.Drawing.Point(277, 110);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(95, 23);
            this.portTextBox.TabIndex = 8;
            this.portTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portTextBox_KeyPress);
            // 
            // portLabel
            // 
            this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(242, 113);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 15);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port";
            // 
            // mountTextBox
            // 
            this.mountTextBox.CausesValidation = false;
            this.mountTextBox.Location = new System.Drawing.Point(86, 110);
            this.mountTextBox.Name = "mountTextBox";
            this.mountTextBox.Size = new System.Drawing.Size(150, 23);
            this.mountTextBox.TabIndex = 6;
            // 
            // mountLabel
            // 
            this.mountLabel.AutoSize = true;
            this.mountLabel.CausesValidation = false;
            this.mountLabel.Location = new System.Drawing.Point(8, 113);
            this.mountLabel.Name = "mountLabel";
            this.mountLabel.Size = new System.Drawing.Size(43, 15);
            this.mountLabel.TabIndex = 5;
            this.mountLabel.Text = "Mount";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(86, 81);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(286, 23);
            this.urlTextBox.TabIndex = 4;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.CausesValidation = false;
            this.urlLabel.Location = new System.Drawing.Point(8, 84);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(28, 15);
            this.urlLabel.TabIndex = 3;
            this.urlLabel.Text = "URL";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeComboBox.Location = new System.Drawing.Point(86, 52);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(286, 23);
            this.typeComboBox.TabIndex = 2;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.CausesValidation = false;
            this.typeLabel.Location = new System.Drawing.Point(8, 55);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(33, 15);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.CausesValidation = false;
            this.serverLabel.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.Location = new System.Drawing.Point(6, 9);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(149, 30);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Server settings";
            // 
            // AddStreamWindow
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStreamWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStreamWindow_FormClosing);
            this.Load += new System.EventHandler(this.AddStreamWindow_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.audioPage.ResumeLayout(false);
            this.audioPage.PerformLayout();
            this.serverPage.ResumeLayout(false);
            this.serverPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private ShockCast.UI.MenuButton audioButton;
        private ShockCast.UI.MenuButton serverButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private ShockCast.UI.HeaderlessTabs tabControl;
        private System.Windows.Forms.TabPage audioPage;
        private System.Windows.Forms.TabPage serverPage;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label codecLabel;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label mountLabel;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.ComboBox sampleRateComboBox;
        private System.Windows.Forms.Label sampleRateLabel;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label khzLabel;
        private System.Windows.Forms.Label kbpsLabel;
        private System.Windows.Forms.ComboBox inputComboBox;
        private System.Windows.Forms.ComboBox codecComboBox;
        private System.Windows.Forms.ComboBox bitrateComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox mountTextBox;
    }
}