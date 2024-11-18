// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class RadiologyInsightsJob : IUtf8JsonSerializable, IJsonModel<RadiologyInsightsJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RadiologyInsightsJob>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RadiologyInsightsJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiologyInsightsJob)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(JobData))
            {
                writer.WritePropertyName("jobData"u8);
                writer.WriteObjectValue(JobData, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteObjectValue(Result, options);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedAt))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedAt.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiresAt))
            {
                writer.WritePropertyName("expiresAt"u8);
                writer.WriteStringValue(ExpiresAt.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedAt))
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedAt.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
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

        RadiologyInsightsJob IJsonModel<RadiologyInsightsJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiologyInsightsJob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRadiologyInsightsJob(document.RootElement, options);
        }

        internal static RadiologyInsightsJob DeserializeRadiologyInsightsJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RadiologyInsightsData jobData = default;
            RadiologyInsightsInferenceResult result = default;
            string id = default;
            JobStatus status = default;
            DateTimeOffset? createdAt = default;
            DateTimeOffset? expiresAt = default;
            DateTimeOffset? updatedAt = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobData = RadiologyInsightsData.DeserializeRadiologyInsightsData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = RadiologyInsightsInferenceResult.DeserializeRadiologyInsightsInferenceResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiresAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedAt = property.Value.GetDateTimeOffset("O");
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RadiologyInsightsJob(
                jobData,
                result,
                id,
                status,
                createdAt,
                expiresAt,
                updatedAt,
                error,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RadiologyInsightsJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RadiologyInsightsJob)} does not support writing '{options.Format}' format.");
            }
        }

        RadiologyInsightsJob IPersistableModel<RadiologyInsightsJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiologyInsightsJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRadiologyInsightsJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RadiologyInsightsJob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RadiologyInsightsJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RadiologyInsightsJob FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRadiologyInsightsJob(document.RootElement);
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
