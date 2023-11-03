// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IntegrationSpaces.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IntegrationSpaces
{
    public partial class BusinessProcessData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(TrackingDataStoreReferenceName))
            {
                writer.WritePropertyName("trackingDataStoreReferenceName"u8);
                writer.WriteStringValue(TrackingDataStoreReferenceName);
            }
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteObjectValue(Identifier);
            }
            if (Optional.IsCollectionDefined(BusinessProcessStages))
            {
                writer.WritePropertyName("businessProcessStages"u8);
                writer.WriteStartObject();
                foreach (var item in BusinessProcessStages)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(BusinessProcessMapping))
            {
                writer.WritePropertyName("businessProcessMapping"u8);
                writer.WriteStartObject();
                foreach (var item in BusinessProcessMapping)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BusinessProcessData DeserializeBusinessProcessData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> version = default;
            Optional<string> description = default;
            Optional<string> tableName = default;
            Optional<string> trackingDataStoreReferenceName = default;
            Optional<BusinessProcessIdentifier> identifier = default;
            Optional<IDictionary<string, BusinessProcessStage>> businessProcessStages = default;
            Optional<IDictionary<string, BusinessProcessMappingItem>> businessProcessMapping = default;
            foreach (var property in element.EnumerateObject())
            {
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
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("trackingDataStoreReferenceName"u8))
                        {
                            trackingDataStoreReferenceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = BusinessProcessIdentifier.DeserializeBusinessProcessIdentifier(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("businessProcessStages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BusinessProcessStage> dictionary = new Dictionary<string, BusinessProcessStage>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BusinessProcessStage.DeserializeBusinessProcessStage(property1.Value));
                            }
                            businessProcessStages = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("businessProcessMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BusinessProcessMappingItem> dictionary = new Dictionary<string, BusinessProcessMappingItem>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BusinessProcessMappingItem.DeserializeBusinessProcessMappingItem(property1.Value));
                            }
                            businessProcessMapping = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BusinessProcessData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), version.Value, description.Value, tableName.Value, trackingDataStoreReferenceName.Value, identifier.Value, Optional.ToDictionary(businessProcessStages), Optional.ToDictionary(businessProcessMapping));
        }
    }
}
