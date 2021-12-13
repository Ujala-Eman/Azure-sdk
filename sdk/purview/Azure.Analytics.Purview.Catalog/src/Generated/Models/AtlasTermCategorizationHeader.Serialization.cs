// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class AtlasTermCategorizationHeader : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CategoryGuid))
            {
                writer.WritePropertyName("categoryGuid");
                writer.WriteStringValue(CategoryGuid);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayText))
            {
                writer.WritePropertyName("displayText");
                writer.WriteStringValue(DisplayText);
            }
            if (Optional.IsDefined(RelationGuid))
            {
                writer.WritePropertyName("relationGuid");
                writer.WriteStringValue(RelationGuid);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AtlasTermCategorizationHeader DeserializeAtlasTermCategorizationHeader(JsonElement element)
        {
            Optional<string> categoryGuid = default;
            Optional<string> description = default;
            Optional<string> displayText = default;
            Optional<string> relationGuid = default;
            Optional<AtlasTermRelationshipStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("categoryGuid"))
                {
                    categoryGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayText"))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relationGuid"))
                {
                    relationGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new AtlasTermRelationshipStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AtlasTermCategorizationHeader(categoryGuid.Value, description.Value, displayText.Value, relationGuid.Value, Optional.ToNullable(status));
        }
    }
}
