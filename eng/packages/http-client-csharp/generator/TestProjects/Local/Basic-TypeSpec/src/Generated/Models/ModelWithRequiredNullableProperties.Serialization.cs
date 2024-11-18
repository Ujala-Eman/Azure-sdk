// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using BasicTypeSpec;

namespace BasicTypeSpec.Models
{
    /// <summary></summary>
    public partial class ModelWithRequiredNullableProperties : IJsonModel<ModelWithRequiredNullableProperties>
    {
        internal ModelWithRequiredNullableProperties()
        {
        }

        void IJsonModel<ModelWithRequiredNullableProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ModelWithRequiredNullableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelWithRequiredNullableProperties)} does not support writing '{format}' format.");
            }
            if (RequiredNullablePrimitive != null)
            {
                writer.WritePropertyName("requiredNullablePrimitive"u8);
                writer.WriteNumberValue(RequiredNullablePrimitive.Value);
            }
            else
            {
                writer.WriteNull("requiredNullablePrimitive"u8);
            }
            if (RequiredExtensibleEnum != null)
            {
                writer.WritePropertyName("requiredExtensibleEnum"u8);
                writer.WriteStringValue(RequiredExtensibleEnum.Value.ToString());
            }
            else
            {
                writer.WriteNull("requiredExtensibleEnum"u8);
            }
            if (RequiredFixedEnum != null)
            {
                writer.WritePropertyName("requiredFixedEnum"u8);
                writer.WriteStringValue(RequiredFixedEnum.Value.ToSerialString());
            }
            else
            {
                writer.WriteNull("requiredFixedEnum"u8);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
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
        }

        ModelWithRequiredNullableProperties IJsonModel<ModelWithRequiredNullableProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ModelWithRequiredNullableProperties JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ModelWithRequiredNullableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelWithRequiredNullableProperties)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelWithRequiredNullableProperties(document.RootElement, options);
        }

        internal static ModelWithRequiredNullableProperties DeserializeModelWithRequiredNullableProperties(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? requiredNullablePrimitive = default;
            StringExtensibleEnum? requiredExtensibleEnum = default;
            StringFixedEnum? requiredFixedEnum = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("requiredNullablePrimitive"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        requiredNullablePrimitive = null;
                        continue;
                    }
                    requiredNullablePrimitive = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("requiredExtensibleEnum"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        requiredExtensibleEnum = null;
                        continue;
                    }
                    requiredExtensibleEnum = new StringExtensibleEnum(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("requiredFixedEnum"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        requiredFixedEnum = null;
                        continue;
                    }
                    requiredFixedEnum = prop.Value.GetString().ToStringFixedEnum();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ModelWithRequiredNullableProperties(requiredNullablePrimitive, requiredExtensibleEnum, requiredFixedEnum, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ModelWithRequiredNullableProperties>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ModelWithRequiredNullableProperties>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelWithRequiredNullableProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ModelWithRequiredNullableProperties IPersistableModel<ModelWithRequiredNullableProperties>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ModelWithRequiredNullableProperties PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ModelWithRequiredNullableProperties>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeModelWithRequiredNullableProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelWithRequiredNullableProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelWithRequiredNullableProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="modelWithRequiredNullableProperties"> The <see cref="ModelWithRequiredNullableProperties"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(ModelWithRequiredNullableProperties modelWithRequiredNullableProperties)
        {
            if (modelWithRequiredNullableProperties == null)
            {
                return null;
            }
            Utf8JsonBinaryContent content = new Utf8JsonBinaryContent();
            content.JsonWriter.WriteObjectValue(modelWithRequiredNullableProperties, ModelSerializationExtensions.WireOptions);
            return content;
        }

        /// <param name="result"> The <see cref="Response"/> to deserialize the <see cref="ModelWithRequiredNullableProperties"/> from. </param>
        public static explicit operator ModelWithRequiredNullableProperties(Response result)
        {
            using Response response = result;
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeModelWithRequiredNullableProperties(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
