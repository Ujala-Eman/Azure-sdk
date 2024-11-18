// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_HostingEnvironmentDetectorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAppServiceEnvironmentDetectorResponses()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetHostingEnvironmentDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetHostingEnvironmentDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentDetectorResource created on azure
            // for more information of creating HostingEnvironmentDetectorResource, please refer to the document of HostingEnvironmentDetectorResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string name = "SampleAppServiceEnvironment";
            string detectorName = "runtimeavailability";
            ResourceIdentifier hostingEnvironmentDetectorResourceId = HostingEnvironmentDetectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, detectorName);
            HostingEnvironmentDetectorResource hostingEnvironmentDetector = client.GetHostingEnvironmentDetectorResource(hostingEnvironmentDetectorResourceId);

            // invoke the operation
            HostingEnvironmentDetectorResource result = await hostingEnvironmentDetector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
