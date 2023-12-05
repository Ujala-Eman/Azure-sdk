// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetworkArmResourceId))
            {
                writer.WritePropertyName("virtualNetworkArmResourceId"u8);
                writer.WriteStringValue(VirtualNetworkArmResourceId);
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

        PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter IJsonModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> virtualNetworkArmResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualNetworkArmResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualNetworkArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter(virtualNetworkArmResourceId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
