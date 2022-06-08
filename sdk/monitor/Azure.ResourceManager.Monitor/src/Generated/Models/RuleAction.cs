// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// The action that is performed when the alert rule becomes active, and when an alert condition is resolved.
    /// Please note <see cref="RuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
    /// </summary>
    public partial class RuleAction
    {
        /// <summary> Initializes a new instance of <see cref="RuleAction"/>. </summary>
        public RuleAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RuleAction"/>. </summary>
        /// <param name="odataType"> specifies the type of the action. There are two types of actions: RuleEmailAction and RuleWebhookAction. </param>
        internal RuleAction(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> specifies the type of the action. There are two types of actions: RuleEmailAction and RuleWebhookAction. </summary>
        internal string OdataType { get; set; }
    }
}
