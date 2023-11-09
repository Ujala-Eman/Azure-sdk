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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataLakeStorageAccountDetails : IUtf8JsonSerializable, IJsonModel<SynapseDataLakeStorageAccountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseDataLakeStorageAccountDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SynapseDataLakeStorageAccountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountUri))
            {
                writer.WritePropertyName("accountUrl"u8);
                writer.WriteStringValue(AccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Filesystem))
            {
                writer.WritePropertyName("filesystem"u8);
                writer.WriteStringValue(Filesystem);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(CreateManagedPrivateEndpoint))
            {
                writer.WritePropertyName("createManagedPrivateEndpoint"u8);
                writer.WriteBooleanValue(CreateManagedPrivateEndpoint.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SynapseDataLakeStorageAccountDetails IJsonModel<SynapseDataLakeStorageAccountDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseDataLakeStorageAccountDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseDataLakeStorageAccountDetails(document.RootElement, options);
        }

        internal static SynapseDataLakeStorageAccountDetails DeserializeSynapseDataLakeStorageAccountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> accountUrl = default;
            Optional<string> filesystem = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<bool> createManagedPrivateEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filesystem"u8))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createManagedPrivateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createManagedPrivateEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseDataLakeStorageAccountDetails(accountUrl.Value, filesystem.Value, resourceId.Value, Optional.ToNullable(createManagedPrivateEndpoint), serializedAdditionalRawData);
        }

        BinaryData IModel<SynapseDataLakeStorageAccountDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseDataLakeStorageAccountDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SynapseDataLakeStorageAccountDetails IModel<SynapseDataLakeStorageAccountDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseDataLakeStorageAccountDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSynapseDataLakeStorageAccountDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SynapseDataLakeStorageAccountDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
