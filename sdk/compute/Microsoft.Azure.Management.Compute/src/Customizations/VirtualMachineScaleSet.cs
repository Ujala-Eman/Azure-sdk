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
        /// <param name="automaticRepairsPolicy">Policy for automatic
        /// repairs.</param>
        /// <param name="virtualMachineProfile">The virtual machine
        /// profile.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="overprovision">Specifies whether the Virtual Machine
        /// Scale Set should be overprovisioned.</param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVMs">When
        /// Overprovision is enabled, extensions are launched only on the
        /// requested number of VMs which are finally kept. This property will
        /// hence ensure that the extensions do not run on the extra
        /// overprovisioned VMs.</param>
        /// <param name="uniqueId">Specifies the ID which uniquely identifies a
        /// Virtual Machine Scale Set.</param>
        /// <param name="singlePlacementGroup">When true this limits the scale
        /// set to a single placement group, of max size 100 virtual machines.
        /// NOTE: If singlePlacementGroup is true, it may be modified to false.
        /// However, if singlePlacementGroup is false, it may not be modified
        /// to true.</param>
        /// <param name="zoneBalance">Whether to force strictly even Virtual
        /// Machine distribution cross x-zones in case there is zone
        /// outage.</param>
        /// <param name="platformFaultDomainCount">Fault Domain count for each
        /// placement group.</param>
        /// <param name="proximityPlacementGroup">Specifies information about
        /// the proximity placement group that the virtual machine scale set
        /// should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2018-04-01.</param>
        /// <param name="hostGroup">Specifies information about the dedicated
        /// host group that the virtual machine scale set resides in.
        /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the Virtual Machines in the
        /// Virtual Machine Scale Set. For instance: whether the Virtual
        /// Machines have the capability to support attaching managed data
        /// disks with UltraSSD_LRS storage account type.</param>
        /// <param name="scaleInPolicy">Specifies the scale-in policy that
        /// decides which virtual machines are chosen for removal when a
        /// Virtual Machine Scale Set is scaled-in.</param>
        /// <param name="orchestrationMode">Specifies the orchestration mode
        /// for the virtual machine scale set. Possible values include:
        /// 'Uniform', 'Flexible'</param>
        /// <param name="identity">The identity of the virtual machine scale
        /// set, if configured.</param>
        /// <param name="zones">The virtual machine scale set zones. NOTE:
        /// Availability zones can only be set when you create the scale
        /// set</param>
        /// <param name="extendedLocation">The extended location of the Virtual
        /// Machine Scale Set.</param>
        public VirtualMachineScaleSet(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Plan plan = default(Plan), UpgradePolicy upgradePolicy = default(UpgradePolicy), AutomaticRepairsPolicy automaticRepairsPolicy = default(AutomaticRepairsPolicy), VirtualMachineScaleSetVMProfile virtualMachineProfile = default(VirtualMachineScaleSetVMProfile), string provisioningState = default(string), bool? overprovision = default(bool?), bool? doNotRunExtensionsOnOverprovisionedVMs = default(bool?), string uniqueId = default(string), bool? singlePlacementGroup = default(bool?), bool? zoneBalance = default(bool?), int? platformFaultDomainCount = default(int?), SubResource proximityPlacementGroup = default(SubResource), SubResource hostGroup = default(SubResource), AdditionalCapabilities additionalCapabilities = default(AdditionalCapabilities), ScaleInPolicy scaleInPolicy = default(ScaleInPolicy), VirtualMachineScaleSetIdentity identity, IList<string> zones, ExtendedLocation extendedLocation)
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Plan = plan;
            UpgradePolicy = upgradePolicy;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            UniqueId = uniqueId;
            SinglePlacementGroup = singlePlacementGroup;
            ZoneBalance = zoneBalance;
            PlatformFaultDomainCount = platformFaultDomainCount;
            ProximityPlacementGroup = proximityPlacementGroup;
            HostGroup = hostGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
            OrchestrationMode = orchestrationMode;
            Identity = identity;
            Zones = zones;
            ExtendedLocation = extendedLocation;
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
        /// <param name="automaticRepairsPolicy">Policy for automatic
        /// repairs.</param>
        /// <param name="virtualMachineProfile">The virtual machine
        /// profile.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="overprovision">Specifies whether the Virtual Machine
        /// Scale Set should be overprovisioned.</param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVMs">When
        /// Overprovision is enabled, extensions are launched only on the
        /// requested number of VMs which are finally kept. This property will
        /// hence ensure that the extensions do not run on the extra
        /// overprovisioned VMs.</param>
        /// <param name="uniqueId">Specifies the ID which uniquely identifies a
        /// Virtual Machine Scale Set.</param>
        /// <param name="singlePlacementGroup">When true this limits the scale
        /// set to a single placement group, of max size 100 virtual machines.
        /// NOTE: If singlePlacementGroup is true, it may be modified to false.
        /// However, if singlePlacementGroup is false, it may not be modified
        /// to true.</param>
        /// <param name="zoneBalance">Whether to force strictly even Virtual
        /// Machine distribution cross x-zones in case there is zone
        /// outage.</param>
        /// <param name="platformFaultDomainCount">Fault Domain count for each
        /// placement group.</param>
        /// <param name="proximityPlacementGroup">Specifies information about
        /// the proximity placement group that the virtual machine scale set
        /// should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2018-04-01.</param>
        /// <param name="hostGroup">Specifies information about the dedicated
        /// host group that the virtual machine scale set resides in.
        /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the Virtual Machines in the
        /// Virtual Machine Scale Set. For instance: whether the Virtual
        /// Machines have the capability to support attaching managed data
        /// disks with UltraSSD_LRS storage account type.</param>
        /// <param name="scaleInPolicy">Specifies the scale-in policy that
        /// decides which virtual machines are chosen for removal when a
        /// Virtual Machine Scale Set is scaled-in.</param>
        /// <param name="orchestrationMode">Specifies the orchestration mode
        /// for the virtual machine scale set. Possible values include:
        /// 'Uniform', 'Flexible'</param>
        /// <param name="identity">The identity of the virtual machine scale
        /// set, if configured.</param>
        /// <param name="zones">The virtual machine scale set zones. NOTE:
        /// Availability zones can only be set when you create the scale
        /// set</param>
        public VirtualMachineScaleSet(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Plan plan = default(Plan), UpgradePolicy upgradePolicy = default(UpgradePolicy), AutomaticRepairsPolicy automaticRepairsPolicy = default(AutomaticRepairsPolicy), VirtualMachineScaleSetVMProfile virtualMachineProfile = default(VirtualMachineScaleSetVMProfile), string provisioningState = default(string), bool? overprovision = default(bool?), bool? doNotRunExtensionsOnOverprovisionedVMs = default(bool?), string uniqueId = default(string), bool? singlePlacementGroup = default(bool?), bool? zoneBalance = default(bool?), int? platformFaultDomainCount = default(int?), SubResource proximityPlacementGroup = default(SubResource), SubResource hostGroup = default(SubResource), AdditionalCapabilities additionalCapabilities = default(AdditionalCapabilities), ScaleInPolicy scaleInPolicy = default(ScaleInPolicy), VirtualMachineScaleSetIdentity identity, IList<string> zones)
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Plan = plan;
            UpgradePolicy = upgradePolicy;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            UniqueId = uniqueId;
            SinglePlacementGroup = singlePlacementGroup;
            ZoneBalance = zoneBalance;
            PlatformFaultDomainCount = platformFaultDomainCount;
            ProximityPlacementGroup = proximityPlacementGroup;
            HostGroup = hostGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
            OrchestrationMode = orchestrationMode;
            Identity = identity;
            Zones = zones;
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
        /// <param name="automaticRepairsPolicy">Policy for automatic
        /// repairs.</param>
        /// <param name="virtualMachineProfile">The virtual machine
        /// profile.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="overprovision">Specifies whether the Virtual Machine
        /// Scale Set should be overprovisioned.</param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVMs">When
        /// Overprovision is enabled, extensions are launched only on the
        /// requested number of VMs which are finally kept. This property will
        /// hence ensure that the extensions do not run on the extra
        /// overprovisioned VMs.</param>
        /// <param name="uniqueId">Specifies the ID which uniquely identifies a
        /// Virtual Machine Scale Set.</param>
        /// <param name="singlePlacementGroup">When true this limits the scale
        /// set to a single placement group, of max size 100 virtual machines.
        /// NOTE: If singlePlacementGroup is true, it may be modified to false.
        /// However, if singlePlacementGroup is false, it may not be modified
        /// to true.</param>
        /// <param name="zoneBalance">Whether to force strictly even Virtual
        /// Machine distribution cross x-zones in case there is zone
        /// outage.</param>
        /// <param name="platformFaultDomainCount">Fault Domain count for each
        /// placement group.</param>
        /// <param name="proximityPlacementGroup">Specifies information about
        /// the proximity placement group that the virtual machine scale set
        /// should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2018-04-01.</param>
        /// <param name="hostGroup">Specifies information about the dedicated
        /// host group that the virtual machine scale set resides in.
        /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the Virtual Machines in the
        /// Virtual Machine Scale Set. For instance: whether the Virtual
        /// Machines have the capability to support attaching managed data
        /// disks with UltraSSD_LRS storage account type.</param>
        /// <param name="scaleInPolicy">Specifies the scale-in policy that
        /// decides which virtual machines are chosen for removal when a
        /// Virtual Machine Scale Set is scaled-in.</param>
        /// <param name="orchestrationMode">Specifies the orchestration mode
        /// for the virtual machine scale set. Possible values include:
        /// 'Uniform', 'Flexible'</param>
        /// <param name="identity">The identity of the virtual machine scale
        /// set, if configured.</param>
        public VirtualMachineScaleSet(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Plan plan = default(Plan), UpgradePolicy upgradePolicy = default(UpgradePolicy), AutomaticRepairsPolicy automaticRepairsPolicy = default(AutomaticRepairsPolicy), VirtualMachineScaleSetVMProfile virtualMachineProfile = default(VirtualMachineScaleSetVMProfile), string provisioningState = default(string), bool? overprovision = default(bool?), bool? doNotRunExtensionsOnOverprovisionedVMs = default(bool?), string uniqueId = default(string), bool? singlePlacementGroup = default(bool?), bool? zoneBalance = default(bool?), int? platformFaultDomainCount = default(int?), SubResource proximityPlacementGroup = default(SubResource), SubResource hostGroup = default(SubResource), AdditionalCapabilities additionalCapabilities = default(AdditionalCapabilities), ScaleInPolicy scaleInPolicy = default(ScaleInPolicy), VirtualMachineScaleSetIdentity identity)
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Plan = plan;
            UpgradePolicy = upgradePolicy;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            UniqueId = uniqueId;
            SinglePlacementGroup = singlePlacementGroup;
            ZoneBalance = zoneBalance;
            PlatformFaultDomainCount = platformFaultDomainCount;
            ProximityPlacementGroup = proximityPlacementGroup;
            HostGroup = hostGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
            OrchestrationMode = orchestrationMode;
            Identity = identity;
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
        /// Gets or sets policy for automatic repairs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.automaticRepairsPolicy")]
        public AutomaticRepairsPolicy AutomaticRepairsPolicy { get; set; }

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
        /// Gets or sets when Overprovision is enabled, extensions are launched
        /// only on the requested number of VMs which are finally kept. This
        /// property will hence ensure that the extensions do not run on the
        /// extra overprovisioned VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.doNotRunExtensionsOnOverprovisionedVMs")]
        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

        /// <summary>
        /// Gets specifies the ID which uniquely identifies a Virtual Machine
        /// Scale Set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or sets when true this limits the scale set to a single
        /// placement group, of max size 100 virtual machines. NOTE: If
        /// singlePlacementGroup is true, it may be modified to false. However,
        /// if singlePlacementGroup is false, it may not be modified to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.singlePlacementGroup")]
        public bool? SinglePlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets whether to force strictly even Virtual Machine
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
        /// Gets or sets specifies information about the proximity placement
        /// group that the virtual machine scale set should be assigned to.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2018-04-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.proximityPlacementGroup")]
        public SubResource ProximityPlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the dedicated host group
        /// that the virtual machine scale set resides in.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2020-06-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostGroup")]
        public SubResource HostGroup { get; set; }

        /// <summary>
        /// Gets or sets specifies additional capabilities enabled or disabled
        /// on the Virtual Machines in the Virtual Machine Scale Set. For
        /// instance: whether the Virtual Machines have the capability to
        /// support attaching managed data disks with UltraSSD_LRS storage
        /// account type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets or sets specifies the scale-in policy that decides which
        /// virtual machines are chosen for removal when a Virtual Machine
        /// Scale Set is scaled-in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleInPolicy")]
        public ScaleInPolicy ScaleInPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies the orchestration mode for the virtual
        /// machine scale set. Possible values include: 'Uniform', 'Flexible'
        /// </summary>
        [JsonProperty(PropertyName = "properties.orchestrationMode")]
        public string OrchestrationMode { get; set; }

        /// <summary>
        /// Gets or sets the identity of the virtual machine scale set, if
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VirtualMachineScaleSetIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set zones. NOTE:
        /// Availability zones can only be set when you create the scale set
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets or sets the extended location of the Virtual Machine Scale
        /// Set.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

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
