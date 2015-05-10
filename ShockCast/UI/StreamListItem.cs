using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockCast.UI
{
    public partial class StreamListItem : UserControl, ISelectableControl
    {
        private Stream stream;
        private bool selected;

        public StreamListItem(Stream audioStream)
        {
            // Set Stream
            stream = audioStream;
            // Create components
            InitializeComponent();
        }

        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                if (value == true)
                {
                    BackColor = Color.WhiteSmoke;
                }
                else
                {
                    BackColor = Color.White;
                }
            }
        }
    }
}
