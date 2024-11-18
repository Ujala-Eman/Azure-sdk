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
    public partial class Sample_DevOpsProjectResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsProjectResource created on azure
            // for more information of creating DevOpsProjectResource, please refer to the document of DevOpsProjectResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            string projectName = "myAzDevOpsProject";
            ResourceIdentifier devOpsProjectResourceId = DevOpsProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName);
            DevOpsProjectResource devOpsProject = client.GetDevOpsProjectResource(devOpsProjectResourceId);

            // invoke the operation
            DevOpsProjectResource result = await devOpsProject.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAzureDevOpsProjects()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/UpdateAzureDevOpsProjects_example.json
            // this example is just showing the usage of "AzureDevOpsProjects_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsProjectResource created on azure
            // for more information of creating DevOpsProjectResource, please refer to the document of DevOpsProjectResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            string projectName = "myAzDevOpsProject";
            ResourceIdentifier devOpsProjectResourceId = DevOpsProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName);
            DevOpsProjectResource devOpsProject = client.GetDevOpsProjectResource(devOpsProjectResourceId);

            // invoke the operation
            DevOpsProjectData data = new DevOpsProjectData()
            {
                Properties = new DevOpsProjectProperties()
                {
                    OnboardingState = ResourceOnboardingState.NotApplicable,
                    ActionableRemediation = new ActionableRemediation()
                    {
                        State = ActionableRemediationState.Enabled,
                    },
                },
            };
            ArmOperation<DevOpsProjectResource> lro = await devOpsProject.UpdateAsync(WaitUntil.Completed, data);
            DevOpsProjectResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsProjectData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
