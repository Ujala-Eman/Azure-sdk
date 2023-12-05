// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnSiteData : IUtf8JsonSerializable, IJsonModel<VpnSiteData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnSiteData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnSiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnSiteData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VpnSiteData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan"u8);
                JsonSerializer.Serialize(writer, VirtualWan);
            }
            if (Optional.IsDefined(DeviceProperties))
            {
                writer.WritePropertyName("deviceProperties"u8);
                writer.WriteObjectValue(DeviceProperties);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(SiteKey))
            {
                writer.WritePropertyName("siteKey"u8);
                writer.WriteStringValue(SiteKey);
            }
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace"u8);
                writer.WriteObjectValue(AddressSpace);
            }
            if (Optional.IsDefined(BgpProperties))
            {
                writer.WritePropertyName("bgpProperties"u8);
                writer.WriteObjectValue(BgpProperties);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(IsSecuritySite))
            {
                writer.WritePropertyName("isSecuritySite"u8);
                writer.WriteBooleanValue(IsSecuritySite.Value);
            }
            if (Optional.IsCollectionDefined(VpnSiteLinks))
            {
                writer.WritePropertyName("vpnSiteLinks"u8);
                writer.WriteStartArray();
                foreach (var item in VpnSiteLinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(O365Policy))
            {
                writer.WritePropertyName("o365Policy"u8);
                writer.WriteObjectValue(O365Policy);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VpnSiteData IJsonModel<VpnSiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnSiteData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VpnSiteData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnSiteData(document.RootElement, options);
        }

        internal static VpnSiteData DeserializeVpnSiteData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualWan = default;
            Optional<DeviceProperties> deviceProperties = default;
            Optional<string> ipAddress = default;
            Optional<string> siteKey = default;
            Optional<AddressSpace> addressSpace = default;
            Optional<BgpSettings> bgpProperties = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<bool> isSecuritySite = default;
            Optional<IList<VpnSiteLinkData>> vpnSiteLinks = default;
            Optional<O365PolicyProperties> o365Policy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualWan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("deviceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deviceProperties = DeviceProperties.DeserializeDeviceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("siteKey"u8))
                        {
                            siteKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressSpace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpProperties = BgpSettings.DeserializeBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isSecuritySite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSecuritySite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vpnSiteLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnSiteLinkData> array = new List<VpnSiteLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnSiteLinkData.DeserializeVpnSiteLinkData(item));
                            }
                            vpnSiteLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("o365Policy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            o365Policy = O365PolicyProperties.DeserializeO365PolicyProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnSiteData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), serializedAdditionalRawData, Optional.ToNullable(etag), virtualWan, deviceProperties.Value, ipAddress.Value, siteKey.Value, addressSpace.Value, bgpProperties.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(isSecuritySite), Optional.ToList(vpnSiteLinks), o365Policy.Value);
        }

        BinaryData IPersistableModel<VpnSiteData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnSiteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VpnSiteData)} does not support '{options.Format}' format.");
            }
        }

        VpnSiteData IPersistableModel<VpnSiteData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnSiteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnSiteData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VpnSiteData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnSiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
