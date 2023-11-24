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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class Category : IUtf8JsonSerializable, IJsonModel<Category>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Category>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Category>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Category>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(Category)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CategoryName))
            {
                writer.WritePropertyName("categoryName"u8);
                writer.WriteStringValue(CategoryName);
            }
            if (options.Format != "W" && Optional.IsDefined(CategoryType))
            {
                writer.WritePropertyName("categoryType"u8);
                writer.WriteStringValue(CategoryType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CategoryStatus))
            {
                writer.WritePropertyName("categoryStatus"u8);
                writer.WriteStringValue(CategoryStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ControlFamilies))
            {
                writer.WritePropertyName("controlFamilies"u8);
                writer.WriteStartArray();
                foreach (var item in ControlFamilies)
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

        Category IJsonModel<Category>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Category>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(Category)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCategory(document.RootElement, options);
        }

        internal static Category DeserializeCategory(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> categoryName = default;
            Optional<CategoryType> categoryType = default;
            Optional<CategoryStatus> categoryStatus = default;
            Optional<IReadOnlyList<ControlFamily>> controlFamilies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("categoryName"u8))
                {
                    categoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categoryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    categoryType = new CategoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("categoryStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    categoryStatus = new CategoryStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controlFamilies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ControlFamily> array = new List<ControlFamily>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ControlFamily.DeserializeControlFamily(item));
                    }
                    controlFamilies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Category(categoryName.Value, Optional.ToNullable(categoryType), Optional.ToNullable(categoryStatus), Optional.ToList(controlFamilies), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Category>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Category>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(Category)} does not support '{options.Format}' format.");
            }
        }

        Category IPersistableModel<Category>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Category>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCategory(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(Category)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Category>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
