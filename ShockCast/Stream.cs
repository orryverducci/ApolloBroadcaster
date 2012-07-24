using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Enc;
using Un4seen.Bass.AddOn.Wma;
using Un4seen.Bass.Misc;

namespace ShockCast
{
    public static class Stream
    {
        #region Private Fields
        private static bool successfulInit; // Represents if BASS was successfully initialised
        private static bool recordingInputActive; // Represents if there is a current active recording input
        private static int recordingHandle; // Handle of the recording stream
        private static RECORDPROC recordProc = new RECORDPROC(RecordHandler); // Recording Callback;
        private static DSP_PeakLevelMeter peakLevelMeter; // Peak Level Meter
        private static bool currentlyStreaming = false; // Represents if it is currently streaming
        private static BroadCast broadCast; // The broadcast to the server
        #endregion

        #region Properties
        public static Encoder Codec { get; set; }
        public static int Bitrate { get; set; }
        public static Server ServerType { get; set; }
        public static string Address { get; set; }
        public static int Port { get; set; }
        public static string Mount { get; set; }
        public static string Password { get; set; }
        #endregion

        #region Events
        public class LevelEventArgs : EventArgs
        {
            public double LeftLevel { get; set; }
            public double RightLevel { get; set; }
        }
        public delegate void LevelEventHandler(object sender, LevelEventArgs e);
        public static event LevelEventHandler PeakLevelMeterUpdate;
        #endregion

        #region Enumerations
        public enum Encoder
        {
            MP3 = 0,
            AAC = 1,
            WMA = 2,
            Ogg = 3
        }

        public enum Server
        {
            SHOUTCAST = 0,
            ICECAST = 1,
            WINMEDIA = 2
        }
        #endregion

        #region Methods
        #region Constructor and destructor
        /// <summary>
        /// Starts up BASS, ready for the stream to be created
        /// </summary>
        public static void Initialise()
        {
            // Registration code for Bass.Net
            // Provided value should be used only for ShockCast, not derived products
            //BassNet.Registration("your mail", "your registration key");
            // Set dll locations
            if (IntPtr.Size == 8) // If running in 64 bit
            {
                Bass.LoadMe("x64");
                BassEnc.LoadMe("x64");
                BassWma.LoadMe("x64");
            }
            else // Else if running in 32 bit
            {
                Bass.LoadMe("x86");
                BassEnc.LoadMe("x86");
                BassWma.LoadMe("x86");
            }
            // Initialise BASS
            if (!Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, System.IntPtr.Zero)) // If unable to initialise
            {
                // Throw exception
                successfulInit = false;
                throw new ApplicationException();
            }
            successfulInit = true;
        }

        /// <summary>
        /// Stops streams and shuts down BASS
        /// </summary>
        public static void Dispose()
        {
            if (successfulInit) // If BASS has been initialised
            {
                BassEnc.FreeMe(); // Free BASSenc
                BassWma.FreeMe(); // Free BASSwma
                Bass.FreeMe(); // Free BASS
            }
        }
        #endregion

        #region Input recording
        /// <summary>
        /// Sets the recording input to the specified input
        /// </summary>
        /// <param name="inputID">ID of the input to use</param>
        public static void SetRecordingInput(int inputID)
        {
            if (recordingInputActive) // If there is an active recording input
            {
                // Free the recording input
                Bass.BASS_ChannelStop(recordingHandle);
                Bass.BASS_RecordFree();
            }
            if (!Bass.BASS_RecordInit(inputID)) // If unable to initialise recording input
            {
                // Throw exception
                recordingInputActive = false;
                throw new ArgumentException();
            }
            recordingInputActive = true;
            // Start recording
            recordingHandle = Bass.BASS_RecordStart(44100, 2, BASSFlag.BASS_SAMPLE_FLOAT, recordProc, IntPtr.Zero);
            // Add Peak Level Meter DSP and Event Handler
            peakLevelMeter = new DSP_PeakLevelMeter(recordingHandle, 1);
            peakLevelMeter.Notification += new EventHandler(PeakLevelMeterNotification);
        }

        /// <summary>
        /// Stub recording callback function
        /// </summary>
        /// <param name="handle">Handle of the recording stream</param>
        /// <param name="buffer">Recording buffer</param>
        /// <param name="length">Length of buffer</param>
        /// <param name="user">User parameters</param>
        /// <returns></returns>
        private static bool RecordHandler(int handle, IntPtr buffer, int length, IntPtr user)
        {
            return true;
        }

        /// <summary>
        /// Triggers event sending peak level meter values
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Event argument</param>
        public static void PeakLevelMeterNotification(object sender, EventArgs e)
        {
            if (PeakLevelMeterUpdate != null)
            {
                // Create event args containing levels
                LevelEventArgs levelEvent = new LevelEventArgs();
                levelEvent.LeftLevel = peakLevelMeter.LevelL_dBV;
                levelEvent.RightLevel = peakLevelMeter.LevelR_dBV;
                // Trigger event
                PeakLevelMeterUpdate(null, levelEvent);
            }
        }
        #endregion

