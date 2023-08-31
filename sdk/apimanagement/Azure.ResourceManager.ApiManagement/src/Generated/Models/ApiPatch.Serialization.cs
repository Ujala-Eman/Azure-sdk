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
    public partial class ApiPatch : IUtf8JsonSerializable, IModelJsonSerializable<ApiPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApiPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApiPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
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

        internal static ApiPatch DeserializeApiPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
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
            Optional<string> displayName = default;
            Optional<Uri> serviceUri = default;
            Optional<string> path = default;
            Optional<IList<ApiOperationInvokableProtocol>> protocols = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subscriptionKeyParameterNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type = new ApiType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiRevision"u8))
                        {
                            apiRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersion"u8))
                        {
                            apiVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCurrent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCurrent = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isOnline"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isOnline = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiRevisionDescription"u8))
                        {
                            apiRevisionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionDescription"u8))
                        {
                            apiVersionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersionSetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("termsOfServiceUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            termsOfServiceUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("contact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contact = ApiContactInformation.DeserializeApiContactInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("license"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            license = ApiLicenseInformation.DeserializeApiLicenseInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApiOperationInvokableProtocol> array = new List<ApiOperationInvokableProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ApiOperationInvokableProtocol(item.GetString()));
                            }
                            protocols = array;
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
            return new ApiPatch(description.Value, authenticationSettings.Value, subscriptionKeyParameterNames.Value, Optional.ToNullable(type), apiRevision.Value, apiVersion.Value, Optional.ToNullable(isCurrent), Optional.ToNullable(isOnline), apiRevisionDescription.Value, apiVersionDescription.Value, apiVersionSetId.Value, Optional.ToNullable(subscriptionRequired), termsOfServiceUri.Value, contact.Value, license.Value, displayName.Value, serviceUri.Value, path.Value, Optional.ToList(protocols), rawData);
        }

        ApiPatch IModelJsonSerializable<ApiPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApiPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApiPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApiPatch IModelSerializable<ApiPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApiPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ApiPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ApiPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApiPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
