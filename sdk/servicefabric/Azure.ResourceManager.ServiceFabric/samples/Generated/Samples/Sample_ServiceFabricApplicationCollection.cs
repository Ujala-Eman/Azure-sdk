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
using Azure.ResourceManager.ServiceFabric;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricApplicationCollection
    {
        // Get an application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricApplicationResource result = await collection.GetAsync(applicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation
            string applicationName = "myApp";
            bool result = await collection.ExistsAsync(applicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get an application
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAnApplication()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationGetOperation_example.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation
            string applicationName = "myApp";
            NullableResponse<ServiceFabricApplicationResource> response = await collection.GetIfExistsAsync(applicationName);
            ServiceFabricApplicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricApplicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Put an application with maximum parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationWithMaximumParameters()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationPutOperation_example_max.json
            // this example is just showing the usage of "Applications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricApplicationData data = new ServiceFabricApplicationData(new AzureLocation("placeholder"))
            {
                TypeVersion = "1.0",
                Parameters =
{
["param1"] = "value1",
},
                UpgradePolicy = new ApplicationUpgradePolicy()
                {
                    UpgradeReplicaSetCheckTimeout = TimeSpan.Parse("01:00:00"),
                    ForceRestart = false,
                    RollingUpgradeMonitoringPolicy = new ArmRollingUpgradeMonitoringPolicy()
                    {
                        FailureAction = ArmUpgradeFailureAction.Rollback,
                        HealthCheckWaitDuration = TimeSpan.Parse("00:02:00"),
                        HealthCheckStableDuration = TimeSpan.Parse("00:05:00"),
                        HealthCheckRetryTimeout = TimeSpan.Parse("00:10:00"),
                        UpgradeTimeout = TimeSpan.Parse("01:00:00"),
                        UpgradeDomainTimeout = TimeSpan.Parse("1.06:00:00"),
                    },
                    ApplicationHealthPolicy = new ArmApplicationHealthPolicy()
                    {
                        ConsiderWarningAsError = true,
                        MaxPercentUnhealthyDeployedApplications = 0,
                        DefaultServiceTypeHealthPolicy = new ArmServiceTypeHealthPolicy()
                        {
                            MaxPercentUnhealthyServices = 0,
                            MaxPercentUnhealthyPartitionsPerService = 0,
                            MaxPercentUnhealthyReplicasPerPartition = 0,
                        },
                    },
                    UpgradeMode = ApplicationRollingUpgradeMode.Monitored,
                },
                MinimumNodes = 1,
                MaximumNodes = 3,
                RemoveApplicationCapacity = false,
                Metrics =
{
new ApplicationMetricDescription()
{
Name = "metric1",
MaximumCapacity = 3,
ReservationCapacity = 1,
TotalApplicationCapacity = 5,
}
},
                TypeName = "myAppType",
                Tags =
{
},
            };
            ArmOperation<ServiceFabricApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            ServiceFabricApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Put an application with minimum parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationWithMinimumParameters()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationPutOperation_example_min.json
            // this example is just showing the usage of "Applications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricApplicationData data = new ServiceFabricApplicationData(new AzureLocation("eastus"))
            {
                TypeVersion = "1.0",
                RemoveApplicationCapacity = false,
                TypeName = "myAppType",
                Tags =
{
},
            };
            ArmOperation<ServiceFabricApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            ServiceFabricApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Put an application with recreate option
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutAnApplicationWithRecreateOption()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationPutOperation_recreate_example.json
            // this example is just showing the usage of "Applications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation
            string applicationName = "myApp";
            ServiceFabricApplicationData data = new ServiceFabricApplicationData(new AzureLocation("placeholder"))
            {
                TypeVersion = "1.0",
                Parameters =
{
["param1"] = "value1",
},
                UpgradePolicy = new ApplicationUpgradePolicy()
                {
                    RecreateApplication = true,
                },
                TypeName = "myAppType",
                Tags =
{
},
            };
            ArmOperation<ServiceFabricApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            ServiceFabricApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a list of application resources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAListOfApplicationResources()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/stable/2021-06-01/examples/ApplicationListOperation_example.json
            // this example is just showing the usage of "Applications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationResource
            ServiceFabricApplicationCollection collection = serviceFabricCluster.GetServiceFabricApplications();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricApplicationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricApplicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
