// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Zendesk. </summary>
    public partial class ZendeskLinkedService : DataFactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of ZendeskLinkedService. </summary>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="uri"> The url to connect Zendesk source. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ZendeskLinkedService(ZendeskAuthenticationType authenticationType, DataFactoryElement<string> uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            AuthenticationType = authenticationType;
            Uri = uri;
            LinkedServiceType = "Zendesk";
        }

        /// <summary> Initializes a new instance of ZendeskLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="uri"> The url to connect Zendesk source. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> The username of the Zendesk source. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password of the Zendesk source. </param>
        /// <param name="apiToken"> The api token for the Zendesk source. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ZendeskLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, ZendeskAuthenticationType authenticationType, DataFactoryElement<string> uri, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, DataFactorySecretBaseDefinition apiToken, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            AuthenticationType = authenticationType;
            Uri = uri;
            UserName = userName;
            Password = password;
            ApiToken = apiToken;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Zendesk";
        }

        /// <summary> The authentication type to use. </summary>
        public ZendeskAuthenticationType AuthenticationType { get; set; }
        /// <summary> The url to connect Zendesk source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> The username of the Zendesk source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The password of the Zendesk source. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The api token for the Zendesk source. </summary>
        public DataFactorySecretBaseDefinition ApiToken { get; set; }
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
