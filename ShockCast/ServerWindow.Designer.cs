namespace ShockCast
{
    partial class ServerWindow
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.mountTextBox = new System.Windows.Forms.TextBox();
            this.mountLabel = new System.Windows.Forms.Label();
            this.serverSeperator = new ShockCast.Seperator();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.CausesValidation = false;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(116, 224);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.CausesValidation = false;
            this.typeLabel.Location = new System.Drawing.Point(12, 36);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(65, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Server Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.CausesValidation = false;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "SHOUTcast",
            "Icecast",
            "Windows Media"});
            this.typeComboBox.Location = new System.Drawing.Point(83, 33);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(189, 21);
            this.typeComboBox.TabIndex = 4;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.CausesValidation = false;
            this.addressTextBox.Location = new System.Drawing.Point(83, 60);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(189, 20);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.CausesValidation = false;
            this.addressLabel.Location = new System.Drawing.Point(12, 63);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(83, 86);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(40, 20);
            this.portTextBox.TabIndex = 8;
            this.portTextBox.TextChanged += new System.EventHandler(this.portTextBox_TextChanged);
            this.portTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portTextBox_KeyPress);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.CausesValidation = false;
            this.portLabel.Location = new System.Drawing.Point(12, 89);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 9;
            this.portLabel.Text = "Port";
            // 
            // mountTextBox
            // 
            this.mountTextBox.Location = new System.Drawing.Point(176, 86);
            this.mountTextBox.Name = "mountTextBox";
            this.mountTextBox.Size = new System.Drawing.Size(96, 20);
            this.mountTextBox.TabIndex = 10;
            this.mountTextBox.TextChanged += new System.EventHandler(this.mountTextBox_TextChanged);
            // 
            // mountLabel
            // 
            this.mountLabel.AutoSize = true;
            this.mountLabel.CausesValidation = false;
            this.mountLabel.Location = new System.Drawing.Point(129, 89);
            this.mountLabel.Name = "mountLabel";
            this.mountLabel.Size = new System.Drawing.Size(37, 13);
            this.mountLabel.TabIndex = 11;
            this.mountLabel.Text = "Mount";
            // 
            // serverSeperator
            // 
            this.serverSeperator.CausesValidation = false;
            this.serverSeperator.Label = "Server Configuration";
            this.serverSeperator.Location = new System.Drawing.Point(12, 12);
            this.serverSeperator.Name = "serverSeperator";
            this.serverSeperator.Size = new System.Drawing.Size(260, 15);
            this.serverSeperator.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.CausesValidation = false;
            this.passwordLabel.Location = new System.Drawing.Point(12, 115);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.CausesValidation = false;
            this.passwordTextBox.Location = new System.Drawing.Point(83, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(189, 20);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // ServerWindow
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.mountLabel);
            this.Controls.Add(this.mountTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.serverSeperator);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Settings";
            this.Load += new System.EventHandler(this.ServerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private Seperator serverSeperator;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox mountTextBox;
        private System.Windows.Forms.Label mountLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}