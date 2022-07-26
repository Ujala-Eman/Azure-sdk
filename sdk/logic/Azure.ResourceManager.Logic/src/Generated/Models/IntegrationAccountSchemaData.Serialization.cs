// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class IntegrationAccountSchemaData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("schemaType");
            writer.WriteStringValue(SchemaType.ToString());
            if (Optional.IsDefined(TargetNamespace))
            {
                writer.WritePropertyName("targetNamespace");
                writer.WriteStringValue(TargetNamespace);
            }
            if (Optional.IsDefined(DocumentName))
            {
                writer.WritePropertyName("documentName");
                writer.WriteStringValue(DocumentName);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName");
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Metadata.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content");
                writer.WriteStringValue(Content);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType");
                writer.WriteStringValue(ContentType);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IntegrationAccountSchemaData DeserializeIntegrationAccountSchemaData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            SchemaType schemaType = default;
            Optional<string> targetNamespace = default;
            Optional<string> documentName = default;
            Optional<string> fileName = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> changedTime = default;
            Optional<BinaryData> metadata = default;
            Optional<string> content = default;
            Optional<string> contentType = default;
            Optional<LogicContentLink> contentLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("schemaType"))
                        {
                            schemaType = new SchemaType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetNamespace"))
                        {
                            targetNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentName"))
                        {
                            documentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileName"))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            changedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("content"))
                        {
                            content = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentType"))
                        {
                            contentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contentLink = LogicContentLink.DeserializeLogicContentLink(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IntegrationAccountSchemaData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, schemaType, targetNamespace.Value, documentName.Value, fileName.Value, Optional.ToNullable(createdTime), Optional.ToNullable(changedTime), metadata.Value, content.Value, contentType.Value, contentLink.Value);
        }
    }
}
