// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataContainer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerDataContainer DeserializeSearchIndexerDataContainer(JsonElement element)
        {
            string name = default;
            Optional<string> query = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new SearchIndexerDataContainer(name, query.HasValue ? query.Value : null);
        }
    }
}
