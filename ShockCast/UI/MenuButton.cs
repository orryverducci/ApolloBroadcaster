using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShockCast.UI
{
    class MenuButton : CheckBox
    {
        public MenuButton()
        {
            this.Appearance = Appearance.Button;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb((255 / 100 * 10), Color.Black);
            this.FlatAppearance.CheckedBackColor = Color.FromArgb((255 / 100 * 20), Color.Black);
        }
    }
}
