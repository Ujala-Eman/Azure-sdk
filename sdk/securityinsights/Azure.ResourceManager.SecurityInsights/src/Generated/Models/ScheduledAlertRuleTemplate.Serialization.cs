// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ScheduledAlertRuleTemplate : IUtf8JsonSerializable, IJsonModel<ScheduledAlertRuleTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledAlertRuleTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduledAlertRuleTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ScheduledAlertRuleTemplate>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ScheduledAlertRuleTemplate>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
            {
                writer.WritePropertyName("alertRulesCreatedByTemplateCount"u8);
                writer.WriteNumberValue(AlertRulesCreatedByTemplateCount.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatedDateUTC))
                {
                    writer.WritePropertyName("createdDateUTC"u8);
                    writer.WriteStringValue(CreatedDateUTC.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastUpdatedDateUTC))
                {
                    writer.WritePropertyName("lastUpdatedDateUTC"u8);
                    writer.WriteStringValue(LastUpdatedDateUTC.Value, "O");
                }
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                writer.WritePropertyName("requiredDataConnectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(QueryFrequency))
            {
                writer.WritePropertyName("queryFrequency"u8);
                writer.WriteStringValue(QueryFrequency.Value, "P");
            }
            if (Optional.IsDefined(QueryPeriod))
            {
                writer.WritePropertyName("queryPeriod"u8);
                writer.WriteStringValue(QueryPeriod.Value, "P");
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(TriggerOperator))
            {
                writer.WritePropertyName("triggerOperator"u8);
                writer.WriteStringValue(TriggerOperator.Value.ToSerialString());
            }
            if (Optional.IsDefined(TriggerThreshold))
            {
                writer.WritePropertyName("triggerThreshold"u8);
                writer.WriteNumberValue(TriggerThreshold.Value);
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(EventGroupingSettings))
            {
                writer.WritePropertyName("eventGroupingSettings"u8);
                writer.WriteObjectValue(EventGroupingSettings);
            }
            if (Optional.IsCollectionDefined(CustomDetails))
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteStartObject();
                foreach (var item in CustomDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(EntityMappings))
            {
                writer.WritePropertyName("entityMappings"u8);
                writer.WriteStartArray();
                foreach (var item in EntityMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlertDetailsOverride))
            {
                writer.WritePropertyName("alertDetailsOverride"u8);
                writer.WriteObjectValue(AlertDetailsOverride);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        ScheduledAlertRuleTemplate IJsonModel<ScheduledAlertRuleTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ScheduledAlertRuleTemplate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledAlertRuleTemplate(document.RootElement, options);
        }

        internal static ScheduledAlertRuleTemplate DeserializeScheduledAlertRuleTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> alertRulesCreatedByTemplateCount = default;
            Optional<DateTimeOffset> createdDateUTC = default;
            Optional<DateTimeOffset> lastUpdatedDateUTC = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<IList<AlertRuleTemplateDataSource>> requiredDataConnectors = default;
            Optional<SecurityInsightsAlertRuleTemplateStatus> status = default;
            Optional<string> query = default;
            Optional<TimeSpan> queryFrequency = default;
            Optional<TimeSpan> queryPeriod = default;
            Optional<SecurityInsightsAlertSeverity> severity = default;
            Optional<SecurityInsightsAlertRuleTriggerOperator> triggerOperator = default;
            Optional<int> triggerThreshold = default;
            Optional<IList<SecurityInsightsAttackTactic>> tactics = default;
            Optional<IList<string>> techniques = default;
            Optional<string> version = default;
            Optional<EventGroupingSettings> eventGroupingSettings = default;
            Optional<IDictionary<string, string>> customDetails = default;
            Optional<IList<SecurityInsightsAlertRuleEntityMapping>> entityMappings = default;
            Optional<SecurityInsightsAlertDetailsOverride> alertDetailsOverride = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("alertRulesCreatedByTemplateCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertRulesCreatedByTemplateCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("createdDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AlertRuleTemplateDataSource> array = new List<AlertRuleTemplateDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AlertRuleTemplateDataSource.DeserializeAlertRuleTemplateDataSource(item));
                            }
                            requiredDataConnectors = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertRuleTemplateStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryFrequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryFrequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("queryPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryPeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerOperator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerOperator = property0.Value.GetString().ToSecurityInsightsAlertRuleTriggerOperator();
                            continue;
                        }
                        if (property0.NameEquals("triggerThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerThreshold = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            techniques = array;
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventGroupingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventGroupingSettings = EventGroupingSettings.DeserializeEventGroupingSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customDetails = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("entityMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertRuleEntityMapping> array = new List<SecurityInsightsAlertRuleEntityMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAlertRuleEntityMapping.DeserializeSecurityInsightsAlertRuleEntityMapping(item));
                            }
                            entityMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("alertDetailsOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertDetailsOverride = SecurityInsightsAlertDetailsOverride.DeserializeSecurityInsightsAlertDetailsOverride(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduledAlertRuleTemplate(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToNullable(alertRulesCreatedByTemplateCount), Optional.ToNullable(createdDateUTC), Optional.ToNullable(lastUpdatedDateUTC), description.Value, displayName.Value, Optional.ToList(requiredDataConnectors), Optional.ToNullable(status), query.Value, Optional.ToNullable(queryFrequency), Optional.ToNullable(queryPeriod), Optional.ToNullable(severity), Optional.ToNullable(triggerOperator), Optional.ToNullable(triggerThreshold), Optional.ToList(tactics), Optional.ToList(techniques), version.Value, eventGroupingSettings.Value, Optional.ToDictionary(customDetails), Optional.ToList(entityMappings), alertDetailsOverride.Value);
        }

        BinaryData IPersistableModel<ScheduledAlertRuleTemplate>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ScheduledAlertRuleTemplate)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ScheduledAlertRuleTemplate IPersistableModel<ScheduledAlertRuleTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ScheduledAlertRuleTemplate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeScheduledAlertRuleTemplate(document.RootElement, options);
        }

        string IPersistableModel<ScheduledAlertRuleTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
