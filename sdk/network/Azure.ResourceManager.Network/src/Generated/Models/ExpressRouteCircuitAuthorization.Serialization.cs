// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey");
                writer.WriteStringValue(AuthorizationKey);
            }
            if (Optional.IsDefined(AuthorizationUseStatus))
            {
                writer.WritePropertyName("authorizationUseStatus");
                writer.WriteStringValue(AuthorizationUseStatus.Value.ToString());
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuitAuthorization DeserializeExpressRouteCircuitAuthorization(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<string> authorizationKey = default;
            Optional<AuthorizationUseStatus> authorizationUseStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authorizationKey"))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationUseStatus"))
                        {
                            authorizationUseStatus = new AuthorizationUseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCircuitAuthorization(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, etag.HasValue ? etag.Value : null, type.HasValue ? type.Value : null, authorizationKey.HasValue ? authorizationKey.Value : null, authorizationUseStatus.HasValue ? authorizationUseStatus.Value : (AuthorizationUseStatus?)null, provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
