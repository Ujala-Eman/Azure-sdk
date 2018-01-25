// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A FTP server Linked Service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FtpServer")]
    [Rest.Serialization.JsonTransformation]
    public partial class FtpServerLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the FtpServerLinkedService class.
        /// </summary>
        public FtpServerLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FtpServerLinkedService class.
        /// </summary>
        /// <param name="host">Host name of the FTP server. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="port">The TCP port number that the FTP server uses to
        /// listen for client connections. Default value is 21. Type: integer
        /// (or Expression with resultType integer), minimum: 0.</param>
        /// <param name="authenticationType">The authentication type to be used
        /// to connect to the FTP server. Possible values include: 'Basic',
        /// 'Anonymous'</param>
        /// <param name="userName">Username to logon the FTP server. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="password">Password to logon the FTP server.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="enableSsl">If true, connect to the FTP server over
        /// SSL/TLS channel. Default value is true. Type: boolean (or
        /// Expression with resultType boolean).</param>
        /// <param name="enableServerCertificateValidation">If true, validate
        /// the FTP server SSL certificate when connect over SSL/TLS channel.
        /// Default value is true. Type: boolean (or Expression with resultType
        /// boolean).</param>
        public FtpServerLinkedService(object host, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object port = default(object), string authenticationType = default(string), object userName = default(object), SecretBase password = default(SecretBase), object encryptedCredential = default(object), object enableSsl = default(object), object enableServerCertificateValidation = default(object))
            : base(additionalProperties, connectVia, description)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            EnableSsl = enableSsl;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets host name of the FTP server. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the TCP port number that the FTP server uses to listen
        /// for client connections. Default value is 21. Type: integer (or
        /// Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to be used to connect to the
        /// FTP server. Possible values include: 'Basic', 'Anonymous'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets username to logon the FTP server. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password to logon the FTP server.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets if true, connect to the FTP server over SSL/TLS
        /// channel. Default value is true. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableSsl")]
        public object EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets if true, validate the FTP server SSL certificate when
        /// connect over SSL/TLS channel. Default value is true. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableServerCertificateValidation")]
        public object EnableServerCertificateValidation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
        }
    }
}
