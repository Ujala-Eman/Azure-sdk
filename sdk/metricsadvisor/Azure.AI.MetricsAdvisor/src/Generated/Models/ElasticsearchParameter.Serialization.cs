// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class ElasticsearchParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("host");
            writer.WriteStringValue(Host);
            writer.WritePropertyName("port");
            writer.WriteStringValue(Port);
            writer.WritePropertyName("authHeader");
            writer.WriteStringValue(AuthHeader);
            writer.WritePropertyName("query");
            writer.WriteStringValue(Query);
            writer.WriteEndObject();
        }

        internal static ElasticsearchParameter DeserializeElasticsearchParameter(JsonElement element)
        {
            string host = default;
            string port = default;
            string authHeader = default;
            string query = default;
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
                if (property.NameEquals("authHeader"))
                {
                    authHeader = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new ElasticsearchParameter(host, port, authHeader, query);
        }
    }
}
