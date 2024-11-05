// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_StreamingEndpointCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAStreamingEndpoint()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/streamingendpoint-create.json
            // this example is just showing the usage of "StreamingEndpoints_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingEndpointResource
            StreamingEndpointCollection collection = mediaServicesAccount.GetStreamingEndpoints();

            // invoke the operation
            string streamingEndpointName = "myStreamingEndpoint1";
            StreamingEndpointData data = new StreamingEndpointData(new AzureLocation("West US"))
            {
                Description = "test event 1",
                ScaleUnits = 1,
                AvailabilitySetName = "availableset",
                AccessControl = new StreamingEndpointAccessControl
                {
                    AkamaiSignatureHeaderAuthenticationKeyList = {new AkamaiSignatureHeaderAuthenticationKey
{
Identifier = "id1",
Base64Key = "dGVzdGlkMQ==",
ExpireOn = default,
}, new AkamaiSignatureHeaderAuthenticationKey
{
Identifier = "id2",
Base64Key = "dGVzdGlkMQ==",
ExpireOn = default,
}},
                    AllowedIPs = {new IPRange
{
Name = "AllowedIp",
Address = IPAddress.Parse("192.168.1.1"),
}},
                },
                IsCdnEnabled = false,
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ArmOperation<StreamingEndpointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, streamingEndpointName, data);
            StreamingEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAStreamingEndpointByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/streamingendpoint-list-by-name.json
            // this example is just showing the usage of "StreamingEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingEndpointResource
            StreamingEndpointCollection collection = mediaServicesAccount.GetStreamingEndpoints();

            // invoke the operation
            string streamingEndpointName = "myStreamingEndpoint1";
            StreamingEndpointResource result = await collection.GetAsync(streamingEndpointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllStreamingEndpoints()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/streamingendpoint-list-all.json
            // this example is just showing the usage of "StreamingEndpoints_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingEndpointResource
            StreamingEndpointCollection collection = mediaServicesAccount.GetStreamingEndpoints();

            // invoke the operation and iterate over the result
            await foreach (StreamingEndpointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingEndpointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAStreamingEndpointByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/streamingendpoint-list-by-name.json
            // this example is just showing the usage of "StreamingEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingEndpointResource
            StreamingEndpointCollection collection = mediaServicesAccount.GetStreamingEndpoints();

            // invoke the operation
            string streamingEndpointName = "myStreamingEndpoint1";
            bool result = await collection.ExistsAsync(streamingEndpointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAStreamingEndpointByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/streamingendpoint-list-by-name.json
            // this example is just showing the usage of "StreamingEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this StreamingEndpointResource
            StreamingEndpointCollection collection = mediaServicesAccount.GetStreamingEndpoints();

            // invoke the operation
            string streamingEndpointName = "myStreamingEndpoint1";
            NullableResponse<StreamingEndpointResource> response = await collection.GetIfExistsAsync(streamingEndpointName);
            StreamingEndpointResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingEndpointData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
