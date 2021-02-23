// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Storage.Models
{
    public partial class DockerManifestV2 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType");
                writer.WriteStringValue((string)MediaType);
            }
            if (Optional.IsDefined(ConfigDescriptor))
            {
                writer.WritePropertyName("config");
                writer.WriteObjectValue(ConfigDescriptor);
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers");
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion");
                writer.WriteNumberValue(SchemaVersion);
            }
            writer.WriteEndObject();
        }

        internal static DockerManifestV2 DeserializeDockerManifestV2(JsonElement element)
        {
            Optional<string> mediaType = default;
            Optional<ContentDescriptor> config = default;
            Optional<IList<ContentDescriptor>> layers = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("config"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    config = ContentDescriptor.DeserializeContentDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContentDescriptor> array = new List<ContentDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentDescriptor.DeserializeContentDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new DockerManifestV2(schemaVersion, mediaType.Value, config.Value, Optional.ToList(layers));
        }
    }
}
