// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaAssetFilterResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnAssetFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/assetFilters-get-by-name.json
            // this example is just showing the usage of "AssetFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetFilterResource created on azure
            // for more information of creating MediaAssetFilterResource, please refer to the document of MediaAssetFilterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            string filterName = "assetFilterWithTimeWindowAndTrack";
            ResourceIdentifier mediaAssetFilterResourceId = MediaAssetFilterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            MediaAssetFilterResource mediaAssetFilter = client.GetMediaAssetFilterResource(mediaAssetFilterResourceId);

            // invoke the operation
            MediaAssetFilterResource result = await mediaAssetFilter.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaAssetFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnAssetFilter()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/assetFilters-delete.json
            // this example is just showing the usage of "AssetFilters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetFilterResource created on azure
            // for more information of creating MediaAssetFilterResource, please refer to the document of MediaAssetFilterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            string filterName = "assetFilterWithTimeWindowAndTrack";
            ResourceIdentifier mediaAssetFilterResourceId = MediaAssetFilterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            MediaAssetFilterResource mediaAssetFilter = client.GetMediaAssetFilterResource(mediaAssetFilterResourceId);

            // invoke the operation
            await mediaAssetFilter.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAnAssetFilter()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/assetFilters-update.json
            // this example is just showing the usage of "AssetFilters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetFilterResource created on azure
            // for more information of creating MediaAssetFilterResource, please refer to the document of MediaAssetFilterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            string filterName = "assetFilterWithTimeWindowAndTrack";
            ResourceIdentifier mediaAssetFilterResourceId = MediaAssetFilterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName, filterName);
            MediaAssetFilterResource mediaAssetFilter = client.GetMediaAssetFilterResource(mediaAssetFilterResourceId);

            // invoke the operation
            MediaAssetFilterData data = new MediaAssetFilterData
            {
                PresentationTimeRange = new PresentationTimeRange
                {
                    StartTimestamp = 10L,
                    EndTimestamp = 170000000L,
                    PresentationWindowDuration = 9223372036854775000L,
                    LiveBackoffDuration = 0L,
                    Timescale = 10000000L,
                    ForceEndTimestamp = false,
                },
                FirstQualityBitrate = 128000,
            };
            MediaAssetFilterResource result = await mediaAssetFilter.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaAssetFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
