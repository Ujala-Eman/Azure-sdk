// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IntegrationSpaces;

namespace Azure.ResourceManager.IntegrationSpaces.Models
{
    internal partial class ApplicationListResult
    {
        internal static ApplicationListResult DeserializeApplicationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IntegrationSpaceApplicationData> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<IntegrationSpaceApplicationData> array = new List<IntegrationSpaceApplicationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationSpaceApplicationData.DeserializeIntegrationSpaceApplicationData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationListResult(value, nextLink.Value);
        }
    }
}
