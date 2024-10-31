// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppJobResource
    {
        // List Container Apps Jobs by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContainerAppJobs_ListContainerAppsJobsBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Jobs_ListBySubscription.json
            // this example is just showing the usage of "Jobs_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerAppJobResource item in subscriptionResource.GetContainerAppJobsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Container Apps Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Job_Get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            ContainerAppJobResource result = await containerAppJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Container Apps Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Job_Delete.json
            // this example is just showing the usage of "Jobs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testWorkerContainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            await containerAppJob.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch Container Apps Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Job_Patch.json
            // this example is just showing the usage of "Jobs_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            ContainerAppJobPatch patch = new ContainerAppJobPatch()
            {
                Properties = new ContainerAppJobPatchProperties()
                {
                    Configuration = new ContainerAppJobConfiguration(ContainerAppJobTriggerType.Manual, 10)
                    {
                        ReplicaRetryLimit = 10,
                        ManualTriggerConfig = new JobConfigurationManualTriggerConfig()
                        {
                            ReplicaCompletionCount = 1,
                            Parallelism = 4,
                        },
                    },
                    Template = new ContainerAppJobTemplate()
                    {
                        InitContainers =
{
new ContainerAppInitContainer()
{
Image = "repo/testcontainerAppsJob0:v4",
Name = "testinitcontainerAppsJob0",
Command =
{
"/bin/sh"
},
Args =
{
"-c","while true; do echo hello; sleep 10;done"
},
Resources = new AppContainerResources()
{
Cpu = 0.2,
Memory = "100Mi",
},
}
},
                        Containers =
{
new ContainerAppContainer()
{
Probes =
{
new ContainerAppProbe()
{
HttpGet = new ContainerAppHttpRequestInfo(8080)
{
HttpHeaders =
{
new ContainerAppHttpHeaderInfo("Custom-Header","Awesome")
},
Path = "/health",
},
InitialDelaySeconds = 3,
PeriodSeconds = 3,
ProbeType = ContainerAppProbeType.Liveness,
}
},
Image = "repo/testcontainerAppsJob0:v1",
Name = "testcontainerAppsJob0",
}
},
                    },
                },
            };
            ArmOperation<ContainerAppJobResource> lro = await containerAppJob.UpdateAsync(WaitUntil.Completed, patch);
            ContainerAppJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Run a Container Apps Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_RunAContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Job_Start.json
            // this example is just showing the usage of "Jobs_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            ContainerAppJobExecutionTemplate template = new ContainerAppJobExecutionTemplate()
            {
                Containers =
{
new JobExecutionContainer()
{
Image = "repo/testcontainerAppsJob0:v4",
Name = "testcontainerAppsJob0",
Resources = new AppContainerResources()
{
Cpu = 0.2,
Memory = "100Mi",
},
}
},
                InitContainers =
{
new JobExecutionContainer()
{
Image = "repo/testcontainerAppsJob0:v4",
Name = "testinitcontainerAppsJob0",
Command =
{
"/bin/sh"
},
Args =
{
"-c","while true; do echo hello; sleep 10;done"
},
Resources = new AppContainerResources()
{
Cpu = 0.2,
Memory = "100Mi",
},
}
},
            };
            ArmOperation<ContainerAppJobExecutionBase> lro = await containerAppJob.StartAsync(WaitUntil.Completed, template: template);
            ContainerAppJobExecutionBase result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Terminate Multiple Container Apps Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StopMultipleExecutions_TerminateMultipleContainerAppsJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Job_Stop_Multiple.json
            // this example is just showing the usage of "Jobs_StopMultipleExecutions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            ArmOperation<ContainerAppJobExecutions> lro = await containerAppJob.StopMultipleExecutionsAsync(WaitUntil.Completed);
            ContainerAppJobExecutions result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // List Container Apps Job Secrets
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecrets_ListContainerAppsJobSecrets()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Job_ListSecrets.json
            // this example is just showing the usage of "Jobs_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerAppWritableSecret item in containerAppJob.GetSecretsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Resume Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Resume_ResumeJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Jobs_Resume.json
            // this example is just showing the usage of "Jobs_Resume" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            ArmOperation<ContainerAppJobResource> lro = await containerAppJob.ResumeAsync(WaitUntil.Completed);
            ContainerAppJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Suspend Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Suspend_SuspendJob()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2024-10-02-preview/examples/Jobs_Suspend.json
            // this example is just showing the usage of "Jobs_Suspend" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerAppsJob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // invoke the operation
            ArmOperation<ContainerAppJobResource> lro = await containerAppJob.SuspendAsync(WaitUntil.Completed);
            ContainerAppJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
