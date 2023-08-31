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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsGroupingConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<SecurityInsightsGroupingConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityInsightsGroupingConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityInsightsGroupingConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("reopenClosedIncident"u8);
            writer.WriteBooleanValue(IsClosedIncidentReopened);
            writer.WritePropertyName("lookbackDuration"u8);
            writer.WriteStringValue(LookbackDuration, "P");
            writer.WritePropertyName("matchingMethod"u8);
            writer.WriteStringValue(MatchingMethod.ToString());
            if (Optional.IsCollectionDefined(GroupByEntities))
            {
                writer.WritePropertyName("groupByEntities"u8);
                writer.WriteStartArray();
                foreach (var item in GroupByEntities)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(GroupByAlertDetails))
            {
                writer.WritePropertyName("groupByAlertDetails"u8);
                writer.WriteStartArray();
                foreach (var item in GroupByAlertDetails)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(GroupByCustomDetails))
            {
                writer.WritePropertyName("groupByCustomDetails"u8);
                writer.WriteStartArray();
                foreach (var item in GroupByCustomDetails)
                {
                    writer.WriteStringValue(item);
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

        internal static SecurityInsightsGroupingConfiguration DeserializeSecurityInsightsGroupingConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            bool reopenClosedIncident = default;
            TimeSpan lookbackDuration = default;
            SecurityInsightsGroupingMatchingMethod matchingMethod = default;
            Optional<IList<SecurityInsightsAlertRuleEntityMappingType>> groupByEntities = default;
            Optional<IList<SecurityInsightsAlertDetail>> groupByAlertDetails = default;
            Optional<IList<string>> groupByCustomDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reopenClosedIncident"u8))
                {
                    reopenClosedIncident = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lookbackDuration"u8))
                {
                    lookbackDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("matchingMethod"u8))
                {
                    matchingMethod = new SecurityInsightsGroupingMatchingMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groupByEntities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAlertRuleEntityMappingType> array = new List<SecurityInsightsAlertRuleEntityMappingType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityInsightsAlertRuleEntityMappingType(item.GetString()));
                    }
                    groupByEntities = array;
                    continue;
                }
                if (property.NameEquals("groupByAlertDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAlertDetail> array = new List<SecurityInsightsAlertDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityInsightsAlertDetail(item.GetString()));
                    }
                    groupByAlertDetails = array;
                    continue;
                }
                if (property.NameEquals("groupByCustomDetails"u8))
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
                    groupByCustomDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityInsightsGroupingConfiguration(enabled, reopenClosedIncident, lookbackDuration, matchingMethod, Optional.ToList(groupByEntities), Optional.ToList(groupByAlertDetails), Optional.ToList(groupByCustomDetails), rawData);
        }

        SecurityInsightsGroupingConfiguration IModelJsonSerializable<SecurityInsightsGroupingConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsGroupingConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityInsightsGroupingConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityInsightsGroupingConfiguration IModelSerializable<SecurityInsightsGroupingConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsGroupingConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityInsightsGroupingConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityInsightsGroupingConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(SecurityInsightsGroupingConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityInsightsGroupingConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityInsightsGroupingConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityInsightsGroupingConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
