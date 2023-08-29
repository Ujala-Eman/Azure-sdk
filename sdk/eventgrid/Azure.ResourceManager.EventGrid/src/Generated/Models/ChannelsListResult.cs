// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Channels operation. </summary>
    internal partial class ChannelsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ChannelsListResult"/>. </summary>
        internal ChannelsListResult()
        {
            Value = new ChangeTrackingList<PartnerNamespaceChannelData>();
        }

        /// <summary> Initializes a new instance of <see cref="ChannelsListResult"/>. </summary>
        /// <param name="value"> A collection of Channels. </param>
        /// <param name="nextLink"> A link for the next page of channels. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ChannelsListResult(IReadOnlyList<PartnerNamespaceChannelData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A collection of Channels. </summary>
        public IReadOnlyList<PartnerNamespaceChannelData> Value { get; }
        /// <summary> A link for the next page of channels. </summary>
        public string NextLink { get; }
    }
}
