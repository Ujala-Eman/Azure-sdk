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

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlServerPropertiesForRestore : IUtf8JsonSerializable, IJsonModel<PostgreSqlServerPropertiesForRestore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlServerPropertiesForRestore>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlServerPropertiesForRestore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerPropertiesForRestore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlServerPropertiesForRestore)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceServerId"u8);
            writer.WriteStringValue(SourceServerId);
            writer.WritePropertyName("restorePointInTime"u8);
            writer.WriteStringValue(RestorePointInTime, "O");
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(SslEnforcement))
            {
                writer.WritePropertyName("sslEnforcement"u8);
                writer.WriteStringValue(SslEnforcement.Value.ToSerialString());
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryption))
            {
                writer.WritePropertyName("infrastructureEncryption"u8);
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            writer.WritePropertyName("createMode"u8);
            writer.WriteStringValue(CreateMode.ToString());
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

        PostgreSqlServerPropertiesForRestore IJsonModel<PostgreSqlServerPropertiesForRestore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerPropertiesForRestore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlServerPropertiesForRestore)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlServerPropertiesForRestore(document.RootElement, options);
        }

        internal static PostgreSqlServerPropertiesForRestore DeserializePostgreSqlServerPropertiesForRestore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sourceServerId = default;
            DateTimeOffset restorePointInTime = default;
            Optional<PostgreSqlServerVersion> version = default;
            Optional<PostgreSqlSslEnforcementEnum> sslEnforcement = default;
            Optional<PostgreSqlMinimalTlsVersionEnum> minimalTlsVersion = default;
            Optional<PostgreSqlInfrastructureEncryption> infrastructureEncryption = default;
            Optional<PostgreSqlPublicNetworkAccessEnum> publicNetworkAccess = default;
            Optional<PostgreSqlStorageProfile> storageProfile = default;
            PostgreSqlCreateMode createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceServerId"u8))
                {
                    sourceServerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restorePointInTime"u8))
                {
                    restorePointInTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = new PostgreSqlServerVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslEnforcement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslEnforcement = property.Value.GetString().ToPostgreSqlSslEnforcementEnum();
                    continue;
                }
                if (property.NameEquals("minimalTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimalTlsVersion = new PostgreSqlMinimalTlsVersionEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryption = new PostgreSqlInfrastructureEncryption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PostgreSqlPublicNetworkAccessEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = PostgreSqlStorageProfile.DeserializePostgreSqlStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    createMode = new PostgreSqlCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlServerPropertiesForRestore(Optional.ToNullable(version), Optional.ToNullable(sslEnforcement), Optional.ToNullable(minimalTlsVersion), Optional.ToNullable(infrastructureEncryption), Optional.ToNullable(publicNetworkAccess), storageProfile.Value, createMode, serializedAdditionalRawData, sourceServerId, restorePointInTime);
        }

        BinaryData IPersistableModel<PostgreSqlServerPropertiesForRestore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerPropertiesForRestore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlServerPropertiesForRestore)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlServerPropertiesForRestore IPersistableModel<PostgreSqlServerPropertiesForRestore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlServerPropertiesForRestore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlServerPropertiesForRestore(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlServerPropertiesForRestore)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlServerPropertiesForRestore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
