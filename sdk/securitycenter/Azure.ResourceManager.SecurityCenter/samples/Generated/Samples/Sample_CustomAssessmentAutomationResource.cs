// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_CustomAssessmentAutomationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACustomAssessmentAutomation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomAssessmentAutomations/customAssessmentAutomationGet_example.json
            // this example is just showing the usage of "CustomAssessmentAutomations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CustomAssessmentAutomationResource created on azure
            // for more information of creating CustomAssessmentAutomationResource, please refer to the document of CustomAssessmentAutomationResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            string customAssessmentAutomationName = "MyCustomAssessmentAutomation";
            ResourceIdentifier customAssessmentAutomationResourceId = CustomAssessmentAutomationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, customAssessmentAutomationName);
            CustomAssessmentAutomationResource customAssessmentAutomation = client.GetCustomAssessmentAutomationResource(customAssessmentAutomationResourceId);

            // invoke the operation
            CustomAssessmentAutomationResource result = await customAssessmentAutomation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomAssessmentAutomationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteACustomAssessmentAutomation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomAssessmentAutomations/customAssessmentAutomationDelete_example.json
            // this example is just showing the usage of "CustomAssessmentAutomations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CustomAssessmentAutomationResource created on azure
            // for more information of creating CustomAssessmentAutomationResource, please refer to the document of CustomAssessmentAutomationResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            string customAssessmentAutomationName = "MyCustomAssessmentAutomation";
            ResourceIdentifier customAssessmentAutomationResourceId = CustomAssessmentAutomationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, customAssessmentAutomationName);
            CustomAssessmentAutomationResource customAssessmentAutomation = client.GetCustomAssessmentAutomationResource(customAssessmentAutomationResourceId);

            // invoke the operation
            await customAssessmentAutomation.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateACustomAssessmentAutomation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2021-07-01-preview/examples/CustomAssessmentAutomations/customAssessmentAutomationCreate_example.json
            // this example is just showing the usage of "CustomAssessmentAutomations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CustomAssessmentAutomationResource created on azure
            // for more information of creating CustomAssessmentAutomationResource, please refer to the document of CustomAssessmentAutomationResource
            string subscriptionId = "e5d1b86c-3051-44d5-8802-aa65d45a279b";
            string resourceGroupName = "TestResourceGroup";
            string customAssessmentAutomationName = "MyCustomAssessmentAutomation";
            ResourceIdentifier customAssessmentAutomationResourceId = CustomAssessmentAutomationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, customAssessmentAutomationName);
            CustomAssessmentAutomationResource customAssessmentAutomation = client.GetCustomAssessmentAutomationResource(customAssessmentAutomationResourceId);

            // invoke the operation
            CustomAssessmentAutomationCreateOrUpdateContent content = new CustomAssessmentAutomationCreateOrUpdateContent
            {
                CompressedQuery = "DQAKAEkAYQBtAF8ARwByAG8AdQBwAA0ACgB8ACAAZQB4AHQAZQBuAGQAIABIAGUAYQBsAHQAaABTAHQAYQB0AHUAcwAgAD0AIABpAGYAZgAoAHQAbwBzAHQAcgBpAG4AZwAoAFIAZQBjAG8AcgBkAC4AVQBzAGUAcgBOAGEAbQBlACkAIABjAG8AbgB0AGEAaQBuAHMAIAAnAHUAcwBlAHIAJwAsACAAJwBVAE4ASABFAEEATABUAEgAWQAnACwAIAAnAEgARQBBAEwAVABIAFkAJwApAA0ACgA=",
                SupportedCloud = CustomAssessmentAutomationSupportedCloud.Aws,
                Severity = CustomAssessmentSeverity.Medium,
                DisplayName = "Password Policy",
                Description = "Data should be encrypted",
                RemediationDescription = "Encrypt store by...",
            };
            ArmOperation<CustomAssessmentAutomationResource> lro = await customAssessmentAutomation.UpdateAsync(WaitUntil.Completed, content);
            CustomAssessmentAutomationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomAssessmentAutomationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
