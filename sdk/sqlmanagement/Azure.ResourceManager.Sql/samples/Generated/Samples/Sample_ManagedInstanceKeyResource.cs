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
    public partial class Sample_ManagedInstanceKeyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyGet.json
            // this example is just showing the usage of "ManagedInstanceKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceKeyResource created on azure
            // for more information of creating ManagedInstanceKeyResource, please refer to the document of ManagedInstanceKeyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ResourceIdentifier managedInstanceKeyResourceId = ManagedInstanceKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, keyName);
            ManagedInstanceKeyResource managedInstanceKey = client.GetManagedInstanceKeyResource(managedInstanceKeyResourceId);

            // invoke the operation
            ManagedInstanceKeyResource result = await managedInstanceKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteTheManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyDelete.json
            // this example is just showing the usage of "ManagedInstanceKeys_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceKeyResource created on azure
            // for more information of creating ManagedInstanceKeyResource, please refer to the document of ManagedInstanceKeyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ResourceIdentifier managedInstanceKeyResourceId = ManagedInstanceKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, keyName);
            ManagedInstanceKeyResource managedInstanceKey = client.GetManagedInstanceKeyResource(managedInstanceKeyResourceId);

            // invoke the operation
            await managedInstanceKey.DeleteAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesOrUpdatesAManagedInstanceKey()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceKeyCreateOrUpdate.json
            // this example is just showing the usage of "ManagedInstanceKeys_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceKeyResource created on azure
            // for more information of creating ManagedInstanceKeyResource, please refer to the document of ManagedInstanceKeyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string managedInstanceName = "sqlcrudtest-4645";
            string keyName = "someVault_someKey_01234567890123456789012345678901";
            ResourceIdentifier managedInstanceKeyResourceId = ManagedInstanceKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, keyName);
            ManagedInstanceKeyResource managedInstanceKey = client.GetManagedInstanceKeyResource(managedInstanceKeyResourceId);

            // invoke the operation
            ManagedInstanceKeyData data = new ManagedInstanceKeyData
            {
                ServerKeyType = SqlServerKeyType.AzureKeyVault,
                Uri = new Uri("https://someVault.vault.azure.net/keys/someKey/01234567890123456789012345678901"),
            };
            ArmOperation<ManagedInstanceKeyResource> lro = await managedInstanceKey.UpdateAsync(WaitUntil.Completed, data);
            ManagedInstanceKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
