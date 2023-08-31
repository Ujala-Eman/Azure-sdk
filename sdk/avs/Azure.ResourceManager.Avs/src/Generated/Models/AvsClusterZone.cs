// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Zone and associated hosts info. </summary>
    public partial class AvsClusterZone
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvsClusterZone"/>. </summary>
        internal AvsClusterZone()
        {
            Hosts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsClusterZone"/>. </summary>
        /// <param name="hosts"> List of hosts belonging to the availability zone in a cluster. </param>
        /// <param name="zone"> Availability zone identifier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsClusterZone(IReadOnlyList<string> hosts, string zone, Dictionary<string, BinaryData> rawData)
        {
            Hosts = hosts;
            Zone = zone;
            _rawData = rawData;
        }

        /// <summary> List of hosts belonging to the availability zone in a cluster. </summary>
        public IReadOnlyList<string> Hosts { get; }
        /// <summary> Availability zone identifier. </summary>
        public string Zone { get; }
    }
}
