// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ApiKeyVaultReferenceData : IUtf8JsonSerializable, IJsonModel<ApiKeyVaultReferenceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiKeyVaultReferenceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiKeyVaultReferenceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Reference != null)
            {
                writer.WritePropertyName("reference"u8);
                writer.WriteStringValue(Reference);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (VaultName != null)
            {
                writer.WritePropertyName("vaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (SecretName != null)
            {
                writer.WritePropertyName("secretName"u8);
                writer.WriteStringValue(SecretName);
            }
            if (SecretVersion != null)
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identityType"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Details != null)
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
            }
            if (Source.HasValue)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (ActiveVersion != null)
            {
                writer.WritePropertyName("activeVersion"u8);
                writer.WriteStringValue(ActiveVersion);
            }
            writer.WriteEndObject();
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

        ApiKeyVaultReferenceData IJsonModel<ApiKeyVaultReferenceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiKeyVaultReferenceData(document.RootElement, options);
        }

        internal static ApiKeyVaultReferenceData DeserializeApiKeyVaultReferenceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string reference = default;
            ResolveStatus? status = default;
            string vaultName = default;
            string secretName = default;
            string secretVersion = default;
            ManagedServiceIdentity identityType = default;
            string details = default;
            ConfigReferenceSource? source = default;
            string activeVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("reference"u8))
                        {
                            reference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToResolveStatus();
                            continue;
                        }
                        if (property0.NameEquals("vaultName"u8))
                        {
                            vaultName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretName"u8))
                        {
                            secretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretVersion"u8))
                        {
                            secretVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identityType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identityType = JsonSerializer.Deserialize<ManagedServiceIdentity>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            details = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new ConfigReferenceSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activeVersion"u8))
                        {
                            activeVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiKeyVaultReferenceData(
                id,
                name,
                type,
                systemData,
                reference,
                status,
                vaultName,
                secretName,
                secretVersion,
                identityType,
                details,
                source,
                activeVersion,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiKeyVaultReferenceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support '{options.Format}' format.");
            }
        }

        ApiKeyVaultReferenceData IPersistableModel<ApiKeyVaultReferenceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiKeyVaultReferenceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiKeyVaultReferenceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiKeyVaultReferenceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiKeyVaultReferenceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
