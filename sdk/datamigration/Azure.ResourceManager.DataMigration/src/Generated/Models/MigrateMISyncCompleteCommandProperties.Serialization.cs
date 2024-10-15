// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMISyncCompleteCommandProperties : IUtf8JsonSerializable, IJsonModel<MigrateMISyncCompleteCommandProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMISyncCompleteCommandProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateMISyncCompleteCommandProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMISyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMISyncCompleteCommandProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteObjectValue(Output, options);
            }
        }

        MigrateMISyncCompleteCommandProperties IJsonModel<MigrateMISyncCompleteCommandProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMISyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMISyncCompleteCommandProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMISyncCompleteCommandProperties(document.RootElement, options);
        }

        internal static MigrateMISyncCompleteCommandProperties DeserializeMigrateMISyncCompleteCommandProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MigrateMISyncCompleteCommandInput input = default;
            MigrateMISyncCompleteCommandOutput output = default;
            CommandType commandType = default;
            IReadOnlyList<ODataError> errors = default;
            CommandState? state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = MigrateMISyncCompleteCommandInput.DeserializeMigrateMISyncCompleteCommandInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = MigrateMISyncCompleteCommandOutput.DeserializeMigrateMISyncCompleteCommandOutput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("commandType"u8))
                {
                    commandType = new CommandType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new CommandState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateMISyncCompleteCommandProperties(
                commandType,
                errors ?? new ChangeTrackingList<ODataError>(),
                state,
                serializedAdditionalRawData,
                input,
                output);
        }

        BinaryData IPersistableModel<MigrateMISyncCompleteCommandProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMISyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMISyncCompleteCommandProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateMISyncCompleteCommandProperties IPersistableModel<MigrateMISyncCompleteCommandProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMISyncCompleteCommandProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMISyncCompleteCommandProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMISyncCompleteCommandProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMISyncCompleteCommandProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
