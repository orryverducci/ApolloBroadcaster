namespace ShockCast
{
    partial class EncoderWindow
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
            this.codecComboBox = new System.Windows.Forms.ComboBox();
            this.codecLabel = new System.Windows.Forms.Label();
            this.bitrateUpDown = new System.Windows.Forms.NumericUpDown();
            this.bitrateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 65);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.CausesValidation = false;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(116, 65);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // codecComboBox
            // 
            this.codecComboBox.CausesValidation = false;
            this.codecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codecComboBox.FormattingEnabled = true;
            this.codecComboBox.Items.AddRange(new object[] {
            "MP3",
            "AACplus",
            "WMA",
            "Ogg Vorbis"});
            this.codecComboBox.Location = new System.Drawing.Point(56, 12);
            this.codecComboBox.Name = "codecComboBox";
            this.codecComboBox.Size = new System.Drawing.Size(216, 21);
            this.codecComboBox.TabIndex = 0;
            this.codecComboBox.SelectedIndexChanged += new System.EventHandler(this.codecComboBox_SelectedIndexChanged);
            // 
            // codecLabel
            // 
            this.codecLabel.AutoSize = true;
            this.codecLabel.CausesValidation = false;
            this.codecLabel.Location = new System.Drawing.Point(12, 15);
            this.codecLabel.Name = "codecLabel";
            this.codecLabel.Size = new System.Drawing.Size(38, 13);
            this.codecLabel.TabIndex = 3;
            this.codecLabel.Text = "Codec";
            // 
            // bitrateUpDown
            // 
            this.bitrateUpDown.Location = new System.Drawing.Point(56, 39);
            this.bitrateUpDown.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.bitrateUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.bitrateUpDown.Name = "bitrateUpDown";
            this.bitrateUpDown.Size = new System.Drawing.Size(60, 20);
            this.bitrateUpDown.TabIndex = 1;
            this.bitrateUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.bitrateUpDown.ValueChanged += new System.EventHandler(this.bitrateUpDown_ValueChanged);
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.CausesValidation = false;
            this.bitrateLabel.Location = new System.Drawing.Point(12, 41);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(37, 13);
            this.bitrateLabel.TabIndex = 5;
            this.bitrateLabel.Text = "Bitrate";
            // 
            // EncoderWindow
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.bitrateLabel);
            this.Controls.Add(this.bitrateUpDown);
            this.Controls.Add(this.codecLabel);
            this.Controls.Add(this.codecComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncoderWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encoder Settings";
            this.Load += new System.EventHandler(this.EncoderWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitrateUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox codecComboBox;
        private System.Windows.Forms.Label codecLabel;
        private System.Windows.Forms.NumericUpDown bitrateUpDown;
        private System.Windows.Forms.Label bitrateLabel;
    }
}