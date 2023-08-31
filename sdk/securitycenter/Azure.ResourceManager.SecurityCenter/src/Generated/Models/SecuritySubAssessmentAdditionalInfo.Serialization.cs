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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecuritySubAssessmentAdditionalInfo : IUtf8JsonSerializable, IModelJsonSerializable<SecuritySubAssessmentAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecuritySubAssessmentAdditionalInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecuritySubAssessmentAdditionalInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("assessedResourceType"u8);
            writer.WriteStringValue(AssessedResourceType.ToString());
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

        internal static SecuritySubAssessmentAdditionalInfo DeserializeSecuritySubAssessmentAdditionalInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("assessedResourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ContainerRegistryVulnerability": return ContainerRegistryVulnerabilityProperties.DeserializeContainerRegistryVulnerabilityProperties(element);
                    case "ServerVulnerabilityAssessment": return ServerVulnerabilityProperties.DeserializeServerVulnerabilityProperties(element);
                    case "SqlServerVulnerability": return SqlServerVulnerabilityProperties.DeserializeSqlServerVulnerabilityProperties(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            AssessedResourceType assessedResourceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assessedResourceType"u8))
                {
                    assessedResourceType = new AssessedResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownAdditionalData(assessedResourceType, rawData);
        }

        SecuritySubAssessmentAdditionalInfo IModelJsonSerializable<SecuritySubAssessmentAdditionalInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecuritySubAssessmentAdditionalInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecuritySubAssessmentAdditionalInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecuritySubAssessmentAdditionalInfo IModelSerializable<SecuritySubAssessmentAdditionalInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecuritySubAssessmentAdditionalInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecuritySubAssessmentAdditionalInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecuritySubAssessmentAdditionalInfo"/> to convert. </param>
        public static implicit operator RequestContent(SecuritySubAssessmentAdditionalInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecuritySubAssessmentAdditionalInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecuritySubAssessmentAdditionalInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecuritySubAssessmentAdditionalInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
