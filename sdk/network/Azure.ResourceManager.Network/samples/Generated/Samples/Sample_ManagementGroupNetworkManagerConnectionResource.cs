// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ManagementGroupNetworkManagerConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerConnectionManagementGroupPut.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupNetworkManagerConnectionResource created on azure
            // for more information of creating ManagementGroupNetworkManagerConnectionResource, please refer to the document of ManagementGroupNetworkManagerConnectionResource
            string managementGroupId = "managementGroupA";
            string networkManagerConnectionName = "TestNMConnection";
            ResourceIdentifier managementGroupNetworkManagerConnectionResourceId = ManagementGroupNetworkManagerConnectionResource.CreateResourceIdentifier(managementGroupId, networkManagerConnectionName);
            ManagementGroupNetworkManagerConnectionResource managementGroupNetworkManagerConnection = client.GetManagementGroupNetworkManagerConnectionResource(managementGroupNetworkManagerConnectionResourceId);

            // invoke the operation
            NetworkManagerConnectionData data = new NetworkManagerConnectionData()
            {
                NetworkManagerId = new ResourceIdentifier("/subscriptions/subscriptionC/resourceGroup/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager"),
            };
            ArmOperation<ManagementGroupNetworkManagerConnectionResource> lro = await managementGroupNetworkManagerConnection.UpdateAsync(WaitUntil.Completed, data);
            ManagementGroupNetworkManagerConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerConnectionManagementGroupGet.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupNetworkManagerConnectionResource created on azure
            // for more information of creating ManagementGroupNetworkManagerConnectionResource, please refer to the document of ManagementGroupNetworkManagerConnectionResource
            string managementGroupId = "managementGroupA";
            string networkManagerConnectionName = "TestNMConnection";
            ResourceIdentifier managementGroupNetworkManagerConnectionResourceId = ManagementGroupNetworkManagerConnectionResource.CreateResourceIdentifier(managementGroupId, networkManagerConnectionName);
            ManagementGroupNetworkManagerConnectionResource managementGroupNetworkManagerConnection = client.GetManagementGroupNetworkManagerConnectionResource(managementGroupNetworkManagerConnectionResourceId);

            // invoke the operation
            ManagementGroupNetworkManagerConnectionResource result = await managementGroupNetworkManagerConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteManagementGroupNetworkManagerConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerConnectionManagementGroupDelete.json
            // this example is just showing the usage of "ManagementGroupNetworkManagerConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagementGroupNetworkManagerConnectionResource created on azure
            // for more information of creating ManagementGroupNetworkManagerConnectionResource, please refer to the document of ManagementGroupNetworkManagerConnectionResource
            string managementGroupId = "managementGroupA";
            string networkManagerConnectionName = "TestNMConnection";
            ResourceIdentifier managementGroupNetworkManagerConnectionResourceId = ManagementGroupNetworkManagerConnectionResource.CreateResourceIdentifier(managementGroupId, networkManagerConnectionName);
            ManagementGroupNetworkManagerConnectionResource managementGroupNetworkManagerConnection = client.GetManagementGroupNetworkManagerConnectionResource(managementGroupNetworkManagerConnectionResourceId);

            // invoke the operation
            await managementGroupNetworkManagerConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
