// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class DnsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nameServers");
            writer.WriteStartArray();
            foreach (var item in NameServers)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SearchDomains))
            {
                writer.WritePropertyName("searchDomains");
                writer.WriteStringValue(SearchDomains);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options");
                writer.WriteStringValue(Options);
            }
            writer.WriteEndObject();
        }

        internal static DnsConfiguration DeserializeDnsConfiguration(JsonElement element)
        {
            IList<string> nameServers = default;
            Optional<string> searchDomains = default;
            Optional<string> options = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameServers"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nameServers = array;
                    continue;
                }
                if (property.NameEquals("searchDomains"))
                {
                    searchDomains = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"))
                {
                    options = property.Value.GetString();
                    continue;
                }
            }
            return new DnsConfiguration(nameServers, searchDomains.Value, options.Value);
        }
    }
}
