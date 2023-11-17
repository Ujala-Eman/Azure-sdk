// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterData : IUtf8JsonSerializable, IJsonModel<HciClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciClusterData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<HciClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HciClusterData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HciClusterData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CloudId))
                {
                    writer.WritePropertyName("cloudId"u8);
                    writer.WriteStringValue(CloudId.Value);
                }
            }
            if (Optional.IsDefined(CloudManagementEndpoint))
            {
                writer.WritePropertyName("cloudManagementEndpoint"u8);
                writer.WriteStringValue(CloudManagementEndpoint);
            }
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId"u8);
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(AadApplicationObjectId))
            {
                writer.WritePropertyName("aadApplicationObjectId"u8);
                writer.WriteStringValue(AadApplicationObjectId.Value);
            }
            if (Optional.IsDefined(AadServicePrincipalObjectId))
            {
                writer.WritePropertyName("aadServicePrincipalObjectId"u8);
                writer.WriteStringValue(AadServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(SoftwareAssuranceProperties))
            {
                writer.WritePropertyName("softwareAssuranceProperties"u8);
                writer.WriteObjectValue(SoftwareAssuranceProperties);
            }
            if (Optional.IsDefined(DesiredProperties))
            {
                writer.WritePropertyName("desiredProperties"u8);
                writer.WriteObjectValue(DesiredProperties);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ReportedProperties))
                {
                    writer.WritePropertyName("reportedProperties"u8);
                    writer.WriteObjectValue(ReportedProperties);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TrialDaysRemaining))
                {
                    writer.WritePropertyName("trialDaysRemaining"u8);
                    writer.WriteNumberValue(TrialDaysRemaining.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(BillingModel))
                {
                    writer.WritePropertyName("billingModel"u8);
                    writer.WriteStringValue(BillingModel);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RegistrationTimestamp))
                {
                    writer.WritePropertyName("registrationTimestamp"u8);
                    writer.WriteStringValue(RegistrationTimestamp.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastSyncTimestamp))
                {
                    writer.WritePropertyName("lastSyncTimestamp"u8);
                    writer.WriteStringValue(LastSyncTimestamp.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastBillingTimestamp))
                {
                    writer.WritePropertyName("lastBillingTimestamp"u8);
                    writer.WriteStringValue(LastBillingTimestamp.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ServiceEndpoint))
                {
                    writer.WritePropertyName("serviceEndpoint"u8);
                    writer.WriteStringValue(ServiceEndpoint);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceProviderObjectId))
                {
                    writer.WritePropertyName("resourceProviderObjectId"u8);
                    writer.WriteStringValue(ResourceProviderObjectId);
                }
            }
            writer.WriteEndObject();
            writer.WritePropertyName("identity"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PrincipalId))
                {
                    writer.WritePropertyName("principalId"u8);
                    writer.WriteStringValue(PrincipalId.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TenantId))
                {
                    writer.WritePropertyName("tenantId"u8);
                    writer.WriteStringValue(TenantId.Value);
                }
            }
            if (Optional.IsDefined(TypeIdentityType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypeIdentityType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        HciClusterData IJsonModel<HciClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HciClusterData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciClusterData(document.RootElement, options);
        }

        internal static HciClusterData DeserializeHciClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<HciClusterStatus> status = default;
            Optional<Guid> cloudId = default;
            Optional<string> cloudManagementEndpoint = default;
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<Guid> aadApplicationObjectId = default;
            Optional<Guid> aadServicePrincipalObjectId = default;
            Optional<SoftwareAssuranceProperties> softwareAssuranceProperties = default;
            Optional<HciClusterDesiredProperties> desiredProperties = default;
            Optional<HciClusterReportedProperties> reportedProperties = default;
            Optional<float> trialDaysRemaining = default;
            Optional<string> billingModel = default;
            Optional<DateTimeOffset> registrationTimestamp = default;
            Optional<DateTimeOffset> lastSyncTimestamp = default;
            Optional<DateTimeOffset> lastBillingTimestamp = default;
            Optional<string> serviceEndpoint = default;
            Optional<string> resourceProviderObjectId = default;
            Optional<Guid> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<HciManagedServiceIdentityType> type0 = default;
            Optional<IDictionary<string, UserAssignedIdentity>> userAssignedIdentities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new HciClusterStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cloudId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("cloudManagementEndpoint"u8))
                        {
                            cloudManagementEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("softwareAssuranceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softwareAssuranceProperties = SoftwareAssuranceProperties.DeserializeSoftwareAssuranceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("desiredProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            desiredProperties = HciClusterDesiredProperties.DeserializeHciClusterDesiredProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reportedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reportedProperties = HciClusterReportedProperties.DeserializeHciClusterReportedProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trialDaysRemaining"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trialDaysRemaining = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("billingModel"u8))
                        {
                            billingModel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSyncTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastBillingTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastBillingTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoint"u8))
                        {
                            serviceEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceProviderObjectId"u8))
                        {
                            resourceProviderObjectId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("principalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new HciManagedServiceIdentityType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userAssignedIdentities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, UserAssignedIdentity> dictionary = new Dictionary<string, UserAssignedIdentity>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, JsonSerializer.Deserialize<UserAssignedIdentity>(property1.Value.GetRawText()));
                            }
                            userAssignedIdentities = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HciClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(status), Optional.ToNullable(cloudId), cloudManagementEndpoint.Value, Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), Optional.ToNullable(aadApplicationObjectId), Optional.ToNullable(aadServicePrincipalObjectId), softwareAssuranceProperties.Value, desiredProperties.Value, reportedProperties.Value, Optional.ToNullable(trialDaysRemaining), billingModel.Value, Optional.ToNullable(registrationTimestamp), Optional.ToNullable(lastSyncTimestamp), Optional.ToNullable(lastBillingTimestamp), serviceEndpoint.Value, resourceProviderObjectId.Value, Optional.ToNullable(principalId), Optional.ToNullable(tenantId), Optional.ToNullable(type0), Optional.ToDictionary(userAssignedIdentities), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HciClusterData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HciClusterData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HciClusterData IPersistableModel<HciClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HciClusterData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHciClusterData(document.RootElement, options);
        }

        string IPersistableModel<HciClusterData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
