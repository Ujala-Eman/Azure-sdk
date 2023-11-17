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

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class ResourcesHistoryRequestOptions : IUtf8JsonSerializable, IJsonModel<ResourcesHistoryRequestOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourcesHistoryRequestOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourcesHistoryRequestOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ResourcesHistoryRequestOptions>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ResourcesHistoryRequestOptions>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteObjectValue(Interval);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("$top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Optional.IsDefined(Skip))
            {
                writer.WritePropertyName("$skip"u8);
                writer.WriteNumberValue(Skip.Value);
            }
            if (Optional.IsDefined(SkipToken))
            {
                writer.WritePropertyName("$skipToken"u8);
                writer.WriteStringValue(SkipToken);
            }
            if (Optional.IsDefined(ResultFormat))
            {
                writer.WritePropertyName("resultFormat"u8);
                writer.WriteStringValue(ResultFormat.Value.ToSerialString());
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

        ResourcesHistoryRequestOptions IJsonModel<ResourcesHistoryRequestOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourcesHistoryRequestOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcesHistoryRequestOptions(document.RootElement, options);
        }

        internal static ResourcesHistoryRequestOptions DeserializeResourcesHistoryRequestOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeInterval> interval = default;
            Optional<int> top = default;
            Optional<int> skip = default;
            Optional<string> skipToken = default;
            Optional<ResultFormat> resultFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = DateTimeInterval.DeserializeDateTimeInterval(property.Value);
                    continue;
                }
                if (property.NameEquals("$top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("$skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("$skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultFormat = property.Value.GetString().ToResultFormat();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourcesHistoryRequestOptions(interval.Value, Optional.ToNullable(top), Optional.ToNullable(skip), skipToken.Value, Optional.ToNullable(resultFormat), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourcesHistoryRequestOptions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourcesHistoryRequestOptions)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ResourcesHistoryRequestOptions IPersistableModel<ResourcesHistoryRequestOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourcesHistoryRequestOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeResourcesHistoryRequestOptions(document.RootElement, options);
        }

        string IPersistableModel<ResourcesHistoryRequestOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
