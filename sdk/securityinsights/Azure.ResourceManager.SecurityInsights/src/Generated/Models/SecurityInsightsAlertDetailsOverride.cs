// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Settings for how to dynamically override alert static details. </summary>
    public partial class SecurityInsightsAlertDetailsOverride
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertDetailsOverride"/>. </summary>
        public SecurityInsightsAlertDetailsOverride()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertDetailsOverride"/>. </summary>
        /// <param name="alertDisplayNameFormat"> the format containing columns name(s) to override the alert name. </param>
        /// <param name="alertDescriptionFormat"> the format containing columns name(s) to override the alert description. </param>
        /// <param name="alertTacticsColumnName"> the column name to take the alert tactics from. </param>
        /// <param name="alertSeverityColumnName"> the column name to take the alert severity from. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsAlertDetailsOverride(string alertDisplayNameFormat, string alertDescriptionFormat, string alertTacticsColumnName, string alertSeverityColumnName, Dictionary<string, BinaryData> rawData)
        {
            AlertDisplayNameFormat = alertDisplayNameFormat;
            AlertDescriptionFormat = alertDescriptionFormat;
            AlertTacticsColumnName = alertTacticsColumnName;
            AlertSeverityColumnName = alertSeverityColumnName;
            _rawData = rawData;
        }

        /// <summary> the format containing columns name(s) to override the alert name. </summary>
        public string AlertDisplayNameFormat { get; set; }
        /// <summary> the format containing columns name(s) to override the alert description. </summary>
        public string AlertDescriptionFormat { get; set; }
        /// <summary> the column name to take the alert tactics from. </summary>
        public string AlertTacticsColumnName { get; set; }
        /// <summary> the column name to take the alert severity from. </summary>
        public string AlertSeverityColumnName { get; set; }
    }
}
