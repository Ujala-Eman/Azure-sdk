// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Maps.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Maps.Samples
{
    public partial class Sample_MapsCreatorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/GetMapsCreator.json
            // this example is just showing the usage of "Creators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsCreatorResource created on azure
            // for more information of creating MapsCreatorResource, please refer to the document of MapsCreatorResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            string creatorName = "myCreator";
            ResourceIdentifier mapsCreatorResourceId = MapsCreatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, creatorName);
            MapsCreatorResource mapsCreator = client.GetMapsCreatorResource(mapsCreatorResourceId);

            // invoke the operation
            MapsCreatorResource result = await mapsCreator.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsCreatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/DeleteMapsCreator.json
            // this example is just showing the usage of "Creators_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsCreatorResource created on azure
            // for more information of creating MapsCreatorResource, please refer to the document of MapsCreatorResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            string creatorName = "myCreator";
            ResourceIdentifier mapsCreatorResourceId = MapsCreatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, creatorName);
            MapsCreatorResource mapsCreator = client.GetMapsCreatorResource(mapsCreatorResourceId);

            // invoke the operation
            await mapsCreator.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateCreatorResource()
        {
            // Generated from example definition: specification/maps/resource-manager/Microsoft.Maps/preview/2021-12-01-preview/examples/UpdateMapsCreator.json
            // this example is just showing the usage of "Creators_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MapsCreatorResource created on azure
            // for more information of creating MapsCreatorResource, please refer to the document of MapsCreatorResource
            string subscriptionId = "21a9967a-e8a9-4656-a70b-96ff1c4d05a0";
            string resourceGroupName = "myResourceGroup";
            string accountName = "myMapsAccount";
            string creatorName = "myCreator";
            ResourceIdentifier mapsCreatorResourceId = MapsCreatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, creatorName);
            MapsCreatorResource mapsCreator = client.GetMapsCreatorResource(mapsCreatorResourceId);

            // invoke the operation
            MapsCreatorPatch patch = new MapsCreatorPatch
            {
                Tags =
{
["specialTag"] = "true"
},
                StorageUnits = 10,
            };
            MapsCreatorResource result = await mapsCreator.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MapsCreatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
