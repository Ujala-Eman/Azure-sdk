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
    public partial class InMageAzureV2SwitchProviderContent : IUtf8JsonSerializable, IModelJsonSerializable<InMageAzureV2SwitchProviderContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageAzureV2SwitchProviderContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageAzureV2SwitchProviderContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageAzureV2SwitchProviderContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetVaultID"u8);
            writer.WriteStringValue(TargetVaultId);
            writer.WritePropertyName("targetFabricID"u8);
            writer.WriteStringValue(TargetFabricId);
            writer.WritePropertyName("targetApplianceID"u8);
            writer.WriteStringValue(TargetApplianceId);
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

        internal static InMageAzureV2SwitchProviderContent DeserializeInMageAzureV2SwitchProviderContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier targetVaultId = default;
            ResourceIdentifier targetFabricId = default;
            string targetApplianceId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetVaultID"u8))
                {
                    targetVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetFabricID"u8))
                {
                    targetFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetApplianceID"u8))
                {
                    targetApplianceId = property.Value.GetString();
                    continue;
                }
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
            return new InMageAzureV2SwitchProviderContent(instanceType, targetVaultId, targetFabricId, targetApplianceId, rawData);
        }

        InMageAzureV2SwitchProviderContent IModelJsonSerializable<InMageAzureV2SwitchProviderContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageAzureV2SwitchProviderContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAzureV2SwitchProviderContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageAzureV2SwitchProviderContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageAzureV2SwitchProviderContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageAzureV2SwitchProviderContent IModelSerializable<InMageAzureV2SwitchProviderContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageAzureV2SwitchProviderContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageAzureV2SwitchProviderContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InMageAzureV2SwitchProviderContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InMageAzureV2SwitchProviderContent"/> to convert. </param>
        public static implicit operator RequestContent(InMageAzureV2SwitchProviderContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InMageAzureV2SwitchProviderContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InMageAzureV2SwitchProviderContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageAzureV2SwitchProviderContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
