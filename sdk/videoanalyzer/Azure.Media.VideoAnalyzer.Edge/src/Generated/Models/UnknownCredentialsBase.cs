// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownCredentialsBase. </summary>
    internal partial class UnknownCredentialsBase : CredentialsBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCredentialsBase"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        internal UnknownCredentialsBase(string type) : base(type)
        {
            Type = type ?? "Unknown";
        }
    }
}
