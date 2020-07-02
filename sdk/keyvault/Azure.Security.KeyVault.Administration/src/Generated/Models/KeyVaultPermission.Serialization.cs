// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    public partial class KeyVaultPermission
    {
        internal static KeyVaultPermission DeserializeKeyVaultPermission(JsonElement element)
        {
            Optional<IReadOnlyList<string>> actions = default;
            Optional<IReadOnlyList<string>> notActions = default;
            Optional<IReadOnlyList<string>> dataActions = default;
            Optional<IReadOnlyList<string>> notDataActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("notActions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    notActions = array;
                    continue;
                }
                if (property.NameEquals("dataActions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    dataActions = array;
                    continue;
                }
                if (property.NameEquals("notDataActions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    notDataActions = array;
                    continue;
                }
            }
            return new KeyVaultPermission(new ChangeTrackingList<string>(actions), new ChangeTrackingList<string>(notActions), new ChangeTrackingList<string>(dataActions), new ChangeTrackingList<string>(notDataActions));
        }
    }
}
