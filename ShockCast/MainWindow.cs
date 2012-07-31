using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockCast
{
    public partial class MainWindow : Form
    {
        #region DllImport
        // Import Win32 API system menu functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern bool InsertMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);
        public const Int32 WM_SYSCOMMAND = 0x112;
        public const Int32 MF_SEPARATOR = 0x800;
        public const Int32 MF_BYPOSITION = 0x400;
        public const Int32 MF_STRING = 0x0;
        public const Int32 IDM_ABOUT = 1000;
        #endregion

        #region Form Load and Close
        public MainWindow()
        {
            // Set UI font to system font
            this.Font = SystemFonts.MessageBoxFont;
            // Initialise UI
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Initialise BASS
            try
            {
                Stream.Initialise();
            }
            catch (TypeInitializationException) // Catch dll missing exception
            {
                MessageBox.Show("Unable to find bass.dll", "ShockCast Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (ApplicationException) // Catch initialisation error exception
            {
                MessageBox.Show("Unable to initialise BASS", "ShockCast Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            // Add 'About' to System Menu
            IntPtr sysMenuHandle = GetSystemMenu(this.Handle, false);
            InsertMenu(sysMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
            InsertMenu(sysMenuHandle, 6, MF_BYPOSITION, IDM_ABOUT, "About ShockCast...");
            // Initialise saved recording device
            try
            {
                Stream.SetRecordingInput(Properties.Settings.Default.Device);
            }
            catch (ArgumentException)
            {
                try
                {
                    Stream.SetRecordingInput(-1);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Unable to initialise an input audio device", "ShockCast Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            // Add event handlers
            Stream.PeakLevelMeterUpdate += new Stream.LevelEventHandler(LevelUpdate);
            Stream.StatusChange += new EventHandler(StatusChange);
            // Initialise saved encoder settings
            Stream.Codec = (Stream.Encoder)Properties.Settings.Default.Encoder;
            Stream.Bitrate = Properties.Settings.Default.Bitrate;
            // Initialise saved server settings
            Stream.ServerType = (Stream.Server)Properties.Settings.Default.Server;
            Stream.Address = Properties.Settings.Default.Address;
            Stream.Port = Properties.Settings.Default.Port;
            Stream.Mount = Properties.Settings.Default.Mount;
            Stream.Password = Properties.Settings.Default.Password;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings
            Properties.Settings.Default.Save();
            // Dispose BASS
            Stream.Dispose();
        }
        #endregion

        #region Buttons
        /// <summary>
        /// WndProc override to respond to About window click on System Menu
        /// </summary>
        /// <param name="m">WndProc message</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND) // If WndProc message is system menu item click
            {
                switch (m.WParam.ToInt32()) // For item clicked
                {
                    case IDM_ABOUT: // If about item
                        // Open about window
                        AboutWindow aboutWindow = new AboutWindow();
                        aboutWindow.ShowDialog();
                        return;
                    default:
                        break;
                }
            }
            // Run base function
            base.WndProc(ref m);
        }

        /// <summary>
        /// Open input window button click
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void inputButton_Click(object sender, EventArgs e)
        {
            InputWindow inputWindow = new InputWindow();
            if (inputWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK) // If OK button clicked on window
            {
                Stream.SetRecordingInput(inputWindow.selectedDevice); // Change input device to selection
                Properties.Settings.Default.Device = inputWindow.selectedDevice; // Set device setting
            }
        }

        /// <summary>
        /// Open encoder window button click
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void encoderButton_Click(object sender, EventArgs e)
        {
            EncoderWindow encoderWindow = new EncoderWindow();
            if (encoderWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK) // If OK button clicked on window
            {
                Stream.Codec = encoderWindow.SelectedCodec; // Set codec to selection
                Properties.Settings.Default.Encoder = (int)encoderWindow.SelectedCodec; // Set codec setting
                Stream.Bitrate = encoderWindow.SelectedBitrate; // Set bitrate to selection
                Properties.Settings.Default.Bitrate = encoderWindow.SelectedBitrate; // Set bitrate setting

            }
        }

        /// <summary>
        /// Open server window button click
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void serverButton_Click(object sender, EventArgs e)
        {
            ServerWindow serverWindow = new ServerWindow();
            if (serverWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK) // If OK button clicked on window
            {
                Stream.ServerType = serverWindow.selectedServerType; // Set server type to selection
                Properties.Settings.Default.Server = (int)serverWindow.selectedServerType; // Set server type setting
                Stream.Address = serverWindow.selectedAddress; // Set address to selection
                Properties.Settings.Default.Address = serverWindow.selectedAddress; // Set address setting
                Stream.Port = serverWindow.selectedPort; // Set port to selection
                Properties.Settings.Default.Port = serverWindow.selectedPort; // Set port setting
                Stream.Mount = serverWindow.selectedMount; // Set mount to selection
                Properties.Settings.Default.Mount = serverWindow.selectedMount; // Set mount setting
                Stream.Password = serverWindow.selectedPassword; // Set password to selection
                Properties.Settings.Default.Password = serverWindow.selectedPassword; // Set password setting
            }
        }

        /// <summary>
        /// Start/stop stream button click
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void startStopButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stream.ToggleStream();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Unable to find the chosen encoder", "Unable to Start Encoding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        /// <summary>
        /// Update levels on the volume meters
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void LevelUpdate(object sender, Stream.LevelEventArgs e)
        {
            if (IsHandleCreated) // If the window has a handle
            {
                // Invoke on form thread
                BeginInvoke((MethodInvoker)delegate
                {
                    leftVolumeMeter.Amplitude = (float)e.LeftLevel;
                    rightVolumeMeter.Amplitude = (float)e.RightLevel;
                });
            }
        }

        /// <summary>
        /// Update status when changed
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void StatusChange(object sender, EventArgs e)
        {
            if (Stream.CurrentStatus == Stream.Status.NOTSTREAMING)
            {
                statusLabel.Text = "Not Streaming";
                startStopButton.Text = "Start Stream";
            }
            else if (Stream.CurrentStatus == Stream.Status.STREAMING)
            {
                statusLabel.Text = "Streaming";
                startStopButton.Text = "Stop Stream";
            }
        }
    }
}