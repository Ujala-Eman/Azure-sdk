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
    [JsonConverter(typeof(MediaJobErroredEventDataConverter))]
    public partial class MediaJobErroredEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaJobErroredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaJobErroredEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaJobErroredEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobErroredEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CorrelationData))
            {
                writer.WritePropertyName("correlationData"u8);
                writer.WriteStartObject();
                foreach (var item in CorrelationData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static MediaJobErroredEventData DeserializeMediaJobErroredEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MediaJobOutput>> outputs = default;
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobState> state = default;
            Optional<IReadOnlyDictionary<string, string>> correlationData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobOutput> array = new List<MediaJobOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobOutput.DeserializeMediaJobOutput(item));
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("correlationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    correlationData = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaJobErroredEventData(Optional.ToNullable(previousState), Optional.ToNullable(state), Optional.ToDictionary(correlationData), Optional.ToList(outputs), rawData);
        }

        MediaJobErroredEventData IModelJsonSerializable<MediaJobErroredEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobErroredEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobErroredEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaJobErroredEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobErroredEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaJobErroredEventData IModelSerializable<MediaJobErroredEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MediaJobErroredEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaJobErroredEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MediaJobErroredEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MediaJobErroredEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaJobErroredEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaJobErroredEventDataConverter : JsonConverter<MediaJobErroredEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobErroredEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobErroredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobErroredEventData(document.RootElement);
            }
        }
    }
}
