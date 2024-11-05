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
    public partial class Sample_ManagedInstanceAzureADOnlyAuthenticationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesAzureActiveDirectoryOnlyAuthenticationObject()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceAzureADOnlyAuthCreateOrUpdate.json
            // this example is just showing the usage of "ManagedInstanceAzureADOnlyAuthentications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "managedInstance";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceAzureADOnlyAuthenticationResource
            ManagedInstanceAzureADOnlyAuthenticationCollection collection = managedInstance.GetManagedInstanceAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            ManagedInstanceAzureADOnlyAuthenticationData data = new ManagedInstanceAzureADOnlyAuthenticationData
            {
                IsAzureADOnlyAuthenticationEnabled = false,
            };
            ArmOperation<ManagedInstanceAzureADOnlyAuthenticationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authenticationName, data);
            ManagedInstanceAzureADOnlyAuthenticationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceAzureADOnlyAuthenticationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAAzureActiveDirectoryOnlyAuthenticationProperty()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceAzureADOnlyAuthGet.json
            // this example is just showing the usage of "ManagedInstanceAzureADOnlyAuthentications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "managedInstance";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceAzureADOnlyAuthenticationResource
            ManagedInstanceAzureADOnlyAuthenticationCollection collection = managedInstance.GetManagedInstanceAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            ManagedInstanceAzureADOnlyAuthenticationResource result = await collection.GetAsync(authenticationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceAzureADOnlyAuthenticationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsAListOfAzureActiveDirectoryOnlyAuthenticationObject()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceAzureADOnlyAuthListByInstance.json
            // this example is just showing the usage of "ManagedInstanceAzureADOnlyAuthentications_ListByInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "managedInstance";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceAzureADOnlyAuthenticationResource
            ManagedInstanceAzureADOnlyAuthenticationCollection collection = managedInstance.GetManagedInstanceAzureADOnlyAuthentications();

            // invoke the operation and iterate over the result
            await foreach (ManagedInstanceAzureADOnlyAuthenticationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstanceAzureADOnlyAuthenticationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAAzureActiveDirectoryOnlyAuthenticationProperty()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceAzureADOnlyAuthGet.json
            // this example is just showing the usage of "ManagedInstanceAzureADOnlyAuthentications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "managedInstance";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceAzureADOnlyAuthenticationResource
            ManagedInstanceAzureADOnlyAuthenticationCollection collection = managedInstance.GetManagedInstanceAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            bool result = await collection.ExistsAsync(authenticationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAAzureActiveDirectoryOnlyAuthenticationProperty()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedInstanceAzureADOnlyAuthGet.json
            // this example is just showing the usage of "ManagedInstanceAzureADOnlyAuthentications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "managedInstance";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceAzureADOnlyAuthenticationResource
            ManagedInstanceAzureADOnlyAuthenticationCollection collection = managedInstance.GetManagedInstanceAzureADOnlyAuthentications();

            // invoke the operation
            AuthenticationName authenticationName = AuthenticationName.Default;
            NullableResponse<ManagedInstanceAzureADOnlyAuthenticationResource> response = await collection.GetIfExistsAsync(authenticationName);
            ManagedInstanceAzureADOnlyAuthenticationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstanceAzureADOnlyAuthenticationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
