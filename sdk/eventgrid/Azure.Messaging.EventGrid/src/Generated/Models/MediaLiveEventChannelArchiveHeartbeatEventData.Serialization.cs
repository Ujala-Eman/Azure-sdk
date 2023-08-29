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
    [JsonConverter(typeof(MediaLiveEventChannelArchiveHeartbeatEventDataConverter))]
    public partial class MediaLiveEventChannelArchiveHeartbeatEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaLiveEventChannelArchiveHeartbeatEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaLiveEventChannelArchiveHeartbeatEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaLiveEventChannelArchiveHeartbeatEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MediaLiveEventChannelArchiveHeartbeatEventData DeserializeMediaLiveEventChannelArchiveHeartbeatEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string channelLatencyMs = default;
            string latencyResultCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channelLatencyMs"u8))
                {
                    channelLatencyMs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latencyResultCode"u8))
                {
                    latencyResultCode = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaLiveEventChannelArchiveHeartbeatEventData(channelLatencyMs, latencyResultCode, rawData);
        }

        MediaLiveEventChannelArchiveHeartbeatEventData IModelJsonSerializable<MediaLiveEventChannelArchiveHeartbeatEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventChannelArchiveHeartbeatEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaLiveEventChannelArchiveHeartbeatEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaLiveEventChannelArchiveHeartbeatEventData IModelSerializable<MediaLiveEventChannelArchiveHeartbeatEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaLiveEventChannelArchiveHeartbeatEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaLiveEventChannelArchiveHeartbeatEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaLiveEventChannelArchiveHeartbeatEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaLiveEventChannelArchiveHeartbeatEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaLiveEventChannelArchiveHeartbeatEventDataConverter : JsonConverter<MediaLiveEventChannelArchiveHeartbeatEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventChannelArchiveHeartbeatEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventChannelArchiveHeartbeatEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventChannelArchiveHeartbeatEventData(document.RootElement);
            }
        }
    }
}
