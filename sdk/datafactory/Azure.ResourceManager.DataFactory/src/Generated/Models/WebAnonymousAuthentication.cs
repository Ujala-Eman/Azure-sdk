// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A WebLinkedService that uses anonymous authentication to communicate with an HTTP endpoint. </summary>
    public partial class WebAnonymousAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="WebAnonymousAuthentication"/>. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public WebAnonymousAuthentication(DataFactoryElement<string> uri) : base(uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            AuthenticationType = WebAuthenticationType.Anonymous;
        }

        /// <summary> Initializes a new instance of <see cref="WebAnonymousAuthentication"/>. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebAnonymousAuthentication(DataFactoryElement<string> uri, WebAuthenticationType authenticationType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(uri, authenticationType, serializedAdditionalRawData)
        {
            AuthenticationType = authenticationType;
        }

        /// <summary> Initializes a new instance of <see cref="WebAnonymousAuthentication"/> for deserialization. </summary>
        internal WebAnonymousAuthentication()
        {
        }
    }
}
