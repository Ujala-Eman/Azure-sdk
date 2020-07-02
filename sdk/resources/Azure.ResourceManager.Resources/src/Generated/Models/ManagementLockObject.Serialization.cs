// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ManagementLockObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("level");
            writer.WriteStringValue(Level.ToString());
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(Owners))
            {
                writer.WritePropertyName("owners");
                writer.WriteStartArray();
                foreach (var item in Owners)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagementLockObject DeserializeManagementLockObject(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> type = default;
            Optional<string> name = default;
            LockLevel level = default;
            Optional<string> notes = default;
            Optional<IList<ManagementLockOwner>> owners = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("level"))
                        {
                            level = new LockLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("notes"))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("owners"))
                        {
                            List<ManagementLockOwner> array = new List<ManagementLockOwner>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ManagementLockOwner.DeserializeManagementLockOwner(item));
                                }
                            }
                            owners = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagementLockObject(id.HasValue ? id.Value : null, type.HasValue ? type.Value : null, name.HasValue ? name.Value : null, level, notes.HasValue ? notes.Value : null, new ChangeTrackingList<ManagementLockOwner>(owners));
        }
    }
}
