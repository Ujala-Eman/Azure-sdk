// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// Signed device capability image response
    /// Serialized Name: SignedCapabilityImageResponse
    /// </summary>
    public partial class SignedCapabilityImageResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SignedCapabilityImageResponse"/>. </summary>
        internal SignedCapabilityImageResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignedCapabilityImageResponse"/>. </summary>
        /// <param name="image">
        /// The signed device capability image as a UTF-8 encoded base 64 string.
        /// Serialized Name: SignedCapabilityImageResponse.image
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SignedCapabilityImageResponse(string image, Dictionary<string, BinaryData> rawData)
        {
            Image = image;
            _rawData = rawData;
        }

        /// <summary>
        /// The signed device capability image as a UTF-8 encoded base 64 string.
        /// Serialized Name: SignedCapabilityImageResponse.image
        /// </summary>
        public string Image { get; }
    }
}
