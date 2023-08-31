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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ProviderPermission : IUtf8JsonSerializable, IModelJsonSerializable<ProviderPermission>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderPermission>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProviderPermission>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (Optional.IsDefined(RoleDefinition))
            {
                writer.WritePropertyName("roleDefinition"u8);
                if (RoleDefinition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AzureRoleDefinition>)RoleDefinition).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ManagedByRoleDefinition))
            {
                writer.WritePropertyName("managedByRoleDefinition"u8);
                if (ManagedByRoleDefinition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AzureRoleDefinition>)ManagedByRoleDefinition).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ProviderAuthorizationConsentState))
            {
                writer.WritePropertyName("providerAuthorizationConsentState"u8);
                writer.WriteStringValue(ProviderAuthorizationConsentState.Value.ToString());
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

        internal static ProviderPermission DeserializeProviderPermission(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> applicationId = default;
            Optional<AzureRoleDefinition> roleDefinition = default;
            Optional<AzureRoleDefinition> managedByRoleDefinition = default;
            Optional<ProviderAuthorizationConsentState> providerAuthorizationConsentState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    roleDefinition = AzureRoleDefinition.DeserializeAzureRoleDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("managedByRoleDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedByRoleDefinition = AzureRoleDefinition.DeserializeAzureRoleDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthorizationConsentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthorizationConsentState = new ProviderAuthorizationConsentState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProviderPermission(applicationId.Value, roleDefinition.Value, managedByRoleDefinition.Value, Optional.ToNullable(providerAuthorizationConsentState), rawData);
        }

        ProviderPermission IModelJsonSerializable<ProviderPermission>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderPermission(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderPermission>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProviderPermission IModelSerializable<ProviderPermission>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderPermission(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProviderPermission"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProviderPermission"/> to convert. </param>
        public static implicit operator RequestContent(ProviderPermission model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProviderPermission"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProviderPermission(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProviderPermission(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
