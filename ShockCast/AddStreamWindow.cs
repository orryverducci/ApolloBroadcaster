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
            InitializeComponent();
        }

        private void AddStreamWindow_Load(object sender, EventArgs e)
        {
            // Load inputs
            inputComboBox.DataSource = inputs;
            inputComboBox.DisplayMember = "Name";
            // Set initial combo box values
            codecComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
        }

        #region Tabs
        private void audioButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[0];
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[1];
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
    }
}