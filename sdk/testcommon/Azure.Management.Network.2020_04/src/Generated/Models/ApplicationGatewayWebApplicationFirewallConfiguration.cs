// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Application gateway web application firewall configuration. </summary>
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration
    {
        /// <summary> Initializes a new instance of ApplicationGatewayWebApplicationFirewallConfiguration. </summary>
        /// <param name="enabled"> Whether the web application firewall is enabled or not. </param>
        /// <param name="firewallMode"> Web application firewall mode. </param>
        /// <param name="ruleSetType"> The type of the web application firewall rule set. Possible values are: &apos;OWASP&apos;. </param>
        /// <param name="ruleSetVersion"> The version of the rule set type. </param>
        public ApplicationGatewayWebApplicationFirewallConfiguration(bool enabled, ApplicationGatewayFirewallMode firewallMode, string ruleSetType, string ruleSetVersion)
        {
            if (ruleSetType == null)
            {
                throw new ArgumentNullException(nameof(ruleSetType));
            }
            if (ruleSetVersion == null)
            {
                throw new ArgumentNullException(nameof(ruleSetVersion));
            }

            Enabled = enabled;
            FirewallMode = firewallMode;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            DisabledRuleGroups = new ChangeTrackingList<ApplicationGatewayFirewallDisabledRuleGroup>();
            Exclusions = new ChangeTrackingList<ApplicationGatewayFirewallExclusion>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayWebApplicationFirewallConfiguration. </summary>
        /// <param name="enabled"> Whether the web application firewall is enabled or not. </param>
        /// <param name="firewallMode"> Web application firewall mode. </param>
        /// <param name="ruleSetType"> The type of the web application firewall rule set. Possible values are: &apos;OWASP&apos;. </param>
        /// <param name="ruleSetVersion"> The version of the rule set type. </param>
        /// <param name="disabledRuleGroups"> The disabled rule groups. </param>
        /// <param name="requestBodyCheck"> Whether allow WAF to check request Body. </param>
        /// <param name="maxRequestBodySize"> Maximum request body size for WAF. </param>
        /// <param name="maxRequestBodySizeInKb"> Maximum request body size in Kb for WAF. </param>
        /// <param name="fileUploadLimitInMb"> Maximum file upload size in Mb for WAF. </param>
        /// <param name="exclusions"> The exclusion list. </param>
        internal ApplicationGatewayWebApplicationFirewallConfiguration(bool enabled, ApplicationGatewayFirewallMode firewallMode, string ruleSetType, string ruleSetVersion, IList<ApplicationGatewayFirewallDisabledRuleGroup> disabledRuleGroups, bool? requestBodyCheck, int? maxRequestBodySize, int? maxRequestBodySizeInKb, int? fileUploadLimitInMb, IList<ApplicationGatewayFirewallExclusion> exclusions)
        {
            Enabled = enabled;
            FirewallMode = firewallMode;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            DisabledRuleGroups = disabledRuleGroups;
            RequestBodyCheck = requestBodyCheck;
            MaxRequestBodySize = maxRequestBodySize;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadLimitInMb = fileUploadLimitInMb;
            Exclusions = exclusions;
        }

        /// <summary> Whether the web application firewall is enabled or not. </summary>
        public bool Enabled { get; set; }
        /// <summary> Web application firewall mode. </summary>
        public ApplicationGatewayFirewallMode FirewallMode { get; set; }
        /// <summary> The type of the web application firewall rule set. Possible values are: &apos;OWASP&apos;. </summary>
        public string RuleSetType { get; set; }
        /// <summary> The version of the rule set type. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> The disabled rule groups. </summary>
        public IList<ApplicationGatewayFirewallDisabledRuleGroup> DisabledRuleGroups { get; }
        /// <summary> Whether allow WAF to check request Body. </summary>
        public bool? RequestBodyCheck { get; set; }
        /// <summary> Maximum request body size for WAF. </summary>
        public int? MaxRequestBodySize { get; set; }
        /// <summary> Maximum request body size in Kb for WAF. </summary>
        public int? MaxRequestBodySizeInKb { get; set; }
        /// <summary> Maximum file upload size in Mb for WAF. </summary>
        public int? FileUploadLimitInMb { get; set; }
        /// <summary> The exclusion list. </summary>
        public IList<ApplicationGatewayFirewallExclusion> Exclusions { get; }
    }
}
