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

namespace Azure.MixedReality.RemoteRendering
{
    public partial class RenderingSession : IUtf8JsonSerializable, IModelJsonSerializable<RenderingSession>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RenderingSession>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RenderingSession>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(SessionId);
            writer.WritePropertyName("size"u8);
            writer.WriteStringValue(Size.ToString());
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
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

        internal static RenderingSession DeserializeRenderingSession(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<int> arrInspectorPort = default;
            Optional<int> handshakePort = default;
            Optional<int> elapsedTimeMinutes = default;
            Optional<string> hostname = default;
            Optional<int> maxLeaseTimeMinutes = default;
            RenderingServerSize size = default;
            RenderingSessionStatus status = default;
            Optional<float> teraflops = default;
            Optional<RemoteRenderingServiceError> error = default;
            Optional<DateTimeOffset> creationTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arrInspectorPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arrInspectorPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("handshakePort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    handshakePort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("elapsedTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elapsedTimeMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLeaseTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLeaseTimeMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = new RenderingServerSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new RenderingSessionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("teraflops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    teraflops = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = RemoteRenderingServiceError.DeserializeRemoteRenderingServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RenderingSession(id, Optional.ToNullable(arrInspectorPort), Optional.ToNullable(handshakePort), Optional.ToNullable(elapsedTimeMinutes), hostname.Value, Optional.ToNullable(maxLeaseTimeMinutes), size, status, Optional.ToNullable(teraflops), error.Value, Optional.ToNullable(creationTime), rawData);
        }

        RenderingSession IModelJsonSerializable<RenderingSession>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRenderingSession(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RenderingSession>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RenderingSession IModelSerializable<RenderingSession>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRenderingSession(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RenderingSession"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RenderingSession"/> to convert. </param>
        public static implicit operator RequestContent(RenderingSession model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RenderingSession"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RenderingSession(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRenderingSession(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
