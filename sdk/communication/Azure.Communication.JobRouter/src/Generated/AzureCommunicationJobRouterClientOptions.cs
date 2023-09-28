// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Client options for Azure.Communication.JobRouter library clients. </summary>
    internal partial class AzureCommunicationJobRouterClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_11_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2023-11-01". </summary>
            V2023_11_01 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AzureCommunicationJobRouterClientOptions. </summary>
        public AzureCommunicationJobRouterClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2023_11_01 => "2023-11-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
