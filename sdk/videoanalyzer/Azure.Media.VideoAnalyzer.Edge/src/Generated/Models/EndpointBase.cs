// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary>
    /// Base class for endpoints.
    /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
    /// </summary>
    public abstract partial class EndpointBase
    {
        /// <summary> Initializes a new instance of <see cref="EndpointBase"/>. </summary>
        /// <param name="url"> The endpoint URL for Video Analyzer to connect to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        protected EndpointBase(string url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
        }

        /// <summary> Initializes a new instance of <see cref="EndpointBase"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="credentials">
        /// Credentials to be presented to the endpoint.
        /// Please note <see cref="CredentialsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HttpHeaderCredentials"/>, <see cref="SymmetricKeyCredentials"/> and <see cref="UsernamePasswordCredentials"/>.
        /// </param>
        /// <param name="url"> The endpoint URL for Video Analyzer to connect to. </param>
        internal EndpointBase(string type, CredentialsBase credentials, string url)
        {
            Type = type;
            Credentials = credentials;
            Url = url;
        }

        /// <summary> Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary>
        /// Credentials to be presented to the endpoint.
        /// Please note <see cref="CredentialsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HttpHeaderCredentials"/>, <see cref="SymmetricKeyCredentials"/> and <see cref="UsernamePasswordCredentials"/>.
        /// </summary>
        public CredentialsBase Credentials { get; set; }
        /// <summary> The endpoint URL for Video Analyzer to connect to. </summary>
        public string Url { get; set; }
    }
}
