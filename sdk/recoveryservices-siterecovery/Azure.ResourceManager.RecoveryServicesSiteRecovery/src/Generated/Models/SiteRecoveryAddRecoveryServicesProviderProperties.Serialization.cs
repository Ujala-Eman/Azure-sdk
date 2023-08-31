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
    public partial class SiteRecoveryAddRecoveryServicesProviderProperties : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryAddRecoveryServicesProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryAddRecoveryServicesProviderProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryAddRecoveryServicesProviderProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            if (Optional.IsDefined(MachineId))
            {
                writer.WritePropertyName("machineId"u8);
                writer.WriteStringValue(MachineId);
            }
            if (Optional.IsDefined(BiosId))
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            writer.WritePropertyName("authenticationIdentityInput"u8);
            if (AuthenticationIdentityContent is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<IdentityProviderContent>)AuthenticationIdentityContent).Serialize(writer, options);
            }
            writer.WritePropertyName("resourceAccessIdentityInput"u8);
            if (ResourceAccessIdentityContent is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<IdentityProviderContent>)ResourceAccessIdentityContent).Serialize(writer, options);
            }
            if (Optional.IsDefined(DataPlaneAuthenticationIdentityContent))
            {
                writer.WritePropertyName("dataPlaneAuthenticationIdentityInput"u8);
                if (DataPlaneAuthenticationIdentityContent is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IdentityProviderContent>)DataPlaneAuthenticationIdentityContent).Serialize(writer, options);
                }
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

        internal static SiteRecoveryAddRecoveryServicesProviderProperties DeserializeSiteRecoveryAddRecoveryServicesProviderProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string machineName = default;
            Optional<string> machineId = default;
            Optional<string> biosId = default;
            IdentityProviderContent authenticationIdentityContent = default;
            IdentityProviderContent resourceAccessIdentityContent = default;
            Optional<IdentityProviderContent> dataPlaneAuthenticationIdentityContent = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationIdentityInput"u8))
                {
                    authenticationIdentityContent = IdentityProviderContent.DeserializeIdentityProviderContent(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceAccessIdentityInput"u8))
                {
                    resourceAccessIdentityContent = IdentityProviderContent.DeserializeIdentityProviderContent(property.Value);
                    continue;
                }
                if (property.NameEquals("dataPlaneAuthenticationIdentityInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneAuthenticationIdentityContent = IdentityProviderContent.DeserializeIdentityProviderContent(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryAddRecoveryServicesProviderProperties(machineName, machineId.Value, biosId.Value, authenticationIdentityContent, resourceAccessIdentityContent, dataPlaneAuthenticationIdentityContent.Value, rawData);
        }

        SiteRecoveryAddRecoveryServicesProviderProperties IModelJsonSerializable<SiteRecoveryAddRecoveryServicesProviderProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryAddRecoveryServicesProviderProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryAddRecoveryServicesProviderProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryAddRecoveryServicesProviderProperties IModelSerializable<SiteRecoveryAddRecoveryServicesProviderProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryAddRecoveryServicesProviderProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryAddRecoveryServicesProviderProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryAddRecoveryServicesProviderProperties"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryAddRecoveryServicesProviderProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryAddRecoveryServicesProviderProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryAddRecoveryServicesProviderProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryAddRecoveryServicesProviderProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
