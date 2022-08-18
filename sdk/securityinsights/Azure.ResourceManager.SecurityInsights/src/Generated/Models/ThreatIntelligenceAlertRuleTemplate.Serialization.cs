// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceAlertRuleTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
            {
                writer.WritePropertyName("alertRulesCreatedByTemplateCount");
                writer.WriteNumberValue(AlertRulesCreatedByTemplateCount.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                writer.WritePropertyName("requiredDataConnectors");
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics");
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques");
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity");
                writer.WriteStringValue(Severity.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ThreatIntelligenceAlertRuleTemplate DeserializeThreatIntelligenceAlertRuleTemplate(JsonElement element)
        {
            AlertRuleKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> alertRulesCreatedByTemplateCount = default;
            Optional<DateTimeOffset> lastUpdatedDateUTC = default;
            Optional<DateTimeOffset> createdDateUTC = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<IList<AlertRuleTemplateDataSource>> requiredDataConnectors = default;
            Optional<TemplateStatus> status = default;
            Optional<IList<AttackTactic>> tactics = default;
            Optional<IList<string>> techniques = default;
            Optional<AlertSeverity> severity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("alertRulesCreatedByTemplateCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            alertRulesCreatedByTemplateCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateUTC"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUpdatedDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdDateUTC"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
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
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new TemplateStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tactics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AttackTactic> array = new List<AttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
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
                        if (property0.NameEquals("severity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            severity = new AlertSeverity(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ThreatIntelligenceAlertRuleTemplate(id, name, type, systemData.Value, kind, Optional.ToNullable(alertRulesCreatedByTemplateCount), Optional.ToNullable(lastUpdatedDateUTC), Optional.ToNullable(createdDateUTC), description.Value, displayName.Value, Optional.ToList(requiredDataConnectors), Optional.ToNullable(status), Optional.ToList(tactics), Optional.ToList(techniques), Optional.ToNullable(severity));
        }
    }
}
