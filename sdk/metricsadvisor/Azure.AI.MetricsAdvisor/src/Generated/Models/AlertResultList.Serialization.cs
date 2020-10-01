// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AlertResultList
    {
        internal static AlertResultList DeserializeAlertResultList(JsonElement element)
        {
            string nextLink = default;
            IReadOnlyList<AlertResult> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<AlertResult> array = new List<AlertResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertResult.DeserializeAlertResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AlertResultList(nextLink, value);
        }
    }
}
