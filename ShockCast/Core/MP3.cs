using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    class MP3 : IEncoder
    {
        public static int[] SupportedBitrates
        {
            get
            {
                int[] bitrates = { 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320 };
                return bitrates;
            }
        }
    }
}
