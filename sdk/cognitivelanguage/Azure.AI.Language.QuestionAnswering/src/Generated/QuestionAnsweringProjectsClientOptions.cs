// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering.Projects
{
    /// <summary> Client options for QuestionAnsweringProjectsClient. </summary>
    public partial class QuestionAnsweringProjectsClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2021_10_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2021-10-01". </summary>
            V2021_10_01 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of QuestionAnsweringProjectsClientOptions. </summary>
        public QuestionAnsweringProjectsClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2021_10_01 => "2021-10-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
