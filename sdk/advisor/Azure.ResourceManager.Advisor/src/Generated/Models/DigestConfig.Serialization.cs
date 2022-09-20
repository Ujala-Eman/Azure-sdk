// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    public partial class DigestConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ActionGroupResourceId))
            {
                writer.WritePropertyName("actionGroupResourceId");
                writer.WriteStringValue(ActionGroupResourceId);
            }
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency");
                writer.WriteNumberValue(Frequency.Value);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories");
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DigestConfig DeserializeDigestConfig(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> actionGroupResourceId = default;
            Optional<int> frequency = default;
            Optional<IList<Category>> categories = default;
            Optional<string> language = default;
            Optional<DigestConfigState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionGroupResourceId"))
                {
                    actionGroupResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frequency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    frequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("categories"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Category> array = new List<Category>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new Category(item.GetString()));
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("language"))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new DigestConfigState(property.Value.GetString());
                    continue;
                }
            }
            return new DigestConfig(name.Value, actionGroupResourceId.Value, Optional.ToNullable(frequency), Optional.ToList(categories), language.Value, Optional.ToNullable(state));
        }
    }
}
