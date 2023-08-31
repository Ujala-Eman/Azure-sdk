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

namespace Azure.ResourceManager.Search.Models
{
    internal partial class NetworkRuleSet : IUtf8JsonSerializable, IModelJsonSerializable<NetworkRuleSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkRuleSet>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkRuleSet>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SearchServiceIPRule>)item).Serialize(writer, options);
                    }
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

        internal static NetworkRuleSet DeserializeNetworkRuleSet(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SearchServiceIPRule>> ipRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchServiceIPRule> array = new List<SearchServiceIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchServiceIPRule.DeserializeSearchServiceIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkRuleSet(Optional.ToList(ipRules), rawData);
        }

        NetworkRuleSet IModelJsonSerializable<NetworkRuleSet>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkRuleSet(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkRuleSet>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkRuleSet IModelSerializable<NetworkRuleSet>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkRuleSet(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkRuleSet"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkRuleSet"/> to convert. </param>
        public static implicit operator RequestContent(NetworkRuleSet model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkRuleSet"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkRuleSet(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkRuleSet(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
