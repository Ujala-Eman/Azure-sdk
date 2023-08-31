// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application notification endpoint. </summary>
    public partial class ArmApplicationNotificationEndpoint
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationNotificationEndpoint"/>. </summary>
        /// <param name="uri"> The managed application notification endpoint uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ArmApplicationNotificationEndpoint(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationNotificationEndpoint"/>. </summary>
        /// <param name="uri"> The managed application notification endpoint uri. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationNotificationEndpoint(Uri uri, Dictionary<string, BinaryData> rawData)
        {
            Uri = uri;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationNotificationEndpoint"/> for deserialization. </summary>
        internal ArmApplicationNotificationEndpoint()
        {
        }

        /// <summary> The managed application notification endpoint uri. </summary>
        public Uri Uri { get; set; }
    }
}
