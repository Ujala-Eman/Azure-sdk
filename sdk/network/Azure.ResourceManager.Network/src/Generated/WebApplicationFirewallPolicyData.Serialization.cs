// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class WebApplicationFirewallPolicyData : IUtf8JsonSerializable, IJsonModel<WebApplicationFirewallPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationFirewallPolicyData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebApplicationFirewallPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallPolicyData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
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
            if (PolicySettings != null)
            {
                writer.WritePropertyName("policySettings"u8);
                writer.WriteObjectValue(PolicySettings);
            }
            if (!(CustomRules is ChangeTrackingList<WebApplicationFirewallCustomRule> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("customRules"u8);
                writer.WriteStartArray();
                foreach (var item in CustomRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ApplicationGateways is ChangeTrackingList<ApplicationGatewayData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("applicationGateways"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationGateways)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ResourceState.HasValue)
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (ManagedRules != null)
            {
                writer.WritePropertyName("managedRules"u8);
                writer.WriteObjectValue(ManagedRules);
            }
            if (options.Format != "W" && !(HttpListeners is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("httpListeners"u8);
                writer.WriteStartArray();
                foreach (var item in HttpListeners)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(PathBasedRules is ChangeTrackingList<WritableSubResource> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("pathBasedRules"u8);
                writer.WriteStartArray();
                foreach (var item in PathBasedRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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

        WebApplicationFirewallPolicyData IJsonModel<WebApplicationFirewallPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallPolicyData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationFirewallPolicyData(document.RootElement, options);
        }

        internal static WebApplicationFirewallPolicyData DeserializeWebApplicationFirewallPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            PolicySettings policySettings = default;
            IList<WebApplicationFirewallCustomRule> customRules = default;
            IReadOnlyList<ApplicationGatewayData> applicationGateways = default;
            NetworkProvisioningState? provisioningState = default;
            WebApplicationFirewallPolicyResourceState? resourceState = default;
            ManagedRulesDefinition managedRules = default;
            IReadOnlyList<WritableSubResource> httpListeners = default;
            IReadOnlyList<WritableSubResource> pathBasedRules = default;
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
                        if (property0.NameEquals("policySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policySettings = PolicySettings.DeserializePolicySettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebApplicationFirewallCustomRule> array = new List<WebApplicationFirewallCustomRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebApplicationFirewallCustomRule.DeserializeWebApplicationFirewallCustomRule(item, options));
                            }
                            customRules = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationGateways"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationGatewayData> array = new List<ApplicationGatewayData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayData.DeserializeApplicationGatewayData(item, options));
                            }
                            applicationGateways = array;
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
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new WebApplicationFirewallPolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedRules = ManagedRulesDefinition.DeserializeManagedRulesDefinition(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("httpListeners"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            httpListeners = array;
                            continue;
                        }
                        if (property0.NameEquals("pathBasedRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            pathBasedRules = array;
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
            return new WebApplicationFirewallPolicyData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                etag,
                policySettings,
                customRules ?? new ChangeTrackingList<WebApplicationFirewallCustomRule>(),
                applicationGateways ?? new ChangeTrackingList<ApplicationGatewayData>(),
                provisioningState,
                resourceState,
                managedRules,
                httpListeners ?? new ChangeTrackingList<WritableSubResource>(),
                pathBasedRules ?? new ChangeTrackingList<WritableSubResource>());
        }

        BinaryData IPersistableModel<WebApplicationFirewallPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallPolicyData)} does not support '{options.Format}' format.");
            }
        }

        WebApplicationFirewallPolicyData IPersistableModel<WebApplicationFirewallPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebApplicationFirewallPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallPolicyData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationFirewallPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
