// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceCorsConfiguration : IUtf8JsonSerializable, IJsonModel<HealthcareApisServiceCorsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareApisServiceCorsConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareApisServiceCorsConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCorsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceCorsConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Methods))
            {
                writer.WritePropertyName("methods"u8);
                writer.WriteStartArray();
                foreach (var item in Methods)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxAge))
            {
                writer.WritePropertyName("maxAge"u8);
                writer.WriteNumberValue(MaxAge.Value);
            }
            if (Optional.IsDefined(AllowCredentials))
            {
                writer.WritePropertyName("allowCredentials"u8);
                writer.WriteBooleanValue(AllowCredentials.Value);
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
        }

        HealthcareApisServiceCorsConfiguration IJsonModel<HealthcareApisServiceCorsConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCorsConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceCorsConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceCorsConfiguration(document.RootElement, options);
        }

        internal static HealthcareApisServiceCorsConfiguration DeserializeHealthcareApisServiceCorsConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> origins = default;
            IList<string> headers = default;
            IList<string> methods = default;
            int? maxAge = default;
            bool? allowCredentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    origins = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("methods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    methods = array;
                    continue;
                }
                if (property.NameEquals("maxAge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCredentials = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareApisServiceCorsConfiguration(
                origins ?? new ChangeTrackingList<string>(),
                headers ?? new ChangeTrackingList<string>(),
                methods ?? new ChangeTrackingList<string>(),
                maxAge,
                allowCredentials,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareApisServiceCorsConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCorsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceCorsConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareApisServiceCorsConfiguration IPersistableModel<HealthcareApisServiceCorsConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCorsConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareApisServiceCorsConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceCorsConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareApisServiceCorsConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
