// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CommitmentPlanAccountAssociationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCommitmentPlans()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/ListSharedCommitmentPlanAssociations.json
            // this example is just showing the usage of "CommitmentPlans_ListAssociations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesCommitmentPlanResource created on azure
            // for more information of creating CognitiveServicesCommitmentPlanResource, please refer to the document of CognitiveServicesCommitmentPlanResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            ResourceIdentifier cognitiveServicesCommitmentPlanResourceId = CognitiveServicesCommitmentPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName);
            CognitiveServicesCommitmentPlanResource cognitiveServicesCommitmentPlan = client.GetCognitiveServicesCommitmentPlanResource(cognitiveServicesCommitmentPlanResourceId);

            // get the collection of this CommitmentPlanAccountAssociationResource
            CommitmentPlanAccountAssociationCollection collection = cognitiveServicesCommitmentPlan.GetCommitmentPlanAccountAssociations();

            // invoke the operation and iterate over the result
            await foreach (CommitmentPlanAccountAssociationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CommitmentPlanAccountAssociationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/GetSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_GetAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesCommitmentPlanResource created on azure
            // for more information of creating CognitiveServicesCommitmentPlanResource, please refer to the document of CognitiveServicesCommitmentPlanResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            ResourceIdentifier cognitiveServicesCommitmentPlanResourceId = CognitiveServicesCommitmentPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName);
            CognitiveServicesCommitmentPlanResource cognitiveServicesCommitmentPlan = client.GetCognitiveServicesCommitmentPlanResource(cognitiveServicesCommitmentPlanResourceId);

            // get the collection of this CommitmentPlanAccountAssociationResource
            CommitmentPlanAccountAssociationCollection collection = cognitiveServicesCommitmentPlan.GetCommitmentPlanAccountAssociations();

            // invoke the operation
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            CommitmentPlanAccountAssociationResource result = await collection.GetAsync(commitmentPlanAssociationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommitmentPlanAccountAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/GetSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_GetAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesCommitmentPlanResource created on azure
            // for more information of creating CognitiveServicesCommitmentPlanResource, please refer to the document of CognitiveServicesCommitmentPlanResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            ResourceIdentifier cognitiveServicesCommitmentPlanResourceId = CognitiveServicesCommitmentPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName);
            CognitiveServicesCommitmentPlanResource cognitiveServicesCommitmentPlan = client.GetCognitiveServicesCommitmentPlanResource(cognitiveServicesCommitmentPlanResourceId);

            // get the collection of this CommitmentPlanAccountAssociationResource
            CommitmentPlanAccountAssociationCollection collection = cognitiveServicesCommitmentPlan.GetCommitmentPlanAccountAssociations();

            // invoke the operation
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            bool result = await collection.ExistsAsync(commitmentPlanAssociationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/GetSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_GetAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesCommitmentPlanResource created on azure
            // for more information of creating CognitiveServicesCommitmentPlanResource, please refer to the document of CognitiveServicesCommitmentPlanResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            ResourceIdentifier cognitiveServicesCommitmentPlanResourceId = CognitiveServicesCommitmentPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName);
            CognitiveServicesCommitmentPlanResource cognitiveServicesCommitmentPlan = client.GetCognitiveServicesCommitmentPlanResource(cognitiveServicesCommitmentPlanResourceId);

            // get the collection of this CommitmentPlanAccountAssociationResource
            CommitmentPlanAccountAssociationCollection collection = cognitiveServicesCommitmentPlan.GetCommitmentPlanAccountAssociations();

            // invoke the operation
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            NullableResponse<CommitmentPlanAccountAssociationResource> response = await collection.GetIfExistsAsync(commitmentPlanAssociationName);
            CommitmentPlanAccountAssociationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CommitmentPlanAccountAssociationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/CreateSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_CreateOrUpdateAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesCommitmentPlanResource created on azure
            // for more information of creating CognitiveServicesCommitmentPlanResource, please refer to the document of CognitiveServicesCommitmentPlanResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            ResourceIdentifier cognitiveServicesCommitmentPlanResourceId = CognitiveServicesCommitmentPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName);
            CognitiveServicesCommitmentPlanResource cognitiveServicesCommitmentPlan = client.GetCognitiveServicesCommitmentPlanResource(cognitiveServicesCommitmentPlanResourceId);

            // get the collection of this CommitmentPlanAccountAssociationResource
            CommitmentPlanAccountAssociationCollection collection = cognitiveServicesCommitmentPlan.GetCommitmentPlanAccountAssociations();

            // invoke the operation
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            CommitmentPlanAccountAssociationData data = new CommitmentPlanAccountAssociationData()
            {
                AccountId = "/subscriptions/subscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.CognitiveServices/accounts/accountName",
            };
            ArmOperation<CommitmentPlanAccountAssociationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, commitmentPlanAssociationName, data);
            CommitmentPlanAccountAssociationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommitmentPlanAccountAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
