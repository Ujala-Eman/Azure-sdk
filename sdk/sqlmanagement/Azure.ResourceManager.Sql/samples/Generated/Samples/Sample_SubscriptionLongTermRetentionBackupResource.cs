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
    public partial class Sample_SubscriptionLongTermRetentionBackupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/LongTermRetentionBackupGet.json
            // this example is just showing the usage of "LongTermRetentionBackups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionLongTermRetentionBackupResource created on azure
            // for more information of creating SubscriptionLongTermRetentionBackupResource, please refer to the document of SubscriptionLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000;Archive";
            ResourceIdentifier subscriptionLongTermRetentionBackupResourceId = SubscriptionLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            SubscriptionLongTermRetentionBackupResource subscriptionLongTermRetentionBackup = client.GetSubscriptionLongTermRetentionBackupResource(subscriptionLongTermRetentionBackupResourceId);

            // invoke the operation
            SubscriptionLongTermRetentionBackupResource result = await subscriptionLongTermRetentionBackup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LongTermRetentionBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/LongTermRetentionBackupDelete.json
            // this example is just showing the usage of "LongTermRetentionBackups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionLongTermRetentionBackupResource created on azure
            // for more information of creating SubscriptionLongTermRetentionBackupResource, please refer to the document of SubscriptionLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000;Hot";
            ResourceIdentifier subscriptionLongTermRetentionBackupResourceId = SubscriptionLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            SubscriptionLongTermRetentionBackupResource subscriptionLongTermRetentionBackup = client.GetSubscriptionLongTermRetentionBackupResource(subscriptionLongTermRetentionBackupResourceId);

            // invoke the operation
            await subscriptionLongTermRetentionBackup.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ChangeAccessTier_ChangeTheLongTermRetentionBackupStorageAccessTier()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/ChangeLongTermRetentionBackupAccessTier.json
            // this example is just showing the usage of "LongTermRetentionBackups_ChangeAccessTier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionLongTermRetentionBackupResource created on azure
            // for more information of creating SubscriptionLongTermRetentionBackupResource, please refer to the document of SubscriptionLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "serverName";
            string longTermRetentionDatabaseName = "databaseName";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000;Archive";
            ResourceIdentifier subscriptionLongTermRetentionBackupResourceId = SubscriptionLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            SubscriptionLongTermRetentionBackupResource subscriptionLongTermRetentionBackup = client.GetSubscriptionLongTermRetentionBackupResource(subscriptionLongTermRetentionBackupResourceId);

            // invoke the operation
            ChangeLongTermRetentionBackupAccessTierParameters changeLongTermRetentionBackupAccessTierParameters = new ChangeLongTermRetentionBackupAccessTierParameters("Hot", "Copy");
            ArmOperation<SubscriptionLongTermRetentionBackupResource> lro = await subscriptionLongTermRetentionBackup.ChangeAccessTierAsync(WaitUntil.Completed, changeLongTermRetentionBackupAccessTierParameters);
            SubscriptionLongTermRetentionBackupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LongTermRetentionBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Copy_CopyTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/LongTermRetentionBackupCopy.json
            // this example is just showing the usage of "LongTermRetentionBackups_Copy" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionLongTermRetentionBackupResource created on azure
            // for more information of creating SubscriptionLongTermRetentionBackupResource, please refer to the document of SubscriptionLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            ResourceIdentifier subscriptionLongTermRetentionBackupResourceId = SubscriptionLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            SubscriptionLongTermRetentionBackupResource subscriptionLongTermRetentionBackup = client.GetSubscriptionLongTermRetentionBackupResource(subscriptionLongTermRetentionBackupResourceId);

            // invoke the operation
            CopyLongTermRetentionBackupContent content = new CopyLongTermRetentionBackupContent
            {
                TargetServerResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/providers/Microsoft.Sql/resourceGroups/resourceGroup/servers/testserver2"),
                TargetDatabaseName = "testDatabase2",
                TargetBackupStorageRedundancy = SqlBackupStorageRedundancy.Geo,
            };
            ArmOperation<LongTermRetentionBackupOperationResult> lro = await subscriptionLongTermRetentionBackup.CopyAsync(WaitUntil.Completed, content);
            LongTermRetentionBackupOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateTheLongTermRetentionBackup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2023-05-01-preview/examples/LongTermRetentionBackupUpdate.json
            // this example is just showing the usage of "LongTermRetentionBackups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionLongTermRetentionBackupResource created on azure
            // for more information of creating SubscriptionLongTermRetentionBackupResource, please refer to the document of SubscriptionLongTermRetentionBackupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            AzureLocation locationName = new AzureLocation("japaneast");
            string longTermRetentionServerName = "testserver";
            string longTermRetentionDatabaseName = "testDatabase";
            string backupName = "55555555-6666-7777-8888-999999999999;131637960820000000";
            ResourceIdentifier subscriptionLongTermRetentionBackupResourceId = SubscriptionLongTermRetentionBackupResource.CreateResourceIdentifier(subscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName);
            SubscriptionLongTermRetentionBackupResource subscriptionLongTermRetentionBackup = client.GetSubscriptionLongTermRetentionBackupResource(subscriptionLongTermRetentionBackupResourceId);

            // invoke the operation
            UpdateLongTermRetentionBackupContent content = new UpdateLongTermRetentionBackupContent
            {
                RequestedBackupStorageRedundancy = SqlBackupStorageRedundancy.Geo,
            };
            ArmOperation<LongTermRetentionBackupOperationResult> lro = await subscriptionLongTermRetentionBackup.UpdateAsync(WaitUntil.Completed, content);
            LongTermRetentionBackupOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
