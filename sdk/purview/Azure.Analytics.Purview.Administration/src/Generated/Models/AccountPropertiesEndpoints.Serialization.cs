// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Administration.Models
{
    public partial class AccountPropertiesEndpoints
    {
        internal static AccountPropertiesEndpoints DeserializeAccountPropertiesEndpoints(JsonElement element)
        {
            Optional<string> catalog = default;
            Optional<string> guardian = default;
            Optional<string> scan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalog"))
                {
                    catalog = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guardian"))
                {
                    guardian = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scan"))
                {
                    scan = property.Value.GetString();
                    continue;
                }
            }
            return new AccountPropertiesEndpoints(catalog.Value, guardian.Value, scan.Value);
        }
    }
}
