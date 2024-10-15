// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseEnvironmentVariableSetup : IUtf8JsonSerializable, IJsonModel<SynapseEnvironmentVariableSetup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseEnvironmentVariableSetup>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseEnvironmentVariableSetup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEnvironmentVariableSetup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseEnvironmentVariableSetup)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("variableName"u8);
            writer.WriteStringValue(VariableName);
            writer.WritePropertyName("variableValue"u8);
            writer.WriteStringValue(VariableValue);
            writer.WriteEndObject();
        }

        SynapseEnvironmentVariableSetup IJsonModel<SynapseEnvironmentVariableSetup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEnvironmentVariableSetup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseEnvironmentVariableSetup)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseEnvironmentVariableSetup(document.RootElement, options);
        }

        internal static SynapseEnvironmentVariableSetup DeserializeSynapseEnvironmentVariableSetup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string variableName = default;
            string variableValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("variableName"u8))
                        {
                            variableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("variableValue"u8))
                        {
                            variableValue = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SynapseEnvironmentVariableSetup(type, serializedAdditionalRawData, variableName, variableValue);
        }

        BinaryData IPersistableModel<SynapseEnvironmentVariableSetup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEnvironmentVariableSetup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseEnvironmentVariableSetup)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseEnvironmentVariableSetup IPersistableModel<SynapseEnvironmentVariableSetup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseEnvironmentVariableSetup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseEnvironmentVariableSetup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseEnvironmentVariableSetup)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseEnvironmentVariableSetup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
