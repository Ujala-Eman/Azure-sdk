// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    public partial class DevOpsStateful : IUtf8JsonSerializable, IJsonModel<DevOpsStateful>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsStateful>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevOpsStateful>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStateful>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsStateful)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(MaxAgentLifetime))
            {
                writer.WritePropertyName("maxAgentLifetime"u8);
                writer.WriteStringValue(MaxAgentLifetime);
            }
            if (Optional.IsDefined(GracePeriodTimeSpan))
            {
                writer.WritePropertyName("gracePeriodTimeSpan"u8);
                writer.WriteStringValue(GracePeriodTimeSpan);
            }
        }

        DevOpsStateful IJsonModel<DevOpsStateful>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStateful>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsStateful)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsStateful(document.RootElement, options);
        }

        internal static DevOpsStateful DeserializeDevOpsStateful(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string maxAgentLifetime = default;
            string gracePeriodTimeSpan = default;
            string kind = default;
            ResourcePredictions resourcePredictions = default;
            ResourcePredictionsProfile resourcePredictionsProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxAgentLifetime"u8))
                {
                    maxAgentLifetime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gracePeriodTimeSpan"u8))
                {
                    gracePeriodTimeSpan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourcePredictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourcePredictions = ResourcePredictions.DeserializeResourcePredictions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourcePredictionsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourcePredictionsProfile = ResourcePredictionsProfile.DeserializeResourcePredictionsProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevOpsStateful(
                kind,
                resourcePredictions,
                resourcePredictionsProfile,
                serializedAdditionalRawData,
                maxAgentLifetime,
                gracePeriodTimeSpan);
        }

        BinaryData IPersistableModel<DevOpsStateful>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStateful>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsStateful)} does not support writing '{options.Format}' format.");
            }
        }

        DevOpsStateful IPersistableModel<DevOpsStateful>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStateful>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevOpsStateful(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsStateful)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsStateful>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
