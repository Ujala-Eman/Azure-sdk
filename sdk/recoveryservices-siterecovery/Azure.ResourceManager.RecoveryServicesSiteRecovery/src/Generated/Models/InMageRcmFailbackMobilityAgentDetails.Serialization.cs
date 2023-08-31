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
    public partial class InMageRcmFailbackMobilityAgentDetails : IUtf8JsonSerializable, IModelJsonSerializable<InMageRcmFailbackMobilityAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageRcmFailbackMobilityAgentDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageRcmFailbackMobilityAgentDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static InMageRcmFailbackMobilityAgentDetails DeserializeInMageRcmFailbackMobilityAgentDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> version = default;
            Optional<string> latestVersion = default;
            Optional<string> driverVersion = default;
            Optional<string> latestUpgradableVersionWithoutReboot = default;
            Optional<DateTimeOffset> agentVersionExpireOn = default;
            Optional<DateTimeOffset> driverVersionExpireOn = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<IReadOnlyList<AgentUpgradeBlockedReason>> reasonsBlockingUpgrade = default;
            Optional<string> isUpgradeable = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestVersion"u8))
                {
                    latestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverVersion"u8))
                {
                    driverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestUpgradableVersionWithoutReboot"u8))
                {
                    latestUpgradableVersionWithoutReboot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("driverVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driverVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("reasonsBlockingUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgentUpgradeBlockedReason> array = new List<AgentUpgradeBlockedReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AgentUpgradeBlockedReason(item.GetString()));
                    }
                    reasonsBlockingUpgrade = array;
                    continue;
                }
                if (property.NameEquals("isUpgradeable"u8))
                {
                    isUpgradeable = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InMageRcmFailbackMobilityAgentDetails(version.Value, latestVersion.Value, driverVersion.Value, latestUpgradableVersionWithoutReboot.Value, Optional.ToNullable(agentVersionExpireOn), Optional.ToNullable(driverVersionExpireOn), Optional.ToNullable(lastHeartbeatUtc), Optional.ToList(reasonsBlockingUpgrade), isUpgradeable.Value, rawData);
        }

        InMageRcmFailbackMobilityAgentDetails IModelJsonSerializable<InMageRcmFailbackMobilityAgentDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackMobilityAgentDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageRcmFailbackMobilityAgentDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageRcmFailbackMobilityAgentDetails IModelSerializable<InMageRcmFailbackMobilityAgentDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageRcmFailbackMobilityAgentDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InMageRcmFailbackMobilityAgentDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InMageRcmFailbackMobilityAgentDetails"/> to convert. </param>
        public static implicit operator RequestContent(InMageRcmFailbackMobilityAgentDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InMageRcmFailbackMobilityAgentDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InMageRcmFailbackMobilityAgentDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageRcmFailbackMobilityAgentDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
