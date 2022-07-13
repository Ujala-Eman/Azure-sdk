// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class KeyVaultSecretUriSecretInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            writer.WritePropertyName("secretType");
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static KeyVaultSecretUriSecretInfo DeserializeKeyVaultSecretUriSecretInfo(JsonElement element)
        {
            Optional<string> value = default;
            LinkerSecretType secretType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretType"))
                {
                    secretType = new LinkerSecretType(property.Value.GetString());
                    continue;
                }
            }
            return new KeyVaultSecretUriSecretInfo(secretType, value.Value);
        }
    }
}
