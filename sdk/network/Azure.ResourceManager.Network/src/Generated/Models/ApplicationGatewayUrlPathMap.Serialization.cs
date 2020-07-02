// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayUrlPathMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultBackendAddressPool))
            {
                writer.WritePropertyName("defaultBackendAddressPool");
                writer.WriteObjectValue(DefaultBackendAddressPool);
            }
            if (Optional.IsDefined(DefaultBackendHttpSettings))
            {
                writer.WritePropertyName("defaultBackendHttpSettings");
                writer.WriteObjectValue(DefaultBackendHttpSettings);
            }
            if (Optional.IsDefined(DefaultRewriteRuleSet))
            {
                writer.WritePropertyName("defaultRewriteRuleSet");
                writer.WriteObjectValue(DefaultRewriteRuleSet);
            }
            if (Optional.IsDefined(DefaultRedirectConfiguration))
            {
                writer.WritePropertyName("defaultRedirectConfiguration");
                writer.WriteObjectValue(DefaultRedirectConfiguration);
            }
            if (Optional.IsDefined(PathRules))
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayUrlPathMap DeserializeApplicationGatewayUrlPathMap(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<SubResource> defaultBackendAddressPool = default;
            Optional<SubResource> defaultBackendHttpSettings = default;
            Optional<SubResource> defaultRewriteRuleSet = default;
            Optional<SubResource> defaultRedirectConfiguration = default;
            Optional<IList<ApplicationGatewayPathRule>> pathRules = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultBackendAddressPool"))
                        {
                            defaultBackendAddressPool = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultBackendHttpSettings"))
                        {
                            defaultBackendHttpSettings = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRewriteRuleSet"))
                        {
                            defaultRewriteRuleSet = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultRedirectConfiguration"))
                        {
                            defaultRedirectConfiguration = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("pathRules"))
                        {
                            List<ApplicationGatewayPathRule> array = new List<ApplicationGatewayPathRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ApplicationGatewayPathRule.DeserializeApplicationGatewayPathRule(item));
                                }
                            }
                            pathRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayUrlPathMap(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, etag.HasValue ? etag.Value : null, type.HasValue ? type.Value : null, defaultBackendAddressPool.HasValue ? defaultBackendAddressPool.Value : null, defaultBackendHttpSettings.HasValue ? defaultBackendHttpSettings.Value : null, defaultRewriteRuleSet.HasValue ? defaultRewriteRuleSet.Value : null, defaultRedirectConfiguration.HasValue ? defaultRedirectConfiguration.Value : null, new ChangeTrackingList<ApplicationGatewayPathRule>(pathRules), provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
