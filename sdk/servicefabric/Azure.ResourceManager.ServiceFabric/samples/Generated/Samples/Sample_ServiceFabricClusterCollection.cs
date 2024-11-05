// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabric.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricClusterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAClusterWithMaximumParameters()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterPutOperation_example_max.json
            // this example is just showing the usage of "Clusters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricClusterResource
            ServiceFabricClusterCollection collection = resourceGroupResource.GetServiceFabricClusters();

            // invoke the operation
            string clusterName = "myCluster";
            ServiceFabricClusterData data = new ServiceFabricClusterData(new AzureLocation("eastus"))
            {
                AddOnFeatures = { ClusterAddOnFeature.RepairManager, ClusterAddOnFeature.DnsService, ClusterAddOnFeature.BackupRestoreService, ClusterAddOnFeature.ResourceMonitorService },
                AzureActiveDirectory = new ClusterAadSetting
                {
                    TenantId = Guid.Parse("6abcc6a0-8666-43f1-87b8-172cf86a9f9c"),
                    ClusterApplication = "5886372e-7bf4-4878-a497-8098aba608ae",
                    ClientApplication = "d151ad89-4bce-4ae8-b3d1-1dc79679fa75",
                },
                CertificateCommonNames = new ClusterServerCertificateCommonNames
                {
                    CommonNames = { new ClusterServerCertificateCommonName("abc.com", BinaryData.FromObjectAsJson("12599211F8F14C90AFA9532AD79A6F2CA1C00622")) },
                    X509StoreName = ClusterCertificateStoreName.My,
                },
                ClientCertificateCommonNames = { new ClusterClientCertificateCommonName(true, "abc.com", BinaryData.FromObjectAsJson("5F3660C715EBBDA31DB1FFDCF508302348DE8E7A")) },
                ClientCertificateThumbprints = { new ClusterClientCertificateThumbprint(true, BinaryData.FromObjectAsJson("5F3660C715EBBDA31DB1FFDCF508302348DE8E7A")) },
                ClusterCodeVersion = "7.0.470.9590",
                DiagnosticsStorageAccountConfig = new DiagnosticsStorageAccountConfig("diag", "StorageAccountKey1", new Uri("https://diag.blob.core.windows.net/"), new Uri("https://diag.queue.core.windows.net/"), new Uri("https://diag.table.core.windows.net/")),
                IsEventStoreServiceEnabled = true,
                FabricSettings = {new SettingsSectionDescription("UpgradeService", new SettingsParameterDescription[]
{
new SettingsParameterDescription("AppPollIntervalInSeconds", "60")
})},
                ManagementEndpoint = new Uri("https://myCluster.eastus.cloudapp.azure.com:19080"),
                NodeTypes = {new ClusterNodeTypeDescription("nt1vm", 19000, 19007, true, 5)
{
DurabilityLevel = ClusterDurabilityLevel.Silver,
ApplicationPorts = new ClusterEndpointRangeDescription(20000, 30000),
EphemeralPorts = new ClusterEndpointRangeDescription(49000, 64000),
IsStateless = false,
IsMultipleAvailabilityZonesSupported = true,
HttpGatewayTokenAuthEndpointPort = 19081,
}},
                ReliabilityLevel = ClusterReliabilityLevel.Platinum,
                ReverseProxyCertificateCommonNames = new ClusterServerCertificateCommonNames
                {
                    CommonNames = { new ClusterServerCertificateCommonName("abc.com", BinaryData.FromObjectAsJson("12599211F8F14C90AFA9532AD79A6F2CA1C00622")) },
                    X509StoreName = ClusterCertificateStoreName.My,
                },
                UpgradeDescription = new ClusterUpgradePolicy(
                default,
                default,
                default,
                default,
                default,
                default,
                new ClusterHealthPolicy
                {
                    MaxPercentUnhealthyNodes = 0,
                    MaxPercentUnhealthyApplications = 0,
                    ApplicationHealthPolicies =
            {
["fabric:/myApp1"] = new ApplicationHealthPolicy
{
MaxPercentUnhealthyServices = 0,
ServiceTypeHealthPolicies =
{
["myServiceType1"] = new ServiceTypeHealthPolicy
{
MaxPercentUnhealthyServices = 100,
}
},
}
            },
                })
                {
                    ForceRestart = false,
                    DeltaHealthPolicy = new ClusterUpgradeDeltaHealthPolicy(0, 0, 0)
                    {
                        ApplicationDeltaHealthPolicies =
{
["fabric:/myApp1"] = new ApplicationDeltaHealthPolicy
{
MaxPercentDeltaUnhealthyServices = 0,
ServiceTypeDeltaHealthPolicies =
{
["myServiceType1"] = new ServiceTypeDeltaHealthPolicy
{
MaxPercentDeltaUnhealthyServices = 0,
}
},
}
},
                    },
                },
                UpgradeMode = ClusterUpgradeMode.Manual,
                MaxUnusedVersionsToKeep = 2L,
                VmImage = "Windows",
                ServiceFabricZonalUpgradeMode = SfZonalUpgradeMode.Hierarchical,
                VmssZonalUpgradeMode = VmssZonalUpgradeMode.Parallel,
                IsInfrastructureServiceManagerEnabled = true,
                UpgradeWave = ClusterUpgradeCadence.Wave1,
                UpgradePauseStartOn = default,
                UpgradePauseEndOn = default,
                Notifications = {new ClusterNotification(true, ClusterNotificationCategory.WaveProgress, ClusterNotificationLevel.Critical, new ClusterNotificationTarget[]
{
new ClusterNotificationTarget(ClusterNotificationChannel.EmailUser, new string[]{"****@microsoft.com", "****@microsoft.com"}),
new ClusterNotificationTarget(ClusterNotificationChannel.EmailSubscription, new string[]{"Owner", "AccountAdmin"})
}), new ClusterNotification(true, ClusterNotificationCategory.WaveProgress, ClusterNotificationLevel.All, new ClusterNotificationTarget[]
{
new ClusterNotificationTarget(ClusterNotificationChannel.EmailUser, new string[]{"****@microsoft.com", "****@microsoft.com"}),
new ClusterNotificationTarget(ClusterNotificationChannel.EmailSubscription, new string[]{"Owner", "AccountAdmin"})
})},
                IsHttpGatewayExclusiveAuthModeEnabled = true,
                Tags = { },
            };
            ArmOperation<ServiceFabricClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            ServiceFabricClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAClusterWithMinimumParameters()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterPutOperation_example_min.json
            // this example is just showing the usage of "Clusters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricClusterResource
            ServiceFabricClusterCollection collection = resourceGroupResource.GetServiceFabricClusters();

            // invoke the operation
            string clusterName = "myCluster";
            ServiceFabricClusterData data = new ServiceFabricClusterData(new AzureLocation("eastus"))
            {
                DiagnosticsStorageAccountConfig = new DiagnosticsStorageAccountConfig("diag", "StorageAccountKey1", new Uri("https://diag.blob.core.windows.net/"), new Uri("https://diag.queue.core.windows.net/"), new Uri("https://diag.table.core.windows.net/")),
                FabricSettings = {new SettingsSectionDescription("UpgradeService", new SettingsParameterDescription[]
{
new SettingsParameterDescription("AppPollIntervalInSeconds", "60")
})},
                ManagementEndpoint = new Uri("http://myCluster.eastus.cloudapp.azure.com:19080"),
                NodeTypes = {new ClusterNodeTypeDescription("nt1vm", 19000, 19007, true, 5)
{
DurabilityLevel = ClusterDurabilityLevel.Bronze,
ApplicationPorts = new ClusterEndpointRangeDescription(20000, 30000),
EphemeralPorts = new ClusterEndpointRangeDescription(49000, 64000),
}},
                ReliabilityLevel = ClusterReliabilityLevel.Silver,
                UpgradeMode = ClusterUpgradeMode.Automatic,
                Tags = { },
            };
            ArmOperation<ServiceFabricClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            ServiceFabricClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACluster()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterGetOperation_example.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricClusterResource
            ServiceFabricClusterCollection collection = resourceGroupResource.GetServiceFabricClusters();

            // invoke the operation
            string clusterName = "myCluster";
            ServiceFabricClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListClusterByResourceGroup()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterListByResourceGroupOperation_example.json
            // this example is just showing the usage of "Clusters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricClusterResource
            ServiceFabricClusterCollection collection = resourceGroupResource.GetServiceFabricClusters();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetACluster()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterGetOperation_example.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricClusterResource
            ServiceFabricClusterCollection collection = resourceGroupResource.GetServiceFabricClusters();

            // invoke the operation
            string clusterName = "myCluster";
            bool result = await collection.ExistsAsync(clusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetACluster()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterGetOperation_example.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricClusterResource
            ServiceFabricClusterCollection collection = resourceGroupResource.GetServiceFabricClusters();

            // invoke the operation
            string clusterName = "myCluster";
            NullableResponse<ServiceFabricClusterResource> response = await collection.GetIfExistsAsync(clusterName);
            ServiceFabricClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
