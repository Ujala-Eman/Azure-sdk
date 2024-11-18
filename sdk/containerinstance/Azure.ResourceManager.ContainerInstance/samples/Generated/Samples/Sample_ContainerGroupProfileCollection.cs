// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerInstance.Samples
{
    public partial class Sample_ContainerGroupProfileCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ContainerGroupProfilesListByResourceGroup()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesListByResourceGroup.json
            // this example is just showing the usage of "ContainerGroupProfiles_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation and iterate over the result
            await foreach (ContainerGroupProfileResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerGroupProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ContainerGroupProfilesGetWithPriority()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesGetPriority.json
            // this example is just showing the usage of "ContainerGroupProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileResource result = await collection.GetAsync(containerGroupProfileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ContainerGroupProfilesGetWithPriority()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesGetPriority.json
            // this example is just showing the usage of "ContainerGroupProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            bool result = await collection.ExistsAsync(containerGroupProfileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ContainerGroupProfilesGetWithPriority()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesGetPriority.json
            // this example is just showing the usage of "ContainerGroupProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            NullableResponse<ContainerGroupProfileResource> response = await collection.GetIfExistsAsync(containerGroupProfileName);
            ContainerGroupProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerGroupProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ContainerGroupProfilesGetSucceeded()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesGet.json
            // this example is just showing the usage of "ContainerGroupProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileResource result = await collection.GetAsync(containerGroupProfileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ContainerGroupProfilesGetSucceeded()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesGet.json
            // this example is just showing the usage of "ContainerGroupProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            bool result = await collection.ExistsAsync(containerGroupProfileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ContainerGroupProfilesGetSucceeded()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesGet.json
            // this example is just showing the usage of "ContainerGroupProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            NullableResponse<ContainerGroupProfileResource> response = await collection.GetIfExistsAsync(containerGroupProfileName);
            ContainerGroupProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerGroupProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ConfidentialContainerGroupProfile()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfileCreateOrUpdate_CreateConfidential.json
            // this example is just showing the usage of "ContainerGroupProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileData data = new ContainerGroupProfileData(new AzureLocation("westeurope"), new ContainerInstanceContainer[]
            {
new ContainerInstanceContainer("accdemo")
{
Image = "confiimage",
Command =
{
},
Ports =
{
new ContainerPort(8000)
},
EnvironmentVariables =
{
},
Resources = new ContainerResourceRequirements(new ContainerResourceRequestsContent(1.5,1)),
SecurityContext = new ContainerSecurityContextDefinition()
{
IsPrivileged = false,
Capabilities = new ContainerSecurityContextCapabilitiesDefinition()
{
Add =
{
"CAP_NET_ADMIN"
},
},
},
}
            }, ContainerInstanceOperatingSystemType.Linux)
            {
                ImageRegistryCredentials =
{
},
                IPAddress = new ContainerGroupIPAddress(new ContainerGroupPort[]
            {
new ContainerGroupPort(8000)
{
Protocol = ContainerGroupNetworkProtocol.Tcp,
}
            }, ContainerGroupIPAddressType.Public),
                Sku = ContainerGroupSku.Confidential,
                ConfidentialComputeCcePolicy = "eyJhbGxvd19hbGwiOiB0cnVlLCAiY29udGFpbmVycyI6IHsibGVuZ3RoIjogMCwgImVsZW1lbnRzIjogbnVsbH19",
                Zones =
{
"1"
},
            };
            ArmOperation<ContainerGroupProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerGroupProfileName, data);
            ContainerGroupProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ContainerGroupProfileCreateWithExtensions()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfileCreateOrUpdate_Extensions.json
            // this example is just showing the usage of "ContainerGroupProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileData data = new ContainerGroupProfileData(new AzureLocation("eastus2"), new ContainerInstanceContainer[]
            {
new ContainerInstanceContainer("demo1")
{
Image = "nginx",
Command =
{
},
Ports =
{
new ContainerPort(80)
},
EnvironmentVariables =
{
},
Resources = new ContainerResourceRequirements(new ContainerResourceRequestsContent(1.5,1)),
}
            }, ContainerInstanceOperatingSystemType.Linux)
            {
                ImageRegistryCredentials =
{
},
                IPAddress = new ContainerGroupIPAddress(new ContainerGroupPort[]
            {
new ContainerGroupPort(80)
{
Protocol = ContainerGroupNetworkProtocol.Tcp,
}
            }, ContainerGroupIPAddressType.Private),
                Extensions =
{
new DeploymentExtensionSpec("kube-proxy")
{
ExtensionType = "kube-proxy",
Version = "1.0",
Settings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
["clusterCidr"] = "10.240.0.0/16",
["kubeVersion"] = "v1.9.10"}),
ProtectedSettings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
["kubeConfig"] = "<kubeconfig encoded string>"}),
},new DeploymentExtensionSpec("vk-realtime-metrics")
{
ExtensionType = "realtime-metrics",
Version = "1.0",
}
},
                Zones =
{
"1"
},
            };
            ArmOperation<ContainerGroupProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerGroupProfileName, data);
            ContainerGroupProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ContainerGroupProfileWithEncryptionProperties()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfileCreateOrUpdate_EncryptionProperties.json
            // this example is just showing the usage of "ContainerGroupProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileData data = new ContainerGroupProfileData(new AzureLocation("eastus2"), new ContainerInstanceContainer[]
            {
new ContainerInstanceContainer("demo1")
{
Image = "nginx",
Command =
{
},
Ports =
{
new ContainerPort(80)
},
EnvironmentVariables =
{
},
Resources = new ContainerResourceRequirements(new ContainerResourceRequestsContent(1.5,1)),
}
            }, ContainerInstanceOperatingSystemType.Linux)
            {
                ImageRegistryCredentials =
{
},
                IPAddress = new ContainerGroupIPAddress(new ContainerGroupPort[]
            {
new ContainerGroupPort(80)
{
Protocol = ContainerGroupNetworkProtocol.Tcp,
}
            }, ContainerGroupIPAddressType.Public),
                EncryptionProperties = new ContainerGroupEncryptionProperties(new Uri("https://testkeyvault.vault.azure.net"), "test-key", "<key version>")
                {
                    Identity = "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/test-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/container-group-identity",
                },
                Zones =
{
"1"
},
            };
            ArmOperation<ContainerGroupProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerGroupProfileName, data);
            ContainerGroupProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ContainerGroupProfilesCreateOrUpdate()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupProfilesCreateOrUpdate.json
            // this example is just showing the usage of "ContainerGroupProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileData data = new ContainerGroupProfileData(new AzureLocation("west us"), new ContainerInstanceContainer[]
            {
new ContainerInstanceContainer("demo1")
{
Image = "nginx",
Command =
{
},
Ports =
{
new ContainerPort(80)
},
EnvironmentVariables =
{
},
Resources = new ContainerResourceRequirements(new ContainerResourceRequestsContent(1.5,1)
{
Gpu = new ContainerGpuResourceInfo(1,ContainerGpuSku.K80),
}),
VolumeMounts =
{
new ContainerVolumeMount("volume1","/mnt/volume1")
{
IsReadOnly = false,
},new ContainerVolumeMount("volume2","/mnt/volume2")
{
IsReadOnly = false,
},new ContainerVolumeMount("volume3","/mnt/volume3")
{
IsReadOnly = true,
}
},
}
            }, ContainerInstanceOperatingSystemType.Linux)
            {
                ImageRegistryCredentials =
{
},
                IPAddress = new ContainerGroupIPAddress(new ContainerGroupPort[]
            {
new ContainerGroupPort(80)
{
Protocol = ContainerGroupNetworkProtocol.Tcp,
}
            }, ContainerGroupIPAddressType.Public),
                Volumes =
{
new ContainerVolume("volume1")
{
AzureFile = new ContainerInstanceAzureFileVolume("shareName","accountName")
{
StorageAccountKey = "accountKey",
},
},new ContainerVolume("volume2")
{
EmptyDir = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
}),
},new ContainerVolume("volume3")
{
Secret =
{
["secretKey1"] = "SecretValue1InBase64",
["secretKey2"] = "SecretValue2InBase64",
},
}
},
                DiagnosticsLogAnalytics = new ContainerGroupLogAnalytics("workspaceid", "workspaceKey")
                {
                    LogType = ContainerGroupLogAnalyticsLogType.ContainerInsights,
                    Metadata =
{
["pod-uuid"] = "test-metadata-value",
},
                    WorkspaceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/rg/providers/microsoft.operationalinsights/workspaces/workspace"),
                },
                Zones =
{
"1"
},
            };
            ArmOperation<ContainerGroupProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerGroupProfileName, data);
            ContainerGroupProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ContainerGroupsCreateWithPriority()
        {
            // Generated from example definition: specification/containerinstance/resource-manager/Microsoft.ContainerInstance/preview/2024-05-01-preview/examples/ContainerGroupsProfileCreateOrUpdate_CreatePriority.json
            // this example is just showing the usage of "ContainerGroupProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "demo";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerGroupProfileResource
            ContainerGroupProfileCollection collection = resourceGroupResource.GetContainerGroupProfiles();

            // invoke the operation
            string containerGroupProfileName = "demo1";
            ContainerGroupProfileData data = new ContainerGroupProfileData(new AzureLocation("eastus"), new ContainerInstanceContainer[]
            {
new ContainerInstanceContainer("test-container-001")
{
Image = "alpine:latest",
Command =
{
"/bin/sh","-c","sleep 10"
},
Resources = new ContainerResourceRequirements(new ContainerResourceRequestsContent(1,1)),
}
            }, ContainerInstanceOperatingSystemType.Linux)
            {
                RestartPolicy = ContainerGroupRestartPolicy.Never,
                Sku = ContainerGroupSku.Standard,
                Priority = ContainerGroupPriority.Spot,
            };
            ArmOperation<ContainerGroupProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, containerGroupProfileName, data);
            ContainerGroupProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerGroupProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
