// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            writer.WritePropertyName("firewallMode");
            writer.WriteStringValue(FirewallMode.ToString());
            writer.WritePropertyName("ruleSetType");
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion");
            writer.WriteStringValue(RuleSetVersion);
            if (Optional.IsDefined(DisabledRuleGroups))
            {
                writer.WritePropertyName("disabledRuleGroups");
                writer.WriteStartArray();
                foreach (var item in DisabledRuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestBodyCheck))
            {
                writer.WritePropertyName("requestBodyCheck");
                writer.WriteBooleanValue(RequestBodyCheck.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySize))
            {
                writer.WritePropertyName("maxRequestBodySize");
                writer.WriteNumberValue(MaxRequestBodySize.Value);
            }
            if (Optional.IsDefined(MaxRequestBodySizeInKb))
            {
                writer.WritePropertyName("maxRequestBodySizeInKb");
                writer.WriteNumberValue(MaxRequestBodySizeInKb.Value);
            }
            if (Optional.IsDefined(FileUploadLimitInMb))
            {
                writer.WritePropertyName("fileUploadLimitInMb");
                writer.WriteNumberValue(FileUploadLimitInMb.Value);
            }
            if (Optional.IsDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions");
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayWebApplicationFirewallConfiguration DeserializeApplicationGatewayWebApplicationFirewallConfiguration(JsonElement element)
        {
            bool enabled = default;
            ApplicationGatewayFirewallMode firewallMode = default;
            string ruleSetType = default;
            string ruleSetVersion = default;
            Optional<IList<ApplicationGatewayFirewallDisabledRuleGroup>> disabledRuleGroups = default;
            Optional<bool> requestBodyCheck = default;
            Optional<int> maxRequestBodySize = default;
            Optional<int> maxRequestBodySizeInKb = default;
            Optional<int> fileUploadLimitInMb = default;
            Optional<IList<ApplicationGatewayFirewallExclusion>> exclusions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("firewallMode"))
                {
                    firewallMode = new ApplicationGatewayFirewallMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSetType"))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disabledRuleGroups"))
                {
                    List<ApplicationGatewayFirewallDisabledRuleGroup> array = new List<ApplicationGatewayFirewallDisabledRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApplicationGatewayFirewallDisabledRuleGroup.DeserializeApplicationGatewayFirewallDisabledRuleGroup(item));
                        }
                    }
                    disabledRuleGroups = array;
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"))
                {
                    requestBodyCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySize"))
                {
                    maxRequestBodySize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySizeInKb"))
                {
                    maxRequestBodySizeInKb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileUploadLimitInMb"))
                {
                    fileUploadLimitInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exclusions"))
                {
                    List<ApplicationGatewayFirewallExclusion> array = new List<ApplicationGatewayFirewallExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApplicationGatewayFirewallExclusion.DeserializeApplicationGatewayFirewallExclusion(item));
                        }
                    }
                    exclusions = array;
                    continue;
                }
            }
            return new ApplicationGatewayWebApplicationFirewallConfiguration(enabled, firewallMode, ruleSetType, ruleSetVersion, new ChangeTrackingList<ApplicationGatewayFirewallDisabledRuleGroup>(disabledRuleGroups), requestBodyCheck.HasValue ? requestBodyCheck.Value : (bool?)null, maxRequestBodySize.HasValue ? maxRequestBodySize.Value : (int?)null, maxRequestBodySizeInKb.HasValue ? maxRequestBodySizeInKb.Value : (int?)null, fileUploadLimitInMb.HasValue ? fileUploadLimitInMb.Value : (int?)null, new ChangeTrackingList<ApplicationGatewayFirewallExclusion>(exclusions));
        }
    }
}
