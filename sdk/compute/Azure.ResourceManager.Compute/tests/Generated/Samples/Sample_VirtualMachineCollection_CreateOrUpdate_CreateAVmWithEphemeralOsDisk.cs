// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_VirtualMachineCollection_CreateOrUpdate_CreateAVmWithEphemeralOsDisk
    {
        // Create a vm with ephemeral os disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualMachineResource
            Compute.VirtualMachineCollection collection = resourceGroupResource.GetVirtualMachines();

            // invoke the operation
            string vmName = "myVM";
            Compute.VirtualMachineData data = new VirtualMachineData(new AzureLocation("westus"))
            {
                Plan = new ComputePlan()
                {
                    Name = "windows2016",
                    Publisher = "microsoft-ads",
                    Product = "windows-data-science-vm",
                },
                HardwareProfile = new VirtualMachineHardwareProfile()
                {
                    VmSize = VirtualMachineSizeType.StandardDS1V2,
                },
                StorageProfile = new VirtualMachineStorageProfile()
                {
                    ImageReference = new ImageReference()
                    {
                        Publisher = "microsoft-ads",
                        Offer = "windows-data-science-vm",
                        Sku = "windows2016",
                        Version = "latest",
                    },
                    OSDisk = new VirtualMachineOSDisk(DiskCreateOptionType.FromImage)
                    {
                        Name = "myVMosdisk",
                        Caching = CachingType.ReadOnly,
                        DiffDiskSettings = new DiffDiskSettings()
                        {
                            Option = DiffDiskOption.Local,
                        },
                        ManagedDisk = new VirtualMachineManagedDisk()
                        {
                            StorageAccountType = StorageAccountType.StandardLrs,
                        },
                    },
                },
                OSProfile = new VirtualMachineOSProfile()
                {
                    ComputerName = "myVM",
                    AdminUsername = "{your-username}",
                    AdminPassword = "{your-password}",
                },
                NetworkProfile = new VirtualMachineNetworkProfile()
                {
                    NetworkInterfaces =
{
new VirtualMachineNetworkInterfaceReference()
{
Primary = true,
Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Network/networkInterfaces/{existing-nic-name}"),
}
},
                },
            };
            ArmOperation<Compute.VirtualMachineResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vmName, data);
            Compute.VirtualMachineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.VirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
