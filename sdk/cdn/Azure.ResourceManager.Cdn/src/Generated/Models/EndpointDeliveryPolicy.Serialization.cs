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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class EndpointDeliveryPolicy : IUtf8JsonSerializable, IJsonModel<EndpointDeliveryPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointDeliveryPolicy>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<EndpointDeliveryPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EndpointDeliveryPolicy>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EndpointDeliveryPolicy>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("rules"u8);
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        EndpointDeliveryPolicy IJsonModel<EndpointDeliveryPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EndpointDeliveryPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointDeliveryPolicy(document.RootElement, options);
        }

        internal static EndpointDeliveryPolicy DeserializeEndpointDeliveryPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            IList<DeliveryRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    List<DeliveryRule> array = new List<DeliveryRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeliveryRule.DeserializeDeliveryRule(item));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EndpointDeliveryPolicy(description.Value, rules, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EndpointDeliveryPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EndpointDeliveryPolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EndpointDeliveryPolicy IPersistableModel<EndpointDeliveryPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EndpointDeliveryPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEndpointDeliveryPolicy(document.RootElement, options);
        }

        string IPersistableModel<EndpointDeliveryPolicy>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
