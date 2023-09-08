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
using Azure.ResourceManager.EventGrid;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_PartnerNamespaceChannelCollection
    {
        // Channels_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ChannelsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/Channels_Get.json
            // this example is just showing the usage of "Channels_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // get the collection of this PartnerNamespaceChannelResource
            PartnerNamespaceChannelCollection collection = partnerNamespace.GetPartnerNamespaceChannels();

            // invoke the operation
            string channelName = "exampleChannelName1";
            PartnerNamespaceChannelResource result = await collection.GetAsync(channelName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerNamespaceChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Channels_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ChannelsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/Channels_Get.json
            // this example is just showing the usage of "Channels_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // get the collection of this PartnerNamespaceChannelResource
            PartnerNamespaceChannelCollection collection = partnerNamespace.GetPartnerNamespaceChannels();

            // invoke the operation
            string channelName = "exampleChannelName1";
            bool result = await collection.ExistsAsync(channelName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Channels_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ChannelsCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/Channels_CreateOrUpdate.json
            // this example is just showing the usage of "Channels_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // get the collection of this PartnerNamespaceChannelResource
            PartnerNamespaceChannelCollection collection = partnerNamespace.GetPartnerNamespaceChannels();

            // invoke the operation
            string channelName = "exampleChannelName1";
            PartnerNamespaceChannelData data = new PartnerNamespaceChannelData()
            {
                ChannelType = PartnerNamespaceChannelType.PartnerTopic,
                PartnerTopicInfo = new PartnerTopicInfo()
                {
                    AzureSubscriptionId = Guid.Parse("8f6b6269-84f2-4d09-9e31-1127efcd1e40"),
                    ResourceGroupName = "examplerg2",
                    Name = "examplePartnerTopic1",
                    Source = "ContosoCorp.Accounts.User1",
                },
                MessageForActivation = "Example message to approver",
                ExpireOnIfNotActivated = DateTimeOffset.Parse("2021-10-21T22:50:25.410433Z"),
            };
            ArmOperation<PartnerNamespaceChannelResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, channelName, data);
            PartnerNamespaceChannelResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerNamespaceChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Channels_ListByPartnerNamespace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ChannelsListByPartnerNamespace()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-06-01-preview/examples/Channels_ListByPartnerNamespace.json
            // this example is just showing the usage of "Channels_ListByPartnerNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceResource created on azure
            // for more information of creating PartnerNamespaceResource, please refer to the document of PartnerNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            ResourceIdentifier partnerNamespaceResourceId = PartnerNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName);
            PartnerNamespaceResource partnerNamespace = client.GetPartnerNamespaceResource(partnerNamespaceResourceId);

            // get the collection of this PartnerNamespaceChannelResource
            PartnerNamespaceChannelCollection collection = partnerNamespace.GetPartnerNamespaceChannels();

            // invoke the operation and iterate over the result
            await foreach (PartnerNamespaceChannelResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PartnerNamespaceChannelData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
