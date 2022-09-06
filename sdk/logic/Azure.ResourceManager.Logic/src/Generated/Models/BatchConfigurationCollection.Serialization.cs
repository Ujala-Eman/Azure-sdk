// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class BatchConfigurationCollection
    {
        internal static BatchConfigurationCollection DeserializeBatchConfigurationCollection(JsonElement element)
        {
            Optional<IReadOnlyList<IntegrationAccountBatchConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IntegrationAccountBatchConfigurationData> array = new List<IntegrationAccountBatchConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationAccountBatchConfigurationData.DeserializeIntegrationAccountBatchConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BatchConfigurationCollection(Optional.ToList(value));
        }
    }
}
