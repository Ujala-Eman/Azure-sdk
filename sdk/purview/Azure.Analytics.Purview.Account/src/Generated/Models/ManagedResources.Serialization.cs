// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Account.Models
{
    public partial class ManagedResources
    {
        internal static ManagedResources DeserializeManagedResources(JsonElement element)
        {
            Optional<string> eventHubNamespace = default;
            Optional<string> resourceGroup = default;
            Optional<string> storageAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHubNamespace"))
                {
                    eventHubNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccount"))
                {
                    storageAccount = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedResources(eventHubNamespace.Value, resourceGroup.Value, storageAccount.Value);
        }
    }
}
