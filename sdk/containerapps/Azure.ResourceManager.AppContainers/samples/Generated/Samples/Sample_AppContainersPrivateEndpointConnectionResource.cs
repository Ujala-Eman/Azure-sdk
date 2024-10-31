// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_AppContainersPrivateEndpointConnectionResource
    {
        // Get a Private Endpoint Connection by Managed Environment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPrivateEndpointConnectionByManagedEnvironment()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/ManagedEnvironmentPrivateEndpointConnections_Get.json
            // this example is just showing the usage of "ManagedEnvironmentPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppContainersPrivateEndpointConnectionResource created on azure
            // for more information of creating AppContainersPrivateEndpointConnectionResource, please refer to the document of AppContainersPrivateEndpointConnectionResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            string privateEndpointConnectionName = "jlaw-demo1";
            ResourceIdentifier appContainersPrivateEndpointConnectionResourceId = AppContainersPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, privateEndpointConnectionName);
            AppContainersPrivateEndpointConnectionResource appContainersPrivateEndpointConnection = client.GetAppContainersPrivateEndpointConnectionResource(appContainersPrivateEndpointConnectionResourceId);

            // invoke the operation
            AppContainersPrivateEndpointConnectionResource result = await appContainersPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppContainersPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a Private Endpoint Connection by Managed Environment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAPrivateEndpointConnectionByManagedEnvironment()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/ManagedEnvironmentPrivateEndpointConnections_CreateOrUpdate.json
            // this example is just showing the usage of "ManagedEnvironmentPrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppContainersPrivateEndpointConnectionResource created on azure
            // for more information of creating AppContainersPrivateEndpointConnectionResource, please refer to the document of AppContainersPrivateEndpointConnectionResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            string privateEndpointConnectionName = "jlaw-demo1";
            ResourceIdentifier appContainersPrivateEndpointConnectionResourceId = AppContainersPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, privateEndpointConnectionName);
            AppContainersPrivateEndpointConnectionResource appContainersPrivateEndpointConnection = client.GetAppContainersPrivateEndpointConnectionResource(appContainersPrivateEndpointConnectionResourceId);

            // invoke the operation
            AppContainersPrivateEndpointConnectionData data = new AppContainersPrivateEndpointConnectionData()
            {
                ConnectionState = new AppContainersPrivateLinkServiceConnectionState()
                {
                    Status = AppContainersPrivateEndpointServiceConnectionStatus.Approved,
                    ActionsRequired = "None",
                },
            };
            ArmOperation<AppContainersPrivateEndpointConnectionResource> lro = await appContainersPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            AppContainersPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppContainersPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a Private Endpoint Connection by Managed Environment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAPrivateEndpointConnectionByManagedEnvironment()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/ManagedEnvironmentPrivateEndpointConnections_Delete.json
            // this example is just showing the usage of "ManagedEnvironmentPrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppContainersPrivateEndpointConnectionResource created on azure
            // for more information of creating AppContainersPrivateEndpointConnectionResource, please refer to the document of AppContainersPrivateEndpointConnectionResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string environmentName = "managedEnv";
            string privateEndpointConnectionName = "jlaw-demo1";
            ResourceIdentifier appContainersPrivateEndpointConnectionResourceId = AppContainersPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, privateEndpointConnectionName);
            AppContainersPrivateEndpointConnectionResource appContainersPrivateEndpointConnection = client.GetAppContainersPrivateEndpointConnectionResource(appContainersPrivateEndpointConnectionResourceId);

            // invoke the operation
            await appContainersPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
