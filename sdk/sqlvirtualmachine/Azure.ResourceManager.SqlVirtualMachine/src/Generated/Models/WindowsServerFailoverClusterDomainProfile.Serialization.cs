// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class WindowsServerFailoverClusterDomainProfile : IUtf8JsonSerializable, IJsonModel<WindowsServerFailoverClusterDomainProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsServerFailoverClusterDomainProfile>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WindowsServerFailoverClusterDomainProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DomainFqdn))
            {
                writer.WritePropertyName("domainFqdn"u8);
                writer.WriteStringValue(DomainFqdn);
            }
            if (Optional.IsDefined(OrganizationalUnitPath))
            {
                writer.WritePropertyName("ouPath"u8);
                writer.WriteStringValue(OrganizationalUnitPath);
            }
            if (Optional.IsDefined(ClusterBootstrapAccount))
            {
                writer.WritePropertyName("clusterBootstrapAccount"u8);
                writer.WriteStringValue(ClusterBootstrapAccount);
            }
            if (Optional.IsDefined(ClusterOperatorAccount))
            {
                writer.WritePropertyName("clusterOperatorAccount"u8);
                writer.WriteStringValue(ClusterOperatorAccount);
            }
            if (Optional.IsDefined(SqlServiceAccount))
            {
                writer.WritePropertyName("sqlServiceAccount"u8);
                writer.WriteStringValue(SqlServiceAccount);
            }
            if (Optional.IsDefined(FileShareWitnessPath))
            {
                writer.WritePropertyName("fileShareWitnessPath"u8);
                writer.WriteStringValue(FileShareWitnessPath);
            }
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageAccountPrimaryKey))
            {
                writer.WritePropertyName("storageAccountPrimaryKey"u8);
                writer.WriteStringValue(StorageAccountPrimaryKey);
            }
            if (Optional.IsDefined(ClusterSubnetType))
            {
                writer.WritePropertyName("clusterSubnetType"u8);
                writer.WriteStringValue(ClusterSubnetType.Value.ToString());
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        WindowsServerFailoverClusterDomainProfile IJsonModel<WindowsServerFailoverClusterDomainProfile>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsServerFailoverClusterDomainProfile(document.RootElement, options);
        }

        internal static WindowsServerFailoverClusterDomainProfile DeserializeWindowsServerFailoverClusterDomainProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domainFqdn = default;
            Optional<string> ouPath = default;
            Optional<string> clusterBootstrapAccount = default;
            Optional<string> clusterOperatorAccount = default;
            Optional<string> sqlServiceAccount = default;
            Optional<string> fileShareWitnessPath = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<string> storageAccountPrimaryKey = default;
            Optional<SqlVmClusterSubnetType> clusterSubnetType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainFqdn"u8))
                {
                    domainFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ouPath"u8))
                {
                    ouPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterBootstrapAccount"u8))
                {
                    clusterBootstrapAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterOperatorAccount"u8))
                {
                    clusterOperatorAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServiceAccount"u8))
                {
                    sqlServiceAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileShareWitnessPath"u8))
                {
                    fileShareWitnessPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountPrimaryKey"u8))
                {
                    storageAccountPrimaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterSubnetType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterSubnetType = new SqlVmClusterSubnetType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsServerFailoverClusterDomainProfile(domainFqdn.Value, ouPath.Value, clusterBootstrapAccount.Value, clusterOperatorAccount.Value, sqlServiceAccount.Value, fileShareWitnessPath.Value, storageAccountUrl.Value, storageAccountPrimaryKey.Value, Optional.ToNullable(clusterSubnetType), serializedAdditionalRawData);
        }

        BinaryData IModel<WindowsServerFailoverClusterDomainProfile>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WindowsServerFailoverClusterDomainProfile IModel<WindowsServerFailoverClusterDomainProfile>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WindowsServerFailoverClusterDomainProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWindowsServerFailoverClusterDomainProfile(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WindowsServerFailoverClusterDomainProfile>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
