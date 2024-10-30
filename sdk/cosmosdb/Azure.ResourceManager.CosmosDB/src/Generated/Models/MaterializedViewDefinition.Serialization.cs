// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MaterializedViewDefinition : IUtf8JsonSerializable, IJsonModel<MaterializedViewDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaterializedViewDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MaterializedViewDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(SourceCollectionRid))
            {
                writer.WritePropertyName("sourceCollectionRid"u8);
                writer.WriteStringValue(SourceCollectionRid);
            }
            writer.WritePropertyName("sourceCollectionId"u8);
            writer.WriteStringValue(SourceCollectionId);
            writer.WritePropertyName("definition"u8);
            writer.WriteStringValue(Definition);
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

        MaterializedViewDefinition IJsonModel<MaterializedViewDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaterializedViewDefinition(document.RootElement, options);
        }

        internal static MaterializedViewDefinition DeserializeMaterializedViewDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceCollectionRid = default;
            string sourceCollectionId = default;
            string definition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceCollectionRid"u8))
                {
                    sourceCollectionRid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCollectionId"u8))
                {
                    sourceCollectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MaterializedViewDefinition(sourceCollectionRid, sourceCollectionId, definition, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceCollectionRid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceCollectionRid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceCollectionRid))
                {
                    builder.Append("  sourceCollectionRid: ");
                    if (SourceCollectionRid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceCollectionRid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceCollectionRid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceCollectionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceCollectionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceCollectionId))
                {
                    builder.Append("  sourceCollectionId: ");
                    if (SourceCollectionId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceCollectionId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceCollectionId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Definition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  definition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Definition))
                {
                    builder.Append("  definition: ");
                    if (Definition.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Definition}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Definition}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MaterializedViewDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        MaterializedViewDefinition IPersistableModel<MaterializedViewDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaterializedViewDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaterializedViewDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
