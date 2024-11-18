// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_LogicWorkflowCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllWorkflowsInAResourceGroup()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/Workflows_ListByResourceGroup.json
            // this example is just showing the usage of "Workflows_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this LogicWorkflowResource
            LogicWorkflowCollection collection = resourceGroupResource.GetLogicWorkflows();

            // invoke the operation and iterate over the result
            await foreach (LogicWorkflowResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogicWorkflowData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAWorkflow()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/Workflows_Get.json
            // this example is just showing the usage of "Workflows_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this LogicWorkflowResource
            LogicWorkflowCollection collection = resourceGroupResource.GetLogicWorkflows();

            // invoke the operation
            string workflowName = "test-workflow";
            LogicWorkflowResource result = await collection.GetAsync(workflowName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogicWorkflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAWorkflow()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/Workflows_Get.json
            // this example is just showing the usage of "Workflows_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this LogicWorkflowResource
            LogicWorkflowCollection collection = resourceGroupResource.GetLogicWorkflows();

            // invoke the operation
            string workflowName = "test-workflow";
            bool result = await collection.ExistsAsync(workflowName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAWorkflow()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/Workflows_Get.json
            // this example is just showing the usage of "Workflows_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this LogicWorkflowResource
            LogicWorkflowCollection collection = resourceGroupResource.GetLogicWorkflows();

            // invoke the operation
            string workflowName = "test-workflow";
            NullableResponse<LogicWorkflowResource> response = await collection.GetIfExistsAsync(workflowName);
            LogicWorkflowResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogicWorkflowData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAWorkflow()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/Workflows_CreateOrUpdate.json
            // this example is just showing the usage of "Workflows_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this LogicWorkflowResource
            LogicWorkflowCollection collection = resourceGroupResource.GetLogicWorkflows();

            // invoke the operation
            string workflowName = "test-workflow";
            LogicWorkflowData data = new LogicWorkflowData(new AzureLocation("brazilsouth"))
            {
                IntegrationAccount = new LogicResourceReference()
                {
                    Id = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/test-resource-group/providers/Microsoft.Logic/integrationAccounts/test-integration-account"),
                },
                Definition = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["$schema"] = "https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#",
                    ["actions"] = new Dictionary<string, object>()
                    {
                        ["Find_pet_by_ID"] = new Dictionary<string, object>()
                        {
                            ["type"] = "ApiConnection",
                            ["inputs"] = new Dictionary<string, object>()
                            {
                                ["path"] = "/pet/@{encodeURIComponent('1')}",
                                ["method"] = "get",
                                ["host"] = new Dictionary<string, object>()
                                {
                                    ["connection"] = new Dictionary<string, object>()
                                    {
                                        ["name"] = "@parameters('$connections')['test-custom-connector']['connectionId']"
                                    }
                                }
                            },
                            ["runAfter"] = new Dictionary<string, object>()
                            {
                            }
                        }
                    },
                    ["contentVersion"] = "1.0.0.0",
                    ["outputs"] = new Dictionary<string, object>()
                    {
                    },
                    ["parameters"] = new Dictionary<string, object>()
                    {
                        ["$connections"] = new Dictionary<string, object>()
                        {
                            ["type"] = "Object",
                            ["defaultValue"] = new Dictionary<string, object>()
                            {
                            }
                        }
                    },
                    ["triggers"] = new Dictionary<string, object>()
                    {
                        ["manual"] = new Dictionary<string, object>()
                        {
                            ["type"] = "Request",
                            ["inputs"] = new Dictionary<string, object>()
                            {
                                ["schema"] = new Dictionary<string, object>()
                                {
                                }
                            },
                            ["kind"] = "Http"
                        }
                    }
                }),
                Parameters =
{
["$connections"] = new LogicWorkflowParameterInfo()
{
Value = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
["test-custom-connector"] = new Dictionary<string, object>()
{
["connectionId"] = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/test-resource-group/providers/Microsoft.Web/connections/test-custom-connector",
["connectionName"] = "test-custom-connector",
["id"] = "/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/providers/Microsoft.Web/locations/brazilsouth/managedApis/test-custom-connector"}}),
},
},
                Tags =
{
},
            };
            ArmOperation<LogicWorkflowResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workflowName, data);
            LogicWorkflowResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogicWorkflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
