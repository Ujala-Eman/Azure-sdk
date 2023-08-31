// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationProtectedItemProperties : IUtf8JsonSerializable, IModelJsonSerializable<ReplicationProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReplicationProtectedItemProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReplicationProtectedItemProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectedItemType))
            {
                writer.WritePropertyName("protectedItemType"u8);
                writer.WriteStringValue(ProtectedItemType);
            }
            if (Optional.IsDefined(ProtectableItemId))
            {
                writer.WritePropertyName("protectableItemId"u8);
                writer.WriteStringValue(ProtectableItemId);
            }
            if (Optional.IsDefined(RecoveryServicesProviderId))
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (Optional.IsDefined(PrimaryFabricFriendlyName))
            {
                writer.WritePropertyName("primaryFabricFriendlyName"u8);
                writer.WriteStringValue(PrimaryFabricFriendlyName);
            }
            if (Optional.IsDefined(PrimaryFabricProvider))
            {
                writer.WritePropertyName("primaryFabricProvider"u8);
                writer.WriteStringValue(PrimaryFabricProvider);
            }
            if (Optional.IsDefined(RecoveryFabricFriendlyName))
            {
                writer.WritePropertyName("recoveryFabricFriendlyName"u8);
                writer.WriteStringValue(RecoveryFabricFriendlyName);
            }
            if (Optional.IsDefined(RecoveryFabricId))
            {
                writer.WritePropertyName("recoveryFabricId"u8);
                writer.WriteStringValue(RecoveryFabricId);
            }
            if (Optional.IsDefined(PrimaryProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("primaryProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(PrimaryProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(RecoveryProtectionContainerFriendlyName))
            {
                writer.WritePropertyName("recoveryProtectionContainerFriendlyName"u8);
                writer.WriteStringValue(RecoveryProtectionContainerFriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState);
            }
            if (Optional.IsDefined(ProtectionStateDescription))
            {
                writer.WritePropertyName("protectionStateDescription"u8);
                writer.WriteStringValue(ProtectionStateDescription);
            }
            if (Optional.IsDefined(ActiveLocation))
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation);
            }
            if (Optional.IsDefined(TestFailoverState))
            {
                writer.WritePropertyName("testFailoverState"u8);
                writer.WriteStringValue(TestFailoverState);
            }
            if (Optional.IsDefined(TestFailoverStateDescription))
            {
                writer.WritePropertyName("testFailoverStateDescription"u8);
                writer.WriteStringValue(TestFailoverStateDescription);
            }
            if (Optional.IsDefined(SwitchProviderState))
            {
                writer.WritePropertyName("switchProviderState"u8);
                writer.WriteStringValue(SwitchProviderState);
            }
            if (Optional.IsDefined(SwitchProviderStateDescription))
            {
                writer.WritePropertyName("switchProviderStateDescription"u8);
                writer.WriteStringValue(SwitchProviderStateDescription);
            }
            if (Optional.IsCollectionDefined(AllowedOperations))
            {
                writer.WritePropertyName("allowedOperations"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedOperations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicationHealth))
            {
                writer.WritePropertyName("replicationHealth"u8);
                writer.WriteStringValue(ReplicationHealth);
            }
            if (Optional.IsDefined(FailoverHealth))
            {
                writer.WritePropertyName("failoverHealth"u8);
                writer.WriteStringValue(FailoverHealth);
            }
            if (Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SiteRecoveryHealthError>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(PolicyFriendlyName))
            {
                writer.WritePropertyName("policyFriendlyName"u8);
                writer.WriteStringValue(PolicyFriendlyName);
            }
            if (Optional.IsDefined(LastSuccessfulFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(LastSuccessfulTestFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulTestFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulTestFailoverOn.Value, "O");
            }
            if (Optional.IsDefined(CurrentScenario))
            {
                writer.WritePropertyName("currentScenario"u8);
                if (CurrentScenario is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CurrentScenarioDetails>)CurrentScenario).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(FailoverRecoveryPointId))
            {
                writer.WritePropertyName("failoverRecoveryPointId"u8);
                writer.WriteStringValue(FailoverRecoveryPointId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                if (ProviderSpecificDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ReplicationProviderSpecificSettings>)ProviderSpecificDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RecoveryContainerId))
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (Optional.IsDefined(EventCorrelationId))
            {
                writer.WritePropertyName("eventCorrelationId"u8);
                writer.WriteStringValue(EventCorrelationId.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ReplicationProtectedItemProperties DeserializeReplicationProtectedItemProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<string> protectedItemType = default;
            Optional<ResourceIdentifier> protectableItemId = default;
            Optional<string> recoveryServicesProviderId = default;
            Optional<string> primaryFabricFriendlyName = default;
            Optional<string> primaryFabricProvider = default;
            Optional<string> recoveryFabricFriendlyName = default;
            Optional<ResourceIdentifier> recoveryFabricId = default;
            Optional<string> primaryProtectionContainerFriendlyName = default;
            Optional<string> recoveryProtectionContainerFriendlyName = default;
            Optional<string> protectionState = default;
            Optional<string> protectionStateDescription = default;
            Optional<string> activeLocation = default;
            Optional<string> testFailoverState = default;
            Optional<string> testFailoverStateDescription = default;
            Optional<string> switchProviderState = default;
            Optional<string> switchProviderStateDescription = default;
            Optional<IReadOnlyList<string>> allowedOperations = default;
            Optional<string> replicationHealth = default;
            Optional<string> failoverHealth = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<string> policyFriendlyName = default;
            Optional<DateTimeOffset> lastSuccessfulFailoverTime = default;
            Optional<DateTimeOffset> lastSuccessfulTestFailoverTime = default;
            Optional<CurrentScenarioDetails> currentScenario = default;
            Optional<ResourceIdentifier> failoverRecoveryPointId = default;
            Optional<ReplicationProviderSpecificSettings> providerSpecificDetails = default;
            Optional<ResourceIdentifier> recoveryContainerId = default;
            Optional<Guid> eventCorrelationId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectableItemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    recoveryServicesProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricFriendlyName"u8))
                {
                    primaryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryFabricProvider"u8))
                {
                    primaryFabricProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricFriendlyName"u8))
                {
                    recoveryFabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryFabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryProtectionContainerFriendlyName"u8))
                {
                    primaryProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryProtectionContainerFriendlyName"u8))
                {
                    recoveryProtectionContainerFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    protectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStateDescription"u8))
                {
                    protectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activeLocation"u8))
                {
                    activeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverState"u8))
                {
                    testFailoverState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverStateDescription"u8))
                {
                    testFailoverStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("switchProviderState"u8))
                {
                    switchProviderState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("switchProviderStateDescription"u8))
                {
                    switchProviderStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedOperations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOperations = array;
                    continue;
                }
                if (property.NameEquals("replicationHealth"u8))
                {
                    replicationHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverHealth"u8))
                {
                    failoverHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyFriendlyName"u8))
                {
                    policyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSuccessfulFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSuccessfulTestFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulTestFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentScenario"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentScenario = CurrentScenarioDetails.DeserializeCurrentScenarioDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = ReplicationProviderSpecificSettings.DeserializeReplicationProviderSpecificSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventCorrelationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventCorrelationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReplicationProtectedItemProperties(friendlyName.Value, protectedItemType.Value, protectableItemId.Value, recoveryServicesProviderId.Value, primaryFabricFriendlyName.Value, primaryFabricProvider.Value, recoveryFabricFriendlyName.Value, recoveryFabricId.Value, primaryProtectionContainerFriendlyName.Value, recoveryProtectionContainerFriendlyName.Value, protectionState.Value, protectionStateDescription.Value, activeLocation.Value, testFailoverState.Value, testFailoverStateDescription.Value, switchProviderState.Value, switchProviderStateDescription.Value, Optional.ToList(allowedOperations), replicationHealth.Value, failoverHealth.Value, Optional.ToList(healthErrors), policyId.Value, policyFriendlyName.Value, Optional.ToNullable(lastSuccessfulFailoverTime), Optional.ToNullable(lastSuccessfulTestFailoverTime), currentScenario.Value, failoverRecoveryPointId.Value, providerSpecificDetails.Value, recoveryContainerId.Value, Optional.ToNullable(eventCorrelationId), rawData);
        }

        ReplicationProtectedItemProperties IModelJsonSerializable<ReplicationProtectedItemProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProtectedItemProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReplicationProtectedItemProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReplicationProtectedItemProperties IModelSerializable<ReplicationProtectedItemProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReplicationProtectedItemProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReplicationProtectedItemProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReplicationProtectedItemProperties"/> to convert. </param>
        public static implicit operator RequestContent(ReplicationProtectedItemProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReplicationProtectedItemProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReplicationProtectedItemProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReplicationProtectedItemProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
