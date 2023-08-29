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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class AzureADPartnerClientAuthentication : IUtf8JsonSerializable, IModelJsonSerializable<AzureADPartnerClientAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureADPartnerClientAuthentication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureADPartnerClientAuthentication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureADPartnerClientAuthentication>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("clientAuthenticationType"u8);
            writer.WriteStringValue(ClientAuthenticationType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureActiveDirectoryTenantId))
            {
                writer.WritePropertyName("azureActiveDirectoryTenantId"u8);
                writer.WriteStringValue(AzureActiveDirectoryTenantId);
            }
            if (Optional.IsDefined(AzureActiveDirectoryApplicationIdOrUri))
            {
                writer.WritePropertyName("azureActiveDirectoryApplicationIdOrUri"u8);
                writer.WriteStringValue(AzureActiveDirectoryApplicationIdOrUri.AbsoluteUri);
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

        internal static AzureADPartnerClientAuthentication DeserializeAzureADPartnerClientAuthentication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartnerClientAuthenticationType clientAuthenticationType = default;
            Optional<string> azureActiveDirectoryTenantId = default;
            Optional<Uri> azureActiveDirectoryApplicationIdOrUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAuthenticationType"u8))
                {
                    clientAuthenticationType = new PartnerClientAuthenticationType(property.Value.GetString());
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
                        if (property0.NameEquals("azureActiveDirectoryTenantId"u8))
                        {
                            azureActiveDirectoryTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectoryApplicationIdOrUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureActiveDirectoryApplicationIdOrUri = new Uri(property0.Value.GetString());
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
            return new AzureADPartnerClientAuthentication(clientAuthenticationType, azureActiveDirectoryTenantId.Value, azureActiveDirectoryApplicationIdOrUri.Value, rawData);
        }

        AzureADPartnerClientAuthentication IModelJsonSerializable<AzureADPartnerClientAuthentication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureADPartnerClientAuthentication>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureADPartnerClientAuthentication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureADPartnerClientAuthentication>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureADPartnerClientAuthentication>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureADPartnerClientAuthentication IModelSerializable<AzureADPartnerClientAuthentication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureADPartnerClientAuthentication>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureADPartnerClientAuthentication(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AzureADPartnerClientAuthentication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AzureADPartnerClientAuthentication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureADPartnerClientAuthentication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
