// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AzureBatchLinkedService : IUtf8JsonSerializable
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
            if (Optional.IsCollectionDefined(Parameters))
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
            if (Optional.IsCollectionDefined(Annotations))
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
            writer.WritePropertyName("accountName");
            writer.WriteObjectValue(AccountName);
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey");
                writer.WriteObjectValue(AccessKey);
            }
            writer.WritePropertyName("batchUri");
            writer.WriteObjectValue(BatchUri);
            writer.WritePropertyName("poolName");
            writer.WriteObjectValue(PoolName);
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
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

        internal static AzureBatchLinkedService DeserializeAzureBatchLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object accountName = default;
            Optional<SecretBase> accessKey = default;
            object batchUri = default;
            object poolName = default;
            LinkedServiceReference linkedServiceName = default;
            Optional<object> encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
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
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accountName"))
                        {
                            accountName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("accessKey"))
                        {
                            accessKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("batchUri"))
                        {
                            batchUri = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("poolName"))
                        {
                            poolName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"))
                        {
                            linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
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
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBatchLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, accountName, accessKey.Value, batchUri, poolName, linkedServiceName, encryptedCredential.Value);
        }
    }
}
