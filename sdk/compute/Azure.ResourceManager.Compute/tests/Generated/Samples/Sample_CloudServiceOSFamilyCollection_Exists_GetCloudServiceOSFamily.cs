// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CloudServiceOSFamilyCollection_Exists_GetCloudServiceOSFamily
    {
        // Get Cloud Service OS Family
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "CloudServiceOperatingSystems_GetOSFamily" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this CloudServiceOSFamilyResource
            AzureLocation location = new AzureLocation("westus2");
            Compute.CloudServiceOSFamilyCollection collection = subscriptionResource.GetCloudServiceOSFamilies(location);

            // invoke the operation
            string osFamilyName = "3";
            bool result = await collection.ExistsAsync(osFamilyName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
