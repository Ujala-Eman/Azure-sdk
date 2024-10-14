// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPointsRecommendedForMoveContent : IUtf8JsonSerializable, IJsonModel<RecoveryPointsRecommendedForMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointsRecommendedForMoveContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPointsRecommendedForMoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointsRecommendedForMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            if (Optional.IsCollectionDefined(ExcludedRPList))
            {
                writer.WritePropertyName("excludedRPList"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedRPList)
                {
                    writer.WriteStringValue(item);
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
        }

        RecoveryPointsRecommendedForMoveContent IJsonModel<RecoveryPointsRecommendedForMoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointsRecommendedForMoveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointsRecommendedForMoveContent(document.RootElement, options);
        }

        internal static RecoveryPointsRecommendedForMoveContent DeserializeRecoveryPointsRecommendedForMoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string objectType = default;
            IList<string> excludedRPList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedRPList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedRPList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPointsRecommendedForMoveContent(objectType, excludedRPList ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPointsRecommendedForMoveContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointsRecommendedForMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPointsRecommendedForMoveContent IPersistableModel<RecoveryPointsRecommendedForMoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointsRecommendedForMoveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPointsRecommendedForMoveContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPointsRecommendedForMoveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
