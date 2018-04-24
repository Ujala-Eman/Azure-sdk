// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSet : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSet class.
        /// </summary>
        public VirtualMachineScaleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSet class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The virtual machine scale set sku.</param>
        /// <param name="plan">Specifies information about the marketplace
        /// image used to create the virtual machine. This element is only used
        /// for marketplace images. Before you can use a marketplace image from
        /// an API, you must enable the image for programmatic use.  In the
        /// Azure portal, find the marketplace image that you want to use and
        /// then click **Want to deploy programmatically, Get Started -&gt;**.
        /// Enter any required information and then click **Save**.</param>
        /// <param name="upgradePolicy">The upgrade policy.</param>
        /// <param name="virtualMachineProfile">The virtual machine
        /// profile.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="overprovision">Specifies whether the Virtual Machine
        /// Scale Set should be overprovisioned.</param>
        /// <param name="uniqueId">Specifies the ID which uniquely identifies a
        /// Virtual Machine Scale Set.</param>
        /// <param name="singlePlacementGroup">When true this limits the scale
        /// set to a single placement group, of max size 100 virtual
        /// machines.</param>
        /// <param name="zoneBalance">Whether to force stictly even Virtual
        /// Machine distribution cross x-zones in case there is zone
        /// outage.</param>
        /// <param name="platformFaultDomainCount">Fault Domain count for each
        /// placement group.</param>
        /// <param name="identity">The identity of the virtual machine scale
        /// set, if configured.</param>
        /// <param name="zones">The virtual machine scale set zones.</param>
        public VirtualMachineScaleSet(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Plan plan = default(Plan), UpgradePolicy upgradePolicy = default(UpgradePolicy), VirtualMachineScaleSetVMProfile virtualMachineProfile = default(VirtualMachineScaleSetVMProfile), string provisioningState = default(string), bool? overprovision = default(bool?), string uniqueId = default(string), bool? singlePlacementGroup = default(bool?), bool? zoneBalance = default(bool?), int? platformFaultDomainCount = default(int?), VirtualMachineScaleSetIdentity identity = default(VirtualMachineScaleSetIdentity), IList<string> zones = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Plan = plan;
            UpgradePolicy = upgradePolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            Overprovision = overprovision;
            UniqueId = uniqueId;
            SinglePlacementGroup = singlePlacementGroup;
            ZoneBalance = zoneBalance;
            PlatformFaultDomainCount = platformFaultDomainCount;
            Identity = identity;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine scale set sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the marketplace image used
        /// to create the virtual machine. This element is only used for
        /// marketplace images. Before you can use a marketplace image from an
        /// API, you must enable the image for programmatic use.  In the Azure
        /// portal, find the marketplace image that you want to use and then
        /// click **Want to deploy programmatically, Get Started -&amp;gt;**.
        /// Enter any required information and then click **Save**.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the upgrade policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradePolicy")]
        public UpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineProfile")]
        public VirtualMachineScaleSetVMProfile VirtualMachineProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets specifies whether the Virtual Machine Scale Set should
        /// be overprovisioned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overprovision")]
        public bool? Overprovision { get; set; }

        /// <summary>
        /// Gets specifies the ID which uniquely identifies a Virtual Machine
        /// Scale Set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or sets when true this limits the scale set to a single
        /// placement group, of max size 100 virtual machines.
        /// </summary>
        [JsonProperty(PropertyName = "properties.singlePlacementGroup")]
        public bool? SinglePlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets whether to force stictly even Virtual Machine
        /// distribution cross x-zones in case there is zone outage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneBalance")]
        public bool? ZoneBalance { get; set; }

        /// <summary>
        /// Gets or sets fault Domain count for each placement group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformFaultDomainCount")]
        public int? PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Gets or sets the identity of the virtual machine scale set, if
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VirtualMachineScaleSetIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set zones.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (UpgradePolicy != null)
            {
                UpgradePolicy.Validate();
            }
            if (VirtualMachineProfile != null)
            {
                VirtualMachineProfile.Validate();
            }
        }
    }
}
