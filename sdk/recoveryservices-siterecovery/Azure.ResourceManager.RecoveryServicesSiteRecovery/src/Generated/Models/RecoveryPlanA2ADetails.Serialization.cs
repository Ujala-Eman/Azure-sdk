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
    public partial class RecoveryPlanA2ADetails : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryPlanA2ADetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryPlanA2ADetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryPlanA2ADetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanA2ADetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryZone))
            {
                writer.WritePropertyName("primaryZone"u8);
                writer.WriteStringValue(PrimaryZone);
            }
            if (Optional.IsDefined(RecoveryZone))
            {
                writer.WritePropertyName("recoveryZone"u8);
                writer.WriteStringValue(RecoveryZone);
            }
            if (Optional.IsDefined(PrimaryExtendedLocation))
            {
                writer.WritePropertyName("primaryExtendedLocation"u8);
                if (PrimaryExtendedLocation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryExtendedLocation>)PrimaryExtendedLocation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RecoveryExtendedLocation))
            {
                writer.WritePropertyName("recoveryExtendedLocation"u8);
                if (RecoveryExtendedLocation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryExtendedLocation>)RecoveryExtendedLocation).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static RecoveryPlanA2ADetails DeserializeRecoveryPlanA2ADetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryZone = default;
            Optional<string> recoveryZone = default;
            Optional<SiteRecoveryExtendedLocation> primaryExtendedLocation = default;
            Optional<SiteRecoveryExtendedLocation> recoveryExtendedLocation = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryZone"u8))
                {
                    primaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryZone"u8))
                {
                    recoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecoveryPlanA2ADetails(instanceType, primaryZone.Value, recoveryZone.Value, primaryExtendedLocation.Value, recoveryExtendedLocation.Value, rawData);
        }

        RecoveryPlanA2ADetails IModelJsonSerializable<RecoveryPlanA2ADetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanA2ADetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanA2ADetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryPlanA2ADetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanA2ADetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryPlanA2ADetails IModelSerializable<RecoveryPlanA2ADetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RecoveryPlanA2ADetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanA2ADetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryPlanA2ADetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryPlanA2ADetails"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryPlanA2ADetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryPlanA2ADetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryPlanA2ADetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryPlanA2ADetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
