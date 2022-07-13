// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBIPAddressOrRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPAddressOrRange))
            {
                writer.WritePropertyName("ipAddressOrRange");
                writer.WriteStringValue(IPAddressOrRange);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBIPAddressOrRange DeserializeCosmosDBIPAddressOrRange(JsonElement element)
        {
            Optional<string> ipAddressOrRange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddressOrRange"))
                {
                    ipAddressOrRange = property.Value.GetString();
                    continue;
                }
            }
            return new CosmosDBIPAddressOrRange(ipAddressOrRange.Value);
        }
    }
}
