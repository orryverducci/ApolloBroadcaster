using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    /// <summary>
    /// A class linking streams to inputs
    /// </summary>
    public class InputStream
    {
        private string inputID;
        private Stream audioStream;

        public string InputID
        {
            get
            {
                return inputID;
            }
        }

        public Stream AudioStream
        {
            get
            {
                return audioStream;
            }
        }

        /// <summary>
        /// Link input to stream
        /// </summary>
        /// <param name="deviceInputID">The device ID for the input audio</param>
        /// <param name="outputAudioStream">The stream to output the inputs audio to</param>
        public InputStream(string deviceInputID, Stream outputAudioStream)
        {
            inputID = deviceInputID;
            audioStream = outputAudioStream;
        }
    }
}
