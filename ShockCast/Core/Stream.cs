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
        /// <summary>
        /// Represents the state of a stream
        /// </summary>
        public enum States
        {
            /// <summary>
            /// Stream is connected
            /// </summary>
            CONNECTED,
            /// <summary>
            /// Stream is not connected
            /// </summary>
            DISCONNECTED,
            /// <summary>
            /// Connection to the server has failed
            /// </summary>
            CONNECTFAILURE
        }
        #endregion

        #region Static Properties
        private static List<Codec> codecs = new List<Codec>();
        private static List<ServerType> serverTypes = new List<ServerType>();

        public static List<Codec> Codecs
        {
            get
            {
                return codecs;
            }
        }

        public static List<ServerType> ServerTypes
        {
            get
            {
                return serverTypes;
            }
        }
        #endregion

        #region Private fields
        /// <summary>
        /// The audio codec of the stream
        /// </summary>
        private string codecType;
        /// <summary>
        /// The bitrate of the stream
        /// </summary>
        private int bitrate;
        /// <summary>
        /// The number of audio channels of the stream
        /// </summary>
        private int channels;
        /// <summary>
        /// The audio sample rate of the stream
        /// </summary>
        private int sampleRate;
        /// <summary>
        /// The server to be streamed to
        /// </summary>
        private string server;
        /// <summary>
        /// The URL of the server to stream to
        /// </summary>
        private string serverURL;
        /// <summary>
        /// The mount to stream to (for compatible servers)
        /// </summary>
        private string mount;
        /// <summary>
        /// The port number on the server to stream to
        /// </summary>
        private int serverPort;
        /// <summary>
        /// The password for the server (when required)
        /// </summary>
        private string password;
        /// <summary>
        /// The current state of the stream
        /// </summary>
        private States currentState;
        #endregion

        #region Information Properties
        /// <summary>
        /// The audio codec of the stream
        /// </summary>
        public string CodecType {
            get
            {
                return codecType;
            }
        }
        /// <summary>
        /// The bitrate of the stream
        /// </summary>
        public int Bitrate {
            get
            {
                return bitrate;
            }
        }
        /// <summary>
        /// The server being streamed to
        /// </summary>
        public string Server
        {
            get
            {
                return server;
            }
        }
        /// <summary>
        /// The URL of the stream
        /// </summary>
        public string StreamURL {
            get
            {
                string returnedURL = serverURL;
                if (serverPort != 0)
                {
                    returnedURL += ":" + serverPort.ToString();
                }
                returnedURL += "/";
                if (mount != String.Empty)
                {
                    returnedURL += mount;
                }
                return returnedURL;
            }
        }
        /// <summary>
        /// The current state of the stream
        /// </summary>
        public States CurrentState
        {
            get
            {
                return currentState;
            }
        }
        #endregion

        #region Constructors
        static Stream()
        {
            // Add MP3 codec to list of codecs
            Codec mp3 = new Codec("MP3", "libmp3lame", 128, new int[] { 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320 });
            codecs.Add(mp3);
            // Add IceCast to the list of server types
            ServerType iceCast = new ServerType("IceCast", 8000, true);
            serverTypes.Add(iceCast);
        }

        /// <summary>
        /// A stream to a server
        /// </summary>
        /// <param name="streamCodec">The audio codec</param>
        /// <param name="streamBitrate">The audio bitrate</param>
        /// <param name="streamChannels">The number of audio channels</param>
        /// <param name="streamSampleRate">The audio sample rate</param>
        /// <param name="streamServer">The server type</param>
        /// <param name="streamURL">The server URL</param>
        /// <param name="streamMount">The server mount point, if required</param>
        /// <param name="streamPort">The server port. Set to 0 to use the default port</param>
        public Stream(string streamCodec, int streamBitrate, int streamChannels, int streamSampleRate, string streamServer, string streamURL, string streamMount, int streamPort)
        {
            codecType = streamCodec;
            bitrate = streamBitrate;
            channels = streamChannels;
            sampleRate = streamSampleRate;
            server = streamServer;
            serverURL = streamURL;
            mount = streamMount;
            serverPort = streamPort;
            currentState = States.DISCONNECTED;
        }
        #endregion
    }
}
