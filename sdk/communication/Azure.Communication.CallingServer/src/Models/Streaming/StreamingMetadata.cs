﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Azure.Communication.CallingServer.Models.Streaming
{
    /// <summary>
    /// Streaming metadata
    /// </summary>
    public class StreamingMetadata
    {
        /// <summary>
        /// Subscription Id
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Format.
        /// </summary>
        [JsonPropertyName("format")]
        public StreamingFormat Format { get; set; }
    }
}
