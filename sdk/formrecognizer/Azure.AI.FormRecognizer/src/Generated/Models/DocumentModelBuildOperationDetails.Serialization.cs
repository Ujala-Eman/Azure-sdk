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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentModelBuildOperationDetails : IUtf8JsonSerializable, IModelJsonSerializable<DocumentModelBuildOperationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentModelBuildOperationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentModelBuildOperationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DocumentModelBuildOperationDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteObjectValue(Result);
            }
            writer.WritePropertyName("operationId"u8);
            writer.WriteStringValue(OperationId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToSerialString());
            if (Optional.IsDefined(PercentCompleted))
            {
                writer.WritePropertyName("percentCompleted"u8);
                writer.WriteNumberValue(PercentCompleted.Value);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedOn, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedOn, "O");
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("resourceLocation"u8);
            writer.WriteStringValue(ResourceLocation.AbsoluteUri);
            if (Optional.IsDefined(ServiceVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ServiceVersion);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(JsonError))
            {
                writer.WritePropertyName("error"u8);
                JsonError.WriteTo(writer);
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

        internal static DocumentModelBuildOperationDetails DeserializeDocumentModelBuildOperationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DocumentModelDetails> result = default;
            string operationId = default;
            DocumentOperationStatus status = default;
            Optional<int> percentCompleted = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            DocumentOperationKind kind = default;
            Uri resourceLocation = default;
            Optional<string> apiVersion = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<JsonElement> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = DocumentModelDetails.DeserializeDocumentModelDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToDocumentOperationStatus();
                    continue;
                }
                if (property.NameEquals("percentCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentCompleted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DocumentOperationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentModelBuildOperationDetails(operationId, status, Optional.ToNullable(percentCompleted), createdDateTime, lastUpdatedDateTime, kind, resourceLocation, apiVersion.Value, Optional.ToDictionary(tags), error, result.Value, rawData);
        }

        DocumentModelBuildOperationDetails IModelJsonSerializable<DocumentModelBuildOperationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DocumentModelBuildOperationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentModelBuildOperationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentModelBuildOperationDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DocumentModelBuildOperationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentModelBuildOperationDetails IModelSerializable<DocumentModelBuildOperationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DocumentModelBuildOperationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentModelBuildOperationDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DocumentModelBuildOperationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DocumentModelBuildOperationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentModelBuildOperationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
