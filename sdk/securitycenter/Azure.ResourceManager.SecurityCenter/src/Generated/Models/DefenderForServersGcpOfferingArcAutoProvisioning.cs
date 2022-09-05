// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ARC autoprovisioning configuration. </summary>
    public partial class DefenderForServersGcpOfferingArcAutoProvisioning
    {
        /// <summary> Initializes a new instance of DefenderForServersGcpOfferingArcAutoProvisioning. </summary>
        public DefenderForServersGcpOfferingArcAutoProvisioning()
        {
        }

        /// <summary> Initializes a new instance of DefenderForServersGcpOfferingArcAutoProvisioning. </summary>
        /// <param name="enabled"> Is arc auto provisioning enabled. </param>
        /// <param name="configuration"> Configuration for ARC autoprovisioning. </param>
        internal DefenderForServersGcpOfferingArcAutoProvisioning(bool? enabled, DefenderForServersGcpOfferingArcAutoProvisioningConfiguration configuration)
        {
            Enabled = enabled;
            Configuration = configuration;
        }

        /// <summary> Is arc auto provisioning enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Configuration for ARC autoprovisioning. </summary>
        public DefenderForServersGcpOfferingArcAutoProvisioningConfiguration Configuration { get; set; }
    }
}
