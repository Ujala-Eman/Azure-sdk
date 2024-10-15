// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HardwareSecurityModules.Models;

namespace Azure.ResourceManager.HardwareSecurityModules.Samples
{
    public partial class Sample_CloudHsmClusterPrivateEndpointConnectionResource
    {
        // CloudHsmClusterPrivateEndpointConnection_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CloudHsmClusterPrivateEndpointConnectionCreateMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/CloudHsmClusterPrivateEndpointConnection_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusterPrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterPrivateEndpointConnectionResource created on azure
            // for more information of creating CloudHsmClusterPrivateEndpointConnectionResource, please refer to the document of CloudHsmClusterPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            string peConnectionName = "sample-pec";
            ResourceIdentifier cloudHsmClusterPrivateEndpointConnectionResourceId = CloudHsmClusterPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            CloudHsmClusterPrivateEndpointConnectionResource cloudHsmClusterPrivateEndpointConnection = client.GetCloudHsmClusterPrivateEndpointConnectionResource(cloudHsmClusterPrivateEndpointConnectionResourceId);

            // invoke the operation
            CloudHsmClusterPrivateEndpointConnectionData data = new CloudHsmClusterPrivateEndpointConnectionData()
            {
                Properties = new CloudHsmClusterPrivateEndpointConnectionProperties(new CloudHsmClusterPrivateLinkServiceConnectionState()
                {
                    Status = CloudHsmClusterPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "My name is Joe and I'm approving this.",
                }),
            };
            ArmOperation<CloudHsmClusterPrivateEndpointConnectionResource> lro = await cloudHsmClusterPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            CloudHsmClusterPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudHsmClusterPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CloudHsmClusterPrivateEndpointConnection_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CloudHsmClusterPrivateEndpointConnectionDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/CloudHsmClusterPrivateEndpointConnection_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusterPrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterPrivateEndpointConnectionResource created on azure
            // for more information of creating CloudHsmClusterPrivateEndpointConnectionResource, please refer to the document of CloudHsmClusterPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            string peConnectionName = "sample-pec";
            ResourceIdentifier cloudHsmClusterPrivateEndpointConnectionResourceId = CloudHsmClusterPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            CloudHsmClusterPrivateEndpointConnectionResource cloudHsmClusterPrivateEndpointConnection = client.GetCloudHsmClusterPrivateEndpointConnectionResource(cloudHsmClusterPrivateEndpointConnectionResourceId);

            // invoke the operation
            await cloudHsmClusterPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CloudHsmClusterPrivateEndpointConnection_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CloudHsmClusterPrivateEndpointConnectionGetMaximumSetGen()
        {
            // Generated from example definition: specification/hardwaresecuritymodules/resource-manager/Microsoft.HardwareSecurityModules/preview/2024-06-30-preview/examples/CloudHsmClusterPrivateEndpointConnection_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "CloudHsmClusterPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudHsmClusterPrivateEndpointConnectionResource created on azure
            // for more information of creating CloudHsmClusterPrivateEndpointConnectionResource, please refer to the document of CloudHsmClusterPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rgcloudhsm";
            string cloudHsmClusterName = "chsm1";
            string peConnectionName = "sample-pec";
            ResourceIdentifier cloudHsmClusterPrivateEndpointConnectionResourceId = CloudHsmClusterPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudHsmClusterName, peConnectionName);
            CloudHsmClusterPrivateEndpointConnectionResource cloudHsmClusterPrivateEndpointConnection = client.GetCloudHsmClusterPrivateEndpointConnectionResource(cloudHsmClusterPrivateEndpointConnectionResourceId);

            // invoke the operation
            CloudHsmClusterPrivateEndpointConnectionResource result = await cloudHsmClusterPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudHsmClusterPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
