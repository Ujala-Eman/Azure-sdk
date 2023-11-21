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
    public partial class TriggerDataMoveContent : IUtf8JsonSerializable, IJsonModel<TriggerDataMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TriggerDataMoveContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TriggerDataMoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerDataMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TriggerDataMoveContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceResourceId"u8);
            writer.WriteStringValue(SourceResourceId);
            writer.WritePropertyName("sourceRegion"u8);
            writer.WriteStringValue(SourceRegion);
            writer.WritePropertyName("dataMoveLevel"u8);
            writer.WriteStringValue(DataMoveLevel.ToString());
            writer.WritePropertyName("correlationId"u8);
            writer.WriteStringValue(CorrelationId);
            if (Optional.IsCollectionDefined(SourceContainerArmIds))
            {
                writer.WritePropertyName("sourceContainerArmIds"u8);
                writer.WriteStartArray();
                foreach (var item in SourceContainerArmIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DoesPauseGC))
            {
                writer.WritePropertyName("pauseGC"u8);
                writer.WriteBooleanValue(DoesPauseGC.Value);
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

        TriggerDataMoveContent IJsonModel<TriggerDataMoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerDataMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(TriggerDataMoveContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerDataMoveContent(document.RootElement, options);
        }

        internal static TriggerDataMoveContent DeserializeTriggerDataMoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sourceResourceId = default;
            AzureLocation sourceRegion = default;
            DataMoveLevel dataMoveLevel = default;
            string correlationId = default;
            Optional<IList<ResourceIdentifier>> sourceContainerArmIds = default;
            Optional<bool> pauseGC = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceId"u8))
                {
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceRegion"u8))
                {
                    sourceRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataMoveLevel"u8))
                {
                    dataMoveLevel = new DataMoveLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceContainerArmIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    sourceContainerArmIds = array;
                    continue;
                }
                if (property.NameEquals("pauseGC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pauseGC = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TriggerDataMoveContent(sourceResourceId, sourceRegion, dataMoveLevel, correlationId, Optional.ToList(sourceContainerArmIds), Optional.ToNullable(pauseGC), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TriggerDataMoveContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerDataMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(TriggerDataMoveContent)} does not support '{options.Format}' format.");
            }
        }

        TriggerDataMoveContent IPersistableModel<TriggerDataMoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TriggerDataMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTriggerDataMoveContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(TriggerDataMoveContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TriggerDataMoveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
