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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationDetails : IUtf8JsonSerializable, IModelJsonSerializable<ArmApplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArmApplicationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArmApplicationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("oid"u8);
                writer.WriteStringValue(ObjectId.Value);
            }
            if (Optional.IsDefined(Puid))
            {
                writer.WritePropertyName("puid"u8);
                writer.WriteStringValue(Puid);
            }
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId.Value);
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

        internal static ArmApplicationDetails DeserializeArmApplicationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> oid = default;
            Optional<string> puid = default;
            Optional<Guid> applicationId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("puid"u8))
                {
                    puid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ArmApplicationDetails(Optional.ToNullable(oid), puid.Value, Optional.ToNullable(applicationId), rawData);
        }

        ArmApplicationDetails IModelJsonSerializable<ArmApplicationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArmApplicationDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArmApplicationDetails IModelSerializable<ArmApplicationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArmApplicationDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ArmApplicationDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ArmApplicationDetails"/> to convert. </param>
        public static implicit operator RequestContent(ArmApplicationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ArmApplicationDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ArmApplicationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArmApplicationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
