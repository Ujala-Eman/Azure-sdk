// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseCustomerManagedKeyEncryption : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseCustomerManagedKeyEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseCustomerManagedKeyEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisEnterpriseCustomerManagedKeyEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyEncryptionKeyIdentity))
            {
                writer.WritePropertyName("keyEncryptionKeyIdentity"u8);
                writer.WriteObjectValue(KeyEncryptionKeyIdentity);
            }
            if (Optional.IsDefined(KeyEncryptionKeyUri))
            {
                writer.WritePropertyName("keyEncryptionKeyUrl"u8);
                writer.WriteStringValue(KeyEncryptionKeyUri.AbsoluteUri);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RedisEnterpriseCustomerManagedKeyEncryption IJsonModel<RedisEnterpriseCustomerManagedKeyEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseCustomerManagedKeyEncryption(document.RootElement, options);
        }

        internal static RedisEnterpriseCustomerManagedKeyEncryption DeserializeRedisEnterpriseCustomerManagedKeyEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity> keyEncryptionKeyIdentity = default;
            Optional<Uri> keyEncryptionKeyUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyEncryptionKeyIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyIdentity = RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity.DeserializeRedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKeyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisEnterpriseCustomerManagedKeyEncryption(keyEncryptionKeyIdentity.Value, keyEncryptionKeyUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryption)} does not support '{options.Format}' format.");
            }
        }

        RedisEnterpriseCustomerManagedKeyEncryption IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisEnterpriseCustomerManagedKeyEncryption(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RedisEnterpriseCustomerManagedKeyEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseCustomerManagedKeyEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
