// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_DiskRestorePointResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnIncrementalDiskRestorePointResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskRestorePointExamples/DiskRestorePoint_Get.json
            // this example is just showing the usage of "DiskRestorePoint_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskRestorePointResource created on azure
            // for more information of creating DiskRestorePointResource, please refer to the document of DiskRestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            ResourceIdentifier diskRestorePointResourceId = DiskRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            DiskRestorePointResource diskRestorePoint = client.GetDiskRestorePointResource(diskRestorePointResourceId);

            // invoke the operation
            DiskRestorePointResource result = await diskRestorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnIncrementalDiskRestorePointWhenSourceResourceIsFromADifferentRegion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskRestorePointExamples/DiskRestorePoint_Get_WhenSourceResourceIsFromDifferentRegion.json
            // this example is just showing the usage of "DiskRestorePoint_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskRestorePointResource created on azure
            // for more information of creating DiskRestorePointResource, please refer to the document of DiskRestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            ResourceIdentifier diskRestorePointResourceId = DiskRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            DiskRestorePointResource diskRestorePoint = client.GetDiskRestorePointResource(diskRestorePointResourceId);

            // invoke the operation
            DiskRestorePointResource result = await diskRestorePoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskRestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GrantAccess_GrantsAccessToADiskRestorePoint()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskRestorePointExamples/DiskRestorePoint_BeginGetAccess.json
            // this example is just showing the usage of "DiskRestorePoint_GrantAccess" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskRestorePointResource created on azure
            // for more information of creating DiskRestorePointResource, please refer to the document of DiskRestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            ResourceIdentifier diskRestorePointResourceId = DiskRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            DiskRestorePointResource diskRestorePoint = client.GetDiskRestorePointResource(diskRestorePointResourceId);

            // invoke the operation
            GrantAccessData data = new GrantAccessData(AccessLevel.Read, 300)
            {
                FileFormat = DiskImageFileFormat.Vhdx,
            };
            ArmOperation<AccessUri> lro = await diskRestorePoint.GrantAccessAsync(WaitUntil.Completed, data);
            AccessUri result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RevokeAccess_RevokesAccessToADiskRestorePoint()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/examples/diskRestorePointExamples/DiskRestorePoint_EndGetAccess.json
            // this example is just showing the usage of "DiskRestorePoint_RevokeAccess" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiskRestorePointResource created on azure
            // for more information of creating DiskRestorePointResource, please refer to the document of DiskRestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            ResourceIdentifier diskRestorePointResourceId = DiskRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            DiskRestorePointResource diskRestorePoint = client.GetDiskRestorePointResource(diskRestorePointResourceId);

            // invoke the operation
            await diskRestorePoint.RevokeAccessAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
