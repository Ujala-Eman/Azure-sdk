// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BreakOutCategoryPolicies : IUtf8JsonSerializable, IJsonModel<BreakOutCategoryPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BreakOutCategoryPolicies>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BreakOutCategoryPolicies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BreakOutCategoryPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BreakOutCategoryPolicies)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Allow))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteBooleanValue(Allow.Value);
            }
            if (Optional.IsDefined(Optimize))
            {
                writer.WritePropertyName("optimize"u8);
                writer.WriteBooleanValue(Optimize.Value);
            }
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteBooleanValue(Default.Value);
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

        BreakOutCategoryPolicies IJsonModel<BreakOutCategoryPolicies>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BreakOutCategoryPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BreakOutCategoryPolicies)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBreakOutCategoryPolicies(document.RootElement, options);
        }

        internal static BreakOutCategoryPolicies DeserializeBreakOutCategoryPolicies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? allow = default;
            bool? optimize = default;
            bool? @default = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allow = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("optimize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optimize = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BreakOutCategoryPolicies(allow, optimize, @default, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BreakOutCategoryPolicies>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BreakOutCategoryPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BreakOutCategoryPolicies)} does not support '{options.Format}' format.");
            }
        }

        BreakOutCategoryPolicies IPersistableModel<BreakOutCategoryPolicies>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BreakOutCategoryPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBreakOutCategoryPolicies(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BreakOutCategoryPolicies)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BreakOutCategoryPolicies>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
