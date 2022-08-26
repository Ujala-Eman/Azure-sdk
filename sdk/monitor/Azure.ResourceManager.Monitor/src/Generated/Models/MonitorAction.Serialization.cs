// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static MonitorAction DeserializeMonitorAction(JsonElement element)
        {
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.AlertingAction": return AlertingAction.DeserializeAlertingAction(element);
                    case "Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.LogToMetricAction": return LogToMetricAction.DeserializeLogToMetricAction(element);
                }
            }
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownMonitorAction(odataType);
        }
    }
}
