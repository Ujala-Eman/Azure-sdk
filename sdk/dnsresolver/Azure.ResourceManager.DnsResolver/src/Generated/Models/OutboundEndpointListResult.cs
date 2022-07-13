// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DnsResolver;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> The response to an enumeration operation on outbound endpoints for a DNS resolver. </summary>
    internal partial class OutboundEndpointListResult
    {
        /// <summary> Initializes a new instance of OutboundEndpointListResult. </summary>
        internal OutboundEndpointListResult()
        {
            Value = new ChangeTrackingList<DnsResolverOutboundEndpointData>();
        }

        /// <summary> Initializes a new instance of OutboundEndpointListResult. </summary>
        /// <param name="value"> Enumeration of the outbound endpoints for a DNS resolver. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        internal OutboundEndpointListResult(IReadOnlyList<DnsResolverOutboundEndpointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Enumeration of the outbound endpoints for a DNS resolver. </summary>
        public IReadOnlyList<DnsResolverOutboundEndpointData> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
