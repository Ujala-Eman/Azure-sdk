// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxBatchInstancePercent))
            {
                writer.WritePropertyName("maxBatchInstancePercent");
                writer.WriteNumberValue(MaxBatchInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyInstancePercent");
                writer.WriteNumberValue(MaxUnhealthyInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyUpgradedInstancePercent");
                writer.WriteNumberValue(MaxUnhealthyUpgradedInstancePercent.Value);
            }
            if (Optional.IsDefined(PauseTimeBetweenBatches))
            {
                writer.WritePropertyName("pauseTimeBetweenBatches");
                writer.WriteStringValue(PauseTimeBetweenBatches);
            }
            writer.WriteEndObject();
        }

        internal static RollingUpgradePolicy DeserializeRollingUpgradePolicy(JsonElement element)
        {
            Optional<int> maxBatchInstancePercent = default;
            Optional<int> maxUnhealthyInstancePercent = default;
            Optional<int> maxUnhealthyUpgradedInstancePercent = default;
            Optional<string> pauseTimeBetweenBatches = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxBatchInstancePercent"))
                {
                    maxBatchInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyInstancePercent"))
                {
                    maxUnhealthyInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyUpgradedInstancePercent"))
                {
                    maxUnhealthyUpgradedInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pauseTimeBetweenBatches"))
                {
                    pauseTimeBetweenBatches = property.Value.GetString();
                    continue;
                }
            }
            return new RollingUpgradePolicy(maxBatchInstancePercent.HasValue ? maxBatchInstancePercent.Value : (int?)null, maxUnhealthyInstancePercent.HasValue ? maxUnhealthyInstancePercent.Value : (int?)null, maxUnhealthyUpgradedInstancePercent.HasValue ? maxUnhealthyUpgradedInstancePercent.Value : (int?)null, pauseTimeBetweenBatches.HasValue ? pauseTimeBetweenBatches.Value : null);
        }
    }
}
