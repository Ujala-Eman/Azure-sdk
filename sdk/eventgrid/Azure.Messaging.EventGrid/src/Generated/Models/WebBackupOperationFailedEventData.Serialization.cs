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
    [JsonConverter(typeof(WebBackupOperationFailedEventDataConverter))]
    public partial class WebBackupOperationFailedEventData : IUtf8JsonSerializable, IModelJsonSerializable<WebBackupOperationFailedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebBackupOperationFailedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebBackupOperationFailedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AppEventTypeDetail))
            {
                writer.WritePropertyName("appEventTypeDetail"u8);
                writer.WriteObjectValue(AppEventTypeDetail);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ClientRequestId))
            {
                writer.WritePropertyName("clientRequestId"u8);
                writer.WriteStringValue(ClientRequestId);
            }
            if (Optional.IsDefined(CorrelationRequestId))
            {
                writer.WritePropertyName("correlationRequestId"u8);
                writer.WriteStringValue(CorrelationRequestId);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(Verb))
            {
                writer.WritePropertyName("verb"u8);
                writer.WriteStringValue(Verb);
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

        internal static WebBackupOperationFailedEventData DeserializeWebBackupOperationFailedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppEventTypeDetail> appEventTypeDetail = default;
            Optional<string> name = default;
            Optional<string> clientRequestId = default;
            Optional<string> correlationRequestId = default;
            Optional<string> requestId = default;
            Optional<string> address = default;
            Optional<string> verb = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appEventTypeDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appEventTypeDetail = AppEventTypeDetail.DeserializeAppEventTypeDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationRequestId"u8))
                {
                    correlationRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verb"u8))
                {
                    verb = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebBackupOperationFailedEventData(appEventTypeDetail.Value, name.Value, clientRequestId.Value, correlationRequestId.Value, requestId.Value, address.Value, verb.Value, rawData);
        }

        WebBackupOperationFailedEventData IModelJsonSerializable<WebBackupOperationFailedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebBackupOperationFailedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebBackupOperationFailedEventData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebBackupOperationFailedEventData IModelSerializable<WebBackupOperationFailedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebBackupOperationFailedEventData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(WebBackupOperationFailedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator WebBackupOperationFailedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebBackupOperationFailedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class WebBackupOperationFailedEventDataConverter : JsonConverter<WebBackupOperationFailedEventData>
        {
            public override void Write(Utf8JsonWriter writer, WebBackupOperationFailedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebBackupOperationFailedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebBackupOperationFailedEventData(document.RootElement);
            }
        }
    }
}
