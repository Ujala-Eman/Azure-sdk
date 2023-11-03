// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IntegrationSpaces.Models
{
    public partial class TrackingDataStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("dataStoreResourceId"u8);
            writer.WriteStringValue(DataStoreResourceId);
            writer.WritePropertyName("dataStoreUri"u8);
            writer.WriteStringValue(DataStoreUri.AbsoluteUri);
            writer.WritePropertyName("dataStoreIngestionUri"u8);
            writer.WriteStringValue(DataStoreIngestionUri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static TrackingDataStore DeserializeTrackingDataStore(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string dataStoreResourceId = default;
            Uri dataStoreUri = default;
            Uri dataStoreIngestionUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreResourceId"u8))
                {
                    dataStoreResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreUri"u8))
                {
                    dataStoreUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataStoreIngestionUri"u8))
                {
                    dataStoreIngestionUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new TrackingDataStore(databaseName, dataStoreResourceId, dataStoreUri, dataStoreIngestionUri);
        }
    }
}
