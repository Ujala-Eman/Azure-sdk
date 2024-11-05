// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkVirtualApplianceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualAppliancePut.json
            // this example is just showing the usage of "NetworkVirtualAppliances_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkVirtualApplianceResource
            NetworkVirtualApplianceCollection collection = resourceGroupResource.GetNetworkVirtualAppliances();

            // invoke the operation
            string networkVirtualApplianceName = "nva";
            NetworkVirtualApplianceData data = new NetworkVirtualApplianceData
            {
                Identity = new ManagedServiceIdentity(default)
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/Microsoft.ManagedIdentity/userAssignedIdentities/identity1")] = null
},
                },
                NvaSku = new VirtualApplianceSkuProperties
                {
                    Vendor = "Cisco SDWAN",
                    BundledScaleUnit = "1",
                    MarketPlaceVersion = "12.1",
                },
                BootStrapConfigurationBlobs = { "https://csrncvhdstorage1.blob.core.windows.net/csrncvhdstoragecont/csrbootstrapconfig" },
                VirtualHubId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1"),
                CloudInitConfigurationBlobs = { "https://csrncvhdstorage1.blob.core.windows.net/csrncvhdstoragecont/csrcloudinitconfig" },
                VirtualApplianceAsn = 10000L,
                NetworkInterfaceConfigurations = {new VirtualApplianceNetworkInterfaceConfiguration
{
NicType = NicTypeInRequest.PublicNic,
VirtualApplianceNetworkInterfaceIPConfigurations = {new VirtualApplianceIPConfiguration
{
Name = "publicnicipconfig",
IsPrimary = true,
}, new VirtualApplianceIPConfiguration
{
Name = "publicnicipconfig-2",
IsPrimary = false,
}},
}, new VirtualApplianceNetworkInterfaceConfiguration
{
NicType = NicTypeInRequest.PrivateNic,
VirtualApplianceNetworkInterfaceIPConfigurations = {new VirtualApplianceIPConfiguration
{
Name = "privatenicipconfig",
IsPrimary = true,
}, new VirtualApplianceIPConfiguration
{
Name = "privatenicipconfig-2",
IsPrimary = false,
}},
}},
                AdditionalNics = {new VirtualApplianceAdditionalNicProperties
{
Name = "exrsdwan",
HasPublicIP = true,
}},
                InternetIngressPublicIPs = {new WritableSubResource
{
Id = new ResourceIdentifier("/subscriptions/{{subscriptionId}}/resourceGroups/{{rg}}/providers/Microsoft.Network/publicIPAddresses/slbip"),
}},
                Location = new AzureLocation("West US"),
                Tags =
{
["key1"] = "value1"
},
            };
            ArmOperation<NetworkVirtualApplianceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkVirtualApplianceName, data);
            NetworkVirtualApplianceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateSaaSNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceSaaSPut.json
            // this example is just showing the usage of "NetworkVirtualAppliances_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkVirtualApplianceResource
            NetworkVirtualApplianceCollection collection = resourceGroupResource.GetNetworkVirtualAppliances();

            // invoke the operation
            string networkVirtualApplianceName = "nva";
            NetworkVirtualApplianceData data = new NetworkVirtualApplianceData
            {
                VirtualHubId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualHubs/hub1"),
                Delegation = new VirtualApplianceDelegationProperties
                {
                    ServiceName = "PaloAltoNetworks.Cloudngfw/firewalls",
                },
                Location = new AzureLocation("West US"),
                Tags =
{
["key1"] = "value1"
},
            };
            ArmOperation<NetworkVirtualApplianceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkVirtualApplianceName, data);
            NetworkVirtualApplianceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceGet.json
            // this example is just showing the usage of "NetworkVirtualAppliances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkVirtualApplianceResource
            NetworkVirtualApplianceCollection collection = resourceGroupResource.GetNetworkVirtualAppliances();

            // invoke the operation
            string networkVirtualApplianceName = "nva";
            NetworkVirtualApplianceResource result = await collection.GetAsync(networkVirtualApplianceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkVirtualApplianceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllNetworkVirtualApplianceForAGivenResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceListByResourceGroup.json
            // this example is just showing the usage of "NetworkVirtualAppliances_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkVirtualApplianceResource
            NetworkVirtualApplianceCollection collection = resourceGroupResource.GetNetworkVirtualAppliances();

            // invoke the operation and iterate over the result
            await foreach (NetworkVirtualApplianceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceGet.json
            // this example is just showing the usage of "NetworkVirtualAppliances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkVirtualApplianceResource
            NetworkVirtualApplianceCollection collection = resourceGroupResource.GetNetworkVirtualAppliances();

            // invoke the operation
            string networkVirtualApplianceName = "nva";
            bool result = await collection.ExistsAsync(networkVirtualApplianceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkVirtualApplianceGet.json
            // this example is just showing the usage of "NetworkVirtualAppliances_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkVirtualApplianceResource
            NetworkVirtualApplianceCollection collection = resourceGroupResource.GetNetworkVirtualAppliances();

            // invoke the operation
            string networkVirtualApplianceName = "nva";
            NullableResponse<NetworkVirtualApplianceResource> response = await collection.GetIfExistsAsync(networkVirtualApplianceName);
            NetworkVirtualApplianceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkVirtualApplianceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
