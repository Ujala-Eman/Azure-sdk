// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    internal partial class DatadogAgreementResourceListResponse
    {
        internal static DatadogAgreementResourceListResponse DeserializeDatadogAgreementResourceListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DatadogAgreementResourceProperties>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatadogAgreementResourceProperties> array = new List<DatadogAgreementResourceProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatadogAgreementResourceProperties.DeserializeDatadogAgreementResourceProperties(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DatadogAgreementResourceListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
