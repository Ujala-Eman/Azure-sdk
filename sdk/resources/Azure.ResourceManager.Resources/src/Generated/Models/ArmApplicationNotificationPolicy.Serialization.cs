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

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ArmApplicationNotificationPolicy : IUtf8JsonSerializable, IModelJsonSerializable<ArmApplicationNotificationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArmApplicationNotificationPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArmApplicationNotificationPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("notificationEndpoints"u8);
            writer.WriteStartArray();
            foreach (var item in NotificationEndpoints)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ArmApplicationNotificationEndpoint>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static ArmApplicationNotificationPolicy DeserializeArmApplicationNotificationPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ArmApplicationNotificationEndpoint> notificationEndpoints = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationEndpoints"u8))
                {
                    List<ArmApplicationNotificationEndpoint> array = new List<ArmApplicationNotificationEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArmApplicationNotificationEndpoint.DeserializeArmApplicationNotificationEndpoint(item));
                    }
                    notificationEndpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ArmApplicationNotificationPolicy(notificationEndpoints, rawData);
        }

        ArmApplicationNotificationPolicy IModelJsonSerializable<ArmApplicationNotificationPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationNotificationPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArmApplicationNotificationPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArmApplicationNotificationPolicy IModelSerializable<ArmApplicationNotificationPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArmApplicationNotificationPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ArmApplicationNotificationPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ArmApplicationNotificationPolicy"/> to convert. </param>
        public static implicit operator RequestContent(ArmApplicationNotificationPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ArmApplicationNotificationPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ArmApplicationNotificationPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArmApplicationNotificationPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
