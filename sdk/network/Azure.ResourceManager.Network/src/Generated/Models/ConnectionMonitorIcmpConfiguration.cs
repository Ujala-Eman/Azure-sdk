// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the ICMP configuration. </summary>
    internal partial class ConnectionMonitorIcmpConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorIcmpConfiguration"/>. </summary>
        public ConnectionMonitorIcmpConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorIcmpConfiguration"/>. </summary>
        /// <param name="disableTraceRoute"> Value indicating whether path evaluation with trace route should be disabled. </param>
        internal ConnectionMonitorIcmpConfiguration(bool? disableTraceRoute)
        {
            DisableTraceRoute = disableTraceRoute;
        }

        /// <summary> Value indicating whether path evaluation with trace route should be disabled. </summary>
        public bool? DisableTraceRoute { get; set; }
    }
}
