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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RuleBasedBackupPolicy : IUtf8JsonSerializable, IModelJsonSerializable<RuleBasedBackupPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RuleBasedBackupPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RuleBasedBackupPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RuleBasedBackupPolicy>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("policyRules"u8);
            writer.WriteStartArray();
            foreach (var item in PolicyRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("datasourceTypes"u8);
            writer.WriteStartArray();
            foreach (var item in DataSourceTypes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static RuleBasedBackupPolicy DeserializeRuleBasedBackupPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataProtectionBasePolicyRule> policyRules = default;
            IList<string> datasourceTypes = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyRules"u8))
                {
                    List<DataProtectionBasePolicyRule> array = new List<DataProtectionBasePolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBasePolicyRule.DeserializeDataProtectionBasePolicyRule(item));
                    }
                    policyRules = array;
                    continue;
                }
                if (property.NameEquals("datasourceTypes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    datasourceTypes = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RuleBasedBackupPolicy(datasourceTypes, objectType, policyRules, rawData);
        }

        RuleBasedBackupPolicy IModelJsonSerializable<RuleBasedBackupPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RuleBasedBackupPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleBasedBackupPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RuleBasedBackupPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RuleBasedBackupPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RuleBasedBackupPolicy IModelSerializable<RuleBasedBackupPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RuleBasedBackupPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRuleBasedBackupPolicy(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RuleBasedBackupPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RuleBasedBackupPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRuleBasedBackupPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
