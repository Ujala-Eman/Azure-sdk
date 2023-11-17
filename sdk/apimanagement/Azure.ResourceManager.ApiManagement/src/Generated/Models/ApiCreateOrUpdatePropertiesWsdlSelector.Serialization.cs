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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector : IUtf8JsonSerializable, IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WsdlServiceName))
            {
                writer.WritePropertyName("wsdlServiceName"u8);
                writer.WriteStringValue(WsdlServiceName);
            }
            if (Optional.IsDefined(WsdlEndpointName))
            {
                writer.WritePropertyName("wsdlEndpointName"u8);
                writer.WriteStringValue(WsdlEndpointName);
            }
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

        ApiCreateOrUpdatePropertiesWsdlSelector IJsonModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiCreateOrUpdatePropertiesWsdlSelector(document.RootElement, options);
        }

        internal static ApiCreateOrUpdatePropertiesWsdlSelector DeserializeApiCreateOrUpdatePropertiesWsdlSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> wsdlServiceName = default;
            Optional<string> wsdlEndpointName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wsdlServiceName"u8))
                {
                    wsdlServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wsdlEndpointName"u8))
                {
                    wsdlEndpointName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiCreateOrUpdatePropertiesWsdlSelector(wsdlServiceName.Value, wsdlEndpointName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApiCreateOrUpdatePropertiesWsdlSelector IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiCreateOrUpdatePropertiesWsdlSelector)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApiCreateOrUpdatePropertiesWsdlSelector(document.RootElement, options);
        }

        string IPersistableModel<ApiCreateOrUpdatePropertiesWsdlSelector>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
