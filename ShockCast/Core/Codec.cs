using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockCast
{
    class Codec
    {
        /// <summary>
        /// Codec Name
        /// </summary>
        private string name;

        /// <summary>
        /// Recommended bitrate
        /// </summary>
        private int recommendedBitrate;

        /// <summary>
        /// Supported bitrates
        /// </summary>
        private int[] supportedBitrates;

        /// <summary>
        /// Codec name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Recommended bitrate
        /// </summary>
        public int RecommendedBitrate
        {
            get
            {
                return recommendedBitrate;
            }
        }

        /// <summary>
        /// Supported bitrates
        /// </summary>
        public int[] SupportedBitrates
        {
            get
            {
                return supportedBitrates;
            }
        }

        /// <summary>
        /// Codec information
        /// </summary>
        /// <param name="codecName">The name of the codec</param>
        /// <param name="codecRecommendedBitrate">The bitrate recommended for the codec</param>
        /// <param name="codecSupportedBitrates">An array of bitrates supported by the codec</param>
        public Codec(string codecName, int codecRecommendedBitrate, int[] codecSupportedBitrates)
        {
            name = codecName;
            recommendedBitrate = codecRecommendedBitrate;
            supportedBitrates = codecSupportedBitrates;
        }
    }
}
