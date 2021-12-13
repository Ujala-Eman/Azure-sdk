// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class TeradataScanRulesetPropertiesAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(ExcludedSystemClassifications))
            {
                writer.WritePropertyName("excludedSystemClassifications");
                writer.WriteStartArray();
                foreach (var item in ExcludedSystemClassifications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncludedCustomClassificationRuleNames))
            {
                writer.WritePropertyName("includedCustomClassificationRuleNames");
                writer.WriteStartArray();
                foreach (var item in IncludedCustomClassificationRuleNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static TeradataScanRulesetPropertiesAutoGenerated DeserializeTeradataScanRulesetPropertiesAutoGenerated(JsonElement element)
        {
            Optional<DateTimeOffset> createdAt = default;
            Optional<string> description = default;
            Optional<IList<string>> excludedSystemClassifications = default;
            Optional<IList<string>> includedCustomClassificationRuleNames = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedSystemClassifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedSystemClassifications = array;
                    continue;
                }
                if (property.NameEquals("includedCustomClassificationRuleNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedCustomClassificationRuleNames = array;
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
            }
            return new TeradataScanRulesetPropertiesAutoGenerated(Optional.ToNullable(createdAt), description.Value, Optional.ToList(excludedSystemClassifications), Optional.ToList(includedCustomClassificationRuleNames), Optional.ToNullable(lastModifiedAt));
        }
    }
}
