// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class Encryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Services))
            {
                writer.WritePropertyName("services");
                writer.WriteObjectValue(Services);
            }
            writer.WritePropertyName("keySource");
            writer.WriteStringValue(KeySource.ToString());
            if (Optional.IsDefined(RequireInfrastructureEncryption))
            {
                writer.WritePropertyName("requireInfrastructureEncryption");
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyvaultproperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            writer.WriteEndObject();
        }

        internal static Encryption DeserializeEncryption(JsonElement element)
        {
            Optional<EncryptionServices> services = default;
            KeySource keySource = default;
            Optional<bool> requireInfrastructureEncryption = default;
            Optional<KeyVaultProperties> keyvaultproperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("services"))
                {
                    services = EncryptionServices.DeserializeEncryptionServices(property.Value);
                    continue;
                }
                if (property.NameEquals("keySource"))
                {
                    keySource = new KeySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requireInfrastructureEncryption"))
                {
                    requireInfrastructureEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyvaultproperties"))
                {
                    keyvaultproperties = KeyVaultProperties.DeserializeKeyVaultProperties(property.Value);
                    continue;
                }
            }
            return new Encryption(services.HasValue ? services.Value : null, keySource, requireInfrastructureEncryption.HasValue ? requireInfrastructureEncryption.Value : (bool?)null, keyvaultproperties.HasValue ? keyvaultproperties.Value : null);
        }
    }
}
