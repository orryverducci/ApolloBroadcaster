﻿using System;
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
            // Add 'About' to System Menu
            IntPtr sysMenuHandle = GetSystemMenu(this.Handle, false);
            InsertMenu(sysMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
            InsertMenu(sysMenuHandle, 6, MF_BYPOSITION, IDM_ABOUT, "About ShockCast...");
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
        #endregion
    }
}