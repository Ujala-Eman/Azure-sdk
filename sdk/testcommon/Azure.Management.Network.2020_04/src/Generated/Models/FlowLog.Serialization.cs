// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class FlowLog : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId");
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(StorageId))
            {
                writer.WritePropertyName("storageId");
                writer.WriteStringValue(StorageId);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy");
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteObjectValue(Format);
            }
            if (Optional.IsDefined(FlowAnalyticsConfiguration))
            {
                writer.WritePropertyName("flowAnalyticsConfiguration");
                writer.WriteObjectValue(FlowAnalyticsConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FlowLog DeserializeFlowLog(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> targetResourceId = default;
            Optional<string> targetResourceGuid = default;
            Optional<string> storageId = default;
            Optional<bool> enabled = default;
            Optional<RetentionPolicyParameters> retentionPolicy = default;
            Optional<FlowLogFormatParameters> format = default;
            Optional<TrafficAnalyticsProperties> flowAnalyticsConfiguration = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetResourceId"))
                        {
                            targetResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceGuid"))
                        {
                            targetResourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageId"))
                        {
                            storageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("retentionPolicy"))
                        {
                            retentionPolicy = RetentionPolicyParameters.DeserializeRetentionPolicyParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("format"))
                        {
                            format = FlowLogFormatParameters.DeserializeFlowLogFormatParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("flowAnalyticsConfiguration"))
                        {
                            flowAnalyticsConfiguration = TrafficAnalyticsProperties.DeserializeTrafficAnalyticsProperties(property0.Value);
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
            return new FlowLog(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, targetResourceId.Value, targetResourceGuid.Value, storageId.Value, Optional.ToNullable(enabled), retentionPolicy.Value, format.Value, flowAnalyticsConfiguration.Value, Optional.ToNullable(provisioningState));
        }
    }
}
