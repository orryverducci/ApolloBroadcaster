using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    class Stream
    {
        #region Enumerations
        public enum CODEC
        {
            MP3
        }
        public enum SERVERTYPE
        {
            SHOUTCAST,
            ICECAST
        }
        #endregion

        #region Properties
        /// <summary>
        /// The audio codec of the stream
        /// </summary>
        public CODEC Codec { get; set; }
        /// <summary>
        /// The bitrate of the stream
        /// </summary>
        public int Bitrate { get; set; }
        /// <summary>
        /// The type of server to be streamed to
        /// </summary>
        public SERVERTYPE ServerType { get; set; }
        /// <summary>
        /// The URL of the server to stream to
        /// </summary>
        public string ServerURL { get; set; }
        /// <summary>
        /// The port number on the server to stream to
        /// </summary>
        public int ServerPort { get; set; }
        /// <summary>
        /// The mount to stream to (for Icecast servers)
        /// </summary>
        public string Mount { get; set; }
        #endregion
    }
}
