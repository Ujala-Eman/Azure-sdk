// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class OracleDataSourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteStringValue(Port);
            }
            if (Optional.IsDefined(Service))
            {
                writer.WritePropertyName("service");
                writer.WriteStringValue(Service);
            }
            if (Optional.IsDefined(Collection))
            {
                writer.WritePropertyName("collection");
                writer.WriteObjectValue(Collection);
            }
            writer.WriteEndObject();
        }

        internal static OracleDataSourceProperties DeserializeOracleDataSourceProperties(JsonElement element)
        {
            Optional<string> host = default;
            Optional<string> port = default;
            Optional<string> service = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            Optional<DataSourcePropertiesCollection> collection = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("service"))
                {
                    service = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("collection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    collection = DataSourcePropertiesCollection.DeserializeDataSourcePropertiesCollection(property.Value);
                    continue;
                }
            }
            return new OracleDataSourceProperties(Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedAt), collection.Value, host.Value, port.Value, service.Value);
        }
    }
}
