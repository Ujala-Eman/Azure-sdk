// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ListAccountSasResponse
    {
        internal static ListAccountSasResponse DeserializeListAccountSasResponse(JsonElement element)
        {
            Optional<string> accountSasToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountSasToken"))
                {
                    accountSasToken = property.Value.GetString();
                    continue;
                }
            }
            return new ListAccountSasResponse(accountSasToken.HasValue ? accountSasToken.Value : null);
        }
    }
}
