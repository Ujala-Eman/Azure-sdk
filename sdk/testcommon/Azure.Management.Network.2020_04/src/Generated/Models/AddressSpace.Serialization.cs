// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AddressSpace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes");
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AddressSpace DeserializeAddressSpace(JsonElement element)
        {
            Optional<IList<string>> addressPrefixes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefixes"))
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
                    addressPrefixes = array;
                    continue;
                }
            }
            return new AddressSpace(new ChangeTrackingList<string>(addressPrefixes));
        }
    }
}
