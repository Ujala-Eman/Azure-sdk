// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ApplicationMetricDescription : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationMetricDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationMetricDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationMetricDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(MaximumCapacity))
            {
                writer.WritePropertyName("maximumCapacity"u8);
                writer.WriteNumberValue(MaximumCapacity.Value);
            }
            if (Optional.IsDefined(ReservationCapacity))
            {
                writer.WritePropertyName("reservationCapacity"u8);
                writer.WriteNumberValue(ReservationCapacity.Value);
            }
            if (Optional.IsDefined(TotalApplicationCapacity))
            {
                writer.WritePropertyName("totalApplicationCapacity"u8);
                writer.WriteNumberValue(TotalApplicationCapacity.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ApplicationMetricDescription DeserializeApplicationMetricDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<long> maximumCapacity = default;
            Optional<long> reservationCapacity = default;
            Optional<long> totalApplicationCapacity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("reservationCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationCapacity = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalApplicationCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalApplicationCapacity = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationMetricDescription(name.Value, Optional.ToNullable(maximumCapacity), Optional.ToNullable(reservationCapacity), Optional.ToNullable(totalApplicationCapacity), rawData);
        }

        ApplicationMetricDescription IModelJsonSerializable<ApplicationMetricDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationMetricDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationMetricDescription>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationMetricDescription IModelSerializable<ApplicationMetricDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationMetricDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationMetricDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationMetricDescription"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationMetricDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationMetricDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationMetricDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationMetricDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
