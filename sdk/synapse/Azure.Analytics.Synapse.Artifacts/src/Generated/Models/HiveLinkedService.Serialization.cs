// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class HiveLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("host");
            writer.WriteObjectValue(Host);
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteObjectValue(Port);
            }
            if (Optional.IsDefined(ServerType))
            {
                writer.WritePropertyName("serverType");
                writer.WriteStringValue(ServerType.Value.ToString());
            }
            if (Optional.IsDefined(ThriftTransportProtocol))
            {
                writer.WritePropertyName("thriftTransportProtocol");
                writer.WriteStringValue(ThriftTransportProtocol.Value.ToString());
            }
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            if (Optional.IsDefined(ServiceDiscoveryMode))
            {
                writer.WritePropertyName("serviceDiscoveryMode");
                writer.WriteObjectValue(ServiceDiscoveryMode);
            }
            if (Optional.IsDefined(ZooKeeperNameSpace))
            {
                writer.WritePropertyName("zooKeeperNameSpace");
                writer.WriteObjectValue(ZooKeeperNameSpace);
            }
            if (Optional.IsDefined(UseNativeQuery))
            {
                writer.WritePropertyName("useNativeQuery");
                writer.WriteObjectValue(UseNativeQuery);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteObjectValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(HttpPath))
            {
                writer.WritePropertyName("httpPath");
                writer.WriteObjectValue(HttpPath);
            }
            if (Optional.IsDefined(EnableSsl))
            {
                writer.WritePropertyName("enableSsl");
                writer.WriteObjectValue(EnableSsl);
            }
            if (Optional.IsDefined(TrustedCertPath))
            {
                writer.WritePropertyName("trustedCertPath");
                writer.WriteObjectValue(TrustedCertPath);
            }
            if (Optional.IsDefined(UseSystemTrustStore))
            {
                writer.WritePropertyName("useSystemTrustStore");
                writer.WriteObjectValue(UseSystemTrustStore);
            }
            if (Optional.IsDefined(AllowHostNameCNMismatch))
            {
                writer.WritePropertyName("allowHostNameCNMismatch");
                writer.WriteObjectValue(AllowHostNameCNMismatch);
            }
            if (Optional.IsDefined(AllowSelfSignedServerCert))
            {
                writer.WritePropertyName("allowSelfSignedServerCert");
                writer.WriteObjectValue(AllowSelfSignedServerCert);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HiveLinkedService DeserializeHiveLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object host = default;
            Optional<object> port = default;
            Optional<HiveServerType> serverType = default;
            Optional<HiveThriftTransportProtocol> thriftTransportProtocol = default;
            HiveAuthenticationType authenticationType = default;
            Optional<object> serviceDiscoveryMode = default;
            Optional<object> zooKeeperNameSpace = default;
            Optional<object> useNativeQuery = default;
            Optional<object> username = default;
            Optional<SecretBase> password = default;
            Optional<object> httpPath = default;
            Optional<object> enableSsl = default;
            Optional<object> trustedCertPath = default;
            Optional<object> useSystemTrustStore = default;
            Optional<object> allowHostNameCNMismatch = default;
            Optional<object> allowSelfSignedServerCert = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("host"))
                        {
                            host = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            port = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("serverType"))
                        {
                            serverType = new HiveServerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thriftTransportProtocol"))
                        {
                            thriftTransportProtocol = new HiveThriftTransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"))
                        {
                            authenticationType = new HiveAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceDiscoveryMode"))
                        {
                            serviceDiscoveryMode = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("zooKeeperNameSpace"))
                        {
                            zooKeeperNameSpace = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useNativeQuery"))
                        {
                            useNativeQuery = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("username"))
                        {
                            username = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpPath"))
                        {
                            httpPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableSsl"))
                        {
                            enableSsl = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("trustedCertPath"))
                        {
                            trustedCertPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("useSystemTrustStore"))
                        {
                            useSystemTrustStore = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowHostNameCNMismatch"))
                        {
                            allowHostNameCNMismatch = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("allowSelfSignedServerCert"))
                        {
                            allowSelfSignedServerCert = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HiveLinkedService(type, connectVia.HasValue ? connectVia.Value : null, description.HasValue ? description.Value : null, new ChangeTrackingDictionary<string, ParameterSpecification>(parameters), new ChangeTrackingList<object>(annotations), additionalProperties, host, port.HasValue ? port.Value : null, serverType.HasValue ? serverType.Value : (HiveServerType?)null, thriftTransportProtocol.HasValue ? thriftTransportProtocol.Value : (HiveThriftTransportProtocol?)null, authenticationType, serviceDiscoveryMode.HasValue ? serviceDiscoveryMode.Value : null, zooKeeperNameSpace.HasValue ? zooKeeperNameSpace.Value : null, useNativeQuery.HasValue ? useNativeQuery.Value : null, username.HasValue ? username.Value : null, password.HasValue ? password.Value : null, httpPath.HasValue ? httpPath.Value : null, enableSsl.HasValue ? enableSsl.Value : null, trustedCertPath.HasValue ? trustedCertPath.Value : null, useSystemTrustStore.HasValue ? useSystemTrustStore.Value : null, allowHostNameCNMismatch.HasValue ? allowHostNameCNMismatch.Value : null, allowSelfSignedServerCert.HasValue ? allowSelfSignedServerCert.Value : null, encryptedCredential.HasValue ? encryptedCredential.Value : null);
        }
    }
}
