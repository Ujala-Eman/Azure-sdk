// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private link service connection details. </summary>
    public partial class PrivateLinkServiceConnection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceConnection"/>. </summary>
        public PrivateLinkServiceConnection()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceConnection"/>. </summary>
        /// <param name="name"> Private link service connection name. </param>
        /// <param name="groupIds"> List of group IDs. </param>
        /// <param name="requestMessage"> Request message. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkServiceConnection(string name, IList<string> groupIds, string requestMessage, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
            _rawData = rawData;
        }

        /// <summary> Private link service connection name. </summary>
        public string Name { get; set; }
        /// <summary> List of group IDs. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> Request message. </summary>
        public string RequestMessage { get; set; }
    }
}
