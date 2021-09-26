// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Purview.Administrator
{
    /// <summary> Client options for PurviewAdministratorClient. </summary>
    public partial class PurviewAdministratorClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2021_07_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2019-11-01-preview". </summary>
            V2019_11_01_preview = 1,
            /// <summary> Service version "2021-07-01". </summary>
            V2021_07_01 = 2,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of PurviewAdministratorClientOptions. </summary>
        public PurviewAdministratorClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2019_11_01_preview => "2019-11-01-preview",
                ServiceVersion.V2021_07_01 => "2021-07-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
