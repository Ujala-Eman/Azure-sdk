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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SqlDataDirectoryMapping : IUtf8JsonSerializable, IJsonModel<SqlDataDirectoryMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlDataDirectoryMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlDataDirectoryMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SqlDataDirectoryMapping>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SqlDataDirectoryMapping>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MappingType))
            {
                writer.WritePropertyName("mappingType"u8);
                writer.WriteStringValue(MappingType.Value.ToString());
            }
            if (Optional.IsDefined(SourceLogicalName))
            {
                writer.WritePropertyName("sourceLogicalName"u8);
                writer.WriteStringValue(SourceLogicalName);
            }
            if (Optional.IsDefined(SourcePath))
            {
                writer.WritePropertyName("sourcePath"u8);
                writer.WriteStringValue(SourcePath);
            }
            if (Optional.IsDefined(TargetPath))
            {
                writer.WritePropertyName("targetPath"u8);
                writer.WriteStringValue(TargetPath);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SqlDataDirectoryMapping IJsonModel<SqlDataDirectoryMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlDataDirectoryMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDataDirectoryMapping(document.RootElement, options);
        }

        internal static SqlDataDirectoryMapping DeserializeSqlDataDirectoryMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlDataDirectoryType> mappingType = default;
            Optional<string> sourceLogicalName = default;
            Optional<string> sourcePath = default;
            Optional<string> targetPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mappingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mappingType = new SqlDataDirectoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceLogicalName"u8))
                {
                    sourceLogicalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePath"u8))
                {
                    sourcePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPath"u8))
                {
                    targetPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlDataDirectoryMapping(Optional.ToNullable(mappingType), sourceLogicalName.Value, sourcePath.Value, targetPath.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlDataDirectoryMapping>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlDataDirectoryMapping)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SqlDataDirectoryMapping IPersistableModel<SqlDataDirectoryMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlDataDirectoryMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSqlDataDirectoryMapping(document.RootElement, options);
        }

        string IPersistableModel<SqlDataDirectoryMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
