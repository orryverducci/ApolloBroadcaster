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
        /// Device channels
        /// </summary>
        private int channels;
        /// <summary>
        /// Device sample rate
        /// </summary>
        private int sampleRate;

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
        /// Device ID
        /// </summary>
        public int Channels
        {
            get
            {
                return channels;
            }
        }

        /// <summary>
        /// Device ID
        /// </summary>
        public int SampleRate
        {
            get
            {
                return sampleRate;
            }
        }

        /// <summary>
        /// Device information
        /// </summary>
        /// <param name="deviceName">The name of the device</param>
        /// <param name="deviceID">The ID of the device</param>
        /// <param name="sampleRate">The sample rate frequency</param>
        /// <param name="channels">The number of channels</param>
        public Device(string deviceName, string deviceID, int deviceSampleRate, int deviceChannels)
        {
            name = deviceName;
            id = deviceID;
            channels = deviceChannels;
            sampleRate = deviceSampleRate;
        }
    }
}
