// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class OAuth2WebhookClientCredential
    {
        internal static OAuth2WebhookClientCredential DeserializeOAuth2WebhookClientCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
            }
            return new OAuth2WebhookClientCredential(clientId.Value, clientSecret.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OAuth2WebhookClientCredential FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOAuth2WebhookClientCredential(document.RootElement);
        }
    }
}
