using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShockCast.UI
{
    public partial class InputHeader : UserControl, ISelectableControl
    {
        private Input input;
        private bool selected;

        /// <summary>
        /// Create an input header
        /// </summary>
        /// <param name="input">The input to display on the header</param>
        public InputHeader(Input inputDevice)
        {
            // Set input to given input
            input = inputDevice;
            // Create components
            InitializeComponent();
            // Set title
            titleLabel.Text = input.Name;
            // Handle amplitude change events on input to update meter
            input.MeterLevelChanged += input_MeterLevelChanged;
            // Pass through click event on controls
            foreach (Control control in Controls)
            {
                control.Click += control_Click;
            }
        }

        void control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        void input_MeterLevelChanged(object sender, EventArgs e)
        {
            volumeMeter.Amplitude = input.MeterLevel;
        }

        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                if (value == true)
                {
                    BackColor = Color.FromArgb(38, 114, 236);
                }
                else
                {
                    BackColor = Color.FromArgb(9, 71, 178);
                }
            }
        }

        public Input Input
        {
            get
            {
                return input;
            }
        }
    }
}
