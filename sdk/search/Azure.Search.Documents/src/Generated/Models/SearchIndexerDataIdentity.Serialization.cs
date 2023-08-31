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
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataIdentity : IUtf8JsonSerializable, IModelJsonSerializable<SearchIndexerDataIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchIndexerDataIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchIndexerDataIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static SearchIndexerDataIdentity DeserializeSearchIndexerDataIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.DataNoneIdentity": return SearchIndexerDataNoneIdentity.DeserializeSearchIndexerDataNoneIdentity(element);
                    case "#Microsoft.Azure.Search.DataUserAssignedIdentity": return SearchIndexerDataUserAssignedIdentity.DeserializeSearchIndexerDataUserAssignedIdentity(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
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
            return new UnknownSearchIndexerDataIdentity(odataType, rawData);
        }

        SearchIndexerDataIdentity IModelJsonSerializable<SearchIndexerDataIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexerDataIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchIndexerDataIdentity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchIndexerDataIdentity IModelSerializable<SearchIndexerDataIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchIndexerDataIdentity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchIndexerDataIdentity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchIndexerDataIdentity"/> to convert. </param>
        public static implicit operator RequestContent(SearchIndexerDataIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchIndexerDataIdentity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchIndexerDataIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchIndexerDataIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
