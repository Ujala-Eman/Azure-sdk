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
    public partial class ApplicationInsightsComponentWebTestLocation : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentWebTestLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentWebTestLocation>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApplicationInsightsComponentWebTestLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApplicationInsightsComponentWebTestLocation>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApplicationInsightsComponentWebTestLocation>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DisplayName))
                {
                    writer.WritePropertyName("DisplayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Tag))
                {
                    writer.WritePropertyName("Tag"u8);
                    writer.WriteStringValue(Tag);
                }
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

        ApplicationInsightsComponentWebTestLocation IJsonModel<ApplicationInsightsComponentWebTestLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentWebTestLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentWebTestLocation(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentWebTestLocation DeserializeApplicationInsightsComponentWebTestLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> tag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("DisplayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentWebTestLocation(displayName.Value, tag.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentWebTestLocation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentWebTestLocation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplicationInsightsComponentWebTestLocation IPersistableModel<ApplicationInsightsComponentWebTestLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentWebTestLocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsComponentWebTestLocation(document.RootElement, options);
        }

        string IPersistableModel<ApplicationInsightsComponentWebTestLocation>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
