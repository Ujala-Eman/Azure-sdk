// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ResourceMover.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ResourceMover.Samples
{
    public partial class Sample_TenantResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetOperationsDiscoveries_OperationsDiscoveryGet()
        {
            // Generated from example definition: specification/resourcemover/resource-manager/Microsoft.Migrate/stable/2023-08-01/examples/OperationsDiscovery_Get.json
            // this example is just showing the usage of "OperationsDiscovery_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation and iterate over the result
            await foreach (MoverOperationsDiscovery item in tenantResource.GetOperationsDiscoveriesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
