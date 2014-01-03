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
            this.serverButton = new System.Windows.Forms.Button();
            this.audioButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl = new ShockCast.HeaderlessTabs();
            this.audioPage = new System.Windows.Forms.TabPage();
            this.bitrateComboBox = new System.Windows.Forms.ComboBox();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.codecComboBox = new System.Windows.Forms.ComboBox();
            this.codecLabel = new System.Windows.Forms.Label();
            this.inputComboBox = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.audioLabel = new System.Windows.Forms.Label();
            this.serverPage = new System.Windows.Forms.TabPage();
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
            this.serverButton.CausesValidation = false;
            this.serverButton.Location = new System.Drawing.Point(0, 23);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(199, 23);
            this.serverButton.TabIndex = 1;
            this.serverButton.Text = "&Server Settings";
            this.serverButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // audioButton
            // 
            this.audioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioButton.CausesValidation = false;
            this.audioButton.Location = new System.Drawing.Point(0, 0);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(199, 23);
            this.audioButton.TabIndex = 0;
            this.audioButton.Text = "&Audio Settings";
            this.audioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
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
            // bitrateComboBox
            // 
            this.bitrateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateComboBox.CausesValidation = false;
            this.bitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitrateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bitrateComboBox.FormattingEnabled = true;
            this.bitrateComboBox.Location = new System.Drawing.Point(55, 110);
            this.bitrateComboBox.Name = "bitrateComboBox";
            this.bitrateComboBox.Size = new System.Drawing.Size(100, 23);
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
            this.codecComboBox.Items.AddRange(new object[] {
            "MP3"});
            this.codecComboBox.Location = new System.Drawing.Point(55, 81);
            this.codecComboBox.Name = "codecComboBox";
            this.codecComboBox.Size = new System.Drawing.Size(317, 23);
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
            this.inputComboBox.Location = new System.Drawing.Point(55, 52);
            this.inputComboBox.Name = "inputComboBox";
            this.inputComboBox.Size = new System.Drawing.Size(317, 23);
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
            // portTextBox
            // 
            this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portTextBox.Location = new System.Drawing.Point(272, 110);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 23);
            this.portTextBox.TabIndex = 8;
            // 
            // portLabel
            // 
            this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(237, 113);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 15);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port";
            // 
            // mountTextBox
            // 
            this.mountTextBox.CausesValidation = false;
            this.mountTextBox.Location = new System.Drawing.Point(57, 110);
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
            this.urlTextBox.Location = new System.Drawing.Point(57, 81);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(315, 23);
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
            this.typeComboBox.Items.AddRange(new object[] {
            "Shoutcast",
            "Icecast"});
            this.typeComboBox.Location = new System.Drawing.Point(57, 52);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(315, 23);
            this.typeComboBox.TabIndex = 2;
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
        private System.Windows.Forms.Button audioButton;
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private HeaderlessTabs tabControl;
        private System.Windows.Forms.TabPage audioPage;
        private System.Windows.Forms.TabPage serverPage;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.ComboBox inputComboBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label codecLabel;
        private System.Windows.Forms.ComboBox codecComboBox;
        private System.Windows.Forms.ComboBox bitrateComboBox;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox mountTextBox;
        private System.Windows.Forms.Label mountLabel;
    }
}