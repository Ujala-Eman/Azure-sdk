// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class AmazonSqlDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static AmazonSqlDataSource DeserializeAmazonSqlDataSource(JsonElement element)
        {
            Optional<AmazonSqlDataSourceProperties> properties = default;
            DataSourceType kind = default;
            Optional<IReadOnlyList<Scan>> scans = default;
            Optional<string> id = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = AmazonSqlDataSourceProperties.DeserializeAmazonSqlDataSourceProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new DataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scans"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Scan> array = new List<Scan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Scan.DeserializeScan(item));
                    }
                    scans = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new AmazonSqlDataSource(id.Value, name.Value, kind, Optional.ToList(scans), properties.Value);
        }
    }
}
