// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    public partial class DataLakeAnalyticsAccountData : IUtf8JsonSerializable, IJsonModel<DataLakeAnalyticsAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeAnalyticsAccountData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataLakeAnalyticsAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tags))
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
            if (options.Format != "W" && Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultDataLakeStoreAccount))
            {
                writer.WritePropertyName("defaultDataLakeStoreAccount"u8);
                writer.WriteStringValue(DefaultDataLakeStoreAccount);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DataLakeStoreAccounts))
            {
                writer.WritePropertyName("dataLakeStoreAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in DataLakeStoreAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PublicDataLakeStoreAccounts))
            {
                writer.WritePropertyName("publicDataLakeStoreAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in PublicDataLakeStoreAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ComputePolicies))
            {
                writer.WritePropertyName("computePolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ComputePolicies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HiveMetastores))
            {
                writer.WritePropertyName("hiveMetastores"u8);
                writer.WriteStartArray();
                foreach (var item in HiveMetastores)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState"u8);
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps"u8);
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentTier))
            {
                writer.WritePropertyName("currentTier"u8);
                writer.WriteStringValue(CurrentTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaxJobCount))
            {
                writer.WritePropertyName("maxJobCount"u8);
                writer.WriteNumberValue(MaxJobCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxActiveJobCountPerUser))
            {
                writer.WritePropertyName("maxActiveJobCountPerUser"u8);
                writer.WriteNumberValue(MaxActiveJobCountPerUser.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxQueuedJobCountPerUser))
            {
                writer.WritePropertyName("maxQueuedJobCountPerUser"u8);
                writer.WriteNumberValue(MaxQueuedJobCountPerUser.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxJobRunningTimeInMin))
            {
                writer.WritePropertyName("maxJobRunningTimeInMin"u8);
                writer.WriteNumberValue(MaxJobRunningTimeInMin.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemMaxJobCount))
            {
                writer.WritePropertyName("systemMaxJobCount"u8);
                writer.WriteNumberValue(SystemMaxJobCount.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelism))
            {
                writer.WritePropertyName("maxDegreeOfParallelism"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelism.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemMaxDegreeOfParallelism))
            {
                writer.WritePropertyName("systemMaxDegreeOfParallelism"u8);
                writer.WriteNumberValue(SystemMaxDegreeOfParallelism.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelismPerJob))
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MinPriorityPerJob))
            {
                writer.WritePropertyName("minPriorityPerJob"u8);
                writer.WriteNumberValue(MinPriorityPerJob.Value);
            }
            if (Optional.IsDefined(QueryStoreRetention))
            {
                writer.WritePropertyName("queryStoreRetention"u8);
                writer.WriteNumberValue(QueryStoreRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DebugDataAccessLevel))
            {
                writer.WritePropertyName("debugDataAccessLevel"u8);
                writer.WriteStringValue(DebugDataAccessLevel.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        DataLakeAnalyticsAccountData IJsonModel<DataLakeAnalyticsAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsAccountData(document.RootElement, options);
        }

        internal static DataLakeAnalyticsAccountData DeserializeDataLakeAnalyticsAccountData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? accountId = default;
            DataLakeAnalyticsAccountStatus? provisioningState = default;
            DataLakeAnalyticsAccountState? state = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? lastModifiedTime = default;
            string endpoint = default;
            string defaultDataLakeStoreAccount = default;
            IReadOnlyList<DataLakeStoreAccountInformationData> dataLakeStoreAccounts = default;
            IReadOnlyList<DataLakeStoreAccountInformationData> publicDataLakeStoreAccounts = default;
            IReadOnlyList<DataLakeAnalyticsStorageAccountInformationData> storageAccounts = default;
            IReadOnlyList<DataLakeAnalyticsComputePolicyData> computePolicies = default;
            IReadOnlyList<DataLakeAnalyticsHiveMetastore> hiveMetastores = default;
            IReadOnlyList<DataLakeAnalyticsVirtualNetworkRule> virtualNetworkRules = default;
            IReadOnlyList<DataLakeAnalyticsFirewallRuleData> firewallRules = default;
            DataLakeAnalyticsFirewallState? firewallState = default;
            DataLakeAnalyticsFirewallAllowAzureIPsState? firewallAllowAzureIPs = default;
            DataLakeAnalyticsCommitmentTierType? newTier = default;
            DataLakeAnalyticsCommitmentTierType? currentTier = default;
            int? maxJobCount = default;
            int? maxActiveJobCountPerUser = default;
            int? maxQueuedJobCountPerUser = default;
            int? maxJobRunningTimeInMin = default;
            int? systemMaxJobCount = default;
            int? maxDegreeOfParallelism = default;
            int? systemMaxDegreeOfParallelism = default;
            int? maxDegreeOfParallelismPerJob = default;
            int? minPriorityPerJob = default;
            int? queryStoreRetention = default;
            DebugDataAccessLevel? debugDataAccessLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("accountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToDataLakeAnalyticsAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToDataLakeAnalyticsAccountState();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultDataLakeStoreAccount"u8))
                        {
                            defaultDataLakeStoreAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeStoreAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item, options));
                            }
                            dataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("publicDataLakeStoreAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item, options));
                            }
                            publicDataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsStorageAccountInformationData> array = new List<DataLakeAnalyticsStorageAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsStorageAccountInformationData.DeserializeDataLakeAnalyticsStorageAccountInformationData(item, options));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("computePolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsComputePolicyData> array = new List<DataLakeAnalyticsComputePolicyData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsComputePolicyData.DeserializeDataLakeAnalyticsComputePolicyData(item, options));
                            }
                            computePolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("hiveMetastores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsHiveMetastore> array = new List<DataLakeAnalyticsHiveMetastore>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsHiveMetastore.DeserializeDataLakeAnalyticsHiveMetastore(item, options));
                            }
                            hiveMetastores = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsVirtualNetworkRule> array = new List<DataLakeAnalyticsVirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsVirtualNetworkRule.DeserializeDataLakeAnalyticsVirtualNetworkRule(item, options));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsFirewallRuleData> array = new List<DataLakeAnalyticsFirewallRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsFirewallRuleData.DeserializeDataLakeAnalyticsFirewallRuleData(item, options));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeAnalyticsFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeAnalyticsFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeAnalyticsCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("currentTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentTier = property0.Value.GetString().ToDataLakeAnalyticsCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("maxJobCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxActiveJobCountPerUser"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxActiveJobCountPerUser = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxQueuedJobCountPerUser"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxQueuedJobCountPerUser = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxJobRunningTimeInMin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxJobRunningTimeInMin = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("systemMaxJobCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemMaxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelism"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("systemMaxDegreeOfParallelism"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemMaxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelismPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelismPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minPriorityPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minPriorityPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("queryStoreRetention"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryStoreRetention = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("debugDataAccessLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            debugDataAccessLevel = property0.Value.GetString().ToDebugDataAccessLevel();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataLakeAnalyticsAccountData(
                id,
                name,
                type,
                systemData,
                accountId,
                provisioningState,
                state,
                creationTime,
                lastModifiedTime,
                endpoint,
                defaultDataLakeStoreAccount,
                dataLakeStoreAccounts ?? new ChangeTrackingList<DataLakeStoreAccountInformationData>(),
                publicDataLakeStoreAccounts ?? new ChangeTrackingList<DataLakeStoreAccountInformationData>(),
                storageAccounts ?? new ChangeTrackingList<DataLakeAnalyticsStorageAccountInformationData>(),
                computePolicies ?? new ChangeTrackingList<DataLakeAnalyticsComputePolicyData>(),
                hiveMetastores ?? new ChangeTrackingList<DataLakeAnalyticsHiveMetastore>(),
                virtualNetworkRules ?? new ChangeTrackingList<DataLakeAnalyticsVirtualNetworkRule>(),
                firewallRules ?? new ChangeTrackingList<DataLakeAnalyticsFirewallRuleData>(),
                firewallState,
                firewallAllowAzureIPs,
                newTier,
                currentTier,
                maxJobCount,
                maxActiveJobCountPerUser,
                maxQueuedJobCountPerUser,
                maxJobRunningTimeInMin,
                systemMaxJobCount,
                maxDegreeOfParallelism,
                systemMaxDegreeOfParallelism,
                maxDegreeOfParallelismPerJob,
                minPriorityPerJob,
                queryStoreRetention,
                debugDataAccessLevel,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeAnalyticsAccountData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountData)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeAnalyticsAccountData IPersistableModel<DataLakeAnalyticsAccountData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeAnalyticsAccountData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsAccountData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeAnalyticsAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
