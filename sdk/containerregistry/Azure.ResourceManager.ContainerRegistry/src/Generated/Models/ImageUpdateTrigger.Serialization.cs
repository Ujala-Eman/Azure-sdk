// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ImageUpdateTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp");
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsCollectionDefined(Images))
            {
                writer.WritePropertyName("images");
                writer.WriteStartArray();
                foreach (var item in Images)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ImageUpdateTrigger DeserializeImageUpdateTrigger(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<IList<ImageDescriptor>> images = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("images"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ImageDescriptor> array = new List<ImageDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageDescriptor.DeserializeImageDescriptor(item));
                    }
                    images = array;
                    continue;
                }
            }
            return new ImageUpdateTrigger(id.Value, Optional.ToNullable(timestamp), Optional.ToList(images));
        }
    }
}
