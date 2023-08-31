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
    internal partial class ConfigurationServiceGitProperty : IUtf8JsonSerializable, IModelJsonSerializable<ConfigurationServiceGitProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConfigurationServiceGitProperty>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConfigurationServiceGitProperty>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ConfigurationServiceGitRepositories))
            {
                writer.WritePropertyName("repositories"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationServiceGitRepositories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static ConfigurationServiceGitProperty DeserializeConfigurationServiceGitProperty(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AppPlatformConfigurationServiceGitRepository>> repositories = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repositories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformConfigurationServiceGitRepository> array = new List<AppPlatformConfigurationServiceGitRepository>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformConfigurationServiceGitRepository.DeserializeAppPlatformConfigurationServiceGitRepository(item));
                    }
                    repositories = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConfigurationServiceGitProperty(Optional.ToList(repositories), rawData);
        }

        ConfigurationServiceGitProperty IModelJsonSerializable<ConfigurationServiceGitProperty>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationServiceGitProperty(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConfigurationServiceGitProperty>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConfigurationServiceGitProperty IModelSerializable<ConfigurationServiceGitProperty>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConfigurationServiceGitProperty(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ConfigurationServiceGitProperty model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ConfigurationServiceGitProperty(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConfigurationServiceGitProperty(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
