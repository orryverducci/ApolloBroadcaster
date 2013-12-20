using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    /// <summary>
    /// The Broadcast Core, which handles inputs and streams
    /// </summary>
    class BroadcastCore
    {
        public BroadcastCore()
        {
            // Check it is running on Windows Vista or newer, throwing an exception if not
            if (Environment.OSVersion.Version.Major < 6)
            {
                throw new PlatformNotSupportedException("This version of Windows is not supported. Windows Vista or newer is required.");
            }
        }

        #region Inputs
        /// <summary>
        /// List of the current inputs
        /// </summary>
        private List<Input> inputs = new List<Input>();
        #endregion
    }
}
