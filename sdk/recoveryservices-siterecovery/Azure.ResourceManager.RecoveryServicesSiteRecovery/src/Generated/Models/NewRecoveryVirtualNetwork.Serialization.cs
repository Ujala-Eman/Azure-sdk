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
    public partial class NewRecoveryVirtualNetwork : IUtf8JsonSerializable, IModelJsonSerializable<NewRecoveryVirtualNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NewRecoveryVirtualNetwork>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NewRecoveryVirtualNetwork>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NewRecoveryVirtualNetwork>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryVirtualNetworkResourceGroupName))
            {
                writer.WritePropertyName("recoveryVirtualNetworkResourceGroupName"u8);
                writer.WriteStringValue(RecoveryVirtualNetworkResourceGroupName);
            }
            if (Optional.IsDefined(RecoveryVirtualNetworkName))
            {
                writer.WritePropertyName("recoveryVirtualNetworkName"u8);
                writer.WriteStringValue(RecoveryVirtualNetworkName);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        internal static NewRecoveryVirtualNetwork DeserializeNewRecoveryVirtualNetwork(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryVirtualNetworkResourceGroupName = default;
            Optional<string> recoveryVirtualNetworkName = default;
            string resourceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryVirtualNetworkResourceGroupName"u8))
                {
                    recoveryVirtualNetworkResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryVirtualNetworkName"u8))
                {
                    recoveryVirtualNetworkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NewRecoveryVirtualNetwork(resourceType, recoveryVirtualNetworkResourceGroupName.Value, recoveryVirtualNetworkName.Value, rawData);
        }

        NewRecoveryVirtualNetwork IModelJsonSerializable<NewRecoveryVirtualNetwork>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NewRecoveryVirtualNetwork>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRecoveryVirtualNetwork(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NewRecoveryVirtualNetwork>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NewRecoveryVirtualNetwork>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NewRecoveryVirtualNetwork IModelSerializable<NewRecoveryVirtualNetwork>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NewRecoveryVirtualNetwork>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNewRecoveryVirtualNetwork(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NewRecoveryVirtualNetwork"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NewRecoveryVirtualNetwork"/> to convert. </param>
        public static implicit operator RequestContent(NewRecoveryVirtualNetwork model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NewRecoveryVirtualNetwork"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NewRecoveryVirtualNetwork(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNewRecoveryVirtualNetwork(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
