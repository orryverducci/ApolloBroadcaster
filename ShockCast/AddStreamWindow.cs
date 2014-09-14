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

        #region Options Properties
        public string Device
        {
            get
            {
                return ((Input)inputComboBox.SelectedItem).ID;
            }
        }

        /// <summary>
        /// The audio codec of the stream
        /// </summary>
        public string CodecType
        {
            get
            {
                return ((Codec)codecComboBox.SelectedItem).Encoder;
            }
        }
        /// <summary>
        /// The bitrate of the stream
        /// </summary>
        public int Bitrate
        {
            get
            {
                return (int)bitrateComboBox.SelectedItem;
            }
        }
        /// <summary>
        /// The number of audio channels of the stream
        /// </summary>
        public int Channels
        {
            get
            {
                return int.Parse(channelTextBox.Text);
            }
        }
        /// <summary>
        /// The number of audio channels of the stream
        /// </summary>
        public int SampleRate
        {
            get
            {
                float sampleRate = float.Parse((string)sampleRateComboBox.SelectedItem);
                sampleRate = sampleRate * 1000;
                return (int)sampleRate;
            }
        }
        /// <summary>
        /// The server being streamed to
        /// </summary>
        public string Server
        {
            get
            {
                return ((ServerType)typeComboBox.SelectedItem).Protocol;
            }
        }
        /// <summary>
        /// The URL of the stream
        /// </summary>
        public string StreamURL
        {
            get
            {
                return urlTextBox.Text;
            }
        }
        /// <summary>
        /// The mount of the stream
        /// </summary>
        public string Mount
        {
            get
            {
                if (((ServerType)typeComboBox.SelectedItem).UsesMounts)
                {

                    return mountTextBox.Text.StartsWith("/") ? mountTextBox.Text.Substring(1) : mountTextBox.Text;
                }
                else
                {
                    return String.Empty;
                }
            }
        }
        /// <summary>
        /// The server port of the stream
        /// </summary>
        public int Port
        {
            get
            {
                int port = int.Parse(portTextBox.Text);
                if (port != ((ServerType)typeComboBox.SelectedItem).DefaultPort)
                {
                    return port;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// The server password of the stream
        /// </summary>
        public string Password
        {
            get
            {
                if (((ServerType)typeComboBox.SelectedItem).RequiresPassword)
                {
                    return passwordTextBox.Text;
                }
                else
                {
                    return String.Empty;
                }
            }
        }
        #endregion

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
            // Load codecs
            codecComboBox.DataSource = Stream.Codecs;
            codecComboBox.DisplayMember = "Name";
            // Load server types
            typeComboBox.DataSource = Stream.ServerTypes;
            typeComboBox.DisplayMember = "Name";
            // Set initial values
            channelTextBox.Text = "2";
            sampleRateComboBox.SelectedIndex = 3;
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

        /// <summary>
        /// Carry out form validation on closing
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void AddStreamWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                // Show error on invalid value in channels text box
                if (channelTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a valid number of channels.", "Unable to Add Stream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                // Show error on invalid value in URL text box
                else if (urlTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a URL for the server.", "Unable to Add Stream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                // Show error when mount not entered if required by server
                else if (((ServerType)(typeComboBox.SelectedItem)).UsesMounts && mountTextBox.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a mount point for the server.", "Unable to Add Stream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
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

        #region Combo Box Selections
        private void codecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change bitrate combo box data source to selected codec
            bitrateComboBox.DataSource = ((Codec)(codecComboBox.SelectedItem)).SupportedBitrates;
            // Select recommended bitrate
            for (int i = 0; i < bitrateComboBox.Items.Count; i++)
            {
                if (((int)(bitrateComboBox.Items[i])) == ((Codec)(codecComboBox.SelectedItem)).RecommendedBitrate)
                {
                    bitrateComboBox.SelectedIndex = i;
                }
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change port number to the server default
            portTextBox.Text = ((ServerType)(typeComboBox.SelectedItem)).DefaultPort.ToString();
            // Enable or disable mount input depending on if server uses mounts
            mountTextBox.Enabled = ((ServerType)(typeComboBox.SelectedItem)).UsesMounts;
            // Enable or disable password input depending on if server requres one
            passwordTextBox.Enabled = ((ServerType)(typeComboBox.SelectedItem)).RequiresPassword;
        }
        #endregion

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