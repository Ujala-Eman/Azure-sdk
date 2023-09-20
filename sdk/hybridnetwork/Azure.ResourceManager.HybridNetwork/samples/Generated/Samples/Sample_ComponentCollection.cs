// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_ComponentCollection
    {
        // Get component resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetComponentResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ComponentGet.json
            // this example is just showing the usage of "components_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // get the collection of this ComponentResource
            ComponentCollection collection = networkFunction.GetComponents();

            // invoke the operation
            string componentName = "testComponent";
            ComponentResource result = await collection.GetAsync(componentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get component resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetComponentResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ComponentGet.json
            // this example is just showing the usage of "components_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // get the collection of this ComponentResource
            ComponentCollection collection = networkFunction.GetComponents();

            // invoke the operation
            string componentName = "testComponent";
            bool result = await collection.ExistsAsync(componentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List components in network function
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListComponentsInNetworkFunction()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ComponentListByNetworkFunction.json
            // this example is just showing the usage of "Components_ListByNetworkFunction" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // get the collection of this ComponentResource
            ComponentCollection collection = networkFunction.GetComponents();

            // invoke the operation and iterate over the result
            await foreach (ComponentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ComponentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
