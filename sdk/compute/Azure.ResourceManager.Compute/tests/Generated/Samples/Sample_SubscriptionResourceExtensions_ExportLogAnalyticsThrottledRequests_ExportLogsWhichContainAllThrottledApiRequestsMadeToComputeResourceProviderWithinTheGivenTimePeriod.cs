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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_SubscriptionResourceExtensions_ExportLogAnalyticsThrottledRequests_ExportLogsWhichContainAllThrottledApiRequestsMadeToComputeResourceProviderWithinTheGivenTimePeriod
    {
        // Export logs which contain all throttled Api requests made to Compute Resource Provider within the given time period.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExportLogAnalyticsThrottledRequests()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "LogAnalytics_ExportThrottledRequests" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            Compute.Models.ThrottledRequestsContent content = new ThrottledRequestsContent(new Uri("https://somesasuri"), DateTimeOffset.Parse("2018-01-21T01:54:06.862601Z"), DateTimeOffset.Parse("2018-01-23T01:54:06.862601Z"))
            {
                GroupByOperationName = true,
                GroupByResourceName = false,
                GroupByClientApplicationId = false,
                GroupByUserAgent = false,
            };
            ArmOperation<Compute.Models.LogAnalytics> lro = await subscriptionResource.ExportLogAnalyticsThrottledRequestsAsync(WaitUntil.Completed, location, content);
            Compute.Models.LogAnalytics result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
