// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DedicatedHostGroupResource_Delete_DedicatedHostGroupsDeleteMinimumSetGen
    {
        // DedicatedHostGroups_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "DedicatedHostGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaa";
            ResourceIdentifier dedicatedHostGroupResourceId = Compute.DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            Compute.DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            await dedicatedHostGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
