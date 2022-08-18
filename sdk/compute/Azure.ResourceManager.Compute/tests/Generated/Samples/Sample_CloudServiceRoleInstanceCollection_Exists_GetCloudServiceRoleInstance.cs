// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CloudServiceRoleInstanceCollection_Exists_GetCloudServiceRoleInstance
    {
        // Get Cloud Service Role Instance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "CloudServiceRoleInstances_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CloudServiceResource created on azure
            // for more information of creating CloudServiceResource, please refer to the document of CloudServiceResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "ConstosoRG";
            string cloudServiceName = "{cs-name}";
            ResourceIdentifier cloudServiceResourceId = Compute.CloudServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudServiceName);
            Compute.CloudServiceResource cloudService = client.GetCloudServiceResource(cloudServiceResourceId);

            // get the collection of this CloudServiceRoleInstanceResource
            Compute.CloudServiceRoleInstanceCollection collection = cloudService.GetCloudServiceRoleInstances();

            // invoke the operation
            string roleInstanceName = "{roleInstance-name}";
            bool result = await collection.ExistsAsync(roleInstanceName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
