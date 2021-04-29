// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate.Models
{
    public partial class Group : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("groupId");
            writer.WriteStringValue(GroupId);
            writer.WritePropertyName("groupType");
            writer.WriteStringValue(GroupType.ToString());
            writer.WritePropertyName("tags");
            writer.WriteStartArray();
            foreach (var item in Tags)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("createdDateTime");
            writer.WriteStringValue(CreatedDateTime);
            if (Optional.IsDefined(DeviceCount))
            {
                writer.WritePropertyName("deviceCount");
                writer.WriteNumberValue(DeviceCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static Group DeserializeGroup(JsonElement element)
        {
            string groupId = default;
            GroupType groupType = default;
            IList<string> tags = default;
            string createdDateTime = default;
            Optional<int> deviceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupType"))
                {
                    groupType = new GroupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deviceCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new Group(groupId, groupType, tags, createdDateTime, Optional.ToNullable(deviceCount));
        }
    }
}
