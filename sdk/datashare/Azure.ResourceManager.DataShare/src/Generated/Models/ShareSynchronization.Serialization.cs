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

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ShareSynchronization : IUtf8JsonSerializable, IModelJsonSerializable<ShareSynchronization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ShareSynchronization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ShareSynchronization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConsumerEmail))
            {
                writer.WritePropertyName("consumerEmail"u8);
                writer.WriteStringValue(ConsumerEmail);
            }
            if (Optional.IsDefined(ConsumerName))
            {
                writer.WritePropertyName("consumerName"u8);
                writer.WriteStringValue(ConsumerName);
            }
            if (Optional.IsDefined(ConsumerTenantName))
            {
                writer.WritePropertyName("consumerTenantName"u8);
                writer.WriteStringValue(ConsumerTenantName);
            }
            if (Optional.IsDefined(DurationInMilliSeconds))
            {
                writer.WritePropertyName("durationMs"u8);
                writer.WriteNumberValue(DurationInMilliSeconds.Value);
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SynchronizationId))
            {
                writer.WritePropertyName("synchronizationId"u8);
                writer.WriteStringValue(SynchronizationId.Value);
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

        internal static ShareSynchronization DeserializeShareSynchronization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> consumerEmail = default;
            Optional<string> consumerName = default;
            Optional<string> consumerTenantName = default;
            Optional<int> durationMs = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> status = default;
            Optional<Guid> synchronizationId = default;
            Optional<SynchronizationMode> synchronizationMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consumerEmail"u8))
                {
                    consumerEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumerName"u8))
                {
                    consumerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumerTenantName"u8))
                {
                    consumerTenantName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("durationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synchronizationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    synchronizationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("synchronizationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    synchronizationMode = new SynchronizationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ShareSynchronization(consumerEmail.Value, consumerName.Value, consumerTenantName.Value, Optional.ToNullable(durationMs), Optional.ToNullable(endTime), message.Value, Optional.ToNullable(startTime), status.Value, Optional.ToNullable(synchronizationId), Optional.ToNullable(synchronizationMode), rawData);
        }

        ShareSynchronization IModelJsonSerializable<ShareSynchronization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeShareSynchronization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ShareSynchronization>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ShareSynchronization IModelSerializable<ShareSynchronization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeShareSynchronization(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ShareSynchronization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ShareSynchronization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeShareSynchronization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
