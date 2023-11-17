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

namespace Azure.ResourceManager.Quota.Models
{
    public partial class QuotaUsagesObject : IUtf8JsonSerializable, IJsonModel<QuotaUsagesObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaUsagesObject>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaUsagesObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<QuotaUsagesObject>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<QuotaUsagesObject>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            if (Optional.IsDefined(UsagesType))
            {
                writer.WritePropertyName("usagesType"u8);
                writer.WriteStringValue(UsagesType.Value.ToString());
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

        QuotaUsagesObject IJsonModel<QuotaUsagesObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QuotaUsagesObject)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaUsagesObject(document.RootElement, options);
        }

        internal static QuotaUsagesObject DeserializeQuotaUsagesObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            Optional<QuotaUsagesType> usagesType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usagesType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usagesType = new QuotaUsagesType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaUsagesObject(value, Optional.ToNullable(usagesType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaUsagesObject>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QuotaUsagesObject)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        QuotaUsagesObject IPersistableModel<QuotaUsagesObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QuotaUsagesObject)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeQuotaUsagesObject(document.RootElement, options);
        }

        string IPersistableModel<QuotaUsagesObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
