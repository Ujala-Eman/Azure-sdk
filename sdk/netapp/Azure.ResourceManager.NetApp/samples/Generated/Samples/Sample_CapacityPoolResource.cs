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
    public partial class Sample_CapacityPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PoolsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Pools_Get.json
            // this example is just showing the usage of "Pools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // invoke the operation
            CapacityPoolResource result = await capacityPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PoolsDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Pools_Delete.json
            // this example is just showing the usage of "Pools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // invoke the operation
            await capacityPool.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PoolsUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Pools_Update.json
            // this example is just showing the usage of "Pools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // invoke the operation
            CapacityPoolPatch patch = new CapacityPoolPatch(default);
            ArmOperation<CapacityPoolResource> lro = await capacityPool.UpdateAsync(WaitUntil.Completed, patch);
            CapacityPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
