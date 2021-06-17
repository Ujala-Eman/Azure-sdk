// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Shopify Service linked service. </summary>
    public partial class ShopifyLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of ShopifyLinkedService. </summary>
        /// <param name="host"> The endpoint of the Shopify server. (i.e. mystore.myshopify.com). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public ShopifyLinkedService(object host)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            Host = host;
            Type = "Shopify";
        }

        /// <summary> Initializes a new instance of ShopifyLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The endpoint of the Shopify server. (i.e. mystore.myshopify.com). </param>
        /// <param name="accessToken"> The API access token that can be used to access Shopify’s data. The token won&apos;t expire if it is offline mode. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal ShopifyLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, SecretBase accessToken, object useEncryptedEndpoints, object useHostVerification, object usePeerVerification, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            AccessToken = accessToken;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Shopify";
        }

        /// <summary> The endpoint of the Shopify server. (i.e. mystore.myshopify.com). </summary>
        public object Host { get; set; }
        /// <summary> The API access token that can be used to access Shopify’s data. The token won&apos;t expire if it is offline mode. </summary>
        public SecretBase AccessToken { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public object UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public object UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public object UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
