// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncFullSchemaTable : IUtf8JsonSerializable, IJsonModel<SyncFullSchemaTable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncFullSchemaTable>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SyncFullSchemaTable>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorId))
            {
                writer.WritePropertyName("errorId"u8);
                writer.WriteStringValue(ErrorId);
            }
            if (options.Format != "W" && Optional.IsDefined(HasError))
            {
                writer.WritePropertyName("hasError"u8);
                writer.WriteBooleanValue(HasError.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName"u8);
                writer.WriteStringValue(QuotedName);
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

        SyncFullSchemaTable IJsonModel<SyncFullSchemaTable>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncFullSchemaTable(document.RootElement, options);
        }

        internal static SyncFullSchemaTable DeserializeSyncFullSchemaTable(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SyncFullSchemaTableColumn> columns = default;
            string errorId = default;
            bool? hasError = default;
            string name = default;
            string quotedName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncFullSchemaTableColumn> array = new List<SyncFullSchemaTableColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncFullSchemaTableColumn.DeserializeSyncFullSchemaTableColumn(item, options));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("errorId"u8))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotedName"u8))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SyncFullSchemaTable(
                columns ?? new ChangeTrackingList<SyncFullSchemaTableColumn>(),
                errorId,
                hasError,
                name,
                quotedName,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Columns), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  columns: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Columns))
                {
                    if (Columns.Any())
                    {
                        builder.Append("  columns: ");
                        builder.AppendLine("[");
                        foreach (var item in Columns)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  columns: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  errorId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ErrorId))
                {
                    builder.Append("  errorId: ");
                    if (ErrorId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ErrorId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ErrorId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HasError), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  hasError: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HasError))
                {
                    builder.Append("  hasError: ");
                    var boolValue = HasError.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QuotedName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  quotedName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QuotedName))
                {
                    builder.Append("  quotedName: ");
                    if (QuotedName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{QuotedName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{QuotedName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SyncFullSchemaTable>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support writing '{options.Format}' format.");
            }
        }

        SyncFullSchemaTable IPersistableModel<SyncFullSchemaTable>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncFullSchemaTable(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncFullSchemaTable>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
