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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAlert : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsAlert>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsAlert>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsAlert>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAlert>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static SecurityInsightsAlert DeserializeSecurityInsightsAlert(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> alertDisplayName = default;
            Optional<string> alertType = default;
            Optional<string> compromisedEntity = default;
            Optional<SecurityInsightsAlertConfidenceLevel> confidenceLevel = default;
            Optional<IReadOnlyList<SecurityInsightsAlertConfidenceReason>> confidenceReasons = default;
            Optional<double> confidenceScore = default;
            Optional<SecurityInsightsAlertConfidenceScoreStatus> confidenceScoreStatus = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<SecurityInsightsKillChainIntent> intent = default;
            Optional<string> providerAlertId = default;
            Optional<DateTimeOffset> processingEndTime = default;
            Optional<string> productComponentName = default;
            Optional<string> productName = default;
            Optional<string> productVersion = default;
            Optional<IReadOnlyList<string>> remediationSteps = default;
            Optional<SecurityInsightsAlertSeverity> severity = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<SecurityInsightsAlertStatus> status = default;
            Optional<string> systemAlertId = default;
            Optional<IReadOnlyList<SecurityInsightsAttackTactic>> tactics = default;
            Optional<DateTimeOffset> timeGenerated = default;
            Optional<string> vendorName = default;
            Optional<string> alertLink = default;
            Optional<IReadOnlyList<BinaryData>> resourceIdentifiers = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertDisplayName"u8))
                        {
                            alertDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertType"u8))
                        {
                            alertType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("compromisedEntity"u8))
                        {
                            compromisedEntity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("confidenceLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceLevel = new SecurityInsightsAlertConfidenceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("confidenceReasons"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertConfidenceReason> array = new List<SecurityInsightsAlertConfidenceReason>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAlertConfidenceReason.DeserializeSecurityInsightsAlertConfidenceReason(item));
                            }
                            confidenceReasons = array;
                            continue;
                        }
                        if (property0.NameEquals("confidenceScore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceScore = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("confidenceScoreStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceScoreStatus = new SecurityInsightsAlertConfidenceScoreStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("intent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intent = new SecurityInsightsKillChainIntent(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("providerAlertId"u8))
                        {
                            providerAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processingEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            processingEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("productComponentName"u8))
                        {
                            productComponentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productName"u8))
                        {
                            productName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productVersion"u8))
                        {
                            productVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationSteps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            remediationSteps = array;
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("systemAlertId"u8))
                        {
                            systemAlertId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("timeGenerated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGenerated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertLink"u8))
                        {
                            alertLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceIdentifiers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            resourceIdentifiers = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsAlert(id, name, type, systemData.Value, kind, Optional.ToDictionary(additionalData), friendlyName.Value, alertDisplayName.Value, alertType.Value, compromisedEntity.Value, Optional.ToNullable(confidenceLevel), Optional.ToList(confidenceReasons), Optional.ToNullable(confidenceScore), Optional.ToNullable(confidenceScoreStatus), description.Value, Optional.ToNullable(endTimeUtc), Optional.ToNullable(intent), providerAlertId.Value, Optional.ToNullable(processingEndTime), productComponentName.Value, productName.Value, productVersion.Value, Optional.ToList(remediationSteps), Optional.ToNullable(severity), Optional.ToNullable(startTimeUtc), Optional.ToNullable(status), systemAlertId.Value, Optional.ToList(tactics), Optional.ToNullable(timeGenerated), vendorName.Value, alertLink.Value, Optional.ToList(resourceIdentifiers), rawData);
        }

        SecurityInsightsAlert IModelJsonSerializable<SecurityInsightsAlert>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAlert>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAlert(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsAlert>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAlert>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsAlert IModelSerializable<SecurityInsightsAlert>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityInsightsAlert>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAlert(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsAlert"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsAlert"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsAlert model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsAlert"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsAlert(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsAlert(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
