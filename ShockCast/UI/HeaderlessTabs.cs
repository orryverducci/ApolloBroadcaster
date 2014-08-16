using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockCast.UI
{
    public class HeaderlessTabs : TabControl
    {
        public override Rectangle DisplayRectangle
        {
            get
            {
                return new Rectangle(0, 0, Width, Height);
            }
        }
    }
}
