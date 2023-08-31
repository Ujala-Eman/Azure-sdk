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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    public partial class SignalRData : IUtf8JsonSerializable, IModelJsonSerializable<SignalRData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SignalRData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SignalRData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SignalRResourceSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
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
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls"u8);
                if (Tls is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SignalRTlsSettings>)Tls).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SignalRFeature>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LiveTraceConfiguration))
            {
                writer.WritePropertyName("liveTraceConfiguration"u8);
                if (LiveTraceConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SignalRLiveTraceConfiguration>)LiveTraceConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ResourceLogConfiguration))
            {
                writer.WritePropertyName("resourceLogConfiguration"u8);
                if (ResourceLogConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SignalRResourceLogCategoryListResult>)ResourceLogConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Cors))
            {
                writer.WritePropertyName("cors"u8);
                if (Cors is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SignalRCorsSettings>)Cors).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Upstream))
            {
                writer.WritePropertyName("upstream"u8);
                if (Upstream is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ServerlessUpstreamSettings>)Upstream).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(NetworkACLs))
            {
                writer.WritePropertyName("networkACLs"u8);
                if (NetworkACLs is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SignalRNetworkAcls>)NetworkACLs).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(DisableAadAuth))
            {
                writer.WritePropertyName("disableAadAuth"u8);
                writer.WriteBooleanValue(DisableAadAuth.Value);
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

        internal static SignalRData DeserializeSignalRData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SignalRResourceSku> sku = default;
            Optional<SignalRServiceKind> kind = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SignalRProvisioningState> provisioningState = default;
            Optional<string> externalIP = default;
            Optional<string> hostName = default;
            Optional<int> publicPort = default;
            Optional<int> serverPort = default;
            Optional<string> version = default;
            Optional<IReadOnlyList<SignalRPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<IReadOnlyList<SignalRSharedPrivateLinkResourceData>> sharedPrivateLinkResources = default;
            Optional<SignalRTlsSettings> tls = default;
            Optional<string> hostNamePrefix = default;
            Optional<IList<SignalRFeature>> features = default;
            Optional<SignalRLiveTraceConfiguration> liveTraceConfiguration = default;
            Optional<SignalRResourceLogCategoryListResult> resourceLogConfiguration = default;
            Optional<SignalRCorsSettings> cors = default;
            Optional<ServerlessUpstreamSettings> upstream = default;
            Optional<SignalRNetworkAcls> networkACLs = default;
            Optional<string> publicNetworkAccess = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> disableAadAuth = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SignalRResourceSku.DeserializeSignalRResourceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new SignalRServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SignalRProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("externalIP"u8))
                        {
                            externalIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SignalRPrivateEndpointConnectionData> array = new List<SignalRPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SignalRPrivateEndpointConnectionData.DeserializeSignalRPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SignalRSharedPrivateLinkResourceData> array = new List<SignalRSharedPrivateLinkResourceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SignalRSharedPrivateLinkResourceData.DeserializeSignalRSharedPrivateLinkResourceData(item));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                        if (property0.NameEquals("tls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tls = SignalRTlsSettings.DeserializeSignalRTlsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostNamePrefix"u8))
                        {
                            hostNamePrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("features"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SignalRFeature> array = new List<SignalRFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SignalRFeature.DeserializeSignalRFeature(item));
                            }
                            features = array;
                            continue;
                        }
                        if (property0.NameEquals("liveTraceConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            liveTraceConfiguration = SignalRLiveTraceConfiguration.DeserializeSignalRLiveTraceConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceLogConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceLogConfiguration = SignalRResourceLogCategoryListResult.DeserializeSignalRResourceLogCategoryListResult(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cors = SignalRCorsSettings.DeserializeSignalRCorsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upstream"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upstream = ServerlessUpstreamSettings.DeserializeServerlessUpstreamSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkACLs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkACLs = SignalRNetworkAcls.DeserializeSignalRNetworkAcls(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableAadAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableAadAuth = property0.Value.GetBoolean();
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
            return new SignalRData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, Optional.ToNullable(kind), identity, Optional.ToNullable(provisioningState), externalIP.Value, hostName.Value, Optional.ToNullable(publicPort), Optional.ToNullable(serverPort), version.Value, Optional.ToList(privateEndpointConnections), Optional.ToList(sharedPrivateLinkResources), tls.Value, hostNamePrefix.Value, Optional.ToList(features), liveTraceConfiguration.Value, resourceLogConfiguration.Value, cors.Value, upstream.Value, networkACLs.Value, publicNetworkAccess.Value, Optional.ToNullable(disableLocalAuth), Optional.ToNullable(disableAadAuth), rawData);
        }

        SignalRData IModelJsonSerializable<SignalRData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SignalRData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SignalRData IModelSerializable<SignalRData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSignalRData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SignalRData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SignalRData"/> to convert. </param>
        public static implicit operator RequestContent(SignalRData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SignalRData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SignalRData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSignalRData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
