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
    public partial class SqlInstanceSettings : IUtf8JsonSerializable, IJsonModel<SqlInstanceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlInstanceSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SqlInstanceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxDop))
            {
                writer.WritePropertyName("maxDop"u8);
                writer.WriteNumberValue(MaxDop.Value);
            }
            if (Optional.IsDefined(IsOptimizeForAdHocWorkloadsEnabled))
            {
                writer.WritePropertyName("isOptimizeForAdHocWorkloadsEnabled"u8);
                writer.WriteBooleanValue(IsOptimizeForAdHocWorkloadsEnabled.Value);
            }
            if (Optional.IsDefined(MinServerMemoryInMB))
            {
                writer.WritePropertyName("minServerMemoryMB"u8);
                writer.WriteNumberValue(MinServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(MaxServerMemoryInMB))
            {
                writer.WritePropertyName("maxServerMemoryMB"u8);
                writer.WriteNumberValue(MaxServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(IsLpimEnabled))
            {
                writer.WritePropertyName("isLpimEnabled"u8);
                writer.WriteBooleanValue(IsLpimEnabled.Value);
            }
            if (Optional.IsDefined(IsIfiEnabled))
            {
                writer.WritePropertyName("isIfiEnabled"u8);
                writer.WriteBooleanValue(IsIfiEnabled.Value);
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

        SqlInstanceSettings IJsonModel<SqlInstanceSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlInstanceSettings(document.RootElement, options);
        }

        internal static SqlInstanceSettings DeserializeSqlInstanceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> collation = default;
            Optional<int> maxDop = default;
            Optional<bool> isOptimizeForAdHocWorkloadsEnabled = default;
            Optional<int> minServerMemoryMB = default;
            Optional<int> maxServerMemoryMB = default;
            Optional<bool> isLpimEnabled = default;
            Optional<bool> isIfiEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collation"u8))
                {
                    collation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDop = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isOptimizeForAdHocWorkloadsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptimizeForAdHocWorkloadsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minServerMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxServerMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isLpimEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLpimEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isIfiEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isIfiEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlInstanceSettings(collation.Value, Optional.ToNullable(maxDop), Optional.ToNullable(isOptimizeForAdHocWorkloadsEnabled), Optional.ToNullable(minServerMemoryMB), Optional.ToNullable(maxServerMemoryMB), Optional.ToNullable(isLpimEnabled), Optional.ToNullable(isIfiEnabled), serializedAdditionalRawData);
        }

        BinaryData IModel<SqlInstanceSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SqlInstanceSettings IModel<SqlInstanceSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSqlInstanceSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SqlInstanceSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
