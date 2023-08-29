// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAzureMonitorSelectedConfigurations : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightAzureMonitorSelectedConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightAzureMonitorSelectedConfigurations>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightAzureMonitorSelectedConfigurations>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ConfigurationVersion))
            {
                writer.WritePropertyName("configurationVersion"u8);
                writer.WriteStringValue(ConfigurationVersion);
            }
            if (Optional.IsCollectionDefined(GlobalConfigurations))
            {
                writer.WritePropertyName("globalConfigurations"u8);
                writer.WriteStartObject();
                foreach (var item in GlobalConfigurations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TableList))
            {
                writer.WritePropertyName("tableList"u8);
                writer.WriteStartArray();
                foreach (var item in TableList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static HDInsightAzureMonitorSelectedConfigurations DeserializeHDInsightAzureMonitorSelectedConfigurations(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> configurationVersion = default;
            Optional<IDictionary<string, string>> globalConfigurations = default;
            Optional<IList<HDInsightAzureMonitorTableConfiguration>> tableList = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationVersion"u8))
                {
                    configurationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("globalConfigurations"u8))
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
                    globalConfigurations = dictionary;
                    continue;
                }
                if (property.NameEquals("tableList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightAzureMonitorTableConfiguration> array = new List<HDInsightAzureMonitorTableConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightAzureMonitorTableConfiguration.DeserializeHDInsightAzureMonitorTableConfiguration(item));
                    }
                    tableList = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightAzureMonitorSelectedConfigurations(configurationVersion.Value, Optional.ToDictionary(globalConfigurations), Optional.ToList(tableList), rawData);
        }

        HDInsightAzureMonitorSelectedConfigurations IModelJsonSerializable<HDInsightAzureMonitorSelectedConfigurations>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAzureMonitorSelectedConfigurations(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightAzureMonitorSelectedConfigurations>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightAzureMonitorSelectedConfigurations IModelSerializable<HDInsightAzureMonitorSelectedConfigurations>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightAzureMonitorSelectedConfigurations(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HDInsightAzureMonitorSelectedConfigurations model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HDInsightAzureMonitorSelectedConfigurations(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightAzureMonitorSelectedConfigurations(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
