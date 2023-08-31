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
    public partial class FabricSpecificDetails : IUtf8JsonSerializable, IModelJsonSerializable<FabricSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FabricSpecificDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FabricSpecificDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static FabricSpecificDetails DeserializeFabricSpecificDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Azure": return SiteRecoveryFabricProviderSpecificDetails.DeserializeSiteRecoveryFabricProviderSpecificDetails(element);
                    case "HyperVSite": return HyperVSiteDetails.DeserializeHyperVSiteDetails(element);
                    case "InMageRcm": return InMageRcmFabricSpecificDetails.DeserializeInMageRcmFabricSpecificDetails(element);
                    case "VMM": return VmmFabricDetails.DeserializeVmmFabricDetails(element);
                    case "VMware": return VMwareDetails.DeserializeVMwareDetails(element);
                    case "VMwareV2": return VMwareV2FabricSpecificDetails.DeserializeVMwareV2FabricSpecificDetails(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownFabricSpecificDetails(instanceType, rawData);
        }

        FabricSpecificDetails IModelJsonSerializable<FabricSpecificDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFabricSpecificDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FabricSpecificDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FabricSpecificDetails IModelSerializable<FabricSpecificDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFabricSpecificDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FabricSpecificDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FabricSpecificDetails"/> to convert. </param>
        public static implicit operator RequestContent(FabricSpecificDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FabricSpecificDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FabricSpecificDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFabricSpecificDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
