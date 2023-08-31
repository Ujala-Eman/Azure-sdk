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

namespace Azure.ResourceManager.ServiceLinker.Models
{
    internal partial class LinkerSecretStore : IUtf8JsonSerializable, IModelJsonSerializable<LinkerSecretStore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkerSecretStore>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkerSecretStore>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultId))
            {
                if (KeyVaultId != null)
                {
                    writer.WritePropertyName("keyVaultId"u8);
                    writer.WriteStringValue(KeyVaultId);
                }
                else
                {
                    writer.WriteNull("keyVaultId");
                }
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

        internal static LinkerSecretStore DeserializeLinkerSecretStore(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> keyVaultId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyVaultId = null;
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkerSecretStore(keyVaultId.Value, rawData);
        }

        LinkerSecretStore IModelJsonSerializable<LinkerSecretStore>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkerSecretStore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkerSecretStore>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkerSecretStore IModelSerializable<LinkerSecretStore>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkerSecretStore(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkerSecretStore"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkerSecretStore"/> to convert. </param>
        public static implicit operator RequestContent(LinkerSecretStore model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkerSecretStore"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkerSecretStore(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkerSecretStore(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
