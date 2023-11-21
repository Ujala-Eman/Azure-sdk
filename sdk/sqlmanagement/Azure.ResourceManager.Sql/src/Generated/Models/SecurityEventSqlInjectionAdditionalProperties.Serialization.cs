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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SecurityEventSqlInjectionAdditionalProperties : IUtf8JsonSerializable, IJsonModel<SecurityEventSqlInjectionAdditionalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityEventSqlInjectionAdditionalProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityEventSqlInjectionAdditionalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ThreatId))
            {
                writer.WritePropertyName("threatId"u8);
                writer.WriteStringValue(ThreatId);
            }
            if (options.Format != "W" && Optional.IsDefined(Statement))
            {
                writer.WritePropertyName("statement"u8);
                writer.WriteStringValue(Statement);
            }
            if (options.Format != "W" && Optional.IsDefined(StatementHighlightOffset))
            {
                writer.WritePropertyName("statementHighlightOffset"u8);
                writer.WriteNumberValue(StatementHighlightOffset.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StatementHighlightLength))
            {
                writer.WritePropertyName("statementHighlightLength"u8);
                writer.WriteNumberValue(StatementHighlightLength.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorSeverity))
            {
                writer.WritePropertyName("errorSeverity"u8);
                writer.WriteNumberValue(ErrorSeverity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
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

        SecurityEventSqlInjectionAdditionalProperties IJsonModel<SecurityEventSqlInjectionAdditionalProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityEventSqlInjectionAdditionalProperties(document.RootElement, options);
        }

        internal static SecurityEventSqlInjectionAdditionalProperties DeserializeSecurityEventSqlInjectionAdditionalProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> threatId = default;
            Optional<string> statement = default;
            Optional<int> statementHighlightOffset = default;
            Optional<int> statementHighlightLength = default;
            Optional<int> errorCode = default;
            Optional<int> errorSeverity = default;
            Optional<string> errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threatId"u8))
                {
                    threatId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statement"u8))
                {
                    statement = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statementHighlightOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementHighlightOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statementHighlightLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statementHighlightLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorSeverity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorSeverity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityEventSqlInjectionAdditionalProperties(threatId.Value, statement.Value, Optional.ToNullable(statementHighlightOffset), Optional.ToNullable(statementHighlightLength), Optional.ToNullable(errorCode), Optional.ToNullable(errorSeverity), errorMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{options.Format}' format.");
            }
        }

        SecurityEventSqlInjectionAdditionalProperties IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityEventSqlInjectionAdditionalProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SecurityEventSqlInjectionAdditionalProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityEventSqlInjectionAdditionalProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
