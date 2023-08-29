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
    [JsonConverter(typeof(MediaLiveEventIncomingStreamsOutOfSyncEventDataConverter))]
    public partial class MediaLiveEventIncomingStreamsOutOfSyncEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaLiveEventIncomingStreamsOutOfSyncEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaLiveEventIncomingStreamsOutOfSyncEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaLiveEventIncomingStreamsOutOfSyncEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MediaLiveEventIncomingStreamsOutOfSyncEventData DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> minLastTimestamp = default;
            Optional<string> typeOfStreamWithMinLastTimestamp = default;
            Optional<string> maxLastTimestamp = default;
            Optional<string> typeOfStreamWithMaxLastTimestamp = default;
            Optional<string> timescaleOfMinLastTimestamp = default;
            Optional<string> timescaleOfMaxLastTimestamp = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minLastTimestamp"u8))
                {
                    minLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeOfStreamWithMinLastTimestamp"u8))
                {
                    typeOfStreamWithMinLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLastTimestamp"u8))
                {
                    maxLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeOfStreamWithMaxLastTimestamp"u8))
                {
                    typeOfStreamWithMaxLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescaleOfMinLastTimestamp"u8))
                {
                    timescaleOfMinLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescaleOfMaxLastTimestamp"u8))
                {
                    timescaleOfMaxLastTimestamp = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaLiveEventIncomingStreamsOutOfSyncEventData(minLastTimestamp.Value, typeOfStreamWithMinLastTimestamp.Value, maxLastTimestamp.Value, typeOfStreamWithMaxLastTimestamp.Value, timescaleOfMinLastTimestamp.Value, timescaleOfMaxLastTimestamp.Value, rawData);
        }

        MediaLiveEventIncomingStreamsOutOfSyncEventData IModelJsonSerializable<MediaLiveEventIncomingStreamsOutOfSyncEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaLiveEventIncomingStreamsOutOfSyncEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaLiveEventIncomingStreamsOutOfSyncEventData IModelSerializable<MediaLiveEventIncomingStreamsOutOfSyncEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaLiveEventIncomingStreamsOutOfSyncEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaLiveEventIncomingStreamsOutOfSyncEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaLiveEventIncomingStreamsOutOfSyncEventDataConverter : JsonConverter<MediaLiveEventIncomingStreamsOutOfSyncEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventIncomingStreamsOutOfSyncEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventIncomingStreamsOutOfSyncEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventIncomingStreamsOutOfSyncEventData(document.RootElement);
            }
        }
    }
}
