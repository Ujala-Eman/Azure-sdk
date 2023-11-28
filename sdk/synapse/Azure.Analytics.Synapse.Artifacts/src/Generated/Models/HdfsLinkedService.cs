// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Hadoop Distributed File System (HDFS) linked service. </summary>
    public partial class HdfsLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="HdfsLinkedService"/>. </summary>
        /// <param name="url"> The URL of the HDFS service endpoint, e.g. http://myhostname:50070/webhdfs/v1 . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public HdfsLinkedService(object url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
            Type = "Hdfs";
        }

        /// <summary> Initializes a new instance of <see cref="HdfsLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="url"> The URL of the HDFS service endpoint, e.g. http://myhostname:50070/webhdfs/v1 . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the HDFS. Possible values are: Anonymous and Windows. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> User name for Windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for Windows authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        internal HdfsLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object url, object authenticationType, object encryptedCredential, object userName, SecretBase password) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Url = url;
            AuthenticationType = authenticationType;
            EncryptedCredential = encryptedCredential;
            UserName = userName;
            Password = password;
            Type = type ?? "Hdfs";
        }

        /// <summary> The URL of the HDFS service endpoint, e.g. http://myhostname:50070/webhdfs/v1 . Type: string (or Expression with resultType string). </summary>
        public object Url { get; set; }
        /// <summary> Type of authentication used to connect to the HDFS. Possible values are: Anonymous and Windows. Type: string (or Expression with resultType string). </summary>
        public object AuthenticationType { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> User name for Windows authentication. Type: string (or Expression with resultType string). </summary>
        public object UserName { get; set; }
        /// <summary>
        /// Password for Windows authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
    }
}
