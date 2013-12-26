using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    interface ISelectableControl
    {
        bool Selected { get; set; }
        Input Input { get; }
    }
}
