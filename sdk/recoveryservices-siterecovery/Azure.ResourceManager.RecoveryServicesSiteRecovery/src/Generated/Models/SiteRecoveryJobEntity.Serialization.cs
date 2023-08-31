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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobEntity : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryJobEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryJobEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryJobEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsDefined(JobFriendlyName))
            {
                writer.WritePropertyName("jobFriendlyName"u8);
                writer.WriteStringValue(JobFriendlyName);
            }
            if (Optional.IsDefined(TargetObjectId))
            {
                writer.WritePropertyName("targetObjectId"u8);
                writer.WriteStringValue(TargetObjectId);
            }
            if (Optional.IsDefined(TargetObjectName))
            {
                writer.WritePropertyName("targetObjectName"u8);
                writer.WriteStringValue(TargetObjectName);
            }
            if (Optional.IsDefined(TargetInstanceType))
            {
                writer.WritePropertyName("targetInstanceType"u8);
                writer.WriteStringValue(TargetInstanceType);
            }
            if (Optional.IsDefined(JobScenarioName))
            {
                writer.WritePropertyName("jobScenarioName"u8);
                writer.WriteStringValue(JobScenarioName);
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

        internal static SiteRecoveryJobEntity DeserializeSiteRecoveryJobEntity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> jobId = default;
            Optional<string> jobFriendlyName = default;
            Optional<string> targetObjectId = default;
            Optional<string> targetObjectName = default;
            Optional<string> targetInstanceType = default;
            Optional<string> jobScenarioName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobFriendlyName"u8))
                {
                    jobFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetObjectId"u8))
                {
                    targetObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetObjectName"u8))
                {
                    targetObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetInstanceType"u8))
                {
                    targetInstanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobScenarioName"u8))
                {
                    jobScenarioName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryJobEntity(jobId.Value, jobFriendlyName.Value, targetObjectId.Value, targetObjectName.Value, targetInstanceType.Value, jobScenarioName.Value, rawData);
        }

        SiteRecoveryJobEntity IModelJsonSerializable<SiteRecoveryJobEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryJobEntity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryJobEntity IModelSerializable<SiteRecoveryJobEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryJobEntity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryJobEntity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryJobEntity"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryJobEntity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryJobEntity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryJobEntity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryJobEntity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
