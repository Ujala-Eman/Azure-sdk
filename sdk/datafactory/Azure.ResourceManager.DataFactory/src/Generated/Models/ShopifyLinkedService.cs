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
    /// <summary> Shopify Service linked service. </summary>
    public partial class ShopifyLinkedService : DataFactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of ShopifyLinkedService. </summary>
        /// <param name="host"> The endpoint of the Shopify server. (i.e. mystore.myshopify.com). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public ShopifyLinkedService(DataFactoryElement<string> host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            LinkedServiceType = "Shopify";
        }

        /// <summary> Initializes a new instance of ShopifyLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The endpoint of the Shopify server. (i.e. mystore.myshopify.com). </param>
        /// <param name="accessToken"> The API access token that can be used to access Shopify’s data. The token won't expire if it is offline mode. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ShopifyLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactorySecretBaseDefinition accessToken, DataFactoryElement<bool> useEncryptedEndpoints, DataFactoryElement<bool> useHostVerification, DataFactoryElement<bool> usePeerVerification, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            AccessToken = accessToken;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Shopify";
        }

        /// <summary> The endpoint of the Shopify server. (i.e. mystore.myshopify.com). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The API access token that can be used to access Shopify’s data. The token won't expire if it is offline mode. </summary>
        public DataFactorySecretBaseDefinition AccessToken { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UsePeerVerification { get; set; }
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
