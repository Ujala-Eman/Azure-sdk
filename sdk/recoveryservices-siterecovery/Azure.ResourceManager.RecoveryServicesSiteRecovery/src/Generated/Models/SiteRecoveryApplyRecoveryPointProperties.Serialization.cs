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
    public partial class SiteRecoveryApplyRecoveryPointProperties : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryApplyRecoveryPointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryApplyRecoveryPointProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryApplyRecoveryPointProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            writer.WritePropertyName("providerSpecificDetails"u8);
            if (ProviderSpecificDetails is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SiteRecoveryApplyRecoveryPointProviderSpecificContent>)ProviderSpecificDetails).Serialize(writer, options);
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

        internal static SiteRecoveryApplyRecoveryPointProperties DeserializeSiteRecoveryApplyRecoveryPointProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> recoveryPointId = default;
            SiteRecoveryApplyRecoveryPointProviderSpecificContent providerSpecificDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    providerSpecificDetails = SiteRecoveryApplyRecoveryPointProviderSpecificContent.DeserializeSiteRecoveryApplyRecoveryPointProviderSpecificContent(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryApplyRecoveryPointProperties(recoveryPointId.Value, providerSpecificDetails, rawData);
        }

        SiteRecoveryApplyRecoveryPointProperties IModelJsonSerializable<SiteRecoveryApplyRecoveryPointProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryApplyRecoveryPointProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryApplyRecoveryPointProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryApplyRecoveryPointProperties IModelSerializable<SiteRecoveryApplyRecoveryPointProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryApplyRecoveryPointProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryApplyRecoveryPointProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryApplyRecoveryPointProperties"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryApplyRecoveryPointProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryApplyRecoveryPointProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryApplyRecoveryPointProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryApplyRecoveryPointProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
