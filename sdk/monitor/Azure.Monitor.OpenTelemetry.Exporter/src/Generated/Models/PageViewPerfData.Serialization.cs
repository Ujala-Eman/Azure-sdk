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

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class PageViewPerfData : IUtf8JsonSerializable, IJsonModel<PageViewPerfData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PageViewPerfData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PageViewPerfData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageViewPerfData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PageViewPerfData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(PerfTotal))
            {
                writer.WritePropertyName("perfTotal"u8);
                writer.WriteStringValue(PerfTotal);
            }
            if (Optional.IsDefined(NetworkConnect))
            {
                writer.WritePropertyName("networkConnect"u8);
                writer.WriteStringValue(NetworkConnect);
            }
            if (Optional.IsDefined(SentRequest))
            {
                writer.WritePropertyName("sentRequest"u8);
                writer.WriteStringValue(SentRequest);
            }
            if (Optional.IsDefined(ReceivedResponse))
            {
                writer.WritePropertyName("receivedResponse"u8);
                writer.WriteStringValue(ReceivedResponse);
            }
            if (Optional.IsDefined(DomProcessing))
            {
                writer.WritePropertyName("domProcessing"u8);
                writer.WriteStringValue(DomProcessing);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Measurements))
            {
                writer.WritePropertyName("measurements"u8);
                writer.WriteStartObject();
                foreach (var item in Measurements)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("ver"u8);
            writer.WriteNumberValue(Version);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        PageViewPerfData IJsonModel<PageViewPerfData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageViewPerfData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PageViewPerfData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePageViewPerfData(document.RootElement, options);
        }

        internal static PageViewPerfData DeserializePageViewPerfData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            Optional<string> url = default;
            Optional<string> duration = default;
            Optional<string> perfTotal = default;
            Optional<string> networkConnect = default;
            Optional<string> sentRequest = default;
            Optional<string> receivedResponse = default;
            Optional<string> domProcessing = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, double>> measurements = default;
            int ver = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("perfTotal"u8))
                {
                    perfTotal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConnect"u8))
                {
                    networkConnect = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentRequest"u8))
                {
                    sentRequest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receivedResponse"u8))
                {
                    receivedResponse = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domProcessing"u8))
                {
                    domProcessing = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("measurements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, double> dictionary = new Dictionary<string, double>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetDouble());
                    }
                    measurements = dictionary;
                    continue;
                }
                if (property.NameEquals("ver"u8))
                {
                    ver = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PageViewPerfData(ver, additionalProperties, id, name, url.Value, duration.Value, perfTotal.Value, networkConnect.Value, sentRequest.Value, receivedResponse.Value, domProcessing.Value, Optional.ToDictionary(properties), Optional.ToDictionary(measurements));
        }

        BinaryData IPersistableModel<PageViewPerfData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageViewPerfData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PageViewPerfData)} does not support '{options.Format}' format.");
            }
        }

        PageViewPerfData IPersistableModel<PageViewPerfData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PageViewPerfData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePageViewPerfData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PageViewPerfData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PageViewPerfData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
