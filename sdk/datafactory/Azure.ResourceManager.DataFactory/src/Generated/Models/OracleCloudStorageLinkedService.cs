// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Oracle Cloud Storage. </summary>
    public partial class OracleCloudStorageLinkedService : FactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of OracleCloudStorageLinkedService. </summary>
        public OracleCloudStorageLinkedService()
        {
            LinkedServiceType = "OracleCloudStorage";
        }

        /// <summary> Initializes a new instance of OracleCloudStorageLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="accessKeyId"> The access key identifier of the Oracle Cloud Storage Identity and Access Management (IAM) user. Type: string (or Expression with resultType string). </param>
        /// <param name="secretAccessKey">
        /// The secret access key of the Oracle Cloud Storage Identity and Access Management (IAM) user.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="serviceUri"> This value specifies the endpoint to access with the Oracle Cloud Storage Connector. This is an optional property; change it only if you want to try a different service endpoint or want to switch between https and http. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal OracleCloudStorageLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData accessKeyId, FactorySecretBaseDefinition secretAccessKey, BinaryData serviceUri, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            AccessKeyId = accessKeyId;
            SecretAccessKey = secretAccessKey;
            ServiceUri = serviceUri;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "OracleCloudStorage";
        }

        /// <summary> The access key identifier of the Oracle Cloud Storage Identity and Access Management (IAM) user. Type: string (or Expression with resultType string). </summary>
        public BinaryData AccessKeyId { get; set; }
        /// <summary>
        /// The secret access key of the Oracle Cloud Storage Identity and Access Management (IAM) user.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition SecretAccessKey { get; set; }
        /// <summary> This value specifies the endpoint to access with the Oracle Cloud Storage Connector. This is an optional property; change it only if you want to try a different service endpoint or want to switch between https and http. Type: string (or Expression with resultType string). </summary>
        public BinaryData ServiceUri { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
