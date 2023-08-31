// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Supported operating system details. </summary>
    public partial class SiteRecoverySupportedOSDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoverySupportedOSDetails"/>. </summary>
        internal SiteRecoverySupportedOSDetails()
        {
            OSVersions = new ChangeTrackingList<SiteRecoveryOSVersionWrapper>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoverySupportedOSDetails"/>. </summary>
        /// <param name="osName"> The name. </param>
        /// <param name="osType"> The type. </param>
        /// <param name="osVersions"> The list of version for operating system. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoverySupportedOSDetails(string osName, string osType, IReadOnlyList<SiteRecoveryOSVersionWrapper> osVersions, Dictionary<string, BinaryData> rawData)
        {
            OSName = osName;
            OSType = osType;
            OSVersions = osVersions;
            _rawData = rawData;
        }

        /// <summary> The name. </summary>
        public string OSName { get; }
        /// <summary> The type. </summary>
        public string OSType { get; }
        /// <summary> The list of version for operating system. </summary>
        public IReadOnlyList<SiteRecoveryOSVersionWrapper> OSVersions { get; }
    }
}
