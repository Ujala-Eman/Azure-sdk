// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Deidentification
{
    public partial class DeidentificationJob : IUtf8JsonSerializable, IJsonModel<DeidentificationJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeidentificationJob>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeidentificationJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidentificationJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeidentificationJob)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation.Value.ToString());
            }
            writer.WritePropertyName("sourceLocation"u8);
            writer.WriteObjectValue(SourceLocation, options);
            writer.WritePropertyName("targetLocation"u8);
            writer.WriteObjectValue(TargetLocation, options);
            if (Optional.IsDefined(Customizations))
            {
                writer.WritePropertyName("customizations"u8);
                writer.WriteObjectValue(Customizations, options);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("lastUpdatedAt"u8);
                writer.WriteStringValue(LastUpdatedAt, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedAt, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StartedAt))
            {
                writer.WritePropertyName("startedAt"u8);
                writer.WriteStringValue(StartedAt.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteObjectValue(Summary, options);
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

        DeidentificationJob IJsonModel<DeidentificationJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidentificationJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeidentificationJob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeidentificationJob(document.RootElement, options);
        }

        internal static DeidentificationJob DeserializeDeidentificationJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            DeidentificationOperationType? operation = default;
            SourceStorageLocation sourceLocation = default;
            TargetStorageLocation targetLocation = default;
            DeidentificationJobCustomizationOptions customizations = default;
            DeidentificationJobStatus status = default;
            ResponseError error = default;
            DateTimeOffset lastUpdatedAt = default;
            DateTimeOffset createdAt = default;
            DateTimeOffset? startedAt = default;
            DeidentificationJobSummary summary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operation = new DeidentificationOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceLocation"u8))
                {
                    sourceLocation = SourceStorageLocation.DeserializeSourceStorageLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = TargetStorageLocation.DeserializeTargetStorageLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customizations = DeidentificationJobCustomizationOptions.DeserializeDeidentificationJobCustomizationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new DeidentificationJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("lastUpdatedAt"u8))
                {
                    lastUpdatedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = DeidentificationJobSummary.DeserializeDeidentificationJobSummary(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeidentificationJob(
                name,
                operation,
                sourceLocation,
                targetLocation,
                customizations,
                status,
                error,
                lastUpdatedAt,
                createdAt,
                startedAt,
                summary,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeidentificationJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidentificationJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeidentificationJob)} does not support writing '{options.Format}' format.");
            }
        }

        DeidentificationJob IPersistableModel<DeidentificationJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeidentificationJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeidentificationJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeidentificationJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeidentificationJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeidentificationJob FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeidentificationJob(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
