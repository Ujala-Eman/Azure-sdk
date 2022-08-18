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
    public partial class Sample_SubscriptionResourceExtensions_GetVirtualMachineImagesEdgeZone_VirtualMachineImagesEdgeZoneGetMinimumSetGen
    {
        // VirtualMachineImagesEdgeZone_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineImagesEdgeZone()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "VirtualMachineImagesEdgeZone_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("aaaaaaaaaaaaaaaaaaaaaaa");
            string edgeZone = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string publisherName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string offer = "aaaaaaaaaaa";
            string skus = "aaaaaaaaaaaaaaaaaa";
            string version = "aa";
            Compute.Models.VirtualMachineImage result = await subscriptionResource.GetVirtualMachineImagesEdgeZoneAsync(location, edgeZone, publisherName, offer, skus, version);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
