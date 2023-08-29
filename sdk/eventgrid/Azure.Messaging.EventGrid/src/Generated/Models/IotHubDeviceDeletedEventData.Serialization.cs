// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(IotHubDeviceDeletedEventDataConverter))]
    public partial class IotHubDeviceDeletedEventData : IUtf8JsonSerializable, IModelJsonSerializable<IotHubDeviceDeletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubDeviceDeletedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubDeviceDeletedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotHubDeviceDeletedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(HubName))
            {
                writer.WritePropertyName("hubName"u8);
                writer.WriteStringValue(HubName);
            }
            if (Optional.IsDefined(Twin))
            {
                writer.WritePropertyName("twin"u8);
                writer.WriteObjectValue(Twin);
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

        internal static IotHubDeviceDeletedEventData DeserializeIotHubDeviceDeletedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<string> hubName = default;
            Optional<DeviceTwinInfo> twin = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("twin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twin = DeviceTwinInfo.DeserializeDeviceTwinInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubDeviceDeletedEventData(deviceId.Value, hubName.Value, twin.Value, rawData);
        }

        IotHubDeviceDeletedEventData IModelJsonSerializable<IotHubDeviceDeletedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotHubDeviceDeletedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubDeviceDeletedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubDeviceDeletedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotHubDeviceDeletedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubDeviceDeletedEventData IModelSerializable<IotHubDeviceDeletedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IotHubDeviceDeletedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubDeviceDeletedEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IotHubDeviceDeletedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IotHubDeviceDeletedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubDeviceDeletedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class IotHubDeviceDeletedEventDataConverter : JsonConverter<IotHubDeviceDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, IotHubDeviceDeletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override IotHubDeviceDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIotHubDeviceDeletedEventData(document.RootElement);
            }
        }
    }
}
