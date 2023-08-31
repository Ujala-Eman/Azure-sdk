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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ServerDnsAliasListResult : IUtf8JsonSerializable, IModelJsonSerializable<ServerDnsAliasListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServerDnsAliasListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServerDnsAliasListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ServerDnsAliasListResult DeserializeServerDnsAliasListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SqlServerDnsAliasData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlServerDnsAliasData> array = new List<SqlServerDnsAliasData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlServerDnsAliasData.DeserializeSqlServerDnsAliasData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServerDnsAliasListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        ServerDnsAliasListResult IModelJsonSerializable<ServerDnsAliasListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServerDnsAliasListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServerDnsAliasListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServerDnsAliasListResult IModelSerializable<ServerDnsAliasListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServerDnsAliasListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServerDnsAliasListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServerDnsAliasListResult"/> to convert. </param>
        public static implicit operator RequestContent(ServerDnsAliasListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServerDnsAliasListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServerDnsAliasListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServerDnsAliasListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
