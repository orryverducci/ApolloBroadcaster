using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockCast
{
    public partial class AddInputWindow : Form
    {
        /// <summary>
        /// List of devices
        /// </summary>
        private List<Device> devices;

        /// <summary>
        /// The selected device
        /// </summary>
        public Device SelectedDevice
        {
            get
            {
                return (Device)deviceComboBox.SelectedItem;
            }
        }

        public AddInputWindow()
        {
            Opacity = 0;
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to populate devices list on form load
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void AddInputWindow_Load(object sender, EventArgs e)
        {
            // Retrieve devices
            devices = Input.GetDevices();
            // Set combo box data source to devices
            deviceComboBox.DataSource = devices;
            deviceComboBox.DisplayMember = "Name";
            // Determine if devices were found
            if (devices.Count() == 0) // If no devices are found
            {
                // Diplay error and exit
                MessageBox.Show("No input devices are available. Check they are plugged in and not disabled.", "Unable to Add Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else // Else if devices are found
            {
                // Show form
                Opacity = 100;
            }
        }

        /// <summary>
        /// Event handler to show device details on selection
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            channelNumLabel.Text = ((Device)(deviceComboBox.SelectedItem)).Channels.ToString();
            float sampleRate = ((Device)(deviceComboBox.SelectedItem)).SampleRate;
            sampleRate = sampleRate / 1000;
            sampleRateFreqLabel.Text = sampleRate.ToString() + " kHz";
        }
    }
}
