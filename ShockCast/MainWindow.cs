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
using ShockCast.UI;

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

        #region Private Fields
        private BroadcastCore broadcastCore;
        private ISelectableControl selectedControl;
        #endregion

        #region Form Load and Close
        public MainWindow()
        {
            // Set UI font to system font
            this.Font = SystemFonts.MessageBoxFont;
            // Initialise UI
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for form load, setting up UI and broadcast core
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Add 'About' to System Menu
            IntPtr sysMenuHandle = GetSystemMenu(this.Handle, false);
            InsertMenu(sysMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
            InsertMenu(sysMenuHandle, 6, MF_BYPOSITION, IDM_ABOUT, "About ShockCast...");
            // Create Broadcast Core
            try
            {
                broadcastCore = new BroadcastCore();
            }
            catch (PlatformNotSupportedException exception)
            {
                MessageBox.Show(exception.Message, "Unable to start ShockCast", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            // Handle streams changing event
            broadcastCore.StreamsChanged += broadcastCore_StreamsChanged;
        }

        /// <summary>
        /// Event handler for form close, cleaning up the broadcast core
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            broadcastCore.Dispose();
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
        /// Add input button click handler
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void inputButton_Click(object sender, EventArgs e)
        {
            // Create form
            AddInputWindow addInputWindow = new AddInputWindow();
            // Show dialog, and add input if the OK button is clicked
            if (addInputWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    broadcastCore.AddInput(addInputWindow.SelectedDevice.ID);
                }
                catch (ArgumentException exception) // If an exception is thown, show an error
                {
                    MessageBox.Show(exception.Message, "Unable to Add Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Add stream button click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streamButton_Click(object sender, EventArgs e)
        {
            // Create form
            AddStreamWindow streamWindow = new AddStreamWindow(broadcastCore.Inputs);
            // Show dialog, and add input if the OK button is clicked
            if (streamWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                broadcastCore.AddStream(streamWindow.Device, streamWindow.CodecType, streamWindow.Bitrate, streamWindow.Channels, streamWindow.SampleRate, streamWindow.Server, streamWindow.StreamURL, streamWindow.Mount, streamWindow.Port, streamWindow.Password);
            }
        }

        /// <summary>
        /// Remove button click handler
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            broadcastCore.RemoveInput(((InputHeader)(selectedControl)).Input);
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Event handler for streams changing
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        void broadcastCore_StreamsChanged(object sender, EventArgs e)
        {
            // Set no items to selected
            removeButton.Enabled = false;
            selectedControl = null;
            // Clear all controls in flow layout
            flowLayoutPanel.Controls.Clear();
            // Add UI elements for each input
            foreach (Input input in broadcastCore.Inputs)
            {
                // Create input header
                InputHeader header = new InputHeader(input);
                // Set input header UI size and position parameters
                header.Width = flowLayoutPanel.Width;
                header.Margin = new System.Windows.Forms.Padding(0);
                // Set click event handler
                header.Click += header_Click;
                // Add to flow layout
                flowLayoutPanel.Controls.Add(header);
                // Add streams
                foreach (InputStream stream in broadcastCore.Streams)
                {
                    if (stream.InputID == input.ID)
                    {
                        // Create stream list item
                        StreamListItem item = new StreamListItem();
                        // Set stream list item UI size and position parameters
                        item.Width = flowLayoutPanel.Width;
                        item.Margin = new System.Windows.Forms.Padding(0);
                        // Add to flow layout
                        flowLayoutPanel.Controls.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler to select item when it is clicked
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        void header_Click(object sender, EventArgs e)
        {
            // Mark previous selected control as not selected
            if (selectedControl != null)
            {
                selectedControl.Selected = false;
            }
            // Set the currently selected control to the newly selected item
            selectedControl = (ISelectableControl)sender;
            selectedControl.Selected = true;
            // Enable remove button
            removeButton.Enabled = true;
        }
        #endregion
    }
}