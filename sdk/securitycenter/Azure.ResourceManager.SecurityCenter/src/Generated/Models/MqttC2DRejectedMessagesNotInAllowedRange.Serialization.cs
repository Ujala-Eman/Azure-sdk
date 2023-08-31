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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class MqttC2DRejectedMessagesNotInAllowedRange : IUtf8JsonSerializable, IModelJsonSerializable<MqttC2DRejectedMessagesNotInAllowedRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MqttC2DRejectedMessagesNotInAllowedRange>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MqttC2DRejectedMessagesNotInAllowedRange>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MqttC2DRejectedMessagesNotInAllowedRange>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("timeWindowSize"u8);
            writer.WriteStringValue(TimeWindowSize, "P");
            writer.WritePropertyName("minThreshold"u8);
            writer.WriteNumberValue(MinThreshold);
            writer.WritePropertyName("maxThreshold"u8);
            writer.WriteNumberValue(MaxThreshold);
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
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

        internal static MqttC2DRejectedMessagesNotInAllowedRange DeserializeMqttC2DRejectedMessagesNotInAllowedRange(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan timeWindowSize = default;
            int minThreshold = default;
            int maxThreshold = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            bool isEnabled = default;
            string ruleType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeWindowSize"u8))
                {
                    timeWindowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("minThreshold"u8))
                {
                    minThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxThreshold"u8))
                {
                    maxThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MqttC2DRejectedMessagesNotInAllowedRange(displayName.Value, description.Value, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize, rawData);
        }

        MqttC2DRejectedMessagesNotInAllowedRange IModelJsonSerializable<MqttC2DRejectedMessagesNotInAllowedRange>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MqttC2DRejectedMessagesNotInAllowedRange>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMqttC2DRejectedMessagesNotInAllowedRange(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MqttC2DRejectedMessagesNotInAllowedRange>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MqttC2DRejectedMessagesNotInAllowedRange>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MqttC2DRejectedMessagesNotInAllowedRange IModelSerializable<MqttC2DRejectedMessagesNotInAllowedRange>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MqttC2DRejectedMessagesNotInAllowedRange>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMqttC2DRejectedMessagesNotInAllowedRange(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/> to convert. </param>
        public static implicit operator RequestContent(MqttC2DRejectedMessagesNotInAllowedRange model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MqttC2DRejectedMessagesNotInAllowedRange(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMqttC2DRejectedMessagesNotInAllowedRange(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
