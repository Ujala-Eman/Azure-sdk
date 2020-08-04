// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class MongoDbCursorMethodsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Project))
            {
                writer.WritePropertyName("project");
                writer.WriteObjectValue(Project);
            }
            if (Optional.IsDefined(Sort))
            {
                writer.WritePropertyName("sort");
                writer.WriteObjectValue(Sort);
            }
            if (Optional.IsDefined(Skip))
            {
                writer.WritePropertyName("skip");
                writer.WriteObjectValue(Skip);
            }
            if (Optional.IsDefined(Limit))
            {
                writer.WritePropertyName("limit");
                writer.WriteObjectValue(Limit);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static MongoDbCursorMethodsProperties DeserializeMongoDbCursorMethodsProperties(JsonElement element)
        {
            Optional<object> project = default;
            Optional<object> sort = default;
            Optional<object> skip = default;
            Optional<object> limit = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("project"))
                {
                    project = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sort"))
                {
                    sort = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("skip"))
                {
                    skip = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MongoDbCursorMethodsProperties(project.Value, sort.Value, skip.Value, limit.Value, additionalProperties);
        }
    }
}
