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
    public partial class SynapseManagedVirtualNetworkSettings : IUtf8JsonSerializable, IJsonModel<SynapseManagedVirtualNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedVirtualNetworkSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SynapseManagedVirtualNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreventDataExfiltration))
            {
                writer.WritePropertyName("preventDataExfiltration"u8);
                writer.WriteBooleanValue(PreventDataExfiltration.Value);
            }
            if (Optional.IsDefined(EnableLinkedAccessCheckOnTargetResource))
            {
                writer.WritePropertyName("linkedAccessCheckOnTargetResource"u8);
                writer.WriteBooleanValue(EnableLinkedAccessCheckOnTargetResource.Value);
            }
            if (Optional.IsCollectionDefined(AllowedAadTenantIdsForLinking))
            {
                writer.WritePropertyName("allowedAadTenantIdsForLinking"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAadTenantIdsForLinking)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        SynapseManagedVirtualNetworkSettings IJsonModel<SynapseManagedVirtualNetworkSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedVirtualNetworkSettings(document.RootElement, options);
        }

        internal static SynapseManagedVirtualNetworkSettings DeserializeSynapseManagedVirtualNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> preventDataExfiltration = default;
            Optional<bool> linkedAccessCheckOnTargetResource = default;
            Optional<IList<string>> allowedAadTenantIdsForLinking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preventDataExfiltration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preventDataExfiltration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linkedAccessCheckOnTargetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedAccessCheckOnTargetResource = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedAadTenantIdsForLinking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedAadTenantIdsForLinking = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseManagedVirtualNetworkSettings(Optional.ToNullable(preventDataExfiltration), Optional.ToNullable(linkedAccessCheckOnTargetResource), Optional.ToList(allowedAadTenantIdsForLinking), serializedAdditionalRawData);
        }

        BinaryData IModel<SynapseManagedVirtualNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SynapseManagedVirtualNetworkSettings IModel<SynapseManagedVirtualNetworkSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseManagedVirtualNetworkSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSynapseManagedVirtualNetworkSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SynapseManagedVirtualNetworkSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
