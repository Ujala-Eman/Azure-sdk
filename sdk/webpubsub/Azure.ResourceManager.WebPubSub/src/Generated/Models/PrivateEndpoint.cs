// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Private endpoint. </summary>
    public partial class PrivateEndpoint
    {
        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        /// <param name="id"> Full qualified Id of the private endpoint. </param>
        internal PrivateEndpoint(string id)
        {
            Id = id;
        }

        /// <summary> Full qualified Id of the private endpoint. </summary>
        public string Id { get; set; }
    }
}
