using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace ShockCast
{
    /// <summary>
    /// Audio input
    /// </summary>
    public class Input : IDisposable
    {
        #region Private Fields
        /// <summary>
        /// The device ID
        /// </summary>
        private string deviceID;
        /// <summary>
        /// The input device
        /// </summary>
        private MMDevice device;
        /// <summary>
        /// The input capture
        /// </summary>
        private IWaveIn waveIn;
        /// <summary>
        /// Buffered wave provider for the input
        /// </summary>
        private BufferedWaveProvider bufferedWaveProvider;
        /// <summary>
        /// The sample providing channel for the input
        /// </summary>
        private SampleChannel sampleChannel;
        /// <summary>
        /// The number of bytes in a sample
        /// </summary>
        private int sampleByteSize;
        /// <summary>
        /// The audio level
        /// </summary>
        private float meterLevel;
        #endregion

        /// <summary>
        /// Event fired when the meter level changes
        /// </summary>
        public event EventHandler MeterLevelChanged;

        #region Constructor and Destructor
        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="ID">The ID of the input to be created</param>
        public Input(string ID)
        {
            // Set the device ID
            deviceID = ID;
            // Get Device from specified ID
            MMDeviceEnumerator devices = new MMDeviceEnumerator();
            device = devices.GetDevice(ID);
            // Set wave in to WASAPI capture of the specified device
            waveIn = new WasapiCapture(device);
            // Set the number of bytes used by each sample
            sampleByteSize = waveIn.WaveFormat.BitsPerSample / 8;
            // Add event handler to retrieve samples from the device
            waveIn.DataAvailable += waveIn_DataAvailable;
            // Create buffered wave provider
            bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
            bufferedWaveProvider.DiscardOnBufferOverflow = true;
            // Create sample channel
            sampleChannel = new SampleChannel(bufferedWaveProvider);
            // Create sample provider
            sampleChannel.PreVolumeMeter += sampleProvider_StreamVolume;
            // Start recording
            waveIn.StartRecording();
        }

        /// <summary>
        /// Stop inputs and clean up
        /// </summary>
        public void Dispose()
        {
            // Stop recording
            waveIn.StopRecording();
            waveIn.Dispose();
        }
        #endregion

        #region Information Properties
        /// <summary>
        /// The device ID
        /// </summary>
        public string ID
        {
            get
            {
                return deviceID;
            }
        }

        /// <summary>
        /// Name of the input device
        /// </summary>
        public string Name
        {
            get
            {
                return device.FriendlyName;
            }
        }

        /// <summary>
        /// The current amplitude of the input in dB
        /// </summary>
        public float MeterLevel
        {
            get
            {
                return meterLevel;
            }
        }
        #endregion

        #region Recording Functions
        /// <summary>
        /// Event handler to retrieve audio data from input device
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Send the data to the buffered wave provider
            bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
            var tempBuffer = new float[e.BytesRecorded / sampleByteSize];
            sampleChannel.Read(tempBuffer, 0, e.BytesRecorded / sampleByteSize);
        }

        /// <summary>
        /// Event handler to update volume meter
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event arguments</param>
        void sampleProvider_StreamVolume(object sender, StreamVolumeEventArgs e)
        {
            float peak;
            // If stereo, set peak to value of the highest channel
            if (e.MaxSampleValues.Count() > 1)
            {
                peak = (e.MaxSampleValues[0] > e.MaxSampleValues[1]) ? e.MaxSampleValues[0] : e.MaxSampleValues[1];
            }
            // Else if mono use only channel peak value
            else
            {
                peak = e.MaxSampleValues[0];
            }
            // Convert signal level to decibels and update level with result
            meterLevel = (float)(20 * Math.Log10(e.MaxSampleValues[0]));
            // Fire event indicating the level has changed
            if (MeterLevelChanged != null)
            {
                MeterLevelChanged(this, new EventArgs());
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Returns a list of all the currently available devices
        /// </summary>
        public static List<Device> GetDevices()
        {
            // Create the list to return
            List<Device> devices = new List<Device>();
            // Create the device enumerator
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            // Enumerate all the plugged in input devices and add them to the list
            foreach (MMDevice endPoint in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                Device device = new Device(endPoint.FriendlyName, endPoint.ID);
                devices.Add(device);
            }
            // Return the list
            return devices;
        }
        #endregion
    }
}