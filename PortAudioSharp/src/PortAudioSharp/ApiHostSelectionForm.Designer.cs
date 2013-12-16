﻿ /*
  * PortAudioSharp - PortAudio bindings for .NET
  * Copyright 2006-2011 Riccardo Gerosa and individual contributors as indicated
  * by the @authors tag. See the copyright.txt in the distribution for a
  * full listing of individual contributors.
  *
  * Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
  * and associated documentation files (the "Software"), to deal in the Software without restriction, 
  * including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
  * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
  * subject to the following conditions:
  *
  * The above copyright notice and this permission notice shall be included in all copies or substantial 
  * portions of the Software.
  *
  * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT 
  * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
  * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
  * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
  * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
  */

namespace PortAudioSharp
{
	partial class ApiHostSelectionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.settingsTableLayoutPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsTableLayoutPanel
			// 
			this.settingsTableLayoutPanel.AutoSize = true;
			this.settingsTableLayoutPanel.ColumnCount = 1;
			this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.settingsTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsTableLayoutPanel.Location = new System.Drawing.Point(10, 10);
			this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
			this.settingsTableLayoutPanel.RowCount = 2;
			this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
			this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.settingsTableLayoutPanel.Size = new System.Drawing.Size(341, 332);
			this.settingsTableLayoutPanel.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cancelButton);
			this.flowLayoutPanel1.Controls.Add(this.okButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 299);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(353, 30);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(275, 3);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(194, 3);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			// 
			// ApiHostSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(361, 352);
			this.Controls.Add(this.settingsTableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ApiHostSelectionForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audio hardware settings";
			this.Load += new System.EventHandler(this.ApiHostSelectionFormLoad);
			this.settingsTableLayoutPanel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	
		void ApiHostSelectionFormLoad(object sender, System.EventArgs e)
		{
			audioSettingsControl = new PortAudioSharp.AudioSettingsControl(this);
			deviceControl = (PortAudioSharp.IDeviceControl) audioSettingsControl;
			this.settingsTableLayoutPanel.Controls.Add(audioSettingsControl, 0, 0);
		}
	}
}
