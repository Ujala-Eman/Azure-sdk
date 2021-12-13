// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class AtlasTypeDef : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(EntityTypes))
            {
                writer.WritePropertyName("entityTypes");
                writer.WriteStartArray();
                foreach (var item in EntityTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SubTypes))
            {
                writer.WritePropertyName("subTypes");
                writer.WriteStartArray();
                foreach (var item in SubTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SuperTypes))
            {
                writer.WritePropertyName("superTypes");
                writer.WriteStartArray();
                foreach (var item in SuperTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RelationshipAttributeDefs))
            {
                writer.WritePropertyName("relationshipAttributeDefs");
                writer.WriteStartArray();
                foreach (var item in RelationshipAttributeDefs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsCollectionDefined(ElementDefs))
            {
                writer.WritePropertyName("elementDefs");
                writer.WriteStartArray();
                foreach (var item in ElementDefs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EndDef1))
            {
                writer.WritePropertyName("endDef1");
                writer.WriteObjectValue(EndDef1);
            }
            if (Optional.IsDefined(EndDef2))
            {
                writer.WritePropertyName("endDef2");
                writer.WriteObjectValue(EndDef2);
            }
            if (Optional.IsDefined(RelationshipCategory))
            {
                writer.WritePropertyName("relationshipCategory");
                writer.WriteStringValue(RelationshipCategory.Value.ToString());
            }
            if (Optional.IsDefined(RelationshipLabel))
            {
                writer.WritePropertyName("relationshipLabel");
                writer.WriteStringValue(RelationshipLabel);
            }
            if (Optional.IsCollectionDefined(AttributeDefs))
            {
                writer.WritePropertyName("attributeDefs");
                writer.WriteStartArray();
                foreach (var item in AttributeDefs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category");
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime");
                writer.WriteNumberValue(CreateTime.Value);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(DateFormatter))
            {
                writer.WritePropertyName("dateFormatter");
                writer.WriteObjectValue(DateFormatter);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Guid))
            {
                writer.WritePropertyName("guid");
                writer.WriteStringValue(Guid);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options");
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ServiceType))
            {
                writer.WritePropertyName("serviceType");
                writer.WriteStringValue(ServiceType);
            }
            if (Optional.IsDefined(TypeVersion))
            {
                writer.WritePropertyName("typeVersion");
                writer.WriteStringValue(TypeVersion);
            }
            if (Optional.IsDefined(UpdateTime))
            {
                writer.WritePropertyName("updateTime");
                writer.WriteNumberValue(UpdateTime.Value);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy");
                writer.WriteStringValue(UpdatedBy);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(LastModifiedTS))
            {
                writer.WritePropertyName("lastModifiedTS");
                writer.WriteStringValue(LastModifiedTS);
            }
            writer.WriteEndObject();
        }

        internal static AtlasTypeDef DeserializeAtlasTypeDef(JsonElement element)
        {
            Optional<IList<string>> entityTypes = default;
            Optional<IList<string>> subTypes = default;
            Optional<IList<string>> superTypes = default;
            Optional<IList<AtlasRelationshipAttributeDef>> relationshipAttributeDefs = default;
            Optional<string> defaultValue = default;
            Optional<IList<AtlasEnumElementDef>> elementDefs = default;
            Optional<AtlasRelationshipEndDef> endDef1 = default;
            Optional<AtlasRelationshipEndDef> endDef2 = default;
            Optional<RelationshipCategory> relationshipCategory = default;
            Optional<string> relationshipLabel = default;
            Optional<IList<AtlasAttributeDef>> attributeDefs = default;
            Optional<TypeCategory> category = default;
            Optional<float> createTime = default;
            Optional<string> createdBy = default;
            Optional<DateFormat> dateFormatter = default;
            Optional<string> description = default;
            Optional<string> guid = default;
            Optional<string> name = default;
            Optional<IDictionary<string, string>> options = default;
            Optional<string> serviceType = default;
            Optional<string> typeVersion = default;
            Optional<float> updateTime = default;
            Optional<string> updatedBy = default;
            Optional<float> version = default;
            Optional<string> lastModifiedTS = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    entityTypes = array;
                    continue;
                }
                if (property.NameEquals("subTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subTypes = array;
                    continue;
                }
                if (property.NameEquals("superTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    superTypes = array;
                    continue;
                }
                if (property.NameEquals("relationshipAttributeDefs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AtlasRelationshipAttributeDef> array = new List<AtlasRelationshipAttributeDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasRelationshipAttributeDef.DeserializeAtlasRelationshipAttributeDef(item));
                    }
                    relationshipAttributeDefs = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elementDefs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AtlasEnumElementDef> array = new List<AtlasEnumElementDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasEnumElementDef.DeserializeAtlasEnumElementDef(item));
                    }
                    elementDefs = array;
                    continue;
                }
                if (property.NameEquals("endDef1"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endDef1 = AtlasRelationshipEndDef.DeserializeAtlasRelationshipEndDef(property.Value);
                    continue;
                }
                if (property.NameEquals("endDef2"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endDef2 = AtlasRelationshipEndDef.DeserializeAtlasRelationshipEndDef(property.Value);
                    continue;
                }
                if (property.NameEquals("relationshipCategory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    relationshipCategory = new RelationshipCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("relationshipLabel"))
                {
                    relationshipLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributeDefs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AtlasAttributeDef> array = new List<AtlasAttributeDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasAttributeDef.DeserializeAtlasAttributeDef(item));
                    }
                    attributeDefs = array;
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    category = new TypeCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateFormatter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateFormatter = DateFormat.DeserializeDateFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guid"))
                {
                    guid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    options = dictionary;
                    continue;
                }
                if (property.NameEquals("serviceType"))
                {
                    serviceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeVersion"))
                {
                    typeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateTime = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("updatedBy"))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lastModifiedTS"))
                {
                    lastModifiedTS = property.Value.GetString();
                    continue;
                }
            }
            return new AtlasTypeDef(Optional.ToNullable(category), Optional.ToNullable(createTime), createdBy.Value, dateFormatter.Value, description.Value, guid.Value, name.Value, Optional.ToDictionary(options), serviceType.Value, typeVersion.Value, Optional.ToNullable(updateTime), updatedBy.Value, Optional.ToNullable(version), lastModifiedTS.Value, Optional.ToList(entityTypes), Optional.ToList(subTypes), Optional.ToList(superTypes), Optional.ToList(relationshipAttributeDefs), defaultValue.Value, Optional.ToList(elementDefs), endDef1.Value, endDef2.Value, Optional.ToNullable(relationshipCategory), relationshipLabel.Value, Optional.ToList(attributeDefs));
        }
    }
}
