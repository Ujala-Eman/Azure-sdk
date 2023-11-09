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
    [JsonConverter(typeof(BlobSinkConverter))]
    public partial class BlobSink : IUtf8JsonSerializable, IJsonModel<BlobSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobSink>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BlobSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BlobWriterOverwriteFiles))
            {
                writer.WritePropertyName("blobWriterOverwriteFiles"u8);
                writer.WriteObjectValue(BlobWriterOverwriteFiles);
            }
            if (Optional.IsDefined(BlobWriterDateTimeFormat))
            {
                writer.WritePropertyName("blobWriterDateTimeFormat"u8);
                writer.WriteObjectValue(BlobWriterDateTimeFormat);
            }
            if (Optional.IsDefined(BlobWriterAddHeader))
            {
                writer.WritePropertyName("blobWriterAddHeader"u8);
                writer.WriteObjectValue(BlobWriterAddHeader);
            }
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior"u8);
                writer.WriteObjectValue(CopyBehavior);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        BlobSink IJsonModel<BlobSink>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobSink)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobSink(document.RootElement, options);
        }

        internal static BlobSink DeserializeBlobSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> blobWriterOverwriteFiles = default;
            Optional<object> blobWriterDateTimeFormat = default;
            Optional<object> blobWriterAddHeader = default;
            Optional<object> copyBehavior = default;
            string type = default;
            Optional<object> writeBatchSize = default;
            Optional<object> writeBatchTimeout = default;
            Optional<object> sinkRetryCount = default;
            Optional<object> sinkRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobWriterOverwriteFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobWriterOverwriteFiles = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("blobWriterDateTimeFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobWriterDateTimeFormat = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("blobWriterAddHeader"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobWriterAddHeader = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("copyBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyBehavior = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new BlobSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, blobWriterOverwriteFiles.Value, blobWriterDateTimeFormat.Value, blobWriterAddHeader.Value, copyBehavior.Value);
        }

        BinaryData IModel<BlobSink>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobSink)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BlobSink IModel<BlobSink>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobSink)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBlobSink(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BlobSink>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class BlobSinkConverter : JsonConverter<BlobSink>
        {
            public override void Write(Utf8JsonWriter writer, BlobSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override BlobSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeBlobSink(document.RootElement);
            }
        }
    }
}
