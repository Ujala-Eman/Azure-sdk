// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.HDInsight.Samples
{
    public partial class Sample_HDInsightPrivateLinkResourceCollection
    {
        // Get all private link resources in a specific HDInsight cluster.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllPrivateLinkResourcesInASpecificHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2024-08-01-preview/examples/GetAllPrivateLinkResourcesInCluster.json
            // this example is just showing the usage of "PrivateLinkResources_ListByCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightPrivateLinkResource
            HDInsightPrivateLinkResourceCollection collection = hdInsightCluster.GetHDInsightPrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (HDInsightPrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get specific private link resource in a specific HDInsight cluster.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSpecificPrivateLinkResourceInASpecificHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2024-08-01-preview/examples/GetPrivateLinkResource.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightPrivateLinkResource
            HDInsightPrivateLinkResourceCollection collection = hdInsightCluster.GetHDInsightPrivateLinkResources();

            // invoke the operation
            string privateLinkResourceName = "gateway";
            HDInsightPrivateLinkResource result = await collection.GetAsync(privateLinkResourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HDInsightPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get specific private link resource in a specific HDInsight cluster.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetSpecificPrivateLinkResourceInASpecificHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2024-08-01-preview/examples/GetPrivateLinkResource.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightPrivateLinkResource
            HDInsightPrivateLinkResourceCollection collection = hdInsightCluster.GetHDInsightPrivateLinkResources();

            // invoke the operation
            string privateLinkResourceName = "gateway";
            bool result = await collection.ExistsAsync(privateLinkResourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get specific private link resource in a specific HDInsight cluster.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetSpecificPrivateLinkResourceInASpecificHDInsightCluster()
        {
            // Generated from example definition: specification/hdinsight/resource-manager/Microsoft.HDInsight/preview/2024-08-01-preview/examples/GetPrivateLinkResource.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HDInsightClusterResource created on azure
            // for more information of creating HDInsightClusterResource, please refer to the document of HDInsightClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cluster1";
            ResourceIdentifier hdInsightClusterResourceId = HDInsightClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            HDInsightClusterResource hdInsightCluster = client.GetHDInsightClusterResource(hdInsightClusterResourceId);

            // get the collection of this HDInsightPrivateLinkResource
            HDInsightPrivateLinkResourceCollection collection = hdInsightCluster.GetHDInsightPrivateLinkResources();

            // invoke the operation
            string privateLinkResourceName = "gateway";
            NullableResponse<HDInsightPrivateLinkResource> response = await collection.GetIfExistsAsync(privateLinkResourceName);
            HDInsightPrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HDInsightPrivateLinkResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
