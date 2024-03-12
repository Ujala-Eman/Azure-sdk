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
    /// <summary> Linked service for TeamDesk. </summary>
    public partial class TeamDeskLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="TeamDeskLinkedService"/>. </summary>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="uri"> The url to connect TeamDesk source. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public TeamDeskLinkedService(TeamDeskAuthenticationType authenticationType, DataFactoryElement<string> uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            AuthenticationType = authenticationType;
            Uri = uri;
            LinkedServiceType = "TeamDesk";
        }

        /// <summary> Initializes a new instance of <see cref="TeamDeskLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="uri"> The url to connect TeamDesk source. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> The username of the TeamDesk source. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password of the TeamDesk source. </param>
        /// <param name="apiToken"> The api token for the TeamDesk source. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal TeamDeskLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, TeamDeskAuthenticationType authenticationType, DataFactoryElement<string> uri, DataFactoryElement<string> userName, DataFactorySecret password, DataFactorySecret apiToken, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            AuthenticationType = authenticationType;
            Uri = uri;
            UserName = userName;
            Password = password;
            ApiToken = apiToken;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "TeamDesk";
        }

        /// <summary> Initializes a new instance of <see cref="TeamDeskLinkedService"/> for deserialization. </summary>
        internal TeamDeskLinkedService()
        {
        }

        /// <summary> The authentication type to use. </summary>
        public TeamDeskAuthenticationType AuthenticationType { get; set; }
        /// <summary> The url to connect TeamDesk source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> The username of the TeamDesk source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The password of the TeamDesk source. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The api token for the TeamDesk source. </summary>
        public DataFactorySecret ApiToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
