// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    public partial class IscsiTargetData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("aclMode");
            writer.WriteStringValue(AclMode.ToString());
            if (Optional.IsCollectionDefined(StaticAcls))
            {
                writer.WritePropertyName("staticAcls");
                writer.WriteStartArray();
                foreach (var item in StaticAcls)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Luns))
            {
                writer.WritePropertyName("luns");
                writer.WriteStartArray();
                foreach (var item in Luns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("targetIqn");
            writer.WriteStringValue(TargetIqn);
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints");
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IscsiTargetData DeserializeIscsiTargetData(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<IReadOnlyList<string>> managedByExtended = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IscsiTargetAclMode aclMode = default;
            Optional<IList<Acl>> staticAcls = default;
            Optional<IList<IscsiLun>> luns = default;
            string targetIqn = default;
            ProvisioningStates provisioningState = default;
            OperationalStatus status = default;
            Optional<IList<string>> endpoints = default;
            Optional<int> port = default;
            Optional<IReadOnlyList<string>> sessions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByExtended"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managedByExtended = array;
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
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("aclMode"))
                        {
                            aclMode = new IscsiTargetAclMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("staticAcls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Acl> array = new List<Acl>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Acl.DeserializeAcl(item));
                            }
                            staticAcls = array;
                            continue;
                        }
                        if (property0.NameEquals("luns"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<IscsiLun> array = new List<IscsiLun>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IscsiLun.DeserializeIscsiLun(item));
                            }
                            luns = array;
                            continue;
                        }
                        if (property0.NameEquals("targetIqn"))
                        {
                            targetIqn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningStates(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = new OperationalStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpoints"))
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
                            endpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sessions"))
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
                            sessions = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IscsiTargetData(id, name, type, systemData, managedBy.Value, Optional.ToList(managedByExtended), aclMode, Optional.ToList(staticAcls), Optional.ToList(luns), targetIqn, provisioningState, status, Optional.ToList(endpoints), Optional.ToNullable(port), Optional.ToList(sessions));
        }
    }
}
