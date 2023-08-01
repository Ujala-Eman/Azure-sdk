// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_RecoverableDatabaseResource
    {
        // Get a recoverable database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARecoverableDatabase()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/RecoverableDatabaseGet.json
            // this example is just showing the usage of "RecoverableDatabases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoverableDatabaseResource created on azure
            // for more information of creating RecoverableDatabaseResource, please refer to the document of RecoverableDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "recoverabledatabasetest-6852";
            string serverName = "recoverabledatabasetest-2080";
            string databaseName = "recoverabledatabasetest-9187";
            ResourceIdentifier recoverableDatabaseResourceId = RecoverableDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            RecoverableDatabaseResource recoverableDatabase = client.GetRecoverableDatabaseResource(recoverableDatabaseResourceId);

            // invoke the operation
            RecoverableDatabaseResource result = await recoverableDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoverableDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a recoverable database with expand equals keys.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsARecoverableDatabaseWithExpandEqualsKeys()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/RecoverableDatabaseGetWithExpandEqualsKeys.json
            // this example is just showing the usage of "RecoverableDatabases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoverableDatabaseResource created on azure
            // for more information of creating RecoverableDatabaseResource, please refer to the document of RecoverableDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "recoverabledatabasetest-6852";
            string serverName = "recoverabledatabasetest-2080";
            string databaseName = "recoverabledatabasetest-9187";
            ResourceIdentifier recoverableDatabaseResourceId = RecoverableDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            RecoverableDatabaseResource recoverableDatabase = client.GetRecoverableDatabaseResource(recoverableDatabaseResourceId);

            // invoke the operation
            string expand = "keys";
            RecoverableDatabaseResource result = await recoverableDatabase.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoverableDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
