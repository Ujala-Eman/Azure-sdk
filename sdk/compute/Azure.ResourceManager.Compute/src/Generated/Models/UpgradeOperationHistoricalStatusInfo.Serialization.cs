// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UpgradeOperationHistoricalStatusInfo
    {
        internal static UpgradeOperationHistoricalStatusInfo DeserializeUpgradeOperationHistoricalStatusInfo(JsonElement element)
        {
            Optional<UpgradeOperationHistoricalStatusInfoProperties> properties = default;
            Optional<string> type = default;
            Optional<string> location = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    properties = UpgradeOperationHistoricalStatusInfoProperties.DeserializeUpgradeOperationHistoricalStatusInfoProperties(property.Value);
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
            }
            return new UpgradeOperationHistoricalStatusInfo(properties.HasValue ? properties.Value : null, type.HasValue ? type.Value : null, location.HasValue ? location.Value : null);
        }
    }
}
