// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SupportTicketNoSubChatTranscriptResource
    {
        // Get chat transcript details for a subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetChatTranscriptDetailsForASubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/GetchatTranscriptDetailsForSupportTicket.json
            // this example is just showing the usage of "ChatTranscriptsNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketNoSubChatTranscriptResource created on azure
            // for more information of creating SupportTicketNoSubChatTranscriptResource, please refer to the document of SupportTicketNoSubChatTranscriptResource
            string supportTicketName = "testticket";
            string chatTranscriptName = "b371192a-b094-4a71-b093-7246029b0a54";
            ResourceIdentifier supportTicketNoSubChatTranscriptResourceId = SupportTicketNoSubChatTranscriptResource.CreateResourceIdentifier(supportTicketName, chatTranscriptName);
            SupportTicketNoSubChatTranscriptResource supportTicketNoSubChatTranscript = client.GetSupportTicketNoSubChatTranscriptResource(supportTicketNoSubChatTranscriptResourceId);

            // invoke the operation
            SupportTicketNoSubChatTranscriptResource result = await supportTicketNoSubChatTranscript.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChatTranscriptDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
