// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties of Provisioning Issue. </summary>
    public partial class ProvisioningIssueProperties
    {
        /// <summary> Initializes a new instance of ProvisioningIssueProperties. </summary>
        internal ProvisioningIssueProperties()
        {
        }

        /// <summary> Initializes a new instance of ProvisioningIssueProperties. </summary>
        /// <param name="issueType"> Type of Issue. </param>
        /// <param name="description"> Description of the issue. </param>
        internal ProvisioningIssueProperties(string issueType, string description)
        {
            IssueType = issueType;
            Description = description;
        }

        /// <summary> Type of Issue. </summary>
        public string IssueType { get; }
        /// <summary> Description of the issue. </summary>
        public string Description { get; }
    }
}
