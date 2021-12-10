// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class PowerBIMsiScanProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IncludePersonalWorkspaces))
            {
                writer.WritePropertyName("includePersonalWorkspaces");
                writer.WriteBooleanValue(IncludePersonalWorkspaces.Value);
            }
            if (Optional.IsDefined(ScanRulesetName))
            {
                writer.WritePropertyName("scanRulesetName");
                writer.WriteStringValue(ScanRulesetName);
            }
            if (Optional.IsDefined(ScanRulesetType))
            {
                writer.WritePropertyName("scanRulesetType");
                writer.WriteStringValue(ScanRulesetType.Value.ToString());
            }
            if (Optional.IsDefined(Collection))
            {
                writer.WritePropertyName("collection");
                writer.WriteObjectValue(Collection);
            }
            if (Optional.IsDefined(Workers))
            {
                writer.WritePropertyName("workers");
                writer.WriteNumberValue(Workers.Value);
            }
            if (Optional.IsDefined(ConnectedVia))
            {
                writer.WritePropertyName("connectedVia");
                writer.WriteObjectValue(ConnectedVia);
            }
            writer.WriteEndObject();
        }

        internal static PowerBIMsiScanProperties DeserializePowerBIMsiScanProperties(JsonElement element)
        {
            Optional<bool> includePersonalWorkspaces = default;
            Optional<string> scanRulesetName = default;
            Optional<ScanRulesetType> scanRulesetType = default;
            Optional<ScanPropertiesCollection> collection = default;
            Optional<int> workers = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            Optional<ScanPropertiesConnectedVia> connectedVia = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includePersonalWorkspaces"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includePersonalWorkspaces = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scanRulesetName"))
                {
                    scanRulesetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scanRulesetType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scanRulesetType = new ScanRulesetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("collection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    collection = ScanPropertiesCollection.DeserializeScanPropertiesCollection(property.Value);
                    continue;
                }
                if (property.NameEquals("workers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectedVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectedVia = ScanPropertiesConnectedVia.DeserializeScanPropertiesConnectedVia(property.Value);
                    continue;
                }
            }
            return new PowerBIMsiScanProperties(scanRulesetName.Value, Optional.ToNullable(scanRulesetType), collection.Value, Optional.ToNullable(workers), Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedAt), connectedVia.Value, Optional.ToNullable(includePersonalWorkspaces));
        }
    }
}
