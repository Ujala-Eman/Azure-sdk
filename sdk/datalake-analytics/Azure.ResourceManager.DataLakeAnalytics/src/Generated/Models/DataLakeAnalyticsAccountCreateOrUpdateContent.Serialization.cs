// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsAccountCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
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
            writer.WritePropertyName("defaultDataLakeStoreAccount");
            writer.WriteStringValue(DefaultDataLakeStoreAccount);
            writer.WritePropertyName("dataLakeStoreAccounts");
            writer.WriteStartArray();
            foreach (var item in DataLakeStoreAccounts)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts");
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ComputePolicies))
            {
                writer.WritePropertyName("computePolicies");
                writer.WriteStartArray();
                foreach (var item in ComputePolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules");
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState");
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps");
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier");
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaxJobCount))
            {
                writer.WritePropertyName("maxJobCount");
                writer.WriteNumberValue(MaxJobCount.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelism))
            {
                writer.WritePropertyName("maxDegreeOfParallelism");
                writer.WriteNumberValue(MaxDegreeOfParallelism.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelismPerJob))
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob");
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (Optional.IsDefined(MinPriorityPerJob))
            {
                writer.WritePropertyName("minPriorityPerJob");
                writer.WriteNumberValue(MinPriorityPerJob.Value);
            }
            if (Optional.IsDefined(QueryStoreRetention))
            {
                writer.WritePropertyName("queryStoreRetention");
                writer.WriteNumberValue(QueryStoreRetention.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
