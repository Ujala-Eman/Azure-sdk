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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class CdnEndpointData : IUtf8JsonSerializable, IModelJsonSerializable<CdnEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CdnEndpointData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CdnEndpointData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath"u8);
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(ContentTypesToCompress))
            {
                writer.WritePropertyName("contentTypesToCompress"u8);
                writer.WriteStartArray();
                foreach (var item in ContentTypesToCompress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(IsCompressionEnabled))
            {
                writer.WritePropertyName("isCompressionEnabled"u8);
                writer.WriteBooleanValue(IsCompressionEnabled.Value);
            }
            if (Optional.IsDefined(IsHttpAllowed))
            {
                writer.WritePropertyName("isHttpAllowed"u8);
                writer.WriteBooleanValue(IsHttpAllowed.Value);
            }
            if (Optional.IsDefined(IsHttpsAllowed))
            {
                writer.WritePropertyName("isHttpsAllowed"u8);
                writer.WriteBooleanValue(IsHttpsAllowed.Value);
            }
            if (Optional.IsDefined(QueryStringCachingBehavior))
            {
                writer.WritePropertyName("queryStringCachingBehavior"u8);
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToSerialString());
            }
            if (Optional.IsDefined(OptimizationType))
            {
                if (OptimizationType != null)
                {
                    writer.WritePropertyName("optimizationType"u8);
                    writer.WriteStringValue(OptimizationType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("optimizationType");
                }
            }
            if (Optional.IsDefined(ProbePath))
            {
                writer.WritePropertyName("probePath"u8);
                writer.WriteStringValue(ProbePath);
            }
            if (Optional.IsCollectionDefined(GeoFilters))
            {
                writer.WritePropertyName("geoFilters"u8);
                writer.WriteStartArray();
                foreach (var item in GeoFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultOriginGroup))
            {
                if (DefaultOriginGroup != null)
                {
                    writer.WritePropertyName("defaultOriginGroup"u8);
                    writer.WriteObjectValue(DefaultOriginGroup);
                }
                else
                {
                    writer.WriteNull("defaultOriginGroup");
                }
            }
            if (Optional.IsCollectionDefined(UriSigningKeys))
            {
                if (UriSigningKeys != null)
                {
                    writer.WritePropertyName("urlSigningKeys"u8);
                    writer.WriteStartArray();
                    foreach (var item in UriSigningKeys)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("urlSigningKeys");
                }
            }
            if (Optional.IsDefined(DeliveryPolicy))
            {
                if (DeliveryPolicy != null)
                {
                    writer.WritePropertyName("deliveryPolicy"u8);
                    writer.WriteObjectValue(DeliveryPolicy);
                }
                else
                {
                    writer.WriteNull("deliveryPolicy");
                }
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                if (WebApplicationFirewallPolicyLink != null)
                {
                    writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                    writer.WriteObjectValue(WebApplicationFirewallPolicyLink);
                }
                else
                {
                    writer.WriteNull("webApplicationFirewallPolicyLink");
                }
            }
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OriginGroups))
            {
                writer.WritePropertyName("originGroups"u8);
                writer.WriteStartArray();
                foreach (var item in OriginGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static CdnEndpointData DeserializeCdnEndpointData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> originPath = default;
            Optional<IList<string>> contentTypesToCompress = default;
            Optional<string> originHostHeader = default;
            Optional<bool> isCompressionEnabled = default;
            Optional<bool> isHttpAllowed = default;
            Optional<bool> isHttpsAllowed = default;
            Optional<QueryStringCachingBehavior> queryStringCachingBehavior = default;
            Optional<OptimizationType?> optimizationType = default;
            Optional<string> probePath = default;
            Optional<IList<GeoFilter>> geoFilters = default;
            Optional<EndpointPropertiesUpdateParametersDefaultOriginGroup> defaultOriginGroup = default;
            Optional<IList<UriSigningKey>> uriSigningKeys = default;
            Optional<EndpointDeliveryPolicy> deliveryPolicy = default;
            Optional<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink> webApplicationFirewallPolicyLink = default;
            Optional<string> hostName = default;
            Optional<IList<DeepCreatedOrigin>> origins = default;
            Optional<IList<DeepCreatedOriginGroup>> originGroups = default;
            Optional<IReadOnlyList<CdnCustomDomainData>> customDomains = default;
            Optional<EndpointResourceState> resourceState = default;
            Optional<CdnEndpointProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("originPath"u8))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentTypesToCompress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            contentTypesToCompress = array;
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCompressionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCompressionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHttpAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpsAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHttpsAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queryStringCachingBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryStringCachingBehavior = property0.Value.GetString().ToQueryStringCachingBehavior();
                            continue;
                        }
                        if (property0.NameEquals("optimizationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                optimizationType = null;
                                continue;
                            }
                            optimizationType = new OptimizationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("probePath"u8))
                        {
                            probePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geoFilters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GeoFilter> array = new List<GeoFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GeoFilter.DeserializeGeoFilter(item));
                            }
                            geoFilters = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultOriginGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                defaultOriginGroup = null;
                                continue;
                            }
                            defaultOriginGroup = EndpointPropertiesUpdateParametersDefaultOriginGroup.DeserializeEndpointPropertiesUpdateParametersDefaultOriginGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("urlSigningKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uriSigningKeys = null;
                                continue;
                            }
                            List<UriSigningKey> array = new List<UriSigningKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UriSigningKey.DeserializeUriSigningKey(item));
                            }
                            uriSigningKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("deliveryPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                deliveryPolicy = null;
                                continue;
                            }
                            deliveryPolicy = EndpointDeliveryPolicy.DeserializeEndpointDeliveryPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                webApplicationFirewallPolicyLink = null;
                                continue;
                            }
                            webApplicationFirewallPolicyLink = EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("origins"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeepCreatedOrigin> array = new List<DeepCreatedOrigin>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeepCreatedOrigin.DeserializeDeepCreatedOrigin(item));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("originGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeepCreatedOriginGroup> array = new List<DeepCreatedOriginGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeepCreatedOriginGroup.DeserializeDeepCreatedOriginGroup(item));
                            }
                            originGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("customDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CdnCustomDomainData> array = new List<CdnCustomDomainData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CdnCustomDomainData.DeserializeCdnCustomDomainData(item));
                            }
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new EndpointResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new CdnEndpointProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CdnEndpointData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, originPath.Value, Optional.ToList(contentTypesToCompress), originHostHeader.Value, Optional.ToNullable(isCompressionEnabled), Optional.ToNullable(isHttpAllowed), Optional.ToNullable(isHttpsAllowed), Optional.ToNullable(queryStringCachingBehavior), Optional.ToNullable(optimizationType), probePath.Value, Optional.ToList(geoFilters), defaultOriginGroup.Value, Optional.ToList(uriSigningKeys), deliveryPolicy.Value, webApplicationFirewallPolicyLink.Value, hostName.Value, Optional.ToList(origins), Optional.ToList(originGroups), Optional.ToList(customDomains), Optional.ToNullable(resourceState), Optional.ToNullable(provisioningState), rawData);
        }

        CdnEndpointData IModelJsonSerializable<CdnEndpointData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnEndpointData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CdnEndpointData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CdnEndpointData IModelSerializable<CdnEndpointData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCdnEndpointData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CdnEndpointData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CdnEndpointData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCdnEndpointData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
