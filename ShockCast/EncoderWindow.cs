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
    public partial class EncoderWindow : Form
    {
        public Stream.Encoder SelectedCodec { get; set; }
        public int SelectedBitrate { get; set; }

        public EncoderWindow()
        {
            // Set UI font to system font
            this.Font = SystemFonts.MessageBoxFont;
            // Initialise UI
            InitializeComponent();
        }

        private void EncoderWindow_Load(object sender, EventArgs e)
        {
            // Set options to settings
            codecComboBox.SelectedIndex = Properties.Settings.Default.Encoder;
            bitrateUpDown.Value = Properties.Settings.Default.Bitrate;
        }

        private void codecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCodec = (Stream.Encoder)codecComboBox.SelectedIndex;
        }

        private void bitrateUpDown_ValueChanged(object sender, EventArgs e)
        {
            SelectedBitrate = (int)bitrateUpDown.Value;
        }
    }
}
