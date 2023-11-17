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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedActionStateInfo : IUtf8JsonSerializable, IJsonModel<RecommendedActionStateInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecommendedActionStateInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecommendedActionStateInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RecommendedActionStateInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RecommendedActionStateInfo>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("currentValue"u8);
            writer.WriteStringValue(CurrentValue.ToString());
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ActionInitiatedBy))
                {
                    writer.WritePropertyName("actionInitiatedBy"u8);
                    writer.WriteStringValue(ActionInitiatedBy.Value.ToSerialString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastModified))
                {
                    writer.WritePropertyName("lastModified"u8);
                    writer.WriteStringValue(LastModified.Value, "O");
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

        RecommendedActionStateInfo IJsonModel<RecommendedActionStateInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecommendedActionStateInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedActionStateInfo(document.RootElement, options);
        }

        internal static RecommendedActionStateInfo DeserializeRecommendedActionStateInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecommendedActionCurrentState currentValue = default;
            Optional<RecommendedActionInitiatedBy> actionInitiatedBy = default;
            Optional<DateTimeOffset> lastModified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentValue"u8))
                {
                    currentValue = new RecommendedActionCurrentState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("actionInitiatedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionInitiatedBy = property.Value.GetString().ToRecommendedActionInitiatedBy();
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecommendedActionStateInfo(currentValue, Optional.ToNullable(actionInitiatedBy), Optional.ToNullable(lastModified), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecommendedActionStateInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecommendedActionStateInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecommendedActionStateInfo IPersistableModel<RecommendedActionStateInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecommendedActionStateInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecommendedActionStateInfo(document.RootElement, options);
        }

        string IPersistableModel<RecommendedActionStateInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
