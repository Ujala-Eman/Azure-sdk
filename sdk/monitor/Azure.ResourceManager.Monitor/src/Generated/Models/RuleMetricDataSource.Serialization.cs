// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class RuleMetricDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MetricName))
            {
                writer.WritePropertyName("metricName");
                writer.WriteStringValue(MetricName);
            }
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceUri");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(LegacyResourceId))
            {
                writer.WritePropertyName("legacyResourceId");
                writer.WriteStringValue(LegacyResourceId);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation");
                writer.WriteStringValue(ResourceLocation);
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace");
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WriteEndObject();
        }

        internal static RuleMetricDataSource DeserializeRuleMetricDataSource(JsonElement element)
        {
            Optional<string> metricName = default;
            string odataType = default;
            Optional<ResourceIdentifier> resourceUri = default;
            Optional<string> legacyResourceId = default;
            Optional<string> resourceLocation = default;
            Optional<string> metricNamespace = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceUri = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("legacyResourceId"))
                {
                    legacyResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
            }
            return new RuleMetricDataSource(odataType, resourceUri.Value, legacyResourceId.Value, resourceLocation.Value, metricNamespace.Value, metricName.Value);
        }
    }
}
