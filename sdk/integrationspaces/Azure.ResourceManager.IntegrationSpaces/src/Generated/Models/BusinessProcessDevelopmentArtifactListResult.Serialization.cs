// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.ResourceManager.IntegrationSpaces.Models
{
    internal partial class BusinessProcessDevelopmentArtifactListResult
    {
        internal static BusinessProcessDevelopmentArtifactListResult DeserializeBusinessProcessDevelopmentArtifactListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<BusinessProcessDevelopmentArtifactResult> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<BusinessProcessDevelopmentArtifactResult> array = new List<BusinessProcessDevelopmentArtifactResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BusinessProcessDevelopmentArtifactResult.DeserializeBusinessProcessDevelopmentArtifactResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BusinessProcessDevelopmentArtifactListResult(value);
        }
    }
}
