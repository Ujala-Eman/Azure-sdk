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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayUrlConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayUrlConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayUrlConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayUrlConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayUrlConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationGatewayUrlConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ModifiedPath))
            {
                writer.WritePropertyName("modifiedPath"u8);
                writer.WriteStringValue(ModifiedPath);
            }
            if (Optional.IsDefined(ModifiedQueryString))
            {
                writer.WritePropertyName("modifiedQueryString"u8);
                writer.WriteStringValue(ModifiedQueryString);
            }
            if (Optional.IsDefined(Reroute))
            {
                writer.WritePropertyName("reroute"u8);
                writer.WriteBooleanValue(Reroute.Value);
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

        ApplicationGatewayUrlConfiguration IJsonModel<ApplicationGatewayUrlConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayUrlConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationGatewayUrlConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayUrlConfiguration(document.RootElement, options);
        }

        internal static ApplicationGatewayUrlConfiguration DeserializeApplicationGatewayUrlConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> modifiedPath = default;
            Optional<string> modifiedQueryString = default;
            Optional<bool> reroute = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modifiedPath"u8))
                {
                    modifiedPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedQueryString"u8))
                {
                    modifiedQueryString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reroute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reroute = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayUrlConfiguration(modifiedPath.Value, modifiedQueryString.Value, Optional.ToNullable(reroute), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayUrlConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayUrlConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationGatewayUrlConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayUrlConfiguration IPersistableModel<ApplicationGatewayUrlConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayUrlConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayUrlConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationGatewayUrlConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayUrlConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
