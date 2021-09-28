// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration for Compute Nodes in a Pool based on the Azure
    /// Virtual Machines infrastructure.
    /// </summary>
    public partial class VirtualMachineConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineConfiguration
        /// class.
        /// </summary>
        public VirtualMachineConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineConfiguration
        /// class.
        /// </summary>
        /// <param name="imageReference">A reference to the Azure Virtual
        /// Machines Marketplace Image or the custom Virtual Machine Image to
        /// use.</param>
        /// <param name="nodeAgentSKUId">The SKU of the Batch Compute Node
        /// agent to be provisioned on Compute Nodes in the Pool.</param>
        /// <param name="windowsConfiguration">Windows operating system
        /// settings on the virtual machine.</param>
        /// <param name="dataDisks">The configuration for data disks attached
        /// to the Compute Nodes in the Pool.</param>
        /// <param name="licenseType">The type of on-premises license to be
        /// used when deploying the operating system.</param>
        /// <param name="containerConfiguration">The container configuration
        /// for the Pool.</param>
        /// <param name="diskEncryptionConfiguration">The disk encryption
        /// configuration for the pool.</param>
        /// <param name="nodePlacementConfiguration">The node placement
        /// configuration for the pool.</param>
        /// <param name="extensions">The virtual machine extension for the
        /// pool.</param>
        /// <param name="osDisk">Settings for the operating system disk of the
        /// Virtual Machine.</param>
        public VirtualMachineConfiguration(ImageReference imageReference, string nodeAgentSKUId, WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), IList<DataDisk> dataDisks = default(IList<DataDisk>), string licenseType = default(string), ContainerConfiguration containerConfiguration = default(ContainerConfiguration), DiskEncryptionConfiguration diskEncryptionConfiguration = default(DiskEncryptionConfiguration), NodePlacementConfiguration nodePlacementConfiguration = default(NodePlacementConfiguration), IList<VMExtension> extensions = default(IList<VMExtension>), OSDisk osDisk = default(OSDisk))
        {
            ImageReference = imageReference;
            NodeAgentSKUId = nodeAgentSKUId;
            WindowsConfiguration = windowsConfiguration;
            DataDisks = dataDisks;
            LicenseType = licenseType;
            ContainerConfiguration = containerConfiguration;
            DiskEncryptionConfiguration = diskEncryptionConfiguration;
            NodePlacementConfiguration = nodePlacementConfiguration;
            Extensions = extensions;
            OsDisk = osDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a reference to the Azure Virtual Machines Marketplace
        /// Image or the custom Virtual Machine Image to use.
        /// </summary>
        [JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the Batch Compute Node agent to be
        /// provisioned on Compute Nodes in the Pool.
        /// </summary>
        /// <remarks>
        /// The Batch Compute Node agent is a program that runs on each Compute
        /// Node in the Pool, and provides the command-and-control interface
        /// between the Compute Node and the Batch service. There are different
        /// implementations of the Compute Node agent, known as SKUs, for
        /// different operating systems. You must specify a Compute Node agent
        /// SKU which matches the selected Image reference. To get the list of
        /// supported Compute Node agent SKUs along with their list of verified
        /// Image references, see the 'List supported Compute Node agent SKUs'
        /// operation.
        /// </remarks>
        [JsonProperty(PropertyName = "nodeAgentSKUId")]
        public string NodeAgentSKUId { get; set; }

        /// <summary>
        /// Gets or sets windows operating system settings on the virtual
        /// machine.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if the imageReference property
        /// specifies a Linux OS Image.
        /// </remarks>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the configuration for data disks attached to the
        /// Compute Nodes in the Pool.
        /// </summary>
        /// <remarks>
        /// This property must be specified if the Compute Nodes in the Pool
        /// need to have empty data disks attached to them. This cannot be
        /// updated. Each Compute Node gets its own disk (the disk is not a
        /// file share). Existing disks cannot be attached, each attached disk
        /// is empty. When the Compute Node is removed from the Pool, the disk
        /// and all data associated with it is also deleted. The disk is not
        /// formatted after being attached, it must be formatted before use -
        /// for more information see
        /// https://docs.microsoft.com/en-us/azure/virtual-machines/linux/classic/attach-disk#initialize-a-new-data-disk-in-linux
        /// and
        /// https://docs.microsoft.com/en-us/azure/virtual-machines/windows/attach-disk-ps#add-an-empty-data-disk-to-a-virtual-machine.
        /// </remarks>
        [JsonProperty(PropertyName = "dataDisks")]
        public IList<DataDisk> DataDisks { get; set; }

        /// <summary>
        /// Gets or sets the type of on-premises license to be used when
        /// deploying the operating system.
        /// </summary>
        /// <remarks>
        /// This only applies to Images that contain the Windows operating
        /// system, and should only be used when you hold valid on-premises
        /// licenses for the Compute Nodes which will be deployed. If omitted,
        /// no on-premises licensing discount is applied. Values are:
        ///
        /// Windows_Server - The on-premises license is for Windows Server.
        /// Windows_Client - The on-premises license is for Windows Client.
        ///
        /// </remarks>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the container configuration for the Pool.
        /// </summary>
        /// <remarks>
        /// If specified, setup is performed on each Compute Node in the Pool
        /// to allow Tasks to run in containers. All regular Tasks and Job
        /// manager Tasks run on this Pool must specify the containerSettings
        /// property, and all other Tasks may specify it.
        /// </remarks>
        [JsonProperty(PropertyName = "containerConfiguration")]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption configuration for the pool.
        /// </summary>
        /// <remarks>
        /// If specified, encryption is performed on each node in the pool
        /// during node provisioning.
        /// </remarks>
        [JsonProperty(PropertyName = "diskEncryptionConfiguration")]
        public DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the node placement configuration for the pool.
        /// </summary>
        /// <remarks>
        /// This configuration will specify rules on how nodes in the pool will
        /// be physically allocated.
        /// </remarks>
        [JsonProperty(PropertyName = "nodePlacementConfiguration")]
        public NodePlacementConfiguration NodePlacementConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine extension for the pool.
        /// </summary>
        /// <remarks>
        /// If specified, the extensions mentioned in this configuration will
        /// be installed on each node.
        /// </remarks>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VMExtension> Extensions { get; set; }

        /// <summary>
        /// Gets or sets settings for the operating system disk of the Virtual
        /// Machine.
        /// </summary>
        [JsonProperty(PropertyName = "osDisk")]
        public OSDisk OsDisk { get; set; }

    }
}
