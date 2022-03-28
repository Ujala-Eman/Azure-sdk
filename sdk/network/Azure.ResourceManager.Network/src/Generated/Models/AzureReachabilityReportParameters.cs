// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Geographic and time constraints for Azure reachability report. </summary>
    public partial class AzureReachabilityReportParameters
    {
        /// <summary> Initializes a new instance of AzureReachabilityReportParameters. </summary>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="startOn"> The start time for the Azure reachability report. </param>
        /// <param name="endOn"> The end time for the Azure reachability report. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerLocation"/> is null. </exception>
        public AzureReachabilityReportParameters(AzureReachabilityReportLocation providerLocation, DateTimeOffset startOn, DateTimeOffset endOn)
        {
            if (providerLocation == null)
            {
                throw new ArgumentNullException(nameof(providerLocation));
            }

            ProviderLocation = providerLocation;
            Providers = new ChangeTrackingList<string>();
            AzureLocations = new ChangeTrackingList<string>();
            StartOn = startOn;
            EndOn = endOn;
        }

        /// <summary> Parameters that define a geographic location. </summary>
        public AzureReachabilityReportLocation ProviderLocation { get; }
        /// <summary> List of Internet service providers. </summary>
        public IList<string> Providers { get; }
        /// <summary> Optional Azure regions to scope the query to. </summary>
        public IList<string> AzureLocations { get; }
        /// <summary> The start time for the Azure reachability report. </summary>
        public DateTimeOffset StartOn { get; }
        /// <summary> The end time for the Azure reachability report. </summary>
        public DateTimeOffset EndOn { get; }
    }
}
