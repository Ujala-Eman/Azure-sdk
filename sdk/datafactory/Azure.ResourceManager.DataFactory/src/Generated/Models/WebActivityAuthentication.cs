// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Web activity authentication properties. </summary>
    public partial class WebActivityAuthentication
    {
        /// <summary> Initializes a new instance of WebActivityAuthentication. </summary>
        public WebActivityAuthentication()
        {
        }

        /// <summary> Initializes a new instance of WebActivityAuthentication. </summary>
        /// <param name="webActivityAuthenticationType"> Web activity authentication (Basic/ClientCertificate/MSI/ServicePrincipal). </param>
        /// <param name="pfx">
        /// Base64-encoded contents of a PFX file or Certificate when used for ServicePrincipal
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="username"> Web activity authentication user name for basic authentication or ClientID when used for ServicePrincipal. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for the PFX file or basic authentication / Secret when used for ServicePrincipal
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="resource"> Resource for which Azure Auth token will be requested when using MSI Authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="userTenant"> TenantId for which Azure Auth token will be requested when using ServicePrincipal Authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal WebActivityAuthentication(string webActivityAuthenticationType, FactorySecretBaseDefinition pfx, BinaryData username, FactorySecretBaseDefinition password, BinaryData resource, BinaryData userTenant, FactoryCredentialReference credential)
        {
            WebActivityAuthenticationType = webActivityAuthenticationType;
            Pfx = pfx;
            Username = username;
            Password = password;
            Resource = resource;
            UserTenant = userTenant;
            Credential = credential;
        }

        /// <summary> Web activity authentication (Basic/ClientCertificate/MSI/ServicePrincipal). </summary>
        public string WebActivityAuthenticationType { get; set; }
        /// <summary>
        /// Base64-encoded contents of a PFX file or Certificate when used for ServicePrincipal
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Pfx { get; set; }
        /// <summary>
        /// Web activity authentication user name for basic authentication or ClientID when used for ServicePrincipal. Type: string (or Expression with resultType string)..
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
        public BinaryData Username { get; set; }
        /// <summary>
        /// Password for the PFX file or basic authentication / Secret when used for ServicePrincipal
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Password { get; set; }
        /// <summary>
        /// Resource for which Azure Auth token will be requested when using MSI Authentication. Type: string (or Expression with resultType string)..
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
        public BinaryData Resource { get; set; }
        /// <summary>
        /// TenantId for which Azure Auth token will be requested when using ServicePrincipal Authentication. Type: string (or Expression with resultType string)..
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
        public BinaryData UserTenant { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public FactoryCredentialReference Credential { get; set; }
    }
}
