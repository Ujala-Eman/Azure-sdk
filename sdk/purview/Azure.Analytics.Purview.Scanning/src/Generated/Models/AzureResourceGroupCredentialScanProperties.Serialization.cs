// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class AzureResourceGroupCredentialScanProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes");
                writer.WriteObjectValue(ResourceTypes);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential");
                writer.WriteObjectValue(Credential);
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

        internal static AzureResourceGroupCredentialScanProperties DeserializeAzureResourceGroupCredentialScanProperties(JsonElement element)
        {
            Optional<ExpandingResourceScanPropertiesResourceTypes> resourceTypes = default;
            Optional<ExpandingResourceScanPropertiesCredential> credential = default;
            Optional<string> scanRulesetName = default;
            Optional<ScanRulesetType> scanRulesetType = default;
            Optional<ScanPropertiesCollection> collection = default;
            Optional<int> workers = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            Optional<ScanPropertiesConnectedVia> connectedVia = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceTypes = ExpandingResourceScanPropertiesResourceTypes.DeserializeExpandingResourceScanPropertiesResourceTypes(property.Value);
                    continue;
                }
                if (property.NameEquals("credential"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credential = ExpandingResourceScanPropertiesCredential.DeserializeExpandingResourceScanPropertiesCredential(property.Value);
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
            return new AzureResourceGroupCredentialScanProperties(scanRulesetName.Value, Optional.ToNullable(scanRulesetType), collection.Value, Optional.ToNullable(workers), Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedAt), connectedVia.Value, resourceTypes.Value, credential.Value);
        }
    }
}
