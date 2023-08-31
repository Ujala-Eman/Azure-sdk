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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AssociatedApiProperties : IUtf8JsonSerializable, IModelJsonSerializable<AssociatedApiProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AssociatedApiProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AssociatedApiProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedApiProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUrl"u8);
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AuthenticationSettings))
            {
                writer.WritePropertyName("authenticationSettings"u8);
                writer.WriteObjectValue(AuthenticationSettings);
            }
            if (Optional.IsDefined(SubscriptionKeyParameterNames))
            {
                writer.WritePropertyName("subscriptionKeyParameterNames"u8);
                writer.WriteObjectValue(SubscriptionKeyParameterNames);
            }
            if (Optional.IsDefined(ApiType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ApiType.Value.ToString());
            }
            if (Optional.IsDefined(ApiRevision))
            {
                writer.WritePropertyName("apiRevision"u8);
                writer.WriteStringValue(ApiRevision);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(IsCurrent))
            {
                writer.WritePropertyName("isCurrent"u8);
                writer.WriteBooleanValue(IsCurrent.Value);
            }
            if (Optional.IsDefined(ApiRevisionDescription))
            {
                writer.WritePropertyName("apiRevisionDescription"u8);
                writer.WriteStringValue(ApiRevisionDescription);
            }
            if (Optional.IsDefined(ApiVersionDescription))
            {
                writer.WritePropertyName("apiVersionDescription"u8);
                writer.WriteStringValue(ApiVersionDescription);
            }
            if (Optional.IsDefined(ApiVersionSetId))
            {
                writer.WritePropertyName("apiVersionSetId"u8);
                writer.WriteStringValue(ApiVersionSetId);
            }
            if (Optional.IsDefined(IsSubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired"u8);
                writer.WriteBooleanValue(IsSubscriptionRequired.Value);
            }
            if (Optional.IsDefined(TermsOfServiceUri))
            {
                writer.WritePropertyName("termsOfServiceUrl"u8);
                writer.WriteStringValue(TermsOfServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Contact))
            {
                writer.WritePropertyName("contact"u8);
                writer.WriteObjectValue(Contact);
            }
            if (Optional.IsDefined(License))
            {
                writer.WritePropertyName("license"u8);
                writer.WriteObjectValue(License);
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

        internal static AssociatedApiProperties DeserializeAssociatedApiProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<Uri> serviceUri = default;
            Optional<string> path = default;
            Optional<IReadOnlyList<ApiOperationInvokableProtocol>> protocols = default;
            Optional<string> description = default;
            Optional<AuthenticationSettingsContract> authenticationSettings = default;
            Optional<SubscriptionKeyParameterNamesContract> subscriptionKeyParameterNames = default;
            Optional<ApiType> type = default;
            Optional<string> apiRevision = default;
            Optional<string> apiVersion = default;
            Optional<bool> isCurrent = default;
            Optional<bool> isOnline = default;
            Optional<string> apiRevisionDescription = default;
            Optional<string> apiVersionDescription = default;
            Optional<ResourceIdentifier> apiVersionSetId = default;
            Optional<bool> subscriptionRequired = default;
            Optional<Uri> termsOfServiceUri = default;
            Optional<ApiContactInformation> contact = default;
            Optional<ApiLicenseInformation> license = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiOperationInvokableProtocol> array = new List<ApiOperationInvokableProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApiOperationInvokableProtocol(item.GetString()));
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (property.NameEquals("subscriptionKeyParameterNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ApiType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiRevision"u8))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCurrent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOnline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("apiRevisionDescription"u8))
                {
                    apiRevisionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionDescription"u8))
                {
                    apiVersionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiVersionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("termsOfServiceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termsOfServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contact = ApiContactInformation.DeserializeApiContactInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("license"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    license = ApiLicenseInformation.DeserializeApiLicenseInformation(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AssociatedApiProperties(description.Value, authenticationSettings.Value, subscriptionKeyParameterNames.Value, Optional.ToNullable(type), apiRevision.Value, apiVersion.Value, Optional.ToNullable(isCurrent), Optional.ToNullable(isOnline), apiRevisionDescription.Value, apiVersionDescription.Value, apiVersionSetId.Value, Optional.ToNullable(subscriptionRequired), termsOfServiceUri.Value, contact.Value, license.Value, id.Value, name.Value, serviceUri.Value, path.Value, Optional.ToList(protocols), rawData);
        }

        AssociatedApiProperties IModelJsonSerializable<AssociatedApiProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedApiProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAssociatedApiProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AssociatedApiProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedApiProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AssociatedApiProperties IModelSerializable<AssociatedApiProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedApiProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAssociatedApiProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AssociatedApiProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AssociatedApiProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAssociatedApiProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
