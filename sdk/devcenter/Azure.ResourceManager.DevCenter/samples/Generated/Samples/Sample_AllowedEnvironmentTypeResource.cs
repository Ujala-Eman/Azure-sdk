// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_AllowedEnvironmentTypeResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ProjectAllowedEnvironmentTypesGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/ProjectAllowedEnvironmentTypes_Get.json
            // this example is just showing the usage of "ProjectAllowedEnvironmentTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AllowedEnvironmentTypeResource created on azure
            // for more information of creating AllowedEnvironmentTypeResource, please refer to the document of AllowedEnvironmentTypeResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "Contoso";
            string environmentTypeName = "DevTest";
            ResourceIdentifier allowedEnvironmentTypeResourceId = AllowedEnvironmentTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, environmentTypeName);
            AllowedEnvironmentTypeResource allowedEnvironmentType = client.GetAllowedEnvironmentTypeResource(allowedEnvironmentTypeResourceId);

            // invoke the operation
            AllowedEnvironmentTypeResource result = await allowedEnvironmentType.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AllowedEnvironmentTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
