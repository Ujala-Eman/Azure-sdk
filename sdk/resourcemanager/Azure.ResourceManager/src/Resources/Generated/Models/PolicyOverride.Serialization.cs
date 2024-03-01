// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class PolicyOverride : IUtf8JsonSerializable, IJsonModel<PolicyOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyOverride>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyOverride)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind.HasValue)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Value != null)
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (!(Selectors is ChangeTrackingList<ResourceSelectorExpression> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("selectors"u8);
                writer.WriteStartArray();
                foreach (var item in Selectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PolicyOverride IJsonModel<PolicyOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyOverride)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyOverride(document.RootElement, options);
        }

        internal static PolicyOverride DeserializePolicyOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PolicyOverrideKind? kind = default;
            string value = default;
            IList<ResourceSelectorExpression> selectors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new PolicyOverrideKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceSelectorExpression> array = new List<ResourceSelectorExpression>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSelectorExpression.DeserializeResourceSelectorExpression(item, options));
                    }
                    selectors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyOverride(kind, value, selectors ?? new ChangeTrackingList<ResourceSelectorExpression>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyOverride)} does not support '{options.Format}' format.");
            }
        }

        PolicyOverride IPersistableModel<PolicyOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyOverride)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
