// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class CustomerManagedEncryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            writer.WriteEndObject();
        }

        internal static CustomerManagedEncryption DeserializeCustomerManagedEncryption(JsonElement element)
        {
            Optional<EncryptionState> status = default;
            Optional<AvsEncryptionKeyVaultProperties> keyVaultProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new EncryptionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyVaultProperties = AvsEncryptionKeyVaultProperties.DeserializeAvsEncryptionKeyVaultProperties(property.Value);
                    continue;
                }
            }
            return new CustomerManagedEncryption(Optional.ToNullable(status), keyVaultProperties.Value);
        }
    }
}
