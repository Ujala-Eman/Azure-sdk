// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppVolumeSnapshotResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SnapshotsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Snapshots_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeSnapshotResource created on azure
            // for more information of creating NetAppVolumeSnapshotResource, please refer to the document of NetAppVolumeSnapshotResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string snapshotName = "snapshot1";
            ResourceIdentifier netAppVolumeSnapshotResourceId = NetAppVolumeSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
            NetAppVolumeSnapshotResource netAppVolumeSnapshot = client.GetNetAppVolumeSnapshotResource(netAppVolumeSnapshotResourceId);

            // invoke the operation
            NetAppVolumeSnapshotResource result = await netAppVolumeSnapshot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SnapshotsDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Snapshots_Delete.json
            // this example is just showing the usage of "Snapshots_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeSnapshotResource created on azure
            // for more information of creating NetAppVolumeSnapshotResource, please refer to the document of NetAppVolumeSnapshotResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string snapshotName = "snapshot1";
            ResourceIdentifier netAppVolumeSnapshotResourceId = NetAppVolumeSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
            NetAppVolumeSnapshotResource netAppVolumeSnapshot = client.GetNetAppVolumeSnapshotResource(netAppVolumeSnapshotResourceId);

            // invoke the operation
            await netAppVolumeSnapshot.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SnapshotsCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Snapshots_Create.json
            // this example is just showing the usage of "Snapshots_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeSnapshotResource created on azure
            // for more information of creating NetAppVolumeSnapshotResource, please refer to the document of NetAppVolumeSnapshotResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string snapshotName = "snapshot1";
            ResourceIdentifier netAppVolumeSnapshotResourceId = NetAppVolumeSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
            NetAppVolumeSnapshotResource netAppVolumeSnapshot = client.GetNetAppVolumeSnapshotResource(netAppVolumeSnapshotResourceId);

            // invoke the operation
            NetAppVolumeSnapshotData data = new NetAppVolumeSnapshotData(new AzureLocation("eastus"));
            ArmOperation<NetAppVolumeSnapshotResource> lro = await netAppVolumeSnapshot.UpdateAsync(WaitUntil.Completed, data);
            NetAppVolumeSnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RestoreFiles_SnapshotsSingleFileRestore()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Snapshots_SingleFileRestore.json
            // this example is just showing the usage of "Snapshots_RestoreFiles" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeSnapshotResource created on azure
            // for more information of creating NetAppVolumeSnapshotResource, please refer to the document of NetAppVolumeSnapshotResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string snapshotName = "snapshot1";
            ResourceIdentifier netAppVolumeSnapshotResourceId = NetAppVolumeSnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, snapshotName);
            NetAppVolumeSnapshotResource netAppVolumeSnapshot = client.GetNetAppVolumeSnapshotResource(netAppVolumeSnapshotResourceId);

            // invoke the operation
            NetAppVolumeSnapshotRestoreFilesContent content = new NetAppVolumeSnapshotRestoreFilesContent(new string[] { "/dir1/customer1.db", "/dir1/customer2.db" });
            await netAppVolumeSnapshot.RestoreFilesAsync(WaitUntil.Completed, content).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
