using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    /// <summary>
    /// An audio device
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Device name
        /// </summary>
        private string name;
        /// <summary>
        /// Device ID
        /// </summary>
        private string id;

        /// <summary>
        /// Device name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Device ID
        /// </summary>
        public string ID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Device information
        /// </summary>
        /// <param name="deviceName">The name of the device</param>
        /// <param name="deviceID">The ID of the device</param>
        public Device(string deviceName, string deviceID)
        {
            name = deviceName;
            id = deviceID;
        }
    }
}
