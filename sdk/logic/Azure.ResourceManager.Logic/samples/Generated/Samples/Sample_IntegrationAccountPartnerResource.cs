// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountPartnerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPartnerByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountPartners_Get.json
            // this example is just showing the usage of "IntegrationAccountPartners_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountPartnerResource created on azure
            // for more information of creating IntegrationAccountPartnerResource, please refer to the document of IntegrationAccountPartnerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string partnerName = "testPartner";
            ResourceIdentifier integrationAccountPartnerResourceId = IntegrationAccountPartnerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
            IntegrationAccountPartnerResource integrationAccountPartner = client.GetIntegrationAccountPartnerResource(integrationAccountPartnerResourceId);

            // invoke the operation
            IntegrationAccountPartnerResource result = await integrationAccountPartner.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountPartnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAPartner()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountPartners_Delete.json
            // this example is just showing the usage of "IntegrationAccountPartners_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountPartnerResource created on azure
            // for more information of creating IntegrationAccountPartnerResource, please refer to the document of IntegrationAccountPartnerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string partnerName = "testPartner";
            ResourceIdentifier integrationAccountPartnerResourceId = IntegrationAccountPartnerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
            IntegrationAccountPartnerResource integrationAccountPartner = client.GetIntegrationAccountPartnerResource(integrationAccountPartnerResourceId);

            // invoke the operation
            await integrationAccountPartner.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAPartner()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountPartners_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountPartners_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountPartnerResource created on azure
            // for more information of creating IntegrationAccountPartnerResource, please refer to the document of IntegrationAccountPartnerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string partnerName = "testPartner";
            ResourceIdentifier integrationAccountPartnerResourceId = IntegrationAccountPartnerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
            IntegrationAccountPartnerResource integrationAccountPartner = client.GetIntegrationAccountPartnerResource(integrationAccountPartnerResourceId);

            // invoke the operation
            IntegrationAccountPartnerData data = new IntegrationAccountPartnerData(new AzureLocation("westus"), IntegrationAccountPartnerType.B2B, new IntegrationAccountPartnerContent
            {
                B2BBusinessIdentities = { new IntegrationAccountBusinessIdentity("AA", "ZZ") },
            })
            {
                Metadata = BinaryData.FromObjectAsJson(new object()),
                Tags = { },
            };
            ArmOperation<IntegrationAccountPartnerResource> lro = await integrationAccountPartner.UpdateAsync(WaitUntil.Completed, data);
            IntegrationAccountPartnerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountPartnerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetContentCallbackUrl_GetTheContentCallbackUrl()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountPartners_ListContentCallbackUrl.json
            // this example is just showing the usage of "IntegrationAccountPartners_ListContentCallbackUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountPartnerResource created on azure
            // for more information of creating IntegrationAccountPartnerResource, please refer to the document of IntegrationAccountPartnerResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            string partnerName = "testPartner";
            ResourceIdentifier integrationAccountPartnerResourceId = IntegrationAccountPartnerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
            IntegrationAccountPartnerResource integrationAccountPartner = client.GetIntegrationAccountPartnerResource(integrationAccountPartnerResourceId);

            // invoke the operation
            ListOperationCallbackUrlParameterInfo info = new ListOperationCallbackUrlParameterInfo
            {
                NotAfter = default,
                KeyType = LogicKeyType.Primary,
            };
            LogicWorkflowTriggerCallbackUri result = await integrationAccountPartner.GetContentCallbackUrlAsync(info);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
