// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the AlertRuleTemplate data model.
    /// Please note <see cref="AlertRuleTemplateData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FusionAlertRuleTemplate"/>, <see cref="MLBehaviorAnalyticsAlertRuleTemplate"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRuleTemplate"/>, <see cref="NrtAlertRuleTemplate"/>, <see cref="ScheduledAlertRuleTemplate"/> and <see cref="ThreatIntelligenceAlertRuleTemplate"/>.
    /// </summary>
    public partial class AlertRuleTemplateData : ResourceData
    {
        /// <summary> Initializes a new instance of AlertRuleTemplateData. </summary>
        public AlertRuleTemplateData()
        {
        }

        /// <summary> Initializes a new instance of AlertRuleTemplateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        internal AlertRuleTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> The kind of the alert rule. </summary>
        internal AlertRuleKind Kind { get; set; }
    }
}
