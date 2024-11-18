// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SqlVirtualMachine.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SqlVirtualMachine.Samples
{
    public partial class Sample_SqlVmCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsASQLVirtualMachine()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachine.json
            // this example is just showing the usage of "SqlVirtualMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmResource result = await collection.GetAsync(sqlVmName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsASQLVirtualMachine()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachine.json
            // this example is just showing the usage of "SqlVirtualMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            bool result = await collection.ExistsAsync(sqlVmName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsASQLVirtualMachine()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachine.json
            // this example is just showing the usage of "SqlVirtualMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            NullableResponse<SqlVmResource> response = await collection.GetIfExistsAsync(sqlVmName);
            SqlVmResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlVmData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineAndJoinsItToASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateVirtualMachineWithVMGroup.json
            // this example is just showing the usage of "SqlVirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmData data = new SqlVmData(new AzureLocation("northeurope"))
            {
                VirtualMachineResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Compute/virtualMachines/testvm2"),
                SqlVmGroupResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachineGroups/testvmgroup"),
                WindowsServerFailoverClusterDomainCredentials = new WindowsServerFailoverClusterDomainCredentials()
                {
                    ClusterBootstrapAccountPassword = "<Password>",
                    ClusterOperatorAccountPassword = "<Password>",
                    SqlServiceAccountPassword = "<Password>",
                },
                WindowsServerFailoverClusterStaticIP = IPAddress.Parse("10.0.0.7"),
            };
            ArmOperation<SqlVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmName, data);
            SqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineForAutomatedBackUpSettingsWithWeeklyAndDaysOfTheWeekToRunTheBackUp()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateSqlVirtualMachineAutomatedBackupWeekly.json
            // this example is just showing the usage of "SqlVirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmData data = new SqlVmData(new AzureLocation("northeurope"))
            {
                VirtualMachineResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Compute/virtualMachines/testvm"),
                SqlServerLicenseType = SqlServerLicenseType.Payg,
                SqlManagement = SqlManagementMode.Full,
                SqlImageSku = SqlImageSku.Enterprise,
                AutoPatchingSettings = new SqlVmAutoPatchingSettings()
                {
                    IsEnabled = true,
                    DayOfWeek = SqlVmAutoPatchingDayOfWeek.Sunday,
                    MaintenanceWindowStartingHour = 2,
                    MaintenanceWindowDurationInMinutes = 60,
                },
                AutoBackupSettings = new SqlVmAutoBackupSettings()
                {
                    IsEnabled = true,
                    IsEncryptionEnabled = true,
                    RetentionPeriodInDays = 17,
                    StorageAccountUri = new Uri("https://teststorage.blob.core.windows.net/"),
                    StorageContainerName = "testcontainer",
                    StorageAccessKey = "<primary storage access key>",
                    Password = "<Password>",
                    AreSystemDbsIncludedInBackup = true,
                    BackupScheduleType = SqVmBackupScheduleType.Manual,
                    FullBackupFrequency = SqlVmFullBackupFrequency.Weekly,
                    DaysOfWeek =
{
SqlVmAutoBackupDayOfWeek.Monday,SqlVmAutoBackupDayOfWeek.Friday
},
                    FullBackupStartHour = 6,
                    FullBackupWindowHours = 11,
                    LogBackupFrequency = 10,
                },
                KeyVaultCredentialSettings = new SqlVmKeyVaultCredentialSettings()
                {
                    IsEnabled = false,
                },
                ServerConfigurationsManagementSettings = new SqlServerConfigurationsManagementSettings()
                {
                    SqlConnectivityUpdateSettings = new SqlConnectivityUpdateSettings()
                    {
                        ConnectivityType = SqlServerConnectivityType.Private,
                        Port = 1433,
                        SqlAuthUpdateUserName = "sqllogin",
                        SqlAuthUpdatePassword = "<password>",
                    },
                    SqlWorkloadType = SqlWorkloadType.Oltp,
                    SqlStorageUpdateSettings = new SqlStorageUpdateSettings()
                    {
                        DiskCount = 1,
                        StartingDeviceId = 2,
                        DiskConfigurationType = SqlVmDiskConfigurationType.New,
                    },
                    IsRServicesEnabled = false,
                },
            };
            ArmOperation<SqlVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmName, data);
            SqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineForStorageConfigurationSettingsToEXTENDDataLogOrTempDBStoragePool()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateSqlVirtualMachineStorageConfigurationEXTEND.json
            // this example is just showing the usage of "SqlVirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmData data = new SqlVmData(new AzureLocation("northeurope"))
            {
                VirtualMachineResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Compute/virtualMachines/testvm"),
                StorageConfigurationSettings = new SqlVmStorageConfigurationSettings()
                {
                    SqlDataSettings = new SqlStorageSettings()
                    {
                        Luns =
{
2
},
                    },
                    DiskConfigurationType = SqlVmDiskConfigurationType.Extend,
                },
            };
            ArmOperation<SqlVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmName, data);
            SqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineForStorageConfigurationSettingsToNEWDataLogAndTempDBStoragePool()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateSqlVirtualMachineStorageConfigurationNEW.json
            // this example is just showing the usage of "SqlVirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmData data = new SqlVmData(new AzureLocation("northeurope"))
            {
                VirtualMachineResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Compute/virtualMachines/testvm"),
                StorageConfigurationSettings = new SqlVmStorageConfigurationSettings()
                {
                    SqlDataSettings = new SqlStorageSettings()
                    {
                        Luns =
{
0
},
                        DefaultFilePath = "F:\\folderpath\\",
                    },
                    SqlLogSettings = new SqlStorageSettings()
                    {
                        Luns =
{
1
},
                        DefaultFilePath = "G:\\folderpath\\",
                    },
                    SqlTempDBSettings = new SqlTempDBSettings()
                    {
                        DataFileSize = 256,
                        DataGrowth = 512,
                        LogFileSize = 256,
                        LogGrowth = 512,
                        DataFileCount = 8,
                        DefaultFilePath = "D:\\TEMP",
                    },
                    IsSqlSystemDBOnDataDisk = true,
                    DiskConfigurationType = SqlVmDiskConfigurationType.New,
                    StorageWorkloadType = SqlVmStorageWorkloadType.Oltp,
                },
            };
            ArmOperation<SqlVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmName, data);
            SqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineWithMaxParameters()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateSqlVirtualMachineMAX.json
            // this example is just showing the usage of "SqlVirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmData data = new SqlVmData(new AzureLocation("northeurope"))
            {
                VirtualMachineResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Compute/virtualMachines/testvm"),
                SqlServerLicenseType = SqlServerLicenseType.Payg,
                SqlManagement = SqlManagementMode.Full,
                SqlImageSku = SqlImageSku.Enterprise,
                AutoPatchingSettings = new SqlVmAutoPatchingSettings()
                {
                    IsEnabled = true,
                    DayOfWeek = SqlVmAutoPatchingDayOfWeek.Sunday,
                    MaintenanceWindowStartingHour = 2,
                    MaintenanceWindowDurationInMinutes = 60,
                },
                AutoBackupSettings = new SqlVmAutoBackupSettings()
                {
                    IsEnabled = true,
                    IsEncryptionEnabled = true,
                    RetentionPeriodInDays = 17,
                    StorageAccountUri = new Uri("https://teststorage.blob.core.windows.net/"),
                    StorageContainerName = "testcontainer",
                    StorageAccessKey = "<primary storage access key>",
                    Password = "<Password>",
                    AreSystemDbsIncludedInBackup = true,
                    BackupScheduleType = SqVmBackupScheduleType.Manual,
                    FullBackupFrequency = SqlVmFullBackupFrequency.Daily,
                    FullBackupStartHour = 6,
                    FullBackupWindowHours = 11,
                    LogBackupFrequency = 10,
                },
                KeyVaultCredentialSettings = new SqlVmKeyVaultCredentialSettings()
                {
                    IsEnabled = false,
                },
                ServerConfigurationsManagementSettings = new SqlServerConfigurationsManagementSettings()
                {
                    SqlConnectivityUpdateSettings = new SqlConnectivityUpdateSettings()
                    {
                        ConnectivityType = SqlServerConnectivityType.Private,
                        Port = 1433,
                        SqlAuthUpdateUserName = "sqllogin",
                        SqlAuthUpdatePassword = "<password>",
                    },
                    SqlWorkloadType = SqlWorkloadType.Oltp,
                    SqlStorageUpdateSettings = new SqlStorageUpdateSettings()
                    {
                        DiskCount = 1,
                        StartingDeviceId = 2,
                        DiskConfigurationType = SqlVmDiskConfigurationType.New,
                    },
                    IsRServicesEnabled = false,
                    SqlInstanceSettings = new SqlInstanceSettings()
                    {
                        Collation = "SQL_Latin1_General_CP1_CI_AS",
                        MaxDop = 8,
                        IsOptimizeForAdHocWorkloadsEnabled = true,
                        MinServerMemoryInMB = 0,
                        MaxServerMemoryInMB = 128,
                        IsLpimEnabled = true,
                        IsIfiEnabled = true,
                    },
                },
                AssessmentSettings = new SqlVmAssessmentSettings()
                {
                    IsEnabled = true,
                    RunImmediately = true,
                    Schedule = new SqlVmAssessmentSchedule()
                    {
                        IsEnabled = true,
                        WeeklyInterval = 1,
                        MonthlyOccurrence = null,
                        DayOfWeek = SqlVmAssessmentDayOfWeek.Sunday,
                        StartTime = "23:17",
                    },
                },
            };
            ArmOperation<SqlVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmName, data);
            SqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesASQLVirtualMachineWithMinParameters()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/CreateOrUpdateSqlVirtualMachineMIN.json
            // this example is just showing the usage of "SqlVirtualMachines_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation
            string sqlVmName = "testvm";
            SqlVmData data = new SqlVmData(new AzureLocation("northeurope"))
            {
                VirtualMachineResourceId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/testrg/providers/Microsoft.Compute/virtualMachines/testvm"),
            };
            ArmOperation<SqlVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sqlVmName, data);
            SqlVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsAllSQLVirtualMachinesInAResourceGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/ListByResourceGroupSqlVirtualMachine.json
            // this example is just showing the usage of "SqlVirtualMachines_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SqlVmResource
            SqlVmCollection collection = resourceGroupResource.GetSqlVms();

            // invoke the operation and iterate over the result
            await foreach (SqlVmResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlVmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
