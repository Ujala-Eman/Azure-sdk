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
    [JsonConverter(typeof(AcsRecordingFileStatusUpdatedEventDataConverter))]
    public partial class AcsRecordingFileStatusUpdatedEventData : IUtf8JsonSerializable, IModelJsonSerializable<AcsRecordingFileStatusUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsRecordingFileStatusUpdatedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsRecordingFileStatusUpdatedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecordingStorageInfo))
            {
                writer.WritePropertyName("recordingStorageInfo"u8);
                writer.WriteObjectValue(RecordingStorageInfo);
            }
            if (Optional.IsDefined(RecordingStartTime))
            {
                writer.WritePropertyName("recordingStartTime"u8);
                writer.WriteStringValue(RecordingStartTime.Value, "O");
            }
            if (Optional.IsDefined(RecordingDurationMs))
            {
                writer.WritePropertyName("recordingDurationMs"u8);
                writer.WriteNumberValue(RecordingDurationMs.Value);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("recordingContentType"u8);
                writer.WriteStringValue(ContentType.Value.ToString());
            }
            if (Optional.IsDefined(ChannelType))
            {
                writer.WritePropertyName("recordingChannelType"u8);
                writer.WriteStringValue(ChannelType.Value.ToString());
            }
            if (Optional.IsDefined(FormatType))
            {
                writer.WritePropertyName("recordingFormatType"u8);
                writer.WriteStringValue(FormatType.Value.ToString());
            }
            if (Optional.IsDefined(SessionEndReason))
            {
                writer.WritePropertyName("sessionEndReason"u8);
                writer.WriteStringValue(SessionEndReason);
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

        internal static AcsRecordingFileStatusUpdatedEventData DeserializeAcsRecordingFileStatusUpdatedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AcsRecordingStorageInfoProperties> recordingStorageInfo = default;
            Optional<DateTimeOffset> recordingStartTime = default;
            Optional<long> recordingDurationMs = default;
            Optional<AcsRecordingContentType> recordingContentType = default;
            Optional<AcsRecordingChannelType> recordingChannelType = default;
            Optional<AcsRecordingFormatType> recordingFormatType = default;
            Optional<string> sessionEndReason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingStorageInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingStorageInfo = AcsRecordingStorageInfoProperties.DeserializeAcsRecordingStorageInfoProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("recordingStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recordingDurationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingDurationMs = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recordingContentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingContentType = new AcsRecordingContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recordingChannelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingChannelType = new AcsRecordingChannelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recordingFormatType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordingFormatType = new AcsRecordingFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionEndReason"u8))
                {
                    sessionEndReason = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsRecordingFileStatusUpdatedEventData(recordingStorageInfo.Value, Optional.ToNullable(recordingStartTime), Optional.ToNullable(recordingDurationMs), Optional.ToNullable(recordingContentType), Optional.ToNullable(recordingChannelType), Optional.ToNullable(recordingFormatType), sessionEndReason.Value, rawData);
        }

        AcsRecordingFileStatusUpdatedEventData IModelJsonSerializable<AcsRecordingFileStatusUpdatedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRecordingFileStatusUpdatedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsRecordingFileStatusUpdatedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsRecordingFileStatusUpdatedEventData IModelSerializable<AcsRecordingFileStatusUpdatedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsRecordingFileStatusUpdatedEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AcsRecordingFileStatusUpdatedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AcsRecordingFileStatusUpdatedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsRecordingFileStatusUpdatedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AcsRecordingFileStatusUpdatedEventDataConverter : JsonConverter<AcsRecordingFileStatusUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRecordingFileStatusUpdatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsRecordingFileStatusUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRecordingFileStatusUpdatedEventData(document.RootElement);
            }
        }
    }
}
