// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Samples
{
    public partial class Sample_VMwareResourcePoolResource
    {
        // GetResourcePool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetResourcePool()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/GetResourcePool.json
            // this example is just showing the usage of "ResourcePools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareResourcePoolResource created on azure
            // for more information of creating VMwareResourcePoolResource, please refer to the document of VMwareResourcePoolResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string resourcePoolName = "HRPool";
            ResourceIdentifier vMwareResourcePoolResourceId = VMwareResourcePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourcePoolName);
            VMwareResourcePoolResource vMwareResourcePool = client.GetVMwareResourcePoolResource(vMwareResourcePoolResourceId);

            // invoke the operation
            VMwareResourcePoolResource result = await vMwareResourcePool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareResourcePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // UpdateResourcePool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateResourcePool()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/UpdateResourcePool.json
            // this example is just showing the usage of "ResourcePools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareResourcePoolResource created on azure
            // for more information of creating VMwareResourcePoolResource, please refer to the document of VMwareResourcePoolResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string resourcePoolName = "HRPool";
            ResourceIdentifier vMwareResourcePoolResourceId = VMwareResourcePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourcePoolName);
            VMwareResourcePoolResource vMwareResourcePool = client.GetVMwareResourcePoolResource(vMwareResourcePoolResourceId);

            // invoke the operation
            VMwareResourcePatchContent content = new VMwareResourcePatchContent()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            VMwareResourcePoolResource result = await vMwareResourcePool.UpdateAsync(content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareResourcePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteResourcePool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteResourcePool()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/DeleteResourcePool.json
            // this example is just showing the usage of "ResourcePools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VMwareResourcePoolResource created on azure
            // for more information of creating VMwareResourcePoolResource, please refer to the document of VMwareResourcePoolResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string resourcePoolName = "HRPool";
            ResourceIdentifier vMwareResourcePoolResourceId = VMwareResourcePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourcePoolName);
            VMwareResourcePoolResource vMwareResourcePool = client.GetVMwareResourcePoolResource(vMwareResourcePoolResourceId);

            // invoke the operation
            await vMwareResourcePool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ListResourcePools
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVMwareResourcePools_ListResourcePools()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/ListResourcePools.json
            // this example is just showing the usage of "ResourcePools_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VMwareResourcePoolResource item in subscriptionResource.GetVMwareResourcePoolsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VMwareResourcePoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
