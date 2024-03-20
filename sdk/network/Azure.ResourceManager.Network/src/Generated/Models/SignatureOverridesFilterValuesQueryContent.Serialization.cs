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
    public partial class SignatureOverridesFilterValuesQueryContent : IUtf8JsonSerializable, IJsonModel<SignatureOverridesFilterValuesQueryContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SignatureOverridesFilterValuesQueryContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SignatureOverridesFilterValuesQueryContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignatureOverridesFilterValuesQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignatureOverridesFilterValuesQueryContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FilterName))
            {
                writer.WritePropertyName("filterName"u8);
                writer.WriteStringValue(FilterName);
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

        SignatureOverridesFilterValuesQueryContent IJsonModel<SignatureOverridesFilterValuesQueryContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignatureOverridesFilterValuesQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SignatureOverridesFilterValuesQueryContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSignatureOverridesFilterValuesQueryContent(document.RootElement, options);
        }

        internal static SignatureOverridesFilterValuesQueryContent DeserializeSignatureOverridesFilterValuesQueryContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filterName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterName"u8))
                {
                    filterName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SignatureOverridesFilterValuesQueryContent(filterName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SignatureOverridesFilterValuesQueryContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignatureOverridesFilterValuesQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SignatureOverridesFilterValuesQueryContent)} does not support '{options.Format}' format.");
            }
        }

        SignatureOverridesFilterValuesQueryContent IPersistableModel<SignatureOverridesFilterValuesQueryContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SignatureOverridesFilterValuesQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSignatureOverridesFilterValuesQueryContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SignatureOverridesFilterValuesQueryContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SignatureOverridesFilterValuesQueryContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
