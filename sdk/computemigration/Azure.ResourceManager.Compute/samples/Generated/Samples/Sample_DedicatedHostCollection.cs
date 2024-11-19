// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_DedicatedHostCollection
    {
        // DedicatedHost_ListByHostGroup_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DedicatedHostListByHostGroupMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/dedicatedHostExamples/DedicatedHost_ListByHostGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_ListByHostGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // get the collection of this DedicatedHostResource
            DedicatedHostCollection collection = dedicatedHostGroup.GetDedicatedHosts();

            // invoke the operation and iterate over the result
            await foreach (DedicatedHostResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHostData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DedicatedHost_ListByHostGroup_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DedicatedHostListByHostGroupMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/dedicatedHostExamples/DedicatedHost_ListByHostGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_ListByHostGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaa";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // get the collection of this DedicatedHostResource
            DedicatedHostCollection collection = dedicatedHostGroup.GetDedicatedHosts();

            // invoke the operation and iterate over the result
            await foreach (DedicatedHostResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHostData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a dedicated host.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADedicatedHost()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/dedicatedHostExamples/DedicatedHost_Get.json
            // this example is just showing the usage of "DedicatedHosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // get the collection of this DedicatedHostResource
            DedicatedHostCollection collection = dedicatedHostGroup.GetDedicatedHosts();

            // invoke the operation
            string hostName = "myHost";
            InstanceViewType? expand = InstanceViewType.InstanceView;
            DedicatedHostResource result = await collection.GetAsync(hostName, expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a dedicated host.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetADedicatedHost()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/dedicatedHostExamples/DedicatedHost_Get.json
            // this example is just showing the usage of "DedicatedHosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // get the collection of this DedicatedHostResource
            DedicatedHostCollection collection = dedicatedHostGroup.GetDedicatedHosts();

            // invoke the operation
            string hostName = "myHost";
            InstanceViewType? expand = InstanceViewType.InstanceView;
            bool result = await collection.ExistsAsync(hostName, expand: expand);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a dedicated host.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetADedicatedHost()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/dedicatedHostExamples/DedicatedHost_Get.json
            // this example is just showing the usage of "DedicatedHosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // get the collection of this DedicatedHostResource
            DedicatedHostCollection collection = dedicatedHostGroup.GetDedicatedHosts();

            // invoke the operation
            string hostName = "myHost";
            InstanceViewType? expand = InstanceViewType.InstanceView;
            NullableResponse<DedicatedHostResource> response = await collection.GetIfExistsAsync(hostName, expand: expand);
            DedicatedHostResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHostData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update a dedicated host .
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateADedicatedHost()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/dedicatedHostExamples/DedicatedHost_CreateOrUpdate.json
            // this example is just showing the usage of "DedicatedHosts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // get the collection of this DedicatedHostResource
            DedicatedHostCollection collection = dedicatedHostGroup.GetDedicatedHosts();

            // invoke the operation
            string hostName = "myDedicatedHost";
            DedicatedHostData data = new DedicatedHostData(new AzureLocation("westus"), new ComputeSku()
            {
                Name = "DSv3-Type1",
            })
            {
                PlatformFaultDomain = 1,
                Tags =
{
["department"] = "HR",
},
            };
            ArmOperation<DedicatedHostResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, hostName, data);
            DedicatedHostResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
