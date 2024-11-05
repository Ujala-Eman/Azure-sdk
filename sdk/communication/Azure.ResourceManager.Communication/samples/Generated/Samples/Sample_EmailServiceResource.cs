// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Communication.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Communication.Samples
{
    public partial class Sample_EmailServiceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetEmailServiceResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/emailServices/get.json
            // this example is just showing the usage of "EmailServices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EmailServiceResource created on azure
            // for more information of creating EmailServiceResource, please refer to the document of EmailServiceResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            ResourceIdentifier emailServiceResourceId = EmailServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName);
            EmailServiceResource emailServiceResource = client.GetEmailServiceResource(emailServiceResourceId);

            // invoke the operation
            EmailServiceResource result = await emailServiceResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EmailServiceResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteEmailServiceResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/emailServices/delete.json
            // this example is just showing the usage of "EmailServices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EmailServiceResource created on azure
            // for more information of creating EmailServiceResource, please refer to the document of EmailServiceResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            ResourceIdentifier emailServiceResourceId = EmailServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName);
            EmailServiceResource emailServiceResource = client.GetEmailServiceResource(emailServiceResourceId);

            // invoke the operation
            await emailServiceResource.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateEmailServiceResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/emailServices/update.json
            // this example is just showing the usage of "EmailServices_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EmailServiceResource created on azure
            // for more information of creating EmailServiceResource, please refer to the document of EmailServiceResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            ResourceIdentifier emailServiceResourceId = EmailServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName);
            EmailServiceResource emailServiceResource = client.GetEmailServiceResource(emailServiceResourceId);

            // invoke the operation
            EmailServiceResourcePatch patch = new EmailServiceResourcePatch
            {
                Tags =
{
["newTag"] = "newVal"
},
            };
            ArmOperation<EmailServiceResource> lro = await emailServiceResource.UpdateAsync(WaitUntil.Completed, patch);
            EmailServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EmailServiceResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
