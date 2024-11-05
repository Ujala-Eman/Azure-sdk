// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningJobResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAutoMLJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/AutoMLJob/get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobResource result = await machineLearningJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCommandJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/CommandJob/get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobResource result = await machineLearningJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPipelineJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/PipelineJob/get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobResource result = await machineLearningJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSweepJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/SweepJob/get.json
            // this example is just showing the usage of "Jobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobResource result = await machineLearningJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/delete.json
            // this example is just showing the usage of "Jobs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "http://subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/jobs/my-favorite-aml-job";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            await machineLearningJob.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAutoMLJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/AutoMLJob/createOrUpdate.json
            // this example is just showing the usage of "Jobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobData data = new MachineLearningJobData(new AutoMLJob(new ImageClassification(new MachineLearningTableJobInput(new Uri("string")), new ImageLimitSettings
            {
                MaxTrials = 2,
            })
            {
                ModelSettings = new ImageModelSettingsClassification
                {
                    ValidationCropSize = 2,
                },
                SearchSpace = {new ImageModelDistributionSettingsClassification
{
ValidationCropSize = "choice(2, 360)",
}},
                TargetColumnName = "string",
            })
            {
                Resources = new MachineLearningJobResourceConfiguration
                {
                    InstanceCount = 1,
                    InstanceType = "string",
                    Properties =
{
["string"] = BinaryData.FromObjectAsJson(new Dictionary<string, object>
{
["9bec0ab0-c62f-4fa9-a97c-7b24bbcc90ad"] = null
})
},
                },
                EnvironmentId = "string",
                EnvironmentVariables =
{
["string"] = "string"
},
                Outputs =
{
["string"] = new MachineLearningUriFileJobOutput
{
Uri = new Uri("string"),
Mode = MachineLearningOutputDeliveryMode.ReadWriteMount,
Description = "string",
}
},
                DisplayName = "string",
                ExperimentName = "string",
                Services =
{
["string"] = new MachineLearningJobService
{
JobServiceType = "string",
Port = 1,
Endpoint = "string",
Properties =
{
["string"] = "string"
},
}
},
                ComputeId = new ResourceIdentifier("string"),
                IsArchived = false,
                Identity = new AmlToken(),
                Description = "string",
                Tags =
{
["string"] = "string"
},
                Properties =
{
["string"] = "string"
},
            });
            ArmOperation<MachineLearningJobResource> lro = await machineLearningJob.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateCommandJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/CommandJob/createOrUpdate.json
            // this example is just showing the usage of "Jobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobData data = new MachineLearningJobData(new MachineLearningCommandJob("string", new ResourceIdentifier("string"))
            {
                Resources = new MachineLearningJobResourceConfiguration
                {
                    InstanceCount = 1,
                    InstanceType = "string",
                    Properties =
{
["string"] = BinaryData.FromObjectAsJson(new Dictionary<string, object>
{
["e6b6493e-7d5e-4db3-be1e-306ec641327e"] = null
})
},
                },
                CodeId = new ResourceIdentifier("string"),
                Inputs =
{
["string"] = new MachineLearningLiteralJobInput("string")
{
Description = "string",
}
},
                Outputs =
{
["string"] = new MachineLearningUriFileJobOutput
{
Uri = new Uri("string"),
Mode = MachineLearningOutputDeliveryMode.ReadWriteMount,
Description = "string",
}
},
                Distribution = new TensorFlowDistributionConfiguration
                {
                    WorkerCount = 1,
                    ParameterServerCount = 1,
                },
                Limits = new MachineLearningCommandJobLimits
                {
                    Timeout = default,
                },
                EnvironmentVariables =
{
["string"] = "string"
},
                DisplayName = "string",
                ExperimentName = "string",
                Services =
{
["string"] = new MachineLearningJobService
{
JobServiceType = "string",
Port = 1,
Endpoint = "string",
Properties =
{
["string"] = "string"
},
}
},
                ComputeId = new ResourceIdentifier("string"),
                Identity = new AmlToken(),
                Description = "string",
                Tags =
{
["string"] = "string"
},
                Properties =
{
["string"] = "string"
},
            });
            ArmOperation<MachineLearningJobResource> lro = await machineLearningJob.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdatePipelineJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/PipelineJob/createOrUpdate.json
            // this example is just showing the usage of "Jobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobData data = new MachineLearningJobData(new MachineLearningPipelineJob
            {
                Settings = BinaryData.FromObjectAsJson(new object()),
                Inputs =
{
["string"] = new MachineLearningLiteralJobInput("string")
{
Description = "string",
}
},
                Outputs =
{
["string"] = new MachineLearningUriFileJobOutput
{
Uri = new Uri("string"),
Mode = MachineLearningOutputDeliveryMode.Upload,
Description = "string",
}
},
                DisplayName = "string",
                ExperimentName = "string",
                Services =
{
["string"] = new MachineLearningJobService
{
JobServiceType = "string",
Port = 1,
Endpoint = "string",
Properties =
{
["string"] = "string"
},
}
},
                ComputeId = new ResourceIdentifier("string"),
                Description = "string",
                Tags =
{
["string"] = "string"
},
                Properties =
{
["string"] = "string"
},
            });
            ArmOperation<MachineLearningJobResource> lro = await machineLearningJob.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateSweepJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/SweepJob/createOrUpdate.json
            // this example is just showing the usage of "Jobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            MachineLearningJobData data = new MachineLearningJobData(new MachineLearningSweepJob(BinaryData.FromObjectAsJson(new Dictionary<string, object>
            {
                ["string"] = new object()
            }), new GridSamplingAlgorithm(), new MachineLearningObjective("string", MachineLearningGoal.Minimize), new MachineLearningTrialComponent("string", new ResourceIdentifier("string"))
            {
                CodeId = new ResourceIdentifier("string"),
                EnvironmentVariables =
{
["string"] = "string"
},
                Distribution = new MpiDistributionConfiguration
                {
                    ProcessCountPerInstance = 1,
                },
                Resources = new MachineLearningJobResourceConfiguration
                {
                    InstanceCount = 1,
                    InstanceType = "string",
                    Properties =
{
["string"] = BinaryData.FromObjectAsJson(new Dictionary<string, object>
{
["e6b6493e-7d5e-4db3-be1e-306ec641327e"] = null
})
},
                },
            })
            {
                Limits = new MachineLearningSweepJobLimits
                {
                    MaxTotalTrials = 1,
                    MaxConcurrentTrials = 1,
                    TrialTimeout = default,
                },
                EarlyTermination = new MedianStoppingPolicy
                {
                    EvaluationInterval = 1,
                    DelayEvaluation = 1,
                },
                DisplayName = "string",
                ExperimentName = "string",
                Services =
{
["string"] = new MachineLearningJobService
{
JobServiceType = "string",
Port = 1,
Endpoint = "string",
Properties =
{
["string"] = "string"
},
}
},
                ComputeId = new ResourceIdentifier("string"),
                Description = "string",
                Tags =
{
["string"] = "string"
},
                Properties =
{
["string"] = "string"
},
            });
            ArmOperation<MachineLearningJobResource> lro = await machineLearningJob.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Cancel_CancelJob()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Job/cancel.json
            // this example is just showing the usage of "Jobs_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningJobResource created on azure
            // for more information of creating MachineLearningJobResource, please refer to the document of MachineLearningJobResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string id = "string";
            ResourceIdentifier machineLearningJobResourceId = MachineLearningJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, id);
            MachineLearningJobResource machineLearningJob = client.GetMachineLearningJobResource(machineLearningJobResourceId);

            // invoke the operation
            await machineLearningJob.CancelAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
