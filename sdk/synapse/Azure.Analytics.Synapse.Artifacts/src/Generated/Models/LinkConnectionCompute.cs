// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionCompute. </summary>
    public partial class LinkConnectionCompute
    {
        /// <summary> Initializes a new instance of LinkConnectionCompute. </summary>
        public LinkConnectionCompute()
        {
        }

        /// <summary> Initializes a new instance of LinkConnectionCompute. </summary>
        /// <param name="coreCount"> Compute core count used by the link connection. </param>
        /// <param name="computeType"> Link connection&apos;s compute type. </param>
        /// <param name="dataProcessIntervalMinutes"> Link connection&apos;s data process interval in minutes. </param>
        internal LinkConnectionCompute(int? coreCount, string computeType, int? dataProcessIntervalMinutes)
        {
            CoreCount = coreCount;
            ComputeType = computeType;
            DataProcessIntervalMinutes = dataProcessIntervalMinutes;
        }

        /// <summary> Compute core count used by the link connection. </summary>
        public int? CoreCount { get; set; }
        /// <summary> Link connection&apos;s compute type. </summary>
        public string ComputeType { get; set; }
        /// <summary> Link connection&apos;s data process interval in minutes. </summary>
        public int? DataProcessIntervalMinutes { get; set; }
    }
}
