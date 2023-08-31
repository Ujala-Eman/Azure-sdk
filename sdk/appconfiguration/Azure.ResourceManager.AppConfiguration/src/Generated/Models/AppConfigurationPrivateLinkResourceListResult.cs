// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class AppConfigurationPrivateLinkResourceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkResourceListResult"/>. </summary>
        internal AppConfigurationPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<AppConfigurationPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationPrivateLinkResourceListResult(IReadOnlyList<AppConfigurationPrivateLinkResourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<AppConfigurationPrivateLinkResourceData> Value { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}
