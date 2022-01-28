// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationPatchable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan");
                JsonSerializer.Serialize(writer, Plan);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
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
            if (Optional.IsDefined(ManagedResourceGroupId))
            {
                writer.WritePropertyName("managedResourceGroupId");
                writer.WriteStringValue(ManagedResourceGroupId);
            }
            if (Optional.IsDefined(ApplicationDefinitionId))
            {
                writer.WritePropertyName("applicationDefinitionId");
                writer.WriteStringValue(ApplicationDefinitionId);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            if (Optional.IsDefined(JitAccessPolicy))
            {
                writer.WritePropertyName("jitAccessPolicy");
                writer.WriteObjectValue(JitAccessPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationPatchable DeserializeApplicationPatchable(JsonElement element)
        {
            Optional<Plan> plan = default;
            Optional<string> kind = default;
            Optional<IdentityAutoGenerated> identity = default;
            Optional<string> managedBy = default;
            Optional<SkuAutoGenerated> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> managedResourceGroupId = default;
            Optional<string> applicationDefinitionId = default;
            Optional<object> parameters = default;
            Optional<object> outputs = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ApplicationBillingDetailsDefinition> billingDetails = default;
            Optional<ApplicationJitAccessPolicy> jitAccessPolicy = default;
            Optional<string> publisherTenantId = default;
            Optional<IReadOnlyList<ApplicationAuthorization>> authorizations = default;
            Optional<ApplicationManagementMode> managementMode = default;
            Optional<ApplicationPackageContact> customerSupport = default;
            Optional<ApplicationPackageSupportUrls> supportUrls = default;
            Optional<IReadOnlyList<ApplicationArtifact>> artifacts = default;
            Optional<ApplicationClientDetails> createdBy = default;
            Optional<ApplicationClientDetails> updatedBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("plan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    plan = JsonSerializer.Deserialize<Plan>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = IdentityAutoGenerated.DeserializeIdentityAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SkuAutoGenerated.DeserializeSkuAutoGenerated(property.Value);
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
                        if (property0.NameEquals("managedResourceGroupId"))
                        {
                            managedResourceGroupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationDefinitionId"))
                        {
                            applicationDefinitionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            parameters = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outputs = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingDetails = ApplicationBillingDetailsDefinition.DeserializeApplicationBillingDetailsDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("jitAccessPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jitAccessPolicy = ApplicationJitAccessPolicy.DeserializeApplicationJitAccessPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("publisherTenantId"))
                        {
                            publisherTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationAuthorization> array = new List<ApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationAuthorization.DeserializeApplicationAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("managementMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managementMode = new ApplicationManagementMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerSupport"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customerSupport = ApplicationPackageContact.DeserializeApplicationPackageContact(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportUrls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            supportUrls = ApplicationPackageSupportUrls.DeserializeApplicationPackageSupportUrls(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("artifacts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationArtifact> array = new List<ApplicationArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationArtifact.DeserializeApplicationArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("createdBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdBy = ApplicationClientDetails.DeserializeApplicationClientDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedBy = ApplicationClientDetails.DeserializeApplicationClientDetails(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationPatchable(id, name, type, systemData, tags, location, managedBy.Value, sku.Value, plan, kind.Value, identity.Value, managedResourceGroupId.Value, applicationDefinitionId.Value, parameters.Value, outputs.Value, Optional.ToNullable(provisioningState), billingDetails.Value, jitAccessPolicy.Value, publisherTenantId.Value, Optional.ToList(authorizations), Optional.ToNullable(managementMode), customerSupport.Value, supportUrls.Value, Optional.ToList(artifacts), createdBy.Value, updatedBy.Value);
        }
    }
}
