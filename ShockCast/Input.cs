using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace ShockCast
{
    /// <summary>
    /// Audio input
    /// </summary>
    public class Input : IDisposable
    {
        private MMDevice device;
        private IWaveIn waveIn;

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