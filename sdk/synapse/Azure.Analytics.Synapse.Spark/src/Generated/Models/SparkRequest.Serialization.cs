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

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkRequest : IUtf8JsonSerializable, IJsonModel<SparkRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkRequest>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SparkRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(File);
            }
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className"u8);
                writer.WriteStringValue(ClassName);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Jars))
            {
                writer.WritePropertyName("jars"u8);
                writer.WriteStartArray();
                foreach (var item in Jars)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PythonFiles))
            {
                writer.WritePropertyName("pyFiles"u8);
                writer.WriteStartArray();
                foreach (var item in PythonFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Archives))
            {
                writer.WritePropertyName("archives"u8);
                writer.WriteStartArray();
                foreach (var item in Archives)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Configuration))
            {
                writer.WritePropertyName("conf"u8);
                writer.WriteStartObject();
                foreach (var item in Configuration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DriverMemory))
            {
                writer.WritePropertyName("driverMemory"u8);
                writer.WriteStringValue(DriverMemory);
            }
            if (Optional.IsDefined(DriverCores))
            {
                writer.WritePropertyName("driverCores"u8);
                writer.WriteNumberValue(DriverCores.Value);
            }
            if (Optional.IsDefined(ExecutorMemory))
            {
                writer.WritePropertyName("executorMemory"u8);
                writer.WriteStringValue(ExecutorMemory);
            }
            if (Optional.IsDefined(ExecutorCores))
            {
                writer.WritePropertyName("executorCores"u8);
                writer.WriteNumberValue(ExecutorCores.Value);
            }
            if (Optional.IsDefined(ExecutorCount))
            {
                writer.WritePropertyName("numExecutors"u8);
                writer.WriteNumberValue(ExecutorCount.Value);
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

        SparkRequest IJsonModel<SparkRequest>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkRequest(document.RootElement, options);
        }

        internal static SparkRequest DeserializeSparkRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> file = default;
            Optional<string> className = default;
            Optional<IReadOnlyList<string>> args = default;
            Optional<IReadOnlyList<string>> jars = default;
            Optional<IReadOnlyList<string>> pyFiles = default;
            Optional<IReadOnlyList<string>> files = default;
            Optional<IReadOnlyList<string>> archives = default;
            Optional<IReadOnlyDictionary<string, string>> conf = default;
            Optional<string> driverMemory = default;
            Optional<int> driverCores = default;
            Optional<string> executorMemory = default;
            Optional<int> executorCores = default;
            Optional<int> numExecutors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("className"u8))
                {
                    className = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("args"u8))
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
                    args = array;
                    continue;
                }
                if (property.NameEquals("jars"u8))
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
                    jars = array;
                    continue;
                }
                if (property.NameEquals("pyFiles"u8))
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
                    pyFiles = array;
                    continue;
                }
                if (property.NameEquals("files"u8))
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
                    files = array;
                    continue;
                }
                if (property.NameEquals("archives"u8))
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
                    archives = array;
                    continue;
                }
                if (property.NameEquals("conf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    conf = dictionary;
                    continue;
                }
                if (property.NameEquals("driverMemory"u8))
                {
                    driverMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driverCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("executorMemory"u8))
                {
                    executorMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executorCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executorCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numExecutors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numExecutors = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkRequest(name.Value, file.Value, className.Value, Optional.ToList(args), Optional.ToList(jars), Optional.ToList(pyFiles), Optional.ToList(files), Optional.ToList(archives), Optional.ToDictionary(conf), driverMemory.Value, Optional.ToNullable(driverCores), executorMemory.Value, Optional.ToNullable(executorCores), Optional.ToNullable(numExecutors), serializedAdditionalRawData);
        }

        BinaryData IModel<SparkRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SparkRequest IModel<SparkRequest>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSparkRequest(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SparkRequest>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
