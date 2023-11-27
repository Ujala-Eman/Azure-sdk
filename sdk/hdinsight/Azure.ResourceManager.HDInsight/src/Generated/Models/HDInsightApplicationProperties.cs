// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The HDInsight cluster application GET response. </summary>
    public partial class HDInsightApplicationProperties
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightApplicationProperties"/>. </summary>
        public HDInsightApplicationProperties()
        {
            InstallScriptActions = new ChangeTrackingList<RuntimeScriptAction>();
            UninstallScriptActions = new ChangeTrackingList<RuntimeScriptAction>();
            HttpsEndpoints = new ChangeTrackingList<HDInsightApplicationHttpsEndpoint>();
            SshEndpoints = new ChangeTrackingList<HDInsightApplicationEndpoint>();
            Errors = new ChangeTrackingList<ResponseError>();
            PrivateLinkConfigurations = new ChangeTrackingList<HDInsightPrivateLinkConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightApplicationProperties"/>. </summary>
        /// <param name="computeProfile"> The list of roles in the cluster. </param>
        /// <param name="installScriptActions"> The list of install script actions. </param>
        /// <param name="uninstallScriptActions"> The list of uninstall script actions. </param>
        /// <param name="httpsEndpoints"> The list of application HTTPS endpoints. </param>
        /// <param name="sshEndpoints"> The list of application SSH endpoints. </param>
        /// <param name="provisioningState"> The provisioning state of the application. </param>
        /// <param name="applicationType"> The application type. </param>
        /// <param name="applicationState"> The application state. </param>
        /// <param name="errors"> The list of errors. </param>
        /// <param name="createdOn"> The application create date time. </param>
        /// <param name="marketplaceIdentifier"> The marketplace identifier. </param>
        /// <param name="privateLinkConfigurations"> The private link configurations. </param>
        internal HDInsightApplicationProperties(ComputeProfile computeProfile, IList<RuntimeScriptAction> installScriptActions, IList<RuntimeScriptAction> uninstallScriptActions, IList<HDInsightApplicationHttpsEndpoint> httpsEndpoints, IList<HDInsightApplicationEndpoint> sshEndpoints, string provisioningState, string applicationType, string applicationState, IList<ResponseError> errors, DateTimeOffset? createdOn, string marketplaceIdentifier, IList<HDInsightPrivateLinkConfiguration> privateLinkConfigurations)
        {
            ComputeProfile = computeProfile;
            InstallScriptActions = installScriptActions;
            UninstallScriptActions = uninstallScriptActions;
            HttpsEndpoints = httpsEndpoints;
            SshEndpoints = sshEndpoints;
            ProvisioningState = provisioningState;
            ApplicationType = applicationType;
            ApplicationState = applicationState;
            Errors = errors;
            CreatedOn = createdOn;
            MarketplaceIdentifier = marketplaceIdentifier;
            PrivateLinkConfigurations = privateLinkConfigurations;
        }

        /// <summary> The list of roles in the cluster. </summary>
        internal ComputeProfile ComputeProfile { get; set; }
        /// <summary> The list of roles in the cluster. </summary>
        public IList<HDInsightClusterRole> ComputeRoles
        {
            get
            {
                if (ComputeProfile is null)
                    ComputeProfile = new ComputeProfile();
                return ComputeProfile.Roles;
            }
        }

        /// <summary> The list of install script actions. </summary>
        public IList<RuntimeScriptAction> InstallScriptActions { get; }
        /// <summary> The list of uninstall script actions. </summary>
        public IList<RuntimeScriptAction> UninstallScriptActions { get; }
        /// <summary> The list of application HTTPS endpoints. </summary>
        public IList<HDInsightApplicationHttpsEndpoint> HttpsEndpoints { get; }
        /// <summary> The list of application SSH endpoints. </summary>
        public IList<HDInsightApplicationEndpoint> SshEndpoints { get; }
        /// <summary> The provisioning state of the application. </summary>
        public string ProvisioningState { get; }
        /// <summary> The application type. </summary>
        public string ApplicationType { get; set; }
        /// <summary> The application state. </summary>
        public string ApplicationState { get; }
        /// <summary> The list of errors. </summary>
        public IList<ResponseError> Errors { get; }
        /// <summary> The application create date time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The marketplace identifier. </summary>
        public string MarketplaceIdentifier { get; }
        /// <summary> The private link configurations. </summary>
        public IList<HDInsightPrivateLinkConfiguration> PrivateLinkConfigurations { get; }
    }
}
