// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureBatchLinkedServiceConverter))]
    public partial class AzureBatchLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
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
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("accountName"u8);
            writer.WriteObjectValue(AccountName);
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey"u8);
                writer.WriteObjectValue(AccessKey);
            }
            writer.WritePropertyName("batchUri"u8);
            writer.WriteObjectValue(BatchUri);
            writer.WritePropertyName("poolName"u8);
            writer.WriteObjectValue(PoolName);
            writer.WritePropertyName("linkedServiceName"u8);
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
            }
            writer.WriteEndObject();
        }

        internal static AzureBatchLinkedService DeserializeAzureBatchLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
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
            Optional<CredentialReference> credential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("accessKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("batchUri"u8))
                        {
                            batchUri = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("poolName"u8))
                        {
                            poolName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"u8))
                        {
                            linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = CredentialReference.DeserializeCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBatchLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, accountName, accessKey.Value, batchUri, poolName, linkedServiceName, encryptedCredential.Value, credential.Value);
        }

        internal partial class AzureBatchLinkedServiceConverter : JsonConverter<AzureBatchLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, AzureBatchLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureBatchLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureBatchLinkedService(document.RootElement);
            }
        }
    }
}
