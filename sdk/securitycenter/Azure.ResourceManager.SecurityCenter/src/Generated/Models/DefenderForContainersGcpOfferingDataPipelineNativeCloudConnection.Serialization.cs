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
    public partial class DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
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

        internal static DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceAccountEmailAddress = default;
            Optional<string> workloadIdentityProviderId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(serviceAccountEmailAddress.Value, workloadIdentityProviderId.Value, rawData);
        }

        DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection IModelJsonSerializable<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection IModelSerializable<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
