// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Metric limits set on an app. </summary>
    public partial class SiteLimits
    {
        /// <summary> Initializes a new instance of <see cref="SiteLimits"/>. </summary>
        public SiteLimits()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteLimits"/>. </summary>
        /// <param name="maxPercentageCpu"> Maximum allowed CPU usage percentage. </param>
        /// <param name="maxMemoryInMb"> Maximum allowed memory usage in MB. </param>
        /// <param name="maxDiskSizeInMb"> Maximum allowed disk size usage in MB. </param>
        internal SiteLimits(double? maxPercentageCpu, long? maxMemoryInMb, long? maxDiskSizeInMb)
        {
            MaxPercentageCpu = maxPercentageCpu;
            MaxMemoryInMb = maxMemoryInMb;
            MaxDiskSizeInMb = maxDiskSizeInMb;
        }

        /// <summary> Maximum allowed CPU usage percentage. </summary>
        public double? MaxPercentageCpu { get; set; }
        /// <summary> Maximum allowed memory usage in MB. </summary>
        public long? MaxMemoryInMb { get; set; }
        /// <summary> Maximum allowed disk size usage in MB. </summary>
        public long? MaxDiskSizeInMb { get; set; }
    }
}
