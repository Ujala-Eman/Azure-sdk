// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseKeyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAWorkspaceKey()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetKey.json
            // this example is just showing the usage of "Keys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKeyResource created on azure
            // for more information of creating SynapseKeyResource, please refer to the document of SynapseKeyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            string keyName = "somekey";
            ResourceIdentifier synapseKeyResourceId = SynapseKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, keyName);
            SynapseKeyResource synapseKey = client.GetSynapseKeyResource(synapseKeyResourceId);

            // invoke the operation
            SynapseKeyResource result = await synapseKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAWorkspaceKey()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateKey.json
            // this example is just showing the usage of "Keys_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKeyResource created on azure
            // for more information of creating SynapseKeyResource, please refer to the document of SynapseKeyResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            string keyName = "somekey";
            ResourceIdentifier synapseKeyResourceId = SynapseKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, keyName);
            SynapseKeyResource synapseKey = client.GetSynapseKeyResource(synapseKeyResourceId);

            // invoke the operation
            SynapseKeyData data = new SynapseKeyData()
            {
                IsActiveCmk = true,
                KeyVaultUri = new Uri("https://vault.azure.net/keys/somesecret"),
            };
            ArmOperation<SynapseKeyResource> lro = await synapseKey.UpdateAsync(WaitUntil.Completed, data);
            SynapseKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAWorkspaceKey()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DeleteKey.json
            // this example is just showing the usage of "Keys_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKeyResource created on azure
            // for more information of creating SynapseKeyResource, please refer to the document of SynapseKeyResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            string keyName = "somekey";
            ResourceIdentifier synapseKeyResourceId = SynapseKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, keyName);
            SynapseKeyResource synapseKey = client.GetSynapseKeyResource(synapseKeyResourceId);

            // invoke the operation
            ArmOperation<SynapseKeyResource> lro = await synapseKey.DeleteAsync(WaitUntil.Completed);
            SynapseKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
