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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class GovernanceAssignmentData : IUtf8JsonSerializable, IModelJsonSerializable<GovernanceAssignmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GovernanceAssignmentData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GovernanceAssignmentData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(RemediationDueOn))
            {
                writer.WritePropertyName("remediationDueDate"u8);
                writer.WriteStringValue(RemediationDueOn.Value, "O");
            }
            if (Optional.IsDefined(RemediationEta))
            {
                writer.WritePropertyName("remediationEta"u8);
                if (RemediationEta is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RemediationEta>)RemediationEta).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsGracePeriod))
            {
                writer.WritePropertyName("isGracePeriod"u8);
                writer.WriteBooleanValue(IsGracePeriod.Value);
            }
            if (Optional.IsDefined(GovernanceEmailNotification))
            {
                writer.WritePropertyName("governanceEmailNotification"u8);
                if (GovernanceEmailNotification is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GovernanceEmailNotification>)GovernanceEmailNotification).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                if (AdditionalData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GovernanceAssignmentAdditionalInfo>)AdditionalData).Serialize(writer, options);
                }
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

        internal static GovernanceAssignmentData DeserializeGovernanceAssignmentData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> owner = default;
            Optional<DateTimeOffset> remediationDueDate = default;
            Optional<RemediationEta> remediationEta = default;
            Optional<bool> isGracePeriod = default;
            Optional<GovernanceEmailNotification> governanceEmailNotification = default;
            Optional<GovernanceAssignmentAdditionalInfo> additionalData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("owner"u8))
                        {
                            owner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationDueDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remediationDueDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("remediationEta"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remediationEta = RemediationEta.DeserializeRemediationEta(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isGracePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGracePeriod = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("governanceEmailNotification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            governanceEmailNotification = GovernanceEmailNotification.DeserializeGovernanceEmailNotification(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            additionalData = GovernanceAssignmentAdditionalInfo.DeserializeGovernanceAssignmentAdditionalInfo(property0.Value);
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
            return new GovernanceAssignmentData(id, name, type, systemData.Value, owner.Value, Optional.ToNullable(remediationDueDate), remediationEta.Value, Optional.ToNullable(isGracePeriod), governanceEmailNotification.Value, additionalData.Value, rawData);
        }

        GovernanceAssignmentData IModelJsonSerializable<GovernanceAssignmentData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceAssignmentData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GovernanceAssignmentData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GovernanceAssignmentData IModelSerializable<GovernanceAssignmentData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGovernanceAssignmentData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GovernanceAssignmentData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GovernanceAssignmentData"/> to convert. </param>
        public static implicit operator RequestContent(GovernanceAssignmentData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GovernanceAssignmentData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GovernanceAssignmentData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGovernanceAssignmentData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
