// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthDataAIServices.Models
{
    public partial class DeidServiceProperties : IUtf8JsonSerializable, IJsonModel<DeidServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeidServiceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeidServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeidServiceProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUrl"u8);
                writer.WriteStringValue(ServiceUri);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DeidServiceProperties IJsonModel<DeidServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeidServiceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeidServiceProperties(document.RootElement, options);
        }

        internal static DeidServiceProperties DeserializeDeidServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthDataAIServicesProvisioningState? provisioningState = default;
            string serviceUrl = default;
            IReadOnlyList<HealthDataAIServicesPrivateEndpointConnection> privateEndpointConnections = default;
            HealthDataAIServicesPublicNetworkAccess? publicNetworkAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HealthDataAIServicesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceUrl"u8))
                {
                    serviceUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthDataAIServicesPrivateEndpointConnection> array = new List<HealthDataAIServicesPrivateEndpointConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthDataAIServicesPrivateEndpointConnection.DeserializeHealthDataAIServicesPrivateEndpointConnection(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = property.Value.GetString().ToHealthDataAIServicesPublicNetworkAccess();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeidServiceProperties(provisioningState, serviceUrl, privateEndpointConnections ?? new ChangeTrackingList<HealthDataAIServicesPrivateEndpointConnection>(), publicNetworkAccess, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeidServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeidServiceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DeidServiceProperties IPersistableModel<DeidServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeidServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeidServiceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeidServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
