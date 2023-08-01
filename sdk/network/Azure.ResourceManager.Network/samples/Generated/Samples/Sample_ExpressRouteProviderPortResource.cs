// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteProviderPortResource
    {
        // Check Dns Name Availability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckDnsNameAvailability_CheckDnsNameAvailability()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/CheckDnsNameAvailability.json
            // this example is just showing the usage of "CheckDnsNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            string domainNameLabel = "testdns";
            DnsNameAvailabilityResult result = await subscriptionResource.CheckDnsNameAvailabilityAsync(location, domainNameLabel);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ExpressRouteProviderPort
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ExpressRouteProviderPort()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/expressRouteProviderPort.json
            // this example is just showing the usage of "ExpressRouteProviderPort" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteProviderPortResource created on azure
            // for more information of creating ExpressRouteProviderPortResource, please refer to the document of ExpressRouteProviderPortResource
            string subscriptionId = "subid";
            string providerport = "abc";
            ResourceIdentifier expressRouteProviderPortResourceId = ExpressRouteProviderPortResource.CreateResourceIdentifier(subscriptionId, providerport);
            ExpressRouteProviderPortResource expressRouteProviderPort = client.GetExpressRouteProviderPortResource(expressRouteProviderPortResourceId);

            // invoke the operation
            ExpressRouteProviderPortResource result = await expressRouteProviderPort.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteProviderPortData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
