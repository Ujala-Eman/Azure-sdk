// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class NetworkManagerDeploymentStatusListResult : IUtf8JsonSerializable, IJsonModel<NetworkManagerDeploymentStatusListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkManagerDeploymentStatusListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkManagerDeploymentStatusListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<NetworkManagerDeploymentStatus> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SkipToken != null)
            {
                writer.WritePropertyName("skipToken"u8);
                writer.WriteStringValue(SkipToken);
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

        NetworkManagerDeploymentStatusListResult IJsonModel<NetworkManagerDeploymentStatusListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkManagerDeploymentStatusListResult(document.RootElement, options);
        }

        internal static NetworkManagerDeploymentStatusListResult DeserializeNetworkManagerDeploymentStatusListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NetworkManagerDeploymentStatus> value = default;
            string skipToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkManagerDeploymentStatus> array = new List<NetworkManagerDeploymentStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkManagerDeploymentStatus.DeserializeNetworkManagerDeploymentStatus(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkManagerDeploymentStatusListResult(value ?? new ChangeTrackingList<NetworkManagerDeploymentStatus>(), skipToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkManagerDeploymentStatusListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusListResult)} does not support '{options.Format}' format.");
            }
        }

        NetworkManagerDeploymentStatusListResult IPersistableModel<NetworkManagerDeploymentStatusListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkManagerDeploymentStatusListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkManagerDeploymentStatusListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
