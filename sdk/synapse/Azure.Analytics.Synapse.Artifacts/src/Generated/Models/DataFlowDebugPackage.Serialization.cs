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
    [JsonConverter(typeof(DataFlowDebugPackageConverter))]
    public partial class DataFlowDebugPackage : IUtf8JsonSerializable, IJsonModel<DataFlowDebugPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFlowDebugPackage>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<DataFlowDebugPackage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlow))
            {
                writer.WritePropertyName("dataFlow"u8);
                writer.WriteObjectValue(DataFlow);
            }
            if (Optional.IsCollectionDefined(DataFlows))
            {
                writer.WritePropertyName("dataFlows"u8);
                writer.WriteStartArray();
                foreach (var item in DataFlows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedServices))
            {
                writer.WritePropertyName("linkedServices"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Staging))
            {
                writer.WritePropertyName("staging"u8);
                writer.WriteObjectValue(Staging);
            }
            if (Optional.IsDefined(DebugSettings))
            {
                writer.WritePropertyName("debugSettings"u8);
                writer.WriteObjectValue(DebugSettings);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        DataFlowDebugPackage IJsonModel<DataFlowDebugPackage>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFlowDebugPackage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowDebugPackage(document.RootElement, options);
        }

        internal static DataFlowDebugPackage DeserializeDataFlowDebugPackage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sessionId = default;
            Optional<DataFlowDebugResource> dataFlow = default;
            Optional<IList<DataFlowDebugResource>> dataFlows = default;
            Optional<IList<DatasetDebugResource>> datasets = default;
            Optional<IList<LinkedServiceDebugResource>> linkedServices = default;
            Optional<DataFlowStagingInfo> staging = default;
            Optional<DataFlowDebugPackageDebugSettings> debugSettings = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlow = DataFlowDebugResource.DeserializeDataFlowDebugResource(property.Value);
                    continue;
                }
                if (property.NameEquals("dataFlows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowDebugResource> array = new List<DataFlowDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowDebugResource.DeserializeDataFlowDebugResource(item));
                    }
                    dataFlows = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetDebugResource> array = new List<DatasetDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetDebugResource.DeserializeDatasetDebugResource(item));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("linkedServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedServiceDebugResource> array = new List<LinkedServiceDebugResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceDebugResource.DeserializeLinkedServiceDebugResource(item));
                    }
                    linkedServices = array;
                    continue;
                }
                if (property.NameEquals("staging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    staging = DataFlowStagingInfo.DeserializeDataFlowStagingInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("debugSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSettings = DataFlowDebugPackageDebugSettings.DeserializeDataFlowDebugPackageDebugSettings(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowDebugPackage(sessionId.Value, dataFlow.Value, Optional.ToList(dataFlows), Optional.ToList(datasets), Optional.ToList(linkedServices), staging.Value, debugSettings.Value, additionalProperties);
        }

        BinaryData IModel<DataFlowDebugPackage>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFlowDebugPackage)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataFlowDebugPackage IModel<DataFlowDebugPackage>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataFlowDebugPackage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataFlowDebugPackage(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<DataFlowDebugPackage>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class DataFlowDebugPackageConverter : JsonConverter<DataFlowDebugPackage>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowDebugPackage model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowDebugPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowDebugPackage(document.RootElement);
            }
        }
    }
}
