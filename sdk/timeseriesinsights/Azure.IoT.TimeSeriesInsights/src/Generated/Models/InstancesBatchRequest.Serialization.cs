// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class InstancesBatchRequest : IUtf8JsonSerializable, IJsonModel<InstancesBatchRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstancesBatchRequest>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<InstancesBatchRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Get))
            {
                writer.WritePropertyName("get"u8);
                writer.WriteObjectValue(Get);
            }
            if (Optional.IsCollectionDefined(Put))
            {
                writer.WritePropertyName("put"u8);
                writer.WriteStartArray();
                foreach (var item in Put)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Update))
            {
                writer.WritePropertyName("update"u8);
                writer.WriteStartArray();
                foreach (var item in Update)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete);
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

        InstancesBatchRequest IJsonModel<InstancesBatchRequest>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesBatchRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancesBatchRequest(document.RootElement, options);
        }

        internal static InstancesBatchRequest DeserializeInstancesBatchRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<InstancesRequestBatchGetOrDelete> @get = default;
            Optional<IList<TimeSeriesInstance>> put = default;
            Optional<IList<TimeSeriesInstance>> update = default;
            Optional<InstancesRequestBatchGetOrDelete> delete = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("get"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @get = InstancesRequestBatchGetOrDelete.DeserializeInstancesRequestBatchGetOrDelete(property.Value);
                    continue;
                }
                if (property.NameEquals("put"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesInstance> array = new List<TimeSeriesInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesInstance.DeserializeTimeSeriesInstance(item));
                    }
                    put = array;
                    continue;
                }
                if (property.NameEquals("update"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesInstance> array = new List<TimeSeriesInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesInstance.DeserializeTimeSeriesInstance(item));
                    }
                    update = array;
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = InstancesRequestBatchGetOrDelete.DeserializeInstancesRequestBatchGetOrDelete(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InstancesBatchRequest(@get.Value, Optional.ToList(put), Optional.ToList(update), delete.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<InstancesBatchRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesBatchRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InstancesBatchRequest IModel<InstancesBatchRequest>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesBatchRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInstancesBatchRequest(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<InstancesBatchRequest>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
