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
    public partial class ServerWindow : Form
    {
        public Stream.Server selectedServerType { get; set; }
        public string selectedAddress { get; set; }
        public int selectedPort { get; set; }
        public string selectedMount { get; set; }
        public string selectedPassword { get; set; }

        public ServerWindow()
        {
            // Set UI font to system font
            this.Font = SystemFonts.MessageBoxFont;
            // Initialise UI
            InitializeComponent();
        }

        private void ServerWindow_Load(object sender, EventArgs e)
        {
            typeComboBox.SelectedIndex = Properties.Settings.Default.Server;
            addressTextBox.Text = Properties.Settings.Default.Address;
            if (Properties.Settings.Default.Port != 0)
            {
                portTextBox.Text = Properties.Settings.Default.Port.ToString();
            }
            mountTextBox.Text = Properties.Settings.Default.Mount;
            passwordTextBox.Text = Properties.Settings.Default.Password;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedServerType = (Stream.Server)typeComboBox.SelectedIndex;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedAddress = addressTextBox.Text;
        }

        /// <summary>
        /// Handle keypress on port textbox, preventing entry of a character other than a number
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void portTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void portTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedPort = int.Parse(portTextBox.Text);
        }

        private void mountTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedMount = mountTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            selectedPassword = passwordTextBox.Text;
        }
    }
}
