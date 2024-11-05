// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerDatabaseReplicationLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheReplicationLink()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ReplicationLinkGet.json
            // this example is just showing the usage of "ReplicationLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseReplicationLinkResource created on azure
            // for more information of creating SqlServerDatabaseReplicationLinkResource, please refer to the document of SqlServerDatabaseReplicationLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "sourcesvr";
            string databaseName = "gamma-db";
            string linkId = "4891ca10-ebd0-47d7-9182-c722651780fb";
            ResourceIdentifier sqlServerDatabaseReplicationLinkResourceId = SqlServerDatabaseReplicationLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, linkId);
            SqlServerDatabaseReplicationLinkResource sqlServerDatabaseReplicationLink = client.GetSqlServerDatabaseReplicationLinkResource(sqlServerDatabaseReplicationLinkResourceId);

            // invoke the operation
            SqlServerDatabaseReplicationLinkResource result = await sqlServerDatabaseReplicationLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseReplicationLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteReplicationLinkOnServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ReplicationLinkDelete.json
            // this example is just showing the usage of "ReplicationLinks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseReplicationLinkResource created on azure
            // for more information of creating SqlServerDatabaseReplicationLinkResource, please refer to the document of SqlServerDatabaseReplicationLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "sourcesvr";
            string databaseName = "gamma-db";
            string linkId = "4891ca10-ebd0-47d7-9182-c722651780fb";
            ResourceIdentifier sqlServerDatabaseReplicationLinkResourceId = SqlServerDatabaseReplicationLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, linkId);
            SqlServerDatabaseReplicationLinkResource sqlServerDatabaseReplicationLink = client.GetSqlServerDatabaseReplicationLinkResource(sqlServerDatabaseReplicationLinkResourceId);

            // invoke the operation
            await sqlServerDatabaseReplicationLink.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateReplicationLink()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ReplicationLinkUpdate.json
            // this example is just showing the usage of "ReplicationLinks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseReplicationLinkResource created on azure
            // for more information of creating SqlServerDatabaseReplicationLinkResource, please refer to the document of SqlServerDatabaseReplicationLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "sourcesvr";
            string databaseName = "gamma-db";
            string linkId = "00000000-1111-2222-3333-666666666666";
            ResourceIdentifier sqlServerDatabaseReplicationLinkResourceId = SqlServerDatabaseReplicationLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, linkId);
            SqlServerDatabaseReplicationLinkResource sqlServerDatabaseReplicationLink = client.GetSqlServerDatabaseReplicationLinkResource(sqlServerDatabaseReplicationLinkResourceId);

            // invoke the operation
            SqlServerDatabaseReplicationLinkPatch patch = new SqlServerDatabaseReplicationLinkPatch
            {
                LinkType = ReplicationLinkType.Standby,
            };
            ArmOperation<SqlServerDatabaseReplicationLinkResource> lro = await sqlServerDatabaseReplicationLink.UpdateAsync(WaitUntil.Completed, patch);
            SqlServerDatabaseReplicationLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseReplicationLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Failover_PlannedFailoverOfAReplicationLink()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ReplicationLinkFailover.json
            // this example is just showing the usage of "ReplicationLinks_Failover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseReplicationLinkResource created on azure
            // for more information of creating SqlServerDatabaseReplicationLinkResource, please refer to the document of SqlServerDatabaseReplicationLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "sourcesvr";
            string databaseName = "gamma-db";
            string linkId = "4891ca10-ebd0-47d7-9182-c722651780fb";
            ResourceIdentifier sqlServerDatabaseReplicationLinkResourceId = SqlServerDatabaseReplicationLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, linkId);
            SqlServerDatabaseReplicationLinkResource sqlServerDatabaseReplicationLink = client.GetSqlServerDatabaseReplicationLinkResource(sqlServerDatabaseReplicationLinkResourceId);

            // invoke the operation
            ArmOperation<SqlServerDatabaseReplicationLinkResource> lro = await sqlServerDatabaseReplicationLink.FailoverAsync(WaitUntil.Completed);
            SqlServerDatabaseReplicationLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseReplicationLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task FailoverAllowDataLoss_ForcedFailoverOfAReplicationLink()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ReplicationLinkFailoverAllowDataLoss.json
            // this example is just showing the usage of "ReplicationLinks_FailoverAllowDataLoss" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerDatabaseReplicationLinkResource created on azure
            // for more information of creating SqlServerDatabaseReplicationLinkResource, please refer to the document of SqlServerDatabaseReplicationLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "sourcesvr";
            string databaseName = "gamma-db";
            string linkId = "4891ca10-ebd0-47d7-9182-c722651780fb";
            ResourceIdentifier sqlServerDatabaseReplicationLinkResourceId = SqlServerDatabaseReplicationLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, linkId);
            SqlServerDatabaseReplicationLinkResource sqlServerDatabaseReplicationLink = client.GetSqlServerDatabaseReplicationLinkResource(sqlServerDatabaseReplicationLinkResourceId);

            // invoke the operation
            ArmOperation<SqlServerDatabaseReplicationLinkResource> lro = await sqlServerDatabaseReplicationLink.FailoverAllowDataLossAsync(WaitUntil.Completed);
            SqlServerDatabaseReplicationLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerDatabaseReplicationLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
