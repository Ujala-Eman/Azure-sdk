// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SsisPackage
    {
        internal static SsisPackage DeserializeSsisPackage(JsonElement element)
        {
            Optional<long> folderId = default;
            Optional<long> projectVersion = default;
            Optional<long> projectId = default;
            Optional<IReadOnlyList<SsisParameter>> parameters = default;
            SsisObjectMetadataType type = default;
            Optional<long> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("folderId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    projectVersion = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    projectId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SsisParameter> array = new List<SsisParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SsisParameter.DeserializeSsisParameter(item));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SsisObjectMetadataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new SsisPackage(type, Optional.ToNullable(id), name.Value, description.Value, Optional.ToNullable(folderId), Optional.ToNullable(projectVersion), Optional.ToNullable(projectId), Optional.ToList(parameters));
        }
    }
}
