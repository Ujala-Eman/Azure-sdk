// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AwsOrganizationalDataMember : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ParentHierarchyId))
            {
                writer.WritePropertyName("parentHierarchyId");
                writer.WriteStringValue(ParentHierarchyId);
            }
            writer.WritePropertyName("organizationMembershipType");
            writer.WriteStringValue(OrganizationMembershipType.ToString());
            writer.WriteEndObject();
        }

        internal static AwsOrganizationalDataMember DeserializeAwsOrganizationalDataMember(JsonElement element)
        {
            Optional<string> parentHierarchyId = default;
            OrganizationMembershipType organizationMembershipType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentHierarchyId"))
                {
                    parentHierarchyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
            }
            return new AwsOrganizationalDataMember(organizationMembershipType, parentHierarchyId.Value);
        }
    }
}
