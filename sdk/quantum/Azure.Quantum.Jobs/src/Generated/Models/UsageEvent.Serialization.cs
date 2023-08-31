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

namespace Azure.Quantum.Jobs.Models
{
    public partial class UsageEvent : IUtf8JsonSerializable, IModelJsonSerializable<UsageEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UsageEvent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UsageEvent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DimensionId))
            {
                writer.WritePropertyName("dimensionId"u8);
                writer.WriteStringValue(DimensionId);
            }
            if (Optional.IsDefined(DimensionName))
            {
                writer.WritePropertyName("dimensionName"u8);
                writer.WriteStringValue(DimensionName);
            }
            if (Optional.IsDefined(MeasureUnit))
            {
                writer.WritePropertyName("measureUnit"u8);
                writer.WriteStringValue(MeasureUnit);
            }
            if (Optional.IsDefined(AmountBilled))
            {
                writer.WritePropertyName("amountBilled"u8);
                writer.WriteNumberValue(AmountBilled.Value);
            }
            if (Optional.IsDefined(AmountConsumed))
            {
                writer.WritePropertyName("amountConsumed"u8);
                writer.WriteNumberValue(AmountConsumed.Value);
            }
            if (Optional.IsDefined(UnitPrice))
            {
                writer.WritePropertyName("unitPrice"u8);
                writer.WriteNumberValue(UnitPrice.Value);
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

        internal static UsageEvent DeserializeUsageEvent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dimensionId = default;
            Optional<string> dimensionName = default;
            Optional<string> measureUnit = default;
            Optional<float> amountBilled = default;
            Optional<float> amountConsumed = default;
            Optional<float> unitPrice = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionId"u8))
                {
                    dimensionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("measureUnit"u8))
                {
                    measureUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amountBilled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amountBilled = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("amountConsumed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amountConsumed = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unitPrice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unitPrice = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UsageEvent(dimensionId.Value, dimensionName.Value, measureUnit.Value, Optional.ToNullable(amountBilled), Optional.ToNullable(amountConsumed), Optional.ToNullable(unitPrice), rawData);
        }

        UsageEvent IModelJsonSerializable<UsageEvent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUsageEvent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UsageEvent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UsageEvent IModelSerializable<UsageEvent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUsageEvent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UsageEvent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UsageEvent"/> to convert. </param>
        public static implicit operator RequestContent(UsageEvent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UsageEvent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UsageEvent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUsageEvent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
