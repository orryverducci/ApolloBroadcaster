namespace ShockCast
{
    partial class MainWindow
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
            this.inputButton = new System.Windows.Forms.Button();
            this.encoderButton = new System.Windows.Forms.Button();
            this.serverButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.metadataTitleLabel = new System.Windows.Forms.Label();
            this.metadataContentLabel = new System.Windows.Forms.Label();
            this.listenerLabel = new System.Windows.Forms.Label();
            this.rightVolumeMeter = new ShockCast.VolumeMeter();
            this.leftVolumeMeter = new ShockCast.VolumeMeter();
            this.statusSeperator = new ShockCast.Seperator();
            this.configurationSeperator = new ShockCast.Seperator();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.CausesValidation = false;
            this.inputButton.Location = new System.Drawing.Point(12, 174);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(94, 25);
            this.inputButton.TabIndex = 8;
            this.inputButton.Text = "Input";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // encoderButton
            // 
            this.encoderButton.CausesValidation = false;
            this.encoderButton.Location = new System.Drawing.Point(112, 174);
            this.encoderButton.Name = "encoderButton";
            this.encoderButton.Size = new System.Drawing.Size(94, 25);
            this.encoderButton.TabIndex = 9;
            this.encoderButton.Text = "Encoder";
            this.encoderButton.UseVisualStyleBackColor = true;
            this.encoderButton.Click += new System.EventHandler(this.encoderButton_Click);
            // 
            // serverButton
            // 
            this.serverButton.CausesValidation = false;
            this.serverButton.Location = new System.Drawing.Point(212, 174);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(95, 25);
            this.serverButton.TabIndex = 10;
            this.serverButton.Text = "Server";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.CausesValidation = false;
            this.startStopButton.Location = new System.Drawing.Point(212, 33);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(95, 25);
            this.startStopButton.TabIndex = 6;
            this.startStopButton.Text = "Start Stream";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.CausesValidation = false;
            this.statusLabel.Location = new System.Drawing.Point(12, 33);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Not Streaming";
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.CausesValidation = false;
            this.bitrateLabel.Location = new System.Drawing.Point(15, 50);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(10, 13);
            this.bitrateLabel.TabIndex = 2;
            this.bitrateLabel.Text = " ";
            // 
            // metadataTitleLabel
            // 
            this.metadataTitleLabel.AutoSize = true;
            this.metadataTitleLabel.CausesValidation = false;
            this.metadataTitleLabel.Location = new System.Drawing.Point(12, 85);
            this.metadataTitleLabel.Name = "metadataTitleLabel";
            this.metadataTitleLabel.Size = new System.Drawing.Size(55, 13);
            this.metadataTitleLabel.TabIndex = 4;
            this.metadataTitleLabel.Text = "Metadata:";
            // 
            // metadataContentLabel
            // 
            this.metadataContentLabel.Location = new System.Drawing.Point(12, 98);
            this.metadataContentLabel.Name = "metadataContentLabel";
            this.metadataContentLabel.Size = new System.Drawing.Size(295, 52);
            this.metadataContentLabel.TabIndex = 5;
            this.metadataContentLabel.Text = " ";
            // 
            // listenerLabel
            // 
            this.listenerLabel.AutoSize = true;
            this.listenerLabel.CausesValidation = false;
            this.listenerLabel.Location = new System.Drawing.Point(12, 63);
            this.listenerLabel.Name = "listenerLabel";
            this.listenerLabel.Size = new System.Drawing.Size(54, 13);
            this.listenerLabel.TabIndex = 3;
            this.listenerLabel.Text = "0 listeners";
            // 
            // rightVolumeMeter
            // 
            this.rightVolumeMeter.Amplitude = -60F;
            this.rightVolumeMeter.CausesValidation = false;
            this.rightVolumeMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rightVolumeMeter.Location = new System.Drawing.Point(349, 12);
            this.rightVolumeMeter.MaxDb = 0F;
            this.rightVolumeMeter.MinDb = -60F;
            this.rightVolumeMeter.Name = "rightVolumeMeter";
            this.rightVolumeMeter.Size = new System.Drawing.Size(23, 187);
            this.rightVolumeMeter.TabIndex = 12;
            this.rightVolumeMeter.Text = "volumeMeter";
            // 
            // leftVolumeMeter
            // 
            this.leftVolumeMeter.Amplitude = -60F;
            this.leftVolumeMeter.CausesValidation = false;
            this.leftVolumeMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.leftVolumeMeter.Location = new System.Drawing.Point(320, 12);
            this.leftVolumeMeter.MaxDb = 0F;
            this.leftVolumeMeter.MinDb = -60F;
            this.leftVolumeMeter.Name = "leftVolumeMeter";
            this.leftVolumeMeter.Size = new System.Drawing.Size(23, 187);
            this.leftVolumeMeter.TabIndex = 11;
            this.leftVolumeMeter.Text = "volumeMeter";
            // 
            // statusSeperator
            // 
            this.statusSeperator.CausesValidation = false;
            this.statusSeperator.Label = "Status";
            this.statusSeperator.Location = new System.Drawing.Point(12, 12);
            this.statusSeperator.Name = "statusSeperator";
            this.statusSeperator.Size = new System.Drawing.Size(295, 15);
            this.statusSeperator.TabIndex = 0;
            // 
            // configurationSeperator
            // 
            this.configurationSeperator.CausesValidation = false;
            this.configurationSeperator.Label = "Configuration";
            this.configurationSeperator.Location = new System.Drawing.Point(12, 153);
            this.configurationSeperator.Name = "configurationSeperator";
            this.configurationSeperator.Size = new System.Drawing.Size(295, 15);
            this.configurationSeperator.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.rightVolumeMeter);
            this.Controls.Add(this.leftVolumeMeter);
            this.Controls.Add(this.listenerLabel);
            this.Controls.Add(this.metadataContentLabel);
            this.Controls.Add(this.metadataTitleLabel);
            this.Controls.Add(this.bitrateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.statusSeperator);
            this.Controls.Add(this.configurationSeperator);
            this.Controls.Add(this.serverButton);
            this.Controls.Add(this.encoderButton);
            this.Controls.Add(this.inputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "ShockCast";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button encoderButton;
        private System.Windows.Forms.Button serverButton;
        private Seperator configurationSeperator;
        private Seperator statusSeperator;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.Label metadataTitleLabel;
        private System.Windows.Forms.Label metadataContentLabel;
        private System.Windows.Forms.Label listenerLabel;
        private VolumeMeter leftVolumeMeter;
        private VolumeMeter rightVolumeMeter;
    }
}

