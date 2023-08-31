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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterSubnet : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterSubnet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterSubnet>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterSubnet>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(IsIPv6Enabled))
            {
                writer.WritePropertyName("enableIpv6"u8);
                writer.WriteBooleanValue(IsIPv6Enabled.Value);
            }
            if (Optional.IsDefined(PrivateEndpointNetworkPolicies))
            {
                writer.WritePropertyName("privateEndpointNetworkPolicies"u8);
                writer.WriteStringValue(PrivateEndpointNetworkPolicies.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkServiceNetworkPolicies))
            {
                writer.WritePropertyName("privateLinkServiceNetworkPolicies"u8);
                writer.WriteStringValue(PrivateLinkServiceNetworkPolicies.Value.ToString());
            }
            if (Optional.IsDefined(NetworkSecurityGroupId))
            {
                writer.WritePropertyName("networkSecurityGroupId"u8);
                writer.WriteStringValue(NetworkSecurityGroupId);
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

        internal static ManagedClusterSubnet DeserializeManagedClusterSubnet(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<bool> enableIPv6 = default;
            Optional<ManagedClusterSubnetPrivateEndpointNetworkPoliciesState> privateEndpointNetworkPolicies = default;
            Optional<ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState> privateLinkServiceNetworkPolicies = default;
            Optional<ResourceIdentifier> networkSecurityGroupId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableIpv6"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableIPv6 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateEndpointNetworkPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpointNetworkPolicies = new ManagedClusterSubnetPrivateEndpointNetworkPoliciesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceNetworkPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceNetworkPolicies = new ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    networkSecurityGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterSubnet(name, Optional.ToNullable(enableIPv6), Optional.ToNullable(privateEndpointNetworkPolicies), Optional.ToNullable(privateLinkServiceNetworkPolicies), networkSecurityGroupId.Value, rawData);
        }

        ManagedClusterSubnet IModelJsonSerializable<ManagedClusterSubnet>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSubnet(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterSubnet>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterSubnet IModelSerializable<ManagedClusterSubnet>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterSubnet(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedClusterSubnet"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedClusterSubnet"/> to convert. </param>
        public static implicit operator RequestContent(ManagedClusterSubnet model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedClusterSubnet"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedClusterSubnet(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterSubnet(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
