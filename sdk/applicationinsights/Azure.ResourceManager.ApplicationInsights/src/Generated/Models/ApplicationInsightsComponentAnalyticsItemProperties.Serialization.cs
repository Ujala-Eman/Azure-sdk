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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    internal partial class ApplicationInsightsComponentAnalyticsItemProperties : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentAnalyticsItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentAnalyticsItemProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApplicationInsightsComponentAnalyticsItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApplicationInsightsComponentAnalyticsItemProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApplicationInsightsComponentAnalyticsItemProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FunctionAlias))
            {
                writer.WritePropertyName("functionAlias"u8);
                writer.WriteStringValue(FunctionAlias);
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

        ApplicationInsightsComponentAnalyticsItemProperties IJsonModel<ApplicationInsightsComponentAnalyticsItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentAnalyticsItemProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentAnalyticsItemProperties(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentAnalyticsItemProperties DeserializeApplicationInsightsComponentAnalyticsItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> functionAlias = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("functionAlias"u8))
                {
                    functionAlias = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentAnalyticsItemProperties(functionAlias.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentAnalyticsItemProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentAnalyticsItemProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplicationInsightsComponentAnalyticsItemProperties IPersistableModel<ApplicationInsightsComponentAnalyticsItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentAnalyticsItemProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsComponentAnalyticsItemProperties(document.RootElement, options);
        }

        string IPersistableModel<ApplicationInsightsComponentAnalyticsItemProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
