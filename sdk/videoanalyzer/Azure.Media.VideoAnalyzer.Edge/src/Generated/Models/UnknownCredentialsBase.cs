// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownCredentialsBase. </summary>
    internal partial class UnknownCredentialsBase : CredentialsBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCredentialsBase"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCredentialsBase(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
            Type = type ?? "Unknown";
        }
    }
}
