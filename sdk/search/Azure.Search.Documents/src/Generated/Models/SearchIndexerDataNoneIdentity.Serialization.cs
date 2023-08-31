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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataNoneIdentity : IUtf8JsonSerializable, IModelJsonSerializable<SearchIndexerDataNoneIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchIndexerDataNoneIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchIndexerDataNoneIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SearchIndexerDataNoneIdentity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
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

        internal static SearchIndexerDataNoneIdentity DeserializeSearchIndexerDataNoneIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchIndexerDataNoneIdentity(odataType, rawData);
        }

        SearchIndexerDataNoneIdentity IModelJsonSerializable<SearchIndexerDataNoneIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SearchIndexerDataNoneIdentity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexerDataNoneIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchIndexerDataNoneIdentity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SearchIndexerDataNoneIdentity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchIndexerDataNoneIdentity IModelSerializable<SearchIndexerDataNoneIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SearchIndexerDataNoneIdentity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchIndexerDataNoneIdentity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchIndexerDataNoneIdentity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchIndexerDataNoneIdentity"/> to convert. </param>
        public static implicit operator RequestContent(SearchIndexerDataNoneIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchIndexerDataNoneIdentity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchIndexerDataNoneIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchIndexerDataNoneIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
