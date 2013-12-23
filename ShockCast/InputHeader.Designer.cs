namespace ShockCast
{
    partial class InputHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.volumeMeter = new ShockCast.VolumeMeter();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.CausesValidation = false;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(4, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(299, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // volumeMeter
            // 
            this.volumeMeter.Amplitude = -60F;
            this.volumeMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeMeter.ForeColor = System.Drawing.Color.White;
            this.volumeMeter.Location = new System.Drawing.Point(309, 5);
            this.volumeMeter.MaxDb = 0F;
            this.volumeMeter.MinDb = -60F;
            this.volumeMeter.Name = "volumeMeter";
            this.volumeMeter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volumeMeter.Size = new System.Drawing.Size(75, 23);
            this.volumeMeter.TabIndex = 1;
            // 
            // InputHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(178)))));
            this.CausesValidation = false;
            this.Controls.Add(this.volumeMeter);
            this.Controls.Add(this.titleLabel);
            this.Name = "InputHeader";
            this.Size = new System.Drawing.Size(390, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private VolumeMeter volumeMeter;
    }
}
