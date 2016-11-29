// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{

    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.Update;
    /// <summary>
    /// An immutable client-side representation of an Azure virtual machine.
    /// </summary>
    public interface IVirtualMachine  :
        IGroupableResource,
        IRefreshable<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>,
        IWrapper<Microsoft.Azure.Management.Compute.Fluent.Models.VirtualMachineInner>,
        IUpdatable<Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.Update.IUpdate>,
        IHasNetworkInterfaces
    {
        /// <summary>
        /// Shuts down the Virtual Machine and releases the compute resources.
        /// <p>
        /// You are not billed for the compute resources that this Virtual Machine uses
        /// </summary>
        void Deallocate();

        /// <summary>
        /// Generalize the Virtual Machine.
        /// </summary>
        void Generalize();

        /// <summary>
        /// Power off (stop) the virtual machine.
        /// <p>
        /// You will be billed for the compute resources that this Virtual Machine uses.
        /// </summary>
        void PowerOff();

        /// <summary>
        /// Restart the virtual machine.
        /// =
        /// </summary>
        void Restart();

        /// <summary>
        /// Start the virtual machine.
        /// </summary>
        void Start();

        /// <summary>
        /// Redeploy the virtual machine.
        /// </summary>
        void Redeploy();

        /// <summary>
        /// List of all available virtual machine sizes this virtual machine can resized to.
        /// </summary>
        /// <returns>the virtual machine sizes</returns>
        Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineSize> AvailableSizes();

        /// <summary>
        /// Captures the virtual machine by copying virtual hard disks of the VM and returns template as json
        /// string that can be used to create similar VMs.
        /// </summary>
        /// <param name="containerName">containerName destination container name to store the captured Vhd</param>
        /// <param name="vhdPrefix">vhdPrefix the prefix for the vhd holding captured image</param>
        /// <param name="overwriteVhd">overwriteVhd whether to overwrites destination vhd if it exists</param>
        /// <returns>the template as json string</returns>
        string Capture(string containerName, string vhdPrefix, bool overwriteVhd);

        /// <summary>
        /// Refreshes the virtual machine instance view to sync with Azure.
        /// <p>
        /// this will caches the instance view which can be later retrieved using {@link VirtualMachine#instanceView()}.
        /// </summary>
        /// <returns>the refreshed instance view</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.VirtualMachineInstanceView RefreshInstanceView();

        /// <returns>name of this virtual machine</returns>
        string ComputerName { get; }

        /// <returns>the virtual machine size</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.VirtualMachineSizeTypes Size { get; }

        /// <returns>the operating system of this virtual machine</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.OperatingSystemTypes OsType { get; }

        /// <returns>the uri to the vhd file backing this virtual machine's operating system disk</returns>
        string OsDiskVhdUri { get; }

        /// <returns>the operating system disk caching type, valid values are 'None', 'ReadOnly', 'ReadWrite'</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.CachingTypes OsDiskCachingType { get; }

        /// <returns>the size of the operating system disk in GB</returns>
        int OsDiskSize { get; }

        /// <returns>the list of data disks attached to this virtual machine</returns>
        System.Collections.Generic.IList<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineDataDisk> DataDisks { get; }

        /// <summary>
        /// Gets the public IP address associated with this virtual machine's primary network interface.
        /// <p>
        /// note that this method makes a rest API call to fetch the resource.
        /// </summary>
        /// <returns>the public IP of the primary network interface</returns>
        Microsoft.Azure.Management.Network.Fluent.IPublicIpAddress GetPrimaryPublicIpAddress();

        /// <returns>the resource ID of the public IP address associated with this virtual machine's primary network interface</returns>
        string GetPrimaryPublicIpAddressId();

        /// <summary>
        /// Returns id to the availability set this virtual machine associated with.
        /// <p>
        /// Having a set of virtual machines in an availability set ensures that during maintenance
        /// event at least one virtual machine will be available.
        /// </summary>
        /// <returns>the availabilitySet reference id</returns>
        string AvailabilitySetId { get; }

        /// <returns>the provisioningState value</returns>
        string ProvisioningState { get; }

        /// <returns>the licenseType value</returns>
        string LicenseType { get; }

        /// <returns>the extensions attached to the Azure Virtual Machine</returns>
        System.Collections.Generic.IDictionary<string,Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineExtension> Extensions { get; }

        /// <returns>the plan value</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.Plan Plan { get; }

        /// <summary>
        /// Returns the storage profile of an Azure virtual machine.
        /// <p>
        /// The storage profile contains information such as the details of the VM image or user image
        /// from which this virtual machine is created, the Azure storage account where the operating system
        /// disk is stored, details of the data disk attached to the virtual machine.
        /// </summary>
        /// <returns>the storageProfile value</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.StorageProfile StorageProfile { get; }

        /// <summary>
        /// Gets the operating system profile of an Azure virtual machine.
        /// </summary>
        /// <returns>the osProfile value</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.OSProfile OsProfile { get; }

        /// <summary>
        /// Returns the diagnostics profile of an Azure virtual machine.
        /// <p>
        /// Enabling diagnostic features in a virtual machine enable you to easily diagnose and recover
        /// virtual machine from boot failures.
        /// </summary>
        /// <returns>the diagnosticsProfile value</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.DiagnosticsProfile DiagnosticsProfile { get; }

        /// <returns>the virtual machine unique id.</returns>
        string VmId { get; }

        /// <returns>the power state of the virtual machine</returns>
        Microsoft.Azure.Management.Compute.Fluent.PowerState PowerState { get; }

        /// <summary>
        /// Get the virtual machine instance view.
        /// <p>
        /// this method returns the cached instance view, to refresh the cache call {@link VirtualMachine#refreshInstanceView()}.
        /// </summary>
        /// <returns>the virtual machine instance view</returns>
        Microsoft.Azure.Management.Compute.Fluent.Models.VirtualMachineInstanceView InstanceView { get; }

    }
}