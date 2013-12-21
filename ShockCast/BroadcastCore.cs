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
        #region Events
        /// <summary>
        /// Event fired when inputs or streams change
        /// </summary>
        public event EventHandler StreamsChanged;
        #endregion

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

        /// <summary>
        /// Add an input
        /// </summary>
        /// <param name="ID">ID of the input to be added</param>
        public void AddInput(string ID)
        {
            // Create input
            Input input = new Input(ID);
            // Add input to current inputs
            inputs.Add(input);
            // Fire streams changed event
            if (StreamsChanged != null)
            {
                StreamsChanged(this, new EventArgs());
            }
        }
        #endregion
    }
}
