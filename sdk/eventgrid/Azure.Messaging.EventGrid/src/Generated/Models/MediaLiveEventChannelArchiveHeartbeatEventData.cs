// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Channel Archive heartbeat event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.LiveEventChannelArchiveHeartbeat event. </summary>
    public partial class MediaLiveEventChannelArchiveHeartbeatEventData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventChannelArchiveHeartbeatEventData"/>. </summary>
        /// <param name="channelLatencyMsInternal"> Gets the channel latency in ms. </param>
        /// <param name="latencyResultCode"> Gets the latency result code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelLatencyMsInternal"/> or <paramref name="latencyResultCode"/> is null. </exception>
        internal MediaLiveEventChannelArchiveHeartbeatEventData(string channelLatencyMsInternal, string latencyResultCode)
        {
            Argument.AssertNotNull(channelLatencyMsInternal, nameof(channelLatencyMsInternal));
            Argument.AssertNotNull(latencyResultCode, nameof(latencyResultCode));

            ChannelLatencyMsInternal = channelLatencyMsInternal;
            LatencyResultCode = latencyResultCode;
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventChannelArchiveHeartbeatEventData"/>. </summary>
        /// <param name="channelLatencyMsInternal"> Gets the channel latency in ms. </param>
        /// <param name="latencyResultCode"> Gets the latency result code. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaLiveEventChannelArchiveHeartbeatEventData(string channelLatencyMsInternal, string latencyResultCode, Dictionary<string, BinaryData> rawData)
        {
            ChannelLatencyMsInternal = channelLatencyMsInternal;
            LatencyResultCode = latencyResultCode;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventChannelArchiveHeartbeatEventData"/> for deserialization. </summary>
        internal MediaLiveEventChannelArchiveHeartbeatEventData()
        {
        }
        /// <summary> Gets the latency result code. </summary>
        public string LatencyResultCode { get; }
    }
}
