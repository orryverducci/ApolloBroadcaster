namespace ShockCast.UI
{
    partial class StreamListItem
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
            this.urlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlLabel.AutoEllipsis = true;
            this.urlLabel.CausesValidation = false;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.Black;
            this.urlLabel.Location = new System.Drawing.Point(4, 2);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(382, 30);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL";
            // 
            // StreamListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.Controls.Add(this.urlLabel);
            this.Name = "StreamListItem";
            this.Size = new System.Drawing.Size(390, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
    }
}
