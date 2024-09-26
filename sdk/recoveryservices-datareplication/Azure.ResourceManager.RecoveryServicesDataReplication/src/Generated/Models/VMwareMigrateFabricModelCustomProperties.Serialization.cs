// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareMigrateFabricModelCustomProperties : IUtf8JsonSerializable, IJsonModel<VMwareMigrateFabricModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareMigrateFabricModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareMigrateFabricModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareMigrateFabricModelCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("vmwareSiteId"u8);
            writer.WriteStringValue(VMwareSiteId);
            writer.WritePropertyName("migrationSolutionId"u8);
            writer.WriteStringValue(MigrationSolutionId);
        }

        VMwareMigrateFabricModelCustomProperties IJsonModel<VMwareMigrateFabricModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareMigrateFabricModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareMigrateFabricModelCustomProperties(document.RootElement, options);
        }

        internal static VMwareMigrateFabricModelCustomProperties DeserializeVMwareMigrateFabricModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareSiteId = default;
            ResourceIdentifier migrationSolutionId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationSolutionId"u8))
                {
                    migrationSolutionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareMigrateFabricModelCustomProperties(instanceType, serializedAdditionalRawData, vmwareSiteId, migrationSolutionId);
        }

        BinaryData IPersistableModel<VMwareMigrateFabricModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareMigrateFabricModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareMigrateFabricModelCustomProperties IPersistableModel<VMwareMigrateFabricModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareMigrateFabricModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareMigrateFabricModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareMigrateFabricModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareMigrateFabricModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
