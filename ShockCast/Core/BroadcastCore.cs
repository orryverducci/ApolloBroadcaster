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
    class BroadcastCore : IDisposable
    {
        #region Events
        /// <summary>
        /// Event fired when inputs or streams change
        /// </summary>
        public event EventHandler StreamsChanged;
        #endregion

        #region Constructor and Dispose
        public BroadcastCore()
        {
            // Check it is running on Windows Vista or newer, throwing an exception if not
            if (Environment.OSVersion.Version.Major < 6)
            {
                throw new PlatformNotSupportedException("This version of Windows is not supported. Windows Vista or newer is required.");
            }
        }

        /// <summary>
        /// Clean up inputs
        /// </summary>
        public void Dispose()
        {
            foreach (Input input in inputs)
            {
                input.Dispose();
            }
        }
        #endregion

        #region Inputs
        /// <summary>
        /// List of the current inputs
        /// </summary>
        private List<Input> inputs = new List<Input>();

        /// <summary>
        /// List of the current inputs
        /// </summary>
        public List<Input> Inputs
        {
            get
            {
                return inputs;
            }
        }

        /// <summary>
        /// Add an input
        /// </summary>
        /// <param name="ID">ID of the input to be added</param>
        public void AddInput(string ID)
        {
            // Try to find input ID to be added in existing inputs
            bool inputExists = inputs.Exists(device => device.ID == ID);
            // Add input if it doesn't already exist
            if (!inputExists)
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
            // Else throw an exception
            else
            {
                throw new ArgumentException("An input has already been created for this device.");
            }
        }

        public void RemoveInput(Input input)
        {
            // Disposes input
            input.Dispose();
            // Remove input
            inputs.Remove(input);
            // Fire streams changed event
            if (StreamsChanged != null)
            {
                StreamsChanged(this, new EventArgs());
            }
        }
        #endregion

        #region Streams
        /// <summary>
        /// List of the current streams
        /// </summary>
        private List<InputStream> streams = new List<InputStream>();

        /// <summary>
        /// List of the current streams
        /// </summary>
        public List<InputStream> Streams
        {
            get
            {
                return streams;
            }
        }

        /// <summary>
        /// Add a stream
        /// </summary>
        /// <param name="inputID">ID of the input device</param>
        /// <param name="codec">Codec of the stream to be added</param>
        /// <param name="bitrate">Bitrate of the stream to be added</param>
        /// <param name="channels">Audio channels of the stream to be added</param>
        /// <param name="sampleRate">Audio sample rate of the stream to be added</param>
        /// <param name="server">Server type of the stream to be added</param>
        /// <param name="serverURL">URL of the stream to be added</param>
        /// <param name="mount">Mount of hte stream to be added</param>
        /// <param name="port">Port of the stream to be added</param>
        /// <param name="password">Password for the server of the stream to be added</param>
        public void AddStream(string inputID, string codec, int bitrate, int channels, int sampleRate, string server, string serverURL, string mount, int port, string password)
        {
            // Create stream
            Stream stream = new Stream(codec, bitrate, channels, sampleRate, server, serverURL, mount, port, password);
            // Create input and stream link
            InputStream inputStream = new InputStream(inputID, stream);
            // Add stream to current streams
            streams.Add(inputStream);
            // Fire streams changed event
            if (StreamsChanged != null)
            {
                StreamsChanged(this, new EventArgs());
            }
        }
        #endregion
    }
}