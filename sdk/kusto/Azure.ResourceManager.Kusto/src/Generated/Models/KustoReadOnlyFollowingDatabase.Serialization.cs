// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoReadOnlyFollowingDatabase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HotCachePeriod))
            {
                writer.WritePropertyName("hotCachePeriod");
                writer.WriteStringValue(HotCachePeriod.Value, "P");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static KustoReadOnlyFollowingDatabase DeserializeKustoReadOnlyFollowingDatabase(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            KustoKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KustoProvisioningState> provisioningState = default;
            Optional<TimeSpan> softDeletePeriod = default;
            Optional<TimeSpan> hotCachePeriod = default;
            Optional<DatabaseStatistics> statistics = default;
            Optional<string> leaderClusterResourceId = default;
            Optional<string> attachedDatabaseConfigurationName = default;
            Optional<KustoDatabasePrincipalsModificationKind> principalsModificationKind = default;
            Optional<KustoDatabaseTableLevelSharingProperties> tableLevelSharingProperties = default;
            Optional<string> originalDatabaseName = default;
            Optional<KustoDatabaseShareOrigin> databaseShareOrigin = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new KustoKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new KustoProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("softDeletePeriod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            softDeletePeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("hotCachePeriod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hotCachePeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("statistics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            statistics = DatabaseStatistics.DeserializeDatabaseStatistics(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("leaderClusterResourceId"))
                        {
                            leaderClusterResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("attachedDatabaseConfigurationName"))
                        {
                            attachedDatabaseConfigurationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalsModificationKind"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            principalsModificationKind = new KustoDatabasePrincipalsModificationKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tableLevelSharingProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tableLevelSharingProperties = KustoDatabaseTableLevelSharingProperties.DeserializeKustoDatabaseTableLevelSharingProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("originalDatabaseName"))
                        {
                            originalDatabaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseShareOrigin"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            databaseShareOrigin = new KustoDatabaseShareOrigin(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new KustoReadOnlyFollowingDatabase(id, name, type, systemData.Value, Optional.ToNullable(location), kind, Optional.ToNullable(provisioningState), Optional.ToNullable(softDeletePeriod), Optional.ToNullable(hotCachePeriod), statistics.Value, leaderClusterResourceId.Value, attachedDatabaseConfigurationName.Value, Optional.ToNullable(principalsModificationKind), tableLevelSharingProperties.Value, originalDatabaseName.Value, Optional.ToNullable(databaseShareOrigin));
        }
    }
}
