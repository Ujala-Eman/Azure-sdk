// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkTableStatusConverter))]
    public partial class LinkTableStatus : IUtf8JsonSerializable, IJsonModel<LinkTableStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkTableStatus>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LinkTableStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteObjectValue(StartTime);
            }
            if (Optional.IsDefined(StopTime))
            {
                writer.WritePropertyName("stopTime"u8);
                writer.WriteObjectValue(StopTime);
            }
            if (Optional.IsDefined(LinkTableId))
            {
                writer.WritePropertyName("linkTableId"u8);
                writer.WriteStringValue(LinkTableId);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(LastProcessedData))
            {
                writer.WritePropertyName("lastProcessedData"u8);
                writer.WriteStringValue(LastProcessedData.Value, "O");
            }
            if (Optional.IsDefined(LastTransactionCommitTime))
            {
                writer.WritePropertyName("lastTransactionCommitTime"u8);
                writer.WriteStringValue(LastTransactionCommitTime.Value, "O");
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        LinkTableStatus IJsonModel<LinkTableStatus>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkTableStatus(document.RootElement, options);
        }

        internal static LinkTableStatus DeserializeLinkTableStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> status = default;
            Optional<string> errorMessage = default;
            Optional<object> startTime = default;
            Optional<object> stopTime = default;
            Optional<string> linkTableId = default;
            Optional<string> errorCode = default;
            Optional<DateTimeOffset> lastProcessedData = default;
            Optional<DateTimeOffset> lastTransactionCommitTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("stopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkTableId"u8))
                {
                    linkTableId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastProcessedData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastProcessedData = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTransactionCommitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTransactionCommitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkTableStatus(id.Value, status.Value, errorMessage.Value, startTime.Value, stopTime.Value, linkTableId.Value, errorCode.Value, Optional.ToNullable(lastProcessedData), Optional.ToNullable(lastTransactionCommitTime), serializedAdditionalRawData);
        }

        BinaryData IModel<LinkTableStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableStatus)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LinkTableStatus IModel<LinkTableStatus>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkTableStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLinkTableStatus(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LinkTableStatus>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class LinkTableStatusConverter : JsonConverter<LinkTableStatus>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableStatus model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkTableStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableStatus(document.RootElement);
            }
        }
    }
}
