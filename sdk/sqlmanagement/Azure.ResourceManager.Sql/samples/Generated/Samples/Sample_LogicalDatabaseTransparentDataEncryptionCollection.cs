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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_LogicalDatabaseTransparentDataEncryptionCollection
    {
        // Get a list of the database's transparent data encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAListOfTheDatabaseSTransparentDataEncryption()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/TransparentDataEncryptionList.json
            // this example is just showing the usage of "TransparentDataEncryptions_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "security-tde-resourcegroup";
            string serverName = "securitytde";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this LogicalDatabaseTransparentDataEncryptionResource
            LogicalDatabaseTransparentDataEncryptionCollection collection = sqlDatabase.GetLogicalDatabaseTransparentDataEncryptions();

            // invoke the operation and iterate over the result
            await foreach (LogicalDatabaseTransparentDataEncryptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogicalDatabaseTransparentDataEncryptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a database's transparent data encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADatabaseSTransparentDataEncryption()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/TransparentDataEncryptionGet.json
            // this example is just showing the usage of "TransparentDataEncryptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "security-tde-resourcegroup";
            string serverName = "securitytde";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this LogicalDatabaseTransparentDataEncryptionResource
            LogicalDatabaseTransparentDataEncryptionCollection collection = sqlDatabase.GetLogicalDatabaseTransparentDataEncryptions();

            // invoke the operation
            TransparentDataEncryptionName tdeName = TransparentDataEncryptionName.Current;
            LogicalDatabaseTransparentDataEncryptionResource result = await collection.GetAsync(tdeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogicalDatabaseTransparentDataEncryptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a database's transparent data encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetADatabaseSTransparentDataEncryption()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/TransparentDataEncryptionGet.json
            // this example is just showing the usage of "TransparentDataEncryptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "security-tde-resourcegroup";
            string serverName = "securitytde";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this LogicalDatabaseTransparentDataEncryptionResource
            LogicalDatabaseTransparentDataEncryptionCollection collection = sqlDatabase.GetLogicalDatabaseTransparentDataEncryptions();

            // invoke the operation
            TransparentDataEncryptionName tdeName = TransparentDataEncryptionName.Current;
            bool result = await collection.ExistsAsync(tdeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a database's transparent data encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetADatabaseSTransparentDataEncryption()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/TransparentDataEncryptionGet.json
            // this example is just showing the usage of "TransparentDataEncryptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "security-tde-resourcegroup";
            string serverName = "securitytde";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this LogicalDatabaseTransparentDataEncryptionResource
            LogicalDatabaseTransparentDataEncryptionCollection collection = sqlDatabase.GetLogicalDatabaseTransparentDataEncryptions();

            // invoke the operation
            TransparentDataEncryptionName tdeName = TransparentDataEncryptionName.Current;
            NullableResponse<LogicalDatabaseTransparentDataEncryptionResource> response = await collection.GetIfExistsAsync(tdeName);
            LogicalDatabaseTransparentDataEncryptionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                LogicalDatabaseTransparentDataEncryptionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Update a database's Transparent Data Encryption state with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateADatabaseSTransparentDataEncryptionStateWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/TransparentDataEncryptionUpdate.json
            // this example is just showing the usage of "TransparentDataEncryptions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securitytde-42-rg";
            string serverName = "securitytde-42";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this LogicalDatabaseTransparentDataEncryptionResource
            LogicalDatabaseTransparentDataEncryptionCollection collection = sqlDatabase.GetLogicalDatabaseTransparentDataEncryptions();

            // invoke the operation
            TransparentDataEncryptionName tdeName = TransparentDataEncryptionName.Current;
            LogicalDatabaseTransparentDataEncryptionData data = new LogicalDatabaseTransparentDataEncryptionData()
            {
                State = TransparentDataEncryptionState.Enabled,
            };
            ArmOperation<LogicalDatabaseTransparentDataEncryptionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tdeName, data);
            LogicalDatabaseTransparentDataEncryptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LogicalDatabaseTransparentDataEncryptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
