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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class LatencyMetric : IUtf8JsonSerializable, IModelJsonSerializable<LatencyMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LatencyMetric>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LatencyMetric>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static LatencyMetric DeserializeLatencyMetric(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<DateTimeOffset> endDateTimeUtc = default;
            Optional<float> aValue = default;
            Optional<float> bValue = default;
            Optional<float> delta = default;
            Optional<float> deltaPercent = default;
            Optional<float> acLower95CI = default;
            Optional<float> ahUpper95CI = default;
            Optional<float> bcLower95CI = default;
            Optional<float> bUpper95CI = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endDateTimeUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("aValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delta = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("deltaPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaPercent = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aCLower95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acLower95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("aHUpper95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ahUpper95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bCLower95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bcLower95CI = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bUpper95CI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bUpper95CI = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LatencyMetric(name.Value, Optional.ToNullable(endDateTimeUtc), Optional.ToNullable(aValue), Optional.ToNullable(bValue), Optional.ToNullable(delta), Optional.ToNullable(deltaPercent), Optional.ToNullable(acLower95CI), Optional.ToNullable(ahUpper95CI), Optional.ToNullable(bcLower95CI), Optional.ToNullable(bUpper95CI), rawData);
        }

        LatencyMetric IModelJsonSerializable<LatencyMetric>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLatencyMetric(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LatencyMetric>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LatencyMetric IModelSerializable<LatencyMetric>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLatencyMetric(doc.RootElement, options);
        }

        public static implicit operator RequestContent(LatencyMetric model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator LatencyMetric(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLatencyMetric(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
