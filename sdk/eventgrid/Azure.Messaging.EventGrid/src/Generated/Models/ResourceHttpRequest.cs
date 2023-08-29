// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The details of the HTTP request. </summary>
    public partial class ResourceHttpRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHttpRequest"/>. </summary>
        internal ResourceHttpRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHttpRequest"/>. </summary>
        /// <param name="clientRequestId"> The client request ID. </param>
        /// <param name="clientIpAddress"> The client IP address. </param>
        /// <param name="methodString"> The request method. </param>
        /// <param name="url"> The url used in the request. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHttpRequest(string clientRequestId, string clientIpAddress, string methodString, string url, Dictionary<string, BinaryData> rawData)
        {
            ClientRequestId = clientRequestId;
            ClientIpAddress = clientIpAddress;
            MethodString = methodString;
            Url = url;
            _rawData = rawData;
        }

        /// <summary> The client request ID. </summary>
        public string ClientRequestId { get; }
        /// <summary> The client IP address. </summary>
        public string ClientIpAddress { get; }
        /// <summary> The url used in the request. </summary>
        public string Url { get; }
    }
}
