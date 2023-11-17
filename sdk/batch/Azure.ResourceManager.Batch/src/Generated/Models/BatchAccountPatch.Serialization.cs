// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountPatch : IUtf8JsonSerializable, IJsonModel<BatchAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPatch>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BatchAccountPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BatchAccountPatch>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BatchAccountPatch>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoStorage))
            {
                writer.WritePropertyName("autoStorage"u8);
                writer.WriteObjectValue(AutoStorage);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsCollectionDefined(AllowedAuthenticationModes))
            {
                if (AllowedAuthenticationModes != null)
                {
                    writer.WritePropertyName("allowedAuthenticationModes"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedAuthenticationModes)
                    {
                        writer.WriteStringValue(item.ToSerialString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedAuthenticationModes");
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BatchAccountPatch IJsonModel<BatchAccountPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPatch(document.RootElement, options);
        }

        internal static BatchAccountPatch DeserializeBatchAccountPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<BatchAccountAutoStorageBaseConfiguration> autoStorage = default;
            Optional<BatchAccountEncryptionConfiguration> encryption = default;
            Optional<IList<BatchAuthenticationMode>> allowedAuthenticationModes = default;
            Optional<BatchPublicNetworkAccess> publicNetworkAccess = default;
            Optional<BatchNetworkProfile> networkProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("autoStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoStorage = BatchAccountAutoStorageBaseConfiguration.DeserializeBatchAccountAutoStorageBaseConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = BatchAccountEncryptionConfiguration.DeserializeBatchAccountEncryptionConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("allowedAuthenticationModes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                allowedAuthenticationModes = null;
                                continue;
                            }
                            List<BatchAuthenticationMode> array = new List<BatchAuthenticationMode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToBatchAuthenticationMode());
                            }
                            allowedAuthenticationModes = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = property0.Value.GetString().ToBatchPublicNetworkAccess();
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = BatchNetworkProfile.DeserializeBatchNetworkProfile(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountPatch(Optional.ToDictionary(tags), identity, autoStorage.Value, encryption.Value, Optional.ToList(allowedAuthenticationModes), Optional.ToNullable(publicNetworkAccess), networkProfile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountPatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BatchAccountPatch IPersistableModel<BatchAccountPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchAccountPatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBatchAccountPatch(document.RootElement, options);
        }

        string IPersistableModel<BatchAccountPatch>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
