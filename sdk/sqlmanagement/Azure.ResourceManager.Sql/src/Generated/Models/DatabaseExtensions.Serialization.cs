// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DatabaseExtensions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OperationMode))
            {
                writer.WritePropertyName("operationMode");
                writer.WriteStringValue(OperationMode.Value.ToString());
            }
            if (Optional.IsDefined(StorageKeyType))
            {
                writer.WritePropertyName("storageKeyType");
                writer.WriteStringValue(StorageKeyType.Value.ToString());
            }
            if (Optional.IsDefined(StorageKey))
            {
                writer.WritePropertyName("storageKey");
                writer.WriteStringValue(StorageKey);
            }
            if (Optional.IsDefined(StorageUri))
            {
                writer.WritePropertyName("storageUri");
                writer.WriteStringValue(StorageUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DatabaseExtensions DeserializeDatabaseExtensions(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<OperationMode> operationMode = default;
            Optional<StorageKeyType> storageKeyType = default;
            Optional<string> storageKey = default;
            Optional<string> storageUri = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("operationMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            operationMode = new OperationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageKeyType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageKeyType = new StorageKeyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageKey"))
                        {
                            storageKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageUri"))
                        {
                            storageUri = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DatabaseExtensions(id, name, type, Optional.ToNullable(operationMode), Optional.ToNullable(storageKeyType), storageKey.Value, storageUri.Value);
        }
    }
}
