// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayCustomError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode");
                writer.WriteStringValue(StatusCode.Value.ToString());
            }
            if (Optional.IsDefined(CustomErrorPageUrl))
            {
                writer.WritePropertyName("customErrorPageUrl");
                writer.WriteStringValue(CustomErrorPageUrl);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayCustomError DeserializeApplicationGatewayCustomError(JsonElement element)
        {
            Optional<ApplicationGatewayCustomErrorStatusCode> statusCode = default;
            Optional<string> customErrorPageUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"))
                {
                    statusCode = new ApplicationGatewayCustomErrorStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customErrorPageUrl"))
                {
                    customErrorPageUrl = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayCustomError(statusCode.HasValue ? statusCode.Value : (ApplicationGatewayCustomErrorStatusCode?)null, customErrorPageUrl.HasValue ? customErrorPageUrl.Value : null);
        }
    }
}