        #region Encoding and Streaming
        /// <summary>
        /// Starts or stops the stream depending on the current status
        /// </summary>
        public static void ToggleStream()
        {
            if (!currentlyStreaming)
            {
                StartStream();
            }
            else
            {
                StopStream();
            }
        }

        /// <summary>
        /// Start streaming
        /// </summary>
        private static void StartStream()
        {
            IBaseEncoder encoder = null;
            IStreamingServer server = null;

            // Setup the encoder
            if (Codec == Encoder.MP3) // If codec is set to MP3
            {
                EncoderLAME lameEncoder = new EncoderLAME(recordingHandle);
                lameEncoder.InputFile = null; // Set input to Stdin
                lameEncoder.OutputFile = null; // Set output to Stdout
                lameEncoder.LAME_Bitrate = Bitrate; // Stream bitrate
                lameEncoder.LAME_Mode = EncoderLAME.LAMEMode.Default; // Number of channels
                lameEncoder.LAME_TargetSampleRate = (int)EncoderLAME.SAMPLERATE.Hz_44100; // Sample rate
                lameEncoder.LAME_Quality = EncoderLAME.LAMEQuality.Quality; // Encoding quality
                if (IntPtr.Size == 8) // If running in 64 bit
                {
                    lameEncoder.EncoderDirectory = "x64";
                }
                else // Else if running in 32 bit
                {
                    lameEncoder.EncoderDirectory = "x86";
                }
                if (!lameEncoder.EncoderExists) // If encoder has not been found, throw an exception
                {
                    throw new FileNotFoundException();
                }
                encoder = lameEncoder;
            }
            else if (Codec == Encoder.AAC)
            {
                throw new NotImplementedException();
            }
            else if (Codec == Encoder.Ogg)
            {
                EncoderOGG oggEncoder = new EncoderOGG(recordingHandle);
                oggEncoder.InputFile = null; // Set input to Stdin
                oggEncoder.OutputFile = null; // Set output to Stdout
                oggEncoder.OGG_UseQualityMode = false; // Use bitrate rather than quality target
                oggEncoder.OGG_UseManagedBitrate = true; // Target bitrate precisely
                oggEncoder.OGG_Bitrate = Bitrate; // Stream bitrate
                oggEncoder.OGG_MinBitrate = Bitrate; // Use CBR
                oggEncoder.OGG_MaxBitrate = Bitrate; // Use CBR
                oggEncoder.OGG_TargetSampleRate = (int)EncoderOGG.SAMPLERATE.Hz_44100; // Sample rate
                if (IntPtr.Size == 8) // If running in 64 bit
                {
                    oggEncoder.EncoderDirectory = "x64";
                }
                else // Else if running in 32 bit
                {
                    oggEncoder.EncoderDirectory = "x86";
                }
                if (!oggEncoder.EncoderExists) // If encoder has not been found, throw an exception
                {
                    throw new FileNotFoundException();
                }
                encoder = oggEncoder;
            }
            else if (Codec == Encoder.WMA)
            {
                EncoderWMA wmaEncoder = new EncoderWMA(recordingHandle);
                wmaEncoder.InputFile = null; // Set intput to Stdin
                wmaEncoder.OutputFile = null; // Set output to Stdout
                wmaEncoder.WMA_Bitrate = Bitrate; // Stream bitrate
                encoder = wmaEncoder;
            }

            // Setup the stream to the server
            if (ServerType == Server.SHOUTCAST)
            {
                SHOUTcast shoutCast = new SHOUTcast(encoder);
                shoutCast.ServerAddress = Address; // Server address
                if (Port != 0) // If port has been set, use it
                {
                    shoutCast.ServerPort = Port;
                }
                else // Otherwise use default SHOUTcast port of 8000
                {
                    shoutCast.ServerPort = 8000;
                }
                shoutCast.Password = Password;
                server = shoutCast;
            }
            else if (ServerType == Server.ICECAST)
            {
                throw new NotImplementedException();
                ICEcast iceCast = new ICEcast(encoder);
                server = iceCast;
            }
            else if (ServerType == Server.WINMEDIA)
            {
                throw new NotImplementedException();
                WMAcast wmaCast = new WMAcast(encoder);
                server = wmaCast;
            }

            // Start streaming
            try
            {
                broadCast = new BroadCast(server);
                broadCast.AutoReconnect = false;
                broadCast.AutoConnect();
                currentlyStreaming = true;
            }
            catch (Exception ex)
            {
                currentlyStreaming = false;
            }
        }

        /// <summary>
        /// Stop Streaming
        /// </summary>
        private static void StopStream()
        {

        }
        #endregion
        #endregion
    }
}
