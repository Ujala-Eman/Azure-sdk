// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class IdentityForCmk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity");
                writer.WriteStringValue(UserAssignedIdentity);
            }
            writer.WriteEndObject();
        }

        internal static IdentityForCmk DeserializeIdentityForCmk(JsonElement element)
        {
            Optional<string> userAssignedIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"))
                {
                    userAssignedIdentity = property.Value.GetString();
                    continue;
                }
            }
            return new IdentityForCmk(userAssignedIdentity.Value);
        }
    }
}
