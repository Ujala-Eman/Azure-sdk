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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class ArcPasswordCredential : IUtf8JsonSerializable, IModelJsonSerializable<ArcPasswordCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArcPasswordCredential>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArcPasswordCredential>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretText))
            {
                writer.WritePropertyName("secretText"u8);
                writer.WriteStringValue(SecretText);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
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

        internal static ArcPasswordCredential DeserializeArcPasswordCredential(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secretText = default;
            Optional<string> keyId = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> endDateTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretText"u8))
                {
                    secretText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyId"u8))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ArcPasswordCredential(secretText.Value, keyId.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(endDateTime), rawData);
        }

        ArcPasswordCredential IModelJsonSerializable<ArcPasswordCredential>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArcPasswordCredential(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArcPasswordCredential>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArcPasswordCredential IModelSerializable<ArcPasswordCredential>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArcPasswordCredential(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ArcPasswordCredential model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ArcPasswordCredential(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArcPasswordCredential(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
