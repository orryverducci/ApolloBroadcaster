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
        public enum SERVERTYPE
        {
            SHOUTCAST,
            ICECAST
        }
        #endregion

        #region Static Properties
        private static List<Codec> codecs = new List<Codec>();

        public static List<Codec> Codecs
        {
            get
            {
                return codecs;
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// The audio codec of the stream
        /// </summary>
        public Codec CodecType { get; set; }
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

        #region Constructors
        static Stream()
        {
            // Add MP3 codec to list of codecs
            Codec mp3 = new Codec("MP3", 128, new int[] { 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320 });
            codecs.Add(mp3);
        }
        #endregion
    }
}
