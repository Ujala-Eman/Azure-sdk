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
    public partial class Sample_MaintenanceConfigurationResource
    {
        // ManagedEnvironmentMaintenanceConfigurationsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ManagedEnvironmentMaintenanceConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/ManagedEnvironment_MaintenanceConfigurations_CreateOrUpdate.json
            // this example is just showing the usage of "MaintenanceConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MaintenanceConfigurationResource created on azure
            // for more information of creating MaintenanceConfigurationResource, please refer to the document of MaintenanceConfigurationResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "rg1";
            string environmentName = "managedEnv";
            string configName = "default";
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenanceConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, configName);
            MaintenanceConfigurationResource maintenanceConfigurationResource = client.GetMaintenanceConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            MaintenanceConfigurationResourceData data = new MaintenanceConfigurationResourceData()
            {
                ScheduledEntries =
{
new ScheduledEntry(WeekDay.Sunday,12,9)
},
            };
            ArmOperation<MaintenanceConfigurationResource> lro = await maintenanceConfigurationResource.UpdateAsync(WaitUntil.Completed, data);
            MaintenanceConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MaintenanceConfigurationResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedEnvironmentMaintenanceConfigurationsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ManagedEnvironmentMaintenanceConfigurationsDelete()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/ManagedEnvironment_MaintenanceConfigurations_Delete.json
            // this example is just showing the usage of "MaintenanceConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MaintenanceConfigurationResource created on azure
            // for more information of creating MaintenanceConfigurationResource, please refer to the document of MaintenanceConfigurationResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "rg1";
            string environmentName = "managedEnv";
            string configName = "default";
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenanceConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, configName);
            MaintenanceConfigurationResource maintenanceConfigurationResource = client.GetMaintenanceConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            await maintenanceConfigurationResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ManagedEnvironmentMaintenanceConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedEnvironmentMaintenanceConfigurationsGet()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/ManagedEnvironment_MaintenanceConfigurations_Get.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MaintenanceConfigurationResource created on azure
            // for more information of creating MaintenanceConfigurationResource, please refer to the document of MaintenanceConfigurationResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "rg1";
            string environmentName = "managedEnv";
            string configName = "default";
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenanceConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, environmentName, configName);
            MaintenanceConfigurationResource maintenanceConfigurationResource = client.GetMaintenanceConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            MaintenanceConfigurationResource result = await maintenanceConfigurationResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MaintenanceConfigurationResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
