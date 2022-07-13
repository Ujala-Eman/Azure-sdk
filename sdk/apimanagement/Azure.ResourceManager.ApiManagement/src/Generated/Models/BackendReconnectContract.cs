// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Reconnect request parameters. </summary>
    public partial class BackendReconnectContract : ResourceData
    {
        /// <summary> Initializes a new instance of BackendReconnectContract. </summary>
        public BackendReconnectContract()
        {
        }

        /// <summary> Initializes a new instance of BackendReconnectContract. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="after"> Duration in ISO8601 format after which reconnect will be initiated. Minimum duration of the Reconnect is PT2M. </param>
        internal BackendReconnectContract(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TimeSpan? after) : base(id, name, resourceType, systemData)
        {
            After = after;
        }

        /// <summary> Duration in ISO8601 format after which reconnect will be initiated. Minimum duration of the Reconnect is PT2M. </summary>
        public TimeSpan? After { get; set; }
    }
}
