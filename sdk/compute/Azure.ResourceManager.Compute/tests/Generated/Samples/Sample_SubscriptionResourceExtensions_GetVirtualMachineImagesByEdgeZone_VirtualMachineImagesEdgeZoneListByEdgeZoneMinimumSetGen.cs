// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_SubscriptionResourceExtensions_GetVirtualMachineImagesByEdgeZone_VirtualMachineImagesEdgeZoneListByEdgeZoneMinimumSetGen
    {
        // VirtualMachineImagesEdgeZone_ListByEdgeZone_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineImagesByEdgeZone()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineImages_ListByEdgeZone" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5ece5940-d962-4dad-a98f-ca9ac0f021a5";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("WestUS");
            string edgeZone = "microsoftlosangeles1";
            await foreach (Compute.Models.VirtualMachineImageBase item in subscriptionResource.GetVirtualMachineImagesByEdgeZoneAsync(location, edgeZone))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
