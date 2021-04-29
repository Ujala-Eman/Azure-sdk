// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Base definition of WebLinkedServiceTypeProperties, this typeProperties is polymorphic based on authenticationType, so not flattened in SDK models. </summary>
    public partial class WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of WebLinkedServiceTypeProperties. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public WebLinkedServiceTypeProperties(object url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Url = url;
        }

        /// <summary> Initializes a new instance of WebLinkedServiceTypeProperties. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        internal WebLinkedServiceTypeProperties(object url, WebAuthenticationType authenticationType)
        {
            Url = url;
            AuthenticationType = authenticationType;
        }

        /// <summary> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </summary>
        public object Url { get; set; }
        /// <summary> Type of authentication used to connect to the web table source. </summary>
        internal WebAuthenticationType AuthenticationType { get; set; }
    }
}
