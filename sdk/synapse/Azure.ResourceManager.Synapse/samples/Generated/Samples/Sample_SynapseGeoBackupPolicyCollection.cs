// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseGeoBackupPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetSqlPoolGeoBackupPolicy()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolGeoBackupPolicies_List.json
            // this example is just showing the usage of "SqlPoolGeoBackupPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-5961";
            string sqlPoolName = "testdw";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseGeoBackupPolicyResource
            SynapseGeoBackupPolicyCollection collection = synapseSqlPool.GetSynapseGeoBackupPolicies();

            // invoke the operation and iterate over the result
            await foreach (SynapseGeoBackupPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseGeoBackupPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateGeoBackupPolicy()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateGeoBackupPolicies.json
            // this example is just showing the usage of "SqlPoolGeoBackupPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string workspaceName = "testws";
            string sqlPoolName = "testdw";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseGeoBackupPolicyResource
            SynapseGeoBackupPolicyCollection collection = synapseSqlPool.GetSynapseGeoBackupPolicies();

            // invoke the operation
            SynapseGeoBackupPolicyName geoBackupPolicyName = SynapseGeoBackupPolicyName.Default;
            SynapseGeoBackupPolicyData data = new SynapseGeoBackupPolicyData(SynapseGeoBackupPolicyState.Enabled);
            ArmOperation<SynapseGeoBackupPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, geoBackupPolicyName, data);
            SynapseGeoBackupPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseGeoBackupPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSqlPoolGeoBackupPolicy()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolGeoBackupPolicy.json
            // this example is just showing the usage of "SqlPoolGeoBackupPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-5961";
            string sqlPoolName = "testdw";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseGeoBackupPolicyResource
            SynapseGeoBackupPolicyCollection collection = synapseSqlPool.GetSynapseGeoBackupPolicies();

            // invoke the operation
            SynapseGeoBackupPolicyName geoBackupPolicyName = SynapseGeoBackupPolicyName.Default;
            SynapseGeoBackupPolicyResource result = await collection.GetAsync(geoBackupPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseGeoBackupPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetSqlPoolGeoBackupPolicy()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolGeoBackupPolicy.json
            // this example is just showing the usage of "SqlPoolGeoBackupPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-5961";
            string sqlPoolName = "testdw";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseGeoBackupPolicyResource
            SynapseGeoBackupPolicyCollection collection = synapseSqlPool.GetSynapseGeoBackupPolicies();

            // invoke the operation
            SynapseGeoBackupPolicyName geoBackupPolicyName = SynapseGeoBackupPolicyName.Default;
            bool result = await collection.ExistsAsync(geoBackupPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetSqlPoolGeoBackupPolicy()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolGeoBackupPolicy.json
            // this example is just showing the usage of "SqlPoolGeoBackupPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-5961";
            string sqlPoolName = "testdw";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseGeoBackupPolicyResource
            SynapseGeoBackupPolicyCollection collection = synapseSqlPool.GetSynapseGeoBackupPolicies();

            // invoke the operation
            SynapseGeoBackupPolicyName geoBackupPolicyName = SynapseGeoBackupPolicyName.Default;
            NullableResponse<SynapseGeoBackupPolicyResource> response = await collection.GetIfExistsAsync(geoBackupPolicyName);
            SynapseGeoBackupPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseGeoBackupPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
