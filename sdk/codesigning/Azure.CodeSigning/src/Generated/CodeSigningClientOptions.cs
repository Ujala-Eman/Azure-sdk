// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.CodeSigning
{
    /// <summary> Client options for CodeSigningClient. </summary>
    public partial class CodeSigningClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_06_15_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2023-06-15-preview". </summary>
            V2023_06_15_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of CodeSigningClientOptions. </summary>
        public CodeSigningClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2023_06_15_Preview => "2023-06-15-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
