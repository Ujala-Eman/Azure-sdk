// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Orbital.Models;

namespace Azure.ResourceManager.Orbital
{
    public partial class AvailableGroundStationData
    {
        internal static AvailableGroundStationData DeserializeAvailableGroundStationData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> city = default;
            Optional<string> providerName = default;
            Optional<float> longitudeDegrees = default;
            Optional<float> latitudeDegrees = default;
            Optional<float> altitudeMeters = default;
            Optional<GroundStationReleaseMode> releaseMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("city"))
                        {
                            city = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerName"))
                        {
                            providerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("longitudeDegrees"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            longitudeDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("latitudeDegrees"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            latitudeDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("altitudeMeters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            altitudeMeters = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("releaseMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            releaseMode = new GroundStationReleaseMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AvailableGroundStationData(id, name, type, systemData.Value, Optional.ToNullable(location), city.Value, providerName.Value, Optional.ToNullable(longitudeDegrees), Optional.ToNullable(latitudeDegrees), Optional.ToNullable(altitudeMeters), Optional.ToNullable(releaseMode));
        }
    }
}
