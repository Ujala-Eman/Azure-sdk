// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderStageDetails
    {
        internal static EdgeOrderStageDetails DeserializeEdgeOrderStageDetails(JsonElement element)
        {
            Optional<EdgeOrderStageStatus> stageStatus = default;
            Optional<EdgeOrderStageName> stageName = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> startTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stageStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stageStatus = new EdgeOrderStageStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stageName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    stageName = new EdgeOrderStageName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new EdgeOrderStageDetails(Optional.ToNullable(stageStatus), Optional.ToNullable(stageName), displayName.Value, Optional.ToNullable(startTime));
        }
    }
}
