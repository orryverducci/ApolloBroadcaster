using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShockCast
{
    public partial class AddStreamWindow : Form
    {
        private List<Input> inputs;

        public AddStreamWindow(List<Input> currentInputs)
        {
            inputs = currentInputs;
            Opacity = 0;
            InitializeComponent();
        }

        private void AddStreamWindow_Load(object sender, EventArgs e)
        {
            // Set default tab
            audioButton.Checked = true;
            // Load inputs
            inputComboBox.DataSource = inputs;
            inputComboBox.DisplayMember = "Name";
            // Set initial combo box values
            codecComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
            // Determine if inputs have been added
            if (inputs.Count() == 0) // If no inputs are available
            {
                // Diplay error and exit
                MessageBox.Show("You have not added any inputs. Please add an input and then try adding a stream again.", "Unable to Add Stream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else // If inputs are available
            {
                Opacity = 100;
            }
        }

        #region Tabs
        private void audioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (audioButton.Checked)
            {
                tabControl.SelectedTab = tabControl.TabPages[0];
                serverButton.Checked = false;
            }
        }

        private void serverButton_CheckedChanged(object sender, EventArgs e)
        {
            if (serverButton.Checked)
            {
                tabControl.SelectedTab = tabControl.TabPages[1];
                audioButton.Checked = false;
            }
        }
        #endregion

        private void codecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] bitrates = {};
            // Remove all existing combo box items
            bitrateComboBox.Items.Clear();
            // Find bitrates supported by selected codec
            if ((string)codecComboBox.SelectedItem == "MP3")
            {
                bitrates = MP3.SupportedBitrates;
            }
            // Add bitrates to combo box
            foreach (int bitrate in bitrates)
            {
                bitrateComboBox.Items.Add(bitrate);
            }
            // Select initial value
            bitrateComboBox.SelectedIndex = 0;
        }

        #region Key Entry Validation
        private void portTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void channelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}