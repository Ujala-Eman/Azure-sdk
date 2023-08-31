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
    public partial class ClusterNotificationTarget : IUtf8JsonSerializable, IModelJsonSerializable<ClusterNotificationTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterNotificationTarget>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterNotificationTarget>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("notificationChannel"u8);
            writer.WriteStringValue(NotificationChannel.ToString());
            writer.WritePropertyName("receivers"u8);
            writer.WriteStartArray();
            foreach (var item in Receivers)
            {
                writer.WriteStringValue(item);
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

        internal static ClusterNotificationTarget DeserializeClusterNotificationTarget(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClusterNotificationChannel notificationChannel = default;
            IList<string> receivers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationChannel"u8))
                {
                    notificationChannel = new ClusterNotificationChannel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("receivers"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    receivers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterNotificationTarget(notificationChannel, receivers, rawData);
        }

        ClusterNotificationTarget IModelJsonSerializable<ClusterNotificationTarget>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterNotificationTarget(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterNotificationTarget>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterNotificationTarget IModelSerializable<ClusterNotificationTarget>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterNotificationTarget(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterNotificationTarget"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterNotificationTarget"/> to convert. </param>
        public static implicit operator RequestContent(ClusterNotificationTarget model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterNotificationTarget"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterNotificationTarget(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterNotificationTarget(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
