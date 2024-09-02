// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI.Chat
{
    internal partial class InternalAzureCosmosDBChatDataSourceParameters : IJsonModel<InternalAzureCosmosDBChatDataSourceParameters>
    {
        void IJsonModel<InternalAzureCosmosDBChatDataSourceParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAzureCosmosDBChatDataSourceParameters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("top_n_documents") != true && Optional.IsDefined(TopNDocuments))
            {
                writer.WritePropertyName("top_n_documents"u8);
                writer.WriteNumberValue(TopNDocuments.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("in_scope") != true && Optional.IsDefined(InScope))
            {
                writer.WritePropertyName("in_scope"u8);
                writer.WriteBooleanValue(InScope.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("strictness") != true && Optional.IsDefined(Strictness))
            {
                writer.WritePropertyName("strictness"u8);
                writer.WriteNumberValue(Strictness.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("role_information") != true && Optional.IsDefined(RoleInformation))
            {
                writer.WritePropertyName("role_information"u8);
                writer.WriteStringValue(RoleInformation);
            }
            if (SerializedAdditionalRawData?.ContainsKey("max_search_queries") != true && Optional.IsDefined(MaxSearchQueries))
            {
                writer.WritePropertyName("max_search_queries"u8);
                writer.WriteNumberValue(MaxSearchQueries.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("allow_partial_result") != true && Optional.IsDefined(AllowPartialResult))
            {
                writer.WritePropertyName("allow_partial_result"u8);
                writer.WriteBooleanValue(AllowPartialResult.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("include_contexts") != true && Optional.IsCollectionDefined(_internalIncludeContexts))
            {
                writer.WritePropertyName("include_contexts"u8);
                writer.WriteStartArray();
                foreach (var item in _internalIncludeContexts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("container_name") != true)
            {
                writer.WritePropertyName("container_name"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (SerializedAdditionalRawData?.ContainsKey("database_name") != true)
            {
                writer.WritePropertyName("database_name"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (SerializedAdditionalRawData?.ContainsKey("embedding_dependency") != true)
            {
                writer.WritePropertyName("embedding_dependency"u8);
                writer.WriteObjectValue<DataSourceVectorizer>(VectorizationSource, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("index_name") != true)
            {
                writer.WritePropertyName("index_name"u8);
                writer.WriteStringValue(IndexName);
            }
            if (SerializedAdditionalRawData?.ContainsKey("authentication") != true)
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue<DataSourceAuthentication>(Authentication, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("fields_mapping") != true)
            {
                writer.WritePropertyName("fields_mapping"u8);
                writer.WriteObjectValue<DataSourceFieldMappings>(FieldMappings, options);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        InternalAzureCosmosDBChatDataSourceParameters IJsonModel<InternalAzureCosmosDBChatDataSourceParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAzureCosmosDBChatDataSourceParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalAzureCosmosDBChatDataSourceParameters(document.RootElement, options);
        }

        internal static InternalAzureCosmosDBChatDataSourceParameters DeserializeInternalAzureCosmosDBChatDataSourceParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? topNDocuments = default;
            bool? inScope = default;
            int? strictness = default;
            string roleInformation = default;
            int? maxSearchQueries = default;
            bool? allowPartialResult = default;
            IList<string> includeContexts = default;
            string containerName = default;
            string databaseName = default;
            DataSourceVectorizer embeddingDependency = default;
            string indexName = default;
            DataSourceAuthentication authentication = default;
            DataSourceFieldMappings fieldsMapping = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("top_n_documents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topNDocuments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("in_scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inScope = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("strictness"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictness = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("role_information"u8))
                {
                    roleInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max_search_queries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxSearchQueries = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allow_partial_result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowPartialResult = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("include_contexts"u8))
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
                    includeContexts = array;
                    continue;
                }
                if (property.NameEquals("container_name"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database_name"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("embedding_dependency"u8))
                {
                    embeddingDependency = DataSourceVectorizer.DeserializeDataSourceVectorizer(property.Value, options);
                    continue;
                }
                if (property.NameEquals("index_name"u8))
                {
                    indexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    authentication = DataSourceAuthentication.DeserializeDataSourceAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fields_mapping"u8))
                {
                    fieldsMapping = DataSourceFieldMappings.DeserializeDataSourceFieldMappings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalAzureCosmosDBChatDataSourceParameters(
                topNDocuments,
                inScope,
                strictness,
                roleInformation,
                maxSearchQueries,
                allowPartialResult,
                includeContexts ?? new ChangeTrackingList<string>(),
                containerName,
                databaseName,
                embeddingDependency,
                indexName,
                authentication,
                fieldsMapping,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalAzureCosmosDBChatDataSourceParameters)} does not support writing '{options.Format}' format.");
            }
        }

        InternalAzureCosmosDBChatDataSourceParameters IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalAzureCosmosDBChatDataSourceParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalAzureCosmosDBChatDataSourceParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalAzureCosmosDBChatDataSourceParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static InternalAzureCosmosDBChatDataSourceParameters FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalAzureCosmosDBChatDataSourceParameters(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}

