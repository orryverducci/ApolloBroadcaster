using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace ShockCast
{
    public partial class InputWindow : Form
    {
        private class Device
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        private List<Device> devices = new List<Device>();
        public int selectedDevice { get; set; } // Device selected from combo box

        public InputWindow()
        {
            // Set UI font to system font
            this.Font = SystemFonts.MessageBoxFont;
            // Initialise UI
            InitializeComponent();
        }

        /// <summary>
        /// Window load, populates list with available devices
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void InputWindow_Load(object sender, EventArgs e)
        {
            Device device = new Device();
            // Add default device to list
            device.ID = -1;
            device.Name = "Default Device";
            devices.Add(device);
            // Add available devices to list
            for (int i = 0; i < Bass.BASS_RecordGetDeviceCount(); i++) // For each available device
            {
                device = new Device();
                BASS_DEVICEINFO deviceInfo = Bass.BASS_RecordGetDeviceInfo(i); // Retrieve device info
                device.ID = i;
                device.Name = deviceInfo.name;
                devices.Add(device);
            }
            // Set combo box data source
            devicesComboBox.DataSource = devices;
            devicesComboBox.DisplayMember = "Name";
            // Set combo box selected item to current device
            devicesComboBox.SelectedIndex = Properties.Settings.Default.Device + 1;
        }

        /// <summary>
        /// Window close, sets selected device property to the combo box selection
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void InputWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            selectedDevice = devicesComboBox.SelectedIndex - 1;
        }
    }
}
