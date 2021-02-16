// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class Zone : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ZoneType))
            {
                writer.WritePropertyName("zoneType");
                writer.WriteStringValue(ZoneType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(RegistrationVirtualNetworks))
            {
                writer.WritePropertyName("registrationVirtualNetworks");
                writer.WriteStartArray();
                foreach (var item in RegistrationVirtualNetworks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResolutionVirtualNetworks))
            {
                writer.WritePropertyName("resolutionVirtualNetworks");
                writer.WriteStartArray();
                foreach (var item in ResolutionVirtualNetworks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Zone DeserializeZone(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<long> maxNumberOfRecordSets = default;
            Optional<long> maxNumberOfRecordsPerRecordSet = default;
            Optional<long> numberOfRecordSets = default;
            Optional<IReadOnlyList<string>> nameServers = default;
            Optional<ZoneType> zoneType = default;
            Optional<IList<SubResource>> registrationVirtualNetworks = default;
            Optional<IList<SubResource>> resolutionVirtualNetworks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("maxNumberOfRecordSets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxNumberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxNumberOfRecordsPerRecordSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxNumberOfRecordsPerRecordSet = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfRecordSets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numberOfRecordSets = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("nameServers"))
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
                            nameServers = array;
                            continue;
                        }
                        if (property0.NameEquals("zoneType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zoneType = property0.Value.GetString().ToZoneType();
                            continue;
                        }
                        if (property0.NameEquals("registrationVirtualNetworks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            registrationVirtualNetworks = array;
                            continue;
                        }
                        if (property0.NameEquals("resolutionVirtualNetworks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            resolutionVirtualNetworks = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Zone(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), etag.Value, Optional.ToNullable(maxNumberOfRecordSets), Optional.ToNullable(maxNumberOfRecordsPerRecordSet), Optional.ToNullable(numberOfRecordSets), Optional.ToList(nameServers), Optional.ToNullable(zoneType), Optional.ToList(registrationVirtualNetworks), Optional.ToList(resolutionVirtualNetworks));
        }
    }
}
