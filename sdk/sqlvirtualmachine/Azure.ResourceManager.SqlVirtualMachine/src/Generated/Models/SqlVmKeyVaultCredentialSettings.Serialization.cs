// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmKeyVaultCredentialSettings : IUtf8JsonSerializable, IJsonModel<SqlVmKeyVaultCredentialSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlVmKeyVaultCredentialSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlVmKeyVaultCredentialSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmKeyVaultCredentialSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmKeyVaultCredentialSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CredentialName))
            {
                writer.WritePropertyName("credentialName"u8);
                writer.WriteStringValue(CredentialName);
            }
            if (Optional.IsDefined(AzureKeyVaultUri))
            {
                writer.WritePropertyName("azureKeyVaultUrl"u8);
                writer.WriteStringValue(AzureKeyVaultUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ServicePrincipalName))
            {
                writer.WritePropertyName("servicePrincipalName"u8);
                writer.WriteStringValue(ServicePrincipalName);
            }
            if (Optional.IsDefined(ServicePrincipalSecret))
            {
                writer.WritePropertyName("servicePrincipalSecret"u8);
                writer.WriteStringValue(ServicePrincipalSecret);
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
        }

        SqlVmKeyVaultCredentialSettings IJsonModel<SqlVmKeyVaultCredentialSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmKeyVaultCredentialSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmKeyVaultCredentialSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlVmKeyVaultCredentialSettings(document.RootElement, options);
        }

        internal static SqlVmKeyVaultCredentialSettings DeserializeSqlVmKeyVaultCredentialSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enable = default;
            string credentialName = default;
            Uri azureKeyVaultUrl = default;
            string servicePrincipalName = default;
            string servicePrincipalSecret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("credentialName"u8))
                {
                    credentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureKeyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureKeyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("servicePrincipalName"u8))
                {
                    servicePrincipalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalSecret"u8))
                {
                    servicePrincipalSecret = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlVmKeyVaultCredentialSettings(
                enable,
                credentialName,
                azureKeyVaultUrl,
                servicePrincipalName,
                servicePrincipalSecret,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlVmKeyVaultCredentialSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmKeyVaultCredentialSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlVmKeyVaultCredentialSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SqlVmKeyVaultCredentialSettings IPersistableModel<SqlVmKeyVaultCredentialSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmKeyVaultCredentialSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlVmKeyVaultCredentialSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlVmKeyVaultCredentialSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlVmKeyVaultCredentialSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
