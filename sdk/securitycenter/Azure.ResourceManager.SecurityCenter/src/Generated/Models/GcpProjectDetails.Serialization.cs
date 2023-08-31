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
    public partial class GcpProjectDetails : IUtf8JsonSerializable, IModelJsonSerializable<GcpProjectDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GcpProjectDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GcpProjectDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ProjectNumber))
            {
                writer.WritePropertyName("projectNumber"u8);
                writer.WriteStringValue(ProjectNumber);
            }
            if (Optional.IsDefined(ProjectId))
            {
                writer.WritePropertyName("projectId"u8);
                writer.WriteStringValue(ProjectId);
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

        internal static GcpProjectDetails DeserializeGcpProjectDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> projectNumber = default;
            Optional<string> projectId = default;
            Optional<string> workloadIdentityPoolId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectNumber"u8))
                {
                    projectNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    projectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityPoolId"u8))
                {
                    workloadIdentityPoolId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GcpProjectDetails(projectNumber.Value, projectId.Value, workloadIdentityPoolId.Value, rawData);
        }

        GcpProjectDetails IModelJsonSerializable<GcpProjectDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpProjectDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GcpProjectDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GcpProjectDetails IModelSerializable<GcpProjectDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGcpProjectDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GcpProjectDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GcpProjectDetails"/> to convert. </param>
        public static implicit operator RequestContent(GcpProjectDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GcpProjectDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GcpProjectDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGcpProjectDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
