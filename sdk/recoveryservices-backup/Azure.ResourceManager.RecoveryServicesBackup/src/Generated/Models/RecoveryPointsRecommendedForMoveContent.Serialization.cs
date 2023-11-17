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
    public partial class RecoveryPointsRecommendedForMoveContent : IUtf8JsonSerializable, IJsonModel<RecoveryPointsRecommendedForMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointsRecommendedForMoveContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPointsRecommendedForMoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RecoveryPointsRecommendedForMoveContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RecoveryPointsRecommendedForMoveContent>)} interface");
            }

            writer.WriteStartObject();
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
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        RecoveryPointsRecommendedForMoveContent IJsonModel<RecoveryPointsRecommendedForMoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointsRecommendedForMoveContent(document.RootElement, options);
        }

        internal static RecoveryPointsRecommendedForMoveContent DeserializeRecoveryPointsRecommendedForMoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> objectType = default;
            Optional<IList<string>> excludedRPList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPointsRecommendedForMoveContent(objectType.Value, Optional.ToList(excludedRPList), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPointsRecommendedForMoveContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecoveryPointsRecommendedForMoveContent IPersistableModel<RecoveryPointsRecommendedForMoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPointsRecommendedForMoveContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecoveryPointsRecommendedForMoveContent(document.RootElement, options);
        }

        string IPersistableModel<RecoveryPointsRecommendedForMoveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
