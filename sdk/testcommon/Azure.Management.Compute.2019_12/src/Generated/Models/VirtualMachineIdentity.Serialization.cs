// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToSerialString());
            }
            if (Optional.IsDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities");
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineIdentity DeserializeVirtualMachineIdentity(JsonElement element)
        {
            Optional<string> principalId = default;
            Optional<string> tenantId = default;
            Optional<ResourceIdentityType> type = default;
            Optional<IDictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>> userAssignedIdentities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToResourceIdentityType();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"))
                {
                    Dictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties> dictionary = new Dictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties.DeserializeComponents1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties(property0.Value));
                        }
                    }
                    userAssignedIdentities = dictionary;
                    continue;
                }
            }
            return new VirtualMachineIdentity(principalId.HasValue ? principalId.Value : null, tenantId.HasValue ? tenantId.Value : null, type.HasValue ? type.Value : (ResourceIdentityType?)null, new ChangeTrackingDictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>(userAssignedIdentities));
        }
    }
}
