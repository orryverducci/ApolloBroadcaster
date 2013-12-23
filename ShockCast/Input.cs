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
        private MMDevice device;
        private IWaveIn waveIn;
        private BufferedWaveProvider bufferedWaveProvider;
        private SampleChannel sampleChannel;
        private int sampleByteSize;
        private float meterLevel;

        public event EventHandler MeterLevelChanged;

        #region Constructor and Destructor
        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="ID">The ID of the input to be created</param>
        public Input(string ID)
        {
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
        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
            var tempBuffer = new float[e.BytesRecorded / sampleByteSize];
            sampleChannel.Read(tempBuffer, 0, e.BytesRecorded / sampleByteSize);
        }

        void sampleProvider_StreamVolume(object sender, StreamVolumeEventArgs e)
        {
            meterLevel = (float)(20 * Math.Log10(e.MaxSampleValues[0]));
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