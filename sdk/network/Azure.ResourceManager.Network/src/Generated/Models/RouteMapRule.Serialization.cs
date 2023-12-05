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
    public partial class RouteMapRule : IUtf8JsonSerializable, IJsonModel<RouteMapRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouteMapRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouteMapRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteMapRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RouteMapRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(MatchCriteria))
            {
                writer.WritePropertyName("matchCriteria"u8);
                writer.WriteStartArray();
                foreach (var item in MatchCriteria)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextStepIfMatched))
            {
                writer.WritePropertyName("nextStepIfMatched"u8);
                writer.WriteStringValue(NextStepIfMatched.Value.ToString());
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

        RouteMapRule IJsonModel<RouteMapRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteMapRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RouteMapRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteMapRule(document.RootElement, options);
        }

        internal static RouteMapRule DeserializeRouteMapRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IList<RouteCriterion>> matchCriteria = default;
            Optional<IList<RouteMapAction>> actions = default;
            Optional<RouteMapNextStepBehavior> nextStepIfMatched = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matchCriteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteCriterion> array = new List<RouteCriterion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteCriterion.DeserializeRouteCriterion(item));
                    }
                    matchCriteria = array;
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteMapAction> array = new List<RouteMapAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteMapAction.DeserializeRouteMapAction(item));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("nextStepIfMatched"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextStepIfMatched = new RouteMapNextStepBehavior(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouteMapRule(name.Value, Optional.ToList(matchCriteria), Optional.ToList(actions), Optional.ToNullable(nextStepIfMatched), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouteMapRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteMapRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RouteMapRule)} does not support '{options.Format}' format.");
            }
        }

        RouteMapRule IPersistableModel<RouteMapRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteMapRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouteMapRule(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RouteMapRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouteMapRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
