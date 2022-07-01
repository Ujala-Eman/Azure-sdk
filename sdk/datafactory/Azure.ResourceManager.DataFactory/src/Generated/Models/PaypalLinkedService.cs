// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Paypal Service linked service. </summary>
    public partial class PaypalLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of PaypalLinkedService. </summary>
        /// <param name="host"> The URL of the PayPal instance. (i.e. api.sandbox.paypal.com). </param>
        /// <param name="clientId"> The client ID associated with your PayPal application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> or <paramref name="clientId"/> is null. </exception>
        public PaypalLinkedService(BinaryData host, BinaryData clientId)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (clientId == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            Host = host;
            ClientId = clientId;
            LinkedServiceType = "Paypal";
        }

        /// <summary> Initializes a new instance of PaypalLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The URL of the PayPal instance. (i.e. api.sandbox.paypal.com). </param>
        /// <param name="clientId"> The client ID associated with your PayPal application. </param>
        /// <param name="clientSecret">
        /// The client secret associated with your PayPal application.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal PaypalLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData host, BinaryData clientId, SecretBase clientSecret, BinaryData useEncryptedEndpoints, BinaryData useHostVerification, BinaryData usePeerVerification, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Paypal";
        }

        /// <summary> The URL of the PayPal instance. (i.e. api.sandbox.paypal.com). </summary>
        public BinaryData Host { get; set; }
        /// <summary> The client ID associated with your PayPal application. </summary>
        public BinaryData ClientId { get; set; }
        /// <summary>
        /// The client secret associated with your PayPal application.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public BinaryData UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public BinaryData UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public BinaryData UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
