// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Asana. </summary>
    public partial class AsanaLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AsanaLinkedService. </summary>
        /// <param name="apiToken"> The api token for the Asana source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiToken"/> is null. </exception>
        public AsanaLinkedService(SecretBase apiToken)
        {
            if (apiToken == null)
            {
                throw new ArgumentNullException(nameof(apiToken));
            }

            ApiToken = apiToken;
            Type = "Asana";
        }

        /// <summary> Initializes a new instance of AsanaLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="apiToken"> The api token for the Asana source. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AsanaLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, SecretBase apiToken, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ApiToken = apiToken;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Asana";
        }

        /// <summary> The api token for the Asana source. </summary>
        public SecretBase ApiToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
