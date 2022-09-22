// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ARC autoprovisioning configuration. </summary>
    public partial class DefenderFoDatabasesAwsOfferingArcAutoProvisioning
    {
        /// <summary> Initializes a new instance of DefenderFoDatabasesAwsOfferingArcAutoProvisioning. </summary>
        public DefenderFoDatabasesAwsOfferingArcAutoProvisioning()
        {
        }

        /// <summary> Initializes a new instance of DefenderFoDatabasesAwsOfferingArcAutoProvisioning. </summary>
        /// <param name="enabled"> Is arc auto provisioning enabled. </param>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        /// <param name="servicePrincipalSecretMetadata"> Metadata of Service Principal secret for autoprovisioning. </param>
        internal DefenderFoDatabasesAwsOfferingArcAutoProvisioning(bool? enabled, string cloudRoleArn, DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata servicePrincipalSecretMetadata)
        {
            Enabled = enabled;
            CloudRoleArn = cloudRoleArn;
            ServicePrincipalSecretMetadata = servicePrincipalSecretMetadata;
        }

        /// <summary> Is arc auto provisioning enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
        /// <summary> Metadata of Service Principal secret for autoprovisioning. </summary>
        public DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata ServicePrincipalSecretMetadata { get; set; }
    }
}
