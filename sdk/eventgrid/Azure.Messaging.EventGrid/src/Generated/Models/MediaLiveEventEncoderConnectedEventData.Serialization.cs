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
    [JsonConverter(typeof(MediaLiveEventEncoderConnectedEventDataConverter))]
    public partial class MediaLiveEventEncoderConnectedEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaLiveEventEncoderConnectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaLiveEventEncoderConnectedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaLiveEventEncoderConnectedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MediaLiveEventEncoderConnectedEventData DeserializeMediaLiveEventEncoderConnectedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ingestUrl = default;
            Optional<string> streamId = default;
            Optional<string> encoderIp = default;
            Optional<string> encoderPort = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"u8))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamId"u8))
                {
                    streamId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderIp"u8))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"u8))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaLiveEventEncoderConnectedEventData(ingestUrl.Value, streamId.Value, encoderIp.Value, encoderPort.Value, rawData);
        }

        MediaLiveEventEncoderConnectedEventData IModelJsonSerializable<MediaLiveEventEncoderConnectedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventEncoderConnectedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaLiveEventEncoderConnectedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaLiveEventEncoderConnectedEventData IModelSerializable<MediaLiveEventEncoderConnectedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaLiveEventEncoderConnectedEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaLiveEventEncoderConnectedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaLiveEventEncoderConnectedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaLiveEventEncoderConnectedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaLiveEventEncoderConnectedEventDataConverter : JsonConverter<MediaLiveEventEncoderConnectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventEncoderConnectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventEncoderConnectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventEncoderConnectedEventData(document.RootElement);
            }
        }
    }
}
