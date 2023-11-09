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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class DateAfterCreation : IUtf8JsonSerializable, IJsonModel<DateAfterCreation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DateAfterCreation>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DateAfterCreation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("daysAfterCreationGreaterThan"u8);
            writer.WriteNumberValue(DaysAfterCreationGreaterThan);
            if (Optional.IsDefined(DaysAfterLastTierChangeGreaterThan))
            {
                writer.WritePropertyName("daysAfterLastTierChangeGreaterThan"u8);
                writer.WriteNumberValue(DaysAfterLastTierChangeGreaterThan.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        DateAfterCreation IJsonModel<DateAfterCreation>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDateAfterCreation(document.RootElement, options);
        }

        internal static DateAfterCreation DeserializeDateAfterCreation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float daysAfterCreationGreaterThan = default;
            Optional<float> daysAfterLastTierChangeGreaterThan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysAfterCreationGreaterThan"u8))
                {
                    daysAfterCreationGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("daysAfterLastTierChangeGreaterThan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daysAfterLastTierChangeGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DateAfterCreation(daysAfterCreationGreaterThan, Optional.ToNullable(daysAfterLastTierChangeGreaterThan), serializedAdditionalRawData);
        }

        BinaryData IModel<DateAfterCreation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DateAfterCreation IModel<DateAfterCreation>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDateAfterCreation(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DateAfterCreation>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
