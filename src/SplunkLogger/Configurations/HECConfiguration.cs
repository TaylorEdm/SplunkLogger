﻿
namespace Splunk.Configurations
{
    /// <summary>
    /// Class used to define configuration for Splunk HEC logger.
    /// </summary>
    public class HECConfiguration
    {
        /// <summary>
        /// Gets or sets the batch interval in miliseconds.
        /// </summary>
        public uint BatchIntervalInMiliseconds { get; set; } = 5000; // 5 seconds

        /// <summary>
        /// Gets or sets the batch size count.
        /// </summary>
        public uint BatchSizeCount { get; set; } = 10;

        /// <summary>
        /// Gets or sets the default timeout in miliseconds.
        /// </summary>
        public int DefaultTimeoutInMiliseconds { get; set; } = 10000; // 10 seconds

        /// <summary>
        /// Gets or sets the splunk collector URL.
        /// </summary>
        public string SplunkCollectorUrl { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        public string Token { get; set; }
    }
}