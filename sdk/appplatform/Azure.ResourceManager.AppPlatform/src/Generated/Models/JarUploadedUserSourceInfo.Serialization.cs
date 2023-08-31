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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class JarUploadedUserSourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<JarUploadedUserSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JarUploadedUserSourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JarUploadedUserSourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JarUploadedUserSourceInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (Optional.IsDefined(JvmOptions))
            {
                writer.WritePropertyName("jvmOptions"u8);
                writer.WriteStringValue(JvmOptions);
            }
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UserSourceInfoType);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        internal static JarUploadedUserSourceInfo DeserializeJarUploadedUserSourceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runtimeVersion = default;
            Optional<string> jvmOptions = default;
            Optional<string> relativePath = default;
            string type = default;
            Optional<string> version = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jvmOptions"u8))
                {
                    jvmOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JarUploadedUserSourceInfo(type, version.Value, relativePath.Value, runtimeVersion.Value, jvmOptions.Value, rawData);
        }

        JarUploadedUserSourceInfo IModelJsonSerializable<JarUploadedUserSourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JarUploadedUserSourceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJarUploadedUserSourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JarUploadedUserSourceInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JarUploadedUserSourceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JarUploadedUserSourceInfo IModelSerializable<JarUploadedUserSourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JarUploadedUserSourceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJarUploadedUserSourceInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(JarUploadedUserSourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator JarUploadedUserSourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJarUploadedUserSourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
