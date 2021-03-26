﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class TagProperties
    {
        internal static TagProperties DeserializeTagProperties(JsonElement element)
        {
            string imageName = default;
            Optional<string> name = default;
            Optional<string> digest = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            Optional<ContentProperties> changeableAttributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"))
                        {
                            name = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("digest"))
                        {
                            digest = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdateTime"))
                        {
                            lastUpdateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changeableAttributes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            changeableAttributes = ContentProperties.DeserializeContentProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("digest"))
                {
                    digest = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("changeableAttributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    changeableAttributes = ContentProperties.DeserializeContentProperties(property.Value);
                    continue;
                }
            }
            return new TagProperties(imageName, name.Value, digest.Value, createdTime, lastUpdateTime, changeableAttributes.Value);
        }
    }
}
