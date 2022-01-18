// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ExtendedLocation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocation
{
    public partial class CustomLocationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication");
                writer.WriteObjectValue(Authentication);
            }
            if (Optional.IsCollectionDefined(ClusterExtensionIds))
            {
                writer.WritePropertyName("clusterExtensionIds");
                writer.WriteStartArray();
                foreach (var item in ClusterExtensionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(HostResourceId))
            {
                writer.WritePropertyName("hostResourceId");
                writer.WriteStringValue(HostResourceId);
            }
            if (Optional.IsDefined(HostType))
            {
                writer.WritePropertyName("hostType");
                writer.WriteStringValue(HostType.Value.ToString());
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace");
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomLocationData DeserializeCustomLocationData(JsonElement element)
        {
            Optional<LocationIdentity> identity = default;
            Optional<SystemData> systemData = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<CustomLocationPropertiesAuthentication> authentication = default;
            Optional<IList<string>> clusterExtensionIds = default;
            Optional<string> displayName = default;
            Optional<string> hostResourceId = default;
            Optional<HostType> hostType = default;
            Optional<string> @namespace = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = LocationIdentity.DeserializeLocationIdentity(property.Value);
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
                if (property.NameEquals("tags"))
                {
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
                    location = property.Value.GetString();
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
                        if (property0.NameEquals("authentication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authentication = CustomLocationPropertiesAuthentication.DeserializeCustomLocationPropertiesAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterExtensionIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            clusterExtensionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostResourceId"))
                        {
                            hostResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hostType = new HostType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("namespace"))
                        {
                            @namespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomLocationData(id, name, type, tags, location, identity.Value, systemData, authentication.Value, Optional.ToList(clusterExtensionIds), displayName.Value, hostResourceId.Value, Optional.ToNullable(hostType), @namespace.Value, provisioningState.Value);
        }
    }
}
