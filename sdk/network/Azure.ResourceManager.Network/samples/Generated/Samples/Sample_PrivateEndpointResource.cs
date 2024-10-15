// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_PrivateEndpointResource
    {
        // Delete private endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePrivateEndpoint()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointDelete.json
            // this example is just showing the usage of "PrivateEndpoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            await privateEndpoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get private endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpoint()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointGet.json
            // this example is just showing the usage of "PrivateEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            PrivateEndpointResource result = await privateEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get private endpoint with application security groups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpointWithApplicationSecurityGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointGetWithASG.json
            // this example is just showing the usage of "PrivateEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            PrivateEndpointResource result = await privateEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get private endpoint with manual approval connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPrivateEndpointWithManualApprovalConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointGetForManualApproval.json
            // this example is just showing the usage of "PrivateEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            PrivateEndpointResource result = await privateEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create private endpoint
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePrivateEndpoint()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointCreate.json
            // this example is just showing the usage of "PrivateEndpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            PrivateEndpointData data = new PrivateEndpointData()
            {
                Subnet = new SubnetData()
                {
                    Id = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/myVnet/subnets/mySubnet"),
                },
                PrivateLinkServiceConnections =
{
new NetworkPrivateLinkServiceConnection()
{
PrivateLinkServiceId = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/privateLinkServices/testPls"),
GroupIds =
{
"groupIdFromResource"
},
RequestMessage = "Please approve my connection.",
}
},
                IPConfigurations =
{
new PrivateEndpointIPConfiguration()
{
Name = "pestaticconfig",
GroupId = "file",
MemberName = "file",
PrivateIPAddress = IPAddress.Parse("192.168.0.6"),
}
},
                CustomNetworkInterfaceName = "testPeNic",
                Location = new AzureLocation("eastus2euap"),
            };
            ArmOperation<PrivateEndpointResource> lro = await privateEndpoint.UpdateAsync(WaitUntil.Completed, data);
            PrivateEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create private endpoint with application security groups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePrivateEndpointWithApplicationSecurityGroups()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointCreateWithASG.json
            // this example is just showing the usage of "PrivateEndpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            PrivateEndpointData data = new PrivateEndpointData()
            {
                Subnet = new SubnetData()
                {
                    Id = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/myVnet/subnets/mySubnet"),
                },
                PrivateLinkServiceConnections =
{
new NetworkPrivateLinkServiceConnection()
{
PrivateLinkServiceId = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/privateLinkServices/testPls"),
GroupIds =
{
"groupIdFromResource"
},
RequestMessage = "Please approve my connection.",
}
},
                ApplicationSecurityGroups =
{
new ApplicationSecurityGroupData()
{
Id = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/provders/Microsoft.Network/applicationSecurityGroup/asg1"),
}
},
                Location = new AzureLocation("eastus2euap"),
            };
            ArmOperation<PrivateEndpointResource> lro = await privateEndpoint.UpdateAsync(WaitUntil.Completed, data);
            PrivateEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create private endpoint with manual approval connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePrivateEndpointWithManualApprovalConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointCreateForManualApproval.json
            // this example is just showing the usage of "PrivateEndpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateEndpointResource created on azure
            // for more information of creating PrivateEndpointResource, please refer to the document of PrivateEndpointResource
            string subscriptionId = "subId";
            string resourceGroupName = "rg1";
            string privateEndpointName = "testPe";
            ResourceIdentifier privateEndpointResourceId = PrivateEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateEndpointName);
            PrivateEndpointResource privateEndpoint = client.GetPrivateEndpointResource(privateEndpointResourceId);

            // invoke the operation
            PrivateEndpointData data = new PrivateEndpointData()
            {
                Subnet = new SubnetData()
                {
                    Id = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/myVnet/subnets/mySubnet"),
                },
                ManualPrivateLinkServiceConnections =
{
new NetworkPrivateLinkServiceConnection()
{
PrivateLinkServiceId = new ResourceIdentifier("/subscriptions/subId/resourceGroups/rg1/providers/Microsoft.Network/privateLinkServices/testPls"),
GroupIds =
{
"groupIdFromResource"
},
RequestMessage = "Please manually approve my connection.",
}
},
                IPConfigurations =
{
new PrivateEndpointIPConfiguration()
{
Name = "pestaticconfig",
GroupId = "file",
MemberName = "file",
PrivateIPAddress = IPAddress.Parse("192.168.0.5"),
}
},
                CustomNetworkInterfaceName = "testPeNic",
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<PrivateEndpointResource> lro = await privateEndpoint.UpdateAsync(WaitUntil.Completed, data);
            PrivateEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all private endpoints
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateEndpoints_ListAllPrivateEndpoints()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/PrivateEndpointListAll.json
            // this example is just showing the usage of "PrivateEndpoints_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (PrivateEndpointResource item in subscriptionResource.GetPrivateEndpointsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PrivateEndpointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
