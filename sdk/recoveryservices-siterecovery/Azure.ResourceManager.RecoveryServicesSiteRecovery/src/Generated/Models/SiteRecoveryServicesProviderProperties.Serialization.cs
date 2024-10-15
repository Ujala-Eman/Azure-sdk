// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryServicesProviderProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryServicesProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryServicesProviderProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryServicesProviderProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FabricType))
            {
                writer.WritePropertyName("fabricType"u8);
                writer.WriteStringValue(FabricType);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProviderVersion))
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (Optional.IsDefined(ServerVersion))
            {
                writer.WritePropertyName("serverVersion"u8);
                writer.WriteStringValue(ServerVersion);
            }
            if (Optional.IsDefined(ProviderVersionState))
            {
                writer.WritePropertyName("providerVersionState"u8);
                writer.WriteStringValue(ProviderVersionState);
            }
            if (Optional.IsDefined(ProviderVersionExpireOn))
            {
                writer.WritePropertyName("providerVersionExpiryDate"u8);
                writer.WriteStringValue(ProviderVersionExpireOn.Value, "O");
            }
            if (Optional.IsDefined(FabricFriendlyName))
            {
                writer.WritePropertyName("fabricFriendlyName"u8);
                writer.WriteStringValue(FabricFriendlyName);
            }
            if (Optional.IsDefined(LastHeartbeatReceivedOn))
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (Optional.IsDefined(ConnectionStatus))
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus);
            }
            if (Optional.IsDefined(ProtectedItemCount))
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (Optional.IsCollectionDefined(AllowedScenarios))
            {
                writer.WritePropertyName("allowedScenarios"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedScenarios)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HealthErrorDetails))
            {
                writer.WritePropertyName("healthErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrorDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DraIdentifier))
            {
                writer.WritePropertyName("draIdentifier"u8);
                writer.WriteStringValue(DraIdentifier);
            }
            if (Optional.IsDefined(MachineId))
            {
                writer.WritePropertyName("machineId"u8);
                writer.WriteStringValue(MachineId);
            }
            if (Optional.IsDefined(MachineName))
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (Optional.IsDefined(AuthenticationIdentityDetails))
            {
                writer.WritePropertyName("authenticationIdentityDetails"u8);
                writer.WriteObjectValue(AuthenticationIdentityDetails, options);
            }
            if (Optional.IsDefined(ResourceAccessIdentityDetails))
            {
                writer.WritePropertyName("resourceAccessIdentityDetails"u8);
                writer.WriteObjectValue(ResourceAccessIdentityDetails, options);
            }
            if (Optional.IsDefined(DataPlaneAuthenticationIdentityDetails))
            {
                writer.WritePropertyName("dataPlaneAuthenticationIdentityDetails"u8);
                writer.WriteObjectValue(DataPlaneAuthenticationIdentityDetails, options);
            }
            if (Optional.IsDefined(ProviderVersionDetails))
            {
                writer.WritePropertyName("providerVersionDetails"u8);
                writer.WriteObjectValue(ProviderVersionDetails, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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
        }

        SiteRecoveryServicesProviderProperties IJsonModel<SiteRecoveryServicesProviderProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryServicesProviderProperties(document.RootElement, options);
        }

        internal static SiteRecoveryServicesProviderProperties DeserializeSiteRecoveryServicesProviderProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fabricType = default;
            string friendlyName = default;
            string providerVersion = default;
            string serverVersion = default;
            string providerVersionState = default;
            DateTimeOffset? providerVersionExpireOn = default;
            string fabricFriendlyName = default;
            DateTimeOffset? lastHeartBeat = default;
            string connectionStatus = default;
            int? protectedItemCount = default;
            IReadOnlyList<string> allowedScenarios = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrorDetails = default;
            string draIdentifier = default;
            string machineId = default;
            string machineName = default;
            string biosId = default;
            IdentityProviderDetails authenticationIdentityDetails = default;
            IdentityProviderDetails resourceAccessIdentityDetails = default;
            IdentityProviderDetails dataPlaneAuthenticationIdentityDetails = default;
            SiteRecoveryVersionDetails providerVersionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricType"u8))
                {
                    fabricType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverVersion"u8))
                {
                    serverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersionState"u8))
                {
                    providerVersionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fabricFriendlyName"u8))
                {
                    fabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartBeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartBeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    connectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedScenarios"u8))
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
                    allowedScenarios = array;
                    continue;
                }
                if (property.NameEquals("healthErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("draIdentifier"u8))
                {
                    draIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceAccessIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceAccessIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataPlaneAuthenticationIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneAuthenticationIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("providerVersionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerVersionDetails = SiteRecoveryVersionDetails.DeserializeSiteRecoveryVersionDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryServicesProviderProperties(
                fabricType,
                friendlyName,
                providerVersion,
                serverVersion,
                providerVersionState,
                providerVersionExpireOn,
                fabricFriendlyName,
                lastHeartBeat,
                connectionStatus,
                protectedItemCount,
                allowedScenarios ?? new ChangeTrackingList<string>(),
                healthErrorDetails ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                draIdentifier,
                machineId,
                machineName,
                biosId,
                authenticationIdentityDetails,
                resourceAccessIdentityDetails,
                dataPlaneAuthenticationIdentityDetails,
                providerVersionDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryServicesProviderProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryServicesProviderProperties IPersistableModel<SiteRecoveryServicesProviderProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryServicesProviderProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryServicesProviderProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
