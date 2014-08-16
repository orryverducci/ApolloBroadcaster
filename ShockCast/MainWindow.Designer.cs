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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.connectButton = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.streamButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new ShockCast.UI.DBFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.CausesValidation = false;
            this.connectButton.Enabled = false;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectButton.Location = new System.Drawing.Point(54, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton.CausesValidation = false;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputButton.Location = new System.Drawing.Point(266, 12);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(100, 23);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Add &Input";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // streamButton
            // 
            this.streamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.streamButton.CausesValidation = false;
            this.streamButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.streamButton.Location = new System.Drawing.Point(372, 12);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(100, 23);
            this.streamButton.TabIndex = 3;
            this.streamButton.Text = "Add &Stream";
            this.streamButton.UseVisualStyleBackColor = true;
            this.streamButton.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.CausesValidation = false;
            this.removeButton.Enabled = false;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeButton.Location = new System.Drawing.Point(160, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "&Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.CausesValidation = false;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(484, 220);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "ShockCast";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ShockCast.UI.DBFlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button streamButton;
        private System.Windows.Forms.Button removeButton;


    }
}

