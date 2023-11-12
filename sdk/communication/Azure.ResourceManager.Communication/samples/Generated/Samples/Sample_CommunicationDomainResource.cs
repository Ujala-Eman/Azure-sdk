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
using Azure.ResourceManager.Communication;
using Azure.ResourceManager.Communication.Models;

namespace Azure.ResourceManager.Communication.Samples
{
    public partial class Sample_CommunicationDomainResource
    {
        // Get Domains resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDomainsResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/preview/2023-06-01-preview/examples/domains/get.json
            // this example is just showing the usage of "Domains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommunicationDomainResource created on azure
            // for more information of creating CommunicationDomainResource, please refer to the document of CommunicationDomainResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            string domainName = "mydomain.com";
            ResourceIdentifier communicationDomainResourceId = CommunicationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName);
            CommunicationDomainResource communicationDomainResource = client.GetCommunicationDomainResource(communicationDomainResourceId);

            // invoke the operation
            CommunicationDomainResource result = await communicationDomainResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommunicationDomainResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Domains resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDomainsResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/preview/2023-06-01-preview/examples/domains/delete.json
            // this example is just showing the usage of "Domains_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommunicationDomainResource created on azure
            // for more information of creating CommunicationDomainResource, please refer to the document of CommunicationDomainResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            string domainName = "mydomain.com";
            ResourceIdentifier communicationDomainResourceId = CommunicationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName);
            CommunicationDomainResource communicationDomainResource = client.GetCommunicationDomainResource(communicationDomainResourceId);

            // invoke the operation
            await communicationDomainResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update Domains resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateDomainsResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/preview/2023-06-01-preview/examples/domains/update.json
            // this example is just showing the usage of "Domains_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommunicationDomainResource created on azure
            // for more information of creating CommunicationDomainResource, please refer to the document of CommunicationDomainResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            string domainName = "mydomain.com";
            ResourceIdentifier communicationDomainResourceId = CommunicationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName);
            CommunicationDomainResource communicationDomainResource = client.GetCommunicationDomainResource(communicationDomainResourceId);

            // invoke the operation
            CommunicationDomainResourcePatch patch = new CommunicationDomainResourcePatch()
            {
                UserEngagementTracking = UserEngagementTracking.Enabled,
            };
            ArmOperation<CommunicationDomainResource> lro = await communicationDomainResource.UpdateAsync(WaitUntil.Completed, patch);
            CommunicationDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommunicationDomainResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Initiate verification
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task InitiateVerification_InitiateVerification()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/preview/2023-06-01-preview/examples/domains/initiateVerification.json
            // this example is just showing the usage of "Domains_InitiateVerification" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommunicationDomainResource created on azure
            // for more information of creating CommunicationDomainResource, please refer to the document of CommunicationDomainResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            string domainName = "mydomain.com";
            ResourceIdentifier communicationDomainResourceId = CommunicationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName);
            CommunicationDomainResource communicationDomainResource = client.GetCommunicationDomainResource(communicationDomainResourceId);

            // invoke the operation
            DomainsRecordVerificationContent content = new DomainsRecordVerificationContent(DomainRecordVerificationType.Spf);
            await communicationDomainResource.InitiateVerificationAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // Cancel verification
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CancelVerification_CancelVerification()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/preview/2023-06-01-preview/examples/domains/cancelVerification.json
            // this example is just showing the usage of "Domains_CancelVerification" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommunicationDomainResource created on azure
            // for more information of creating CommunicationDomainResource, please refer to the document of CommunicationDomainResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            string domainName = "mydomain.com";
            ResourceIdentifier communicationDomainResourceId = CommunicationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName);
            CommunicationDomainResource communicationDomainResource = client.GetCommunicationDomainResource(communicationDomainResourceId);

            // invoke the operation
            DomainsRecordVerificationContent content = new DomainsRecordVerificationContent(DomainRecordVerificationType.Spf);
            await communicationDomainResource.CancelVerificationAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
