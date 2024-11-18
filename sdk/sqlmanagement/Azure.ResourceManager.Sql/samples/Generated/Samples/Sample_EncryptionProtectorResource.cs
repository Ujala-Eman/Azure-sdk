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
    public partial class Sample_EncryptionProtectorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheEncryptionProtector()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/EncryptionProtectorGet.json
            // this example is just showing the usage of "EncryptionProtectors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EncryptionProtectorResource created on azure
            // for more information of creating EncryptionProtectorResource, please refer to the document of EncryptionProtectorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-4645";
            EncryptionProtectorName encryptionProtectorName = EncryptionProtectorName.Current;
            ResourceIdentifier encryptionProtectorResourceId = EncryptionProtectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, encryptionProtectorName);
            EncryptionProtectorResource encryptionProtector = client.GetEncryptionProtectorResource(encryptionProtectorResourceId);

            // invoke the operation
            EncryptionProtectorResource result = await encryptionProtector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EncryptionProtectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateTheEncryptionProtectorToKeyVault()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/EncryptionProtectorCreateOrUpdateKeyVault.json
            // this example is just showing the usage of "EncryptionProtectors_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EncryptionProtectorResource created on azure
            // for more information of creating EncryptionProtectorResource, please refer to the document of EncryptionProtectorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-4645";
            EncryptionProtectorName encryptionProtectorName = EncryptionProtectorName.Current;
            ResourceIdentifier encryptionProtectorResourceId = EncryptionProtectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, encryptionProtectorName);
            EncryptionProtectorResource encryptionProtector = client.GetEncryptionProtectorResource(encryptionProtectorResourceId);

            // invoke the operation
            EncryptionProtectorData data = new EncryptionProtectorData()
            {
                ServerKeyName = "someVault_someKey_01234567890123456789012345678901",
                ServerKeyType = SqlServerKeyType.AzureKeyVault,
                IsAutoRotationEnabled = false,
            };
            ArmOperation<EncryptionProtectorResource> lro = await encryptionProtector.UpdateAsync(WaitUntil.Completed, data);
            EncryptionProtectorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EncryptionProtectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateTheEncryptionProtectorToServiceManaged()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/EncryptionProtectorCreateOrUpdateServiceManaged.json
            // this example is just showing the usage of "EncryptionProtectors_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EncryptionProtectorResource created on azure
            // for more information of creating EncryptionProtectorResource, please refer to the document of EncryptionProtectorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-4645";
            EncryptionProtectorName encryptionProtectorName = EncryptionProtectorName.Current;
            ResourceIdentifier encryptionProtectorResourceId = EncryptionProtectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, encryptionProtectorName);
            EncryptionProtectorResource encryptionProtector = client.GetEncryptionProtectorResource(encryptionProtectorResourceId);

            // invoke the operation
            EncryptionProtectorData data = new EncryptionProtectorData()
            {
                ServerKeyName = "ServiceManaged",
                ServerKeyType = SqlServerKeyType.ServiceManaged,
            };
            ArmOperation<EncryptionProtectorResource> lro = await encryptionProtector.UpdateAsync(WaitUntil.Completed, data);
            EncryptionProtectorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EncryptionProtectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Revalidate_RevalidatesTheEncryptionProtector()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/EncryptionProtectorRevalidate.json
            // this example is just showing the usage of "EncryptionProtectors_Revalidate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EncryptionProtectorResource created on azure
            // for more information of creating EncryptionProtectorResource, please refer to the document of EncryptionProtectorResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-7398";
            string serverName = "sqlcrudtest-4645";
            EncryptionProtectorName encryptionProtectorName = EncryptionProtectorName.Current;
            ResourceIdentifier encryptionProtectorResourceId = EncryptionProtectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, encryptionProtectorName);
            EncryptionProtectorResource encryptionProtector = client.GetEncryptionProtectorResource(encryptionProtectorResourceId);

            // invoke the operation
            await encryptionProtector.RevalidateAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
