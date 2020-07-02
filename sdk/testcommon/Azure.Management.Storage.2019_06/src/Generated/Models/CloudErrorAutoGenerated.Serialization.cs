// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    internal partial class CloudErrorAutoGenerated
    {
        internal static CloudErrorAutoGenerated DeserializeCloudErrorAutoGenerated(JsonElement element)
        {
            Optional<CloudErrorBodyAutoGenerated> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = CloudErrorBodyAutoGenerated.DeserializeCloudErrorBodyAutoGenerated(property.Value);
                    continue;
                }
            }
            return new CloudErrorAutoGenerated(error.HasValue ? error.Value : null);
        }
    }
}
