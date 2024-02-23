// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanPlannedFailoverProperties : IUtf8JsonSerializable, IJsonModel<RecoveryPlanPlannedFailoverProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanPlannedFailoverProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanPlannedFailoverProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanPlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("failoverDirection"u8);
            writer.WriteStringValue(FailoverDirection.ToString());
            if (!(ProviderSpecificDetails is ChangeTrackingList<RecoveryPlanProviderSpecificFailoverContent> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        RecoveryPlanPlannedFailoverProperties IJsonModel<RecoveryPlanPlannedFailoverProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanPlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanPlannedFailoverProperties(document.RootElement, options);
        }

        internal static RecoveryPlanPlannedFailoverProperties DeserializeRecoveryPlanPlannedFailoverProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PossibleOperationsDirection failoverDirection = default;
            Optional<IList<RecoveryPlanProviderSpecificFailoverContent>> providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverDirection"u8))
                {
                    failoverDirection = new PossibleOperationsDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificFailoverContent> array = new List<RecoveryPlanProviderSpecificFailoverContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificFailoverContent.DeserializeRecoveryPlanProviderSpecificFailoverContent(item, options));
                    }
                    providerSpecificDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanPlannedFailoverProperties(failoverDirection, Optional.ToList(providerSpecificDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPlanPlannedFailoverProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanPlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{options.Format}' format.");
            }
        }

        RecoveryPlanPlannedFailoverProperties IPersistableModel<RecoveryPlanPlannedFailoverProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanPlannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanPlannedFailoverProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanPlannedFailoverProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanPlannedFailoverProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
