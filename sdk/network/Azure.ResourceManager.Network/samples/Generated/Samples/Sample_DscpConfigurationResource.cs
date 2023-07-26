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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_DscpConfigurationResource
    {
        // Create DSCP Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateDSCPConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/DscpConfigurationCreate.json
            // this example is just showing the usage of "DscpConfiguration_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscpConfigurationResource created on azure
            // for more information of creating DscpConfigurationResource, please refer to the document of DscpConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string dscpConfigurationName = "mydscpconfig";
            ResourceIdentifier dscpConfigurationResourceId = DscpConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dscpConfigurationName);
            DscpConfigurationResource dscpConfiguration = client.GetDscpConfigurationResource(dscpConfigurationResourceId);

            // invoke the operation
            DscpConfigurationData data = new DscpConfigurationData()
            {
                QosDefinitionCollection =
{
new DscpQosDefinition()
{
Markings =
{
1
},
SourceIPRanges =
{
new QosIPRange()
{
StartIP = "127.0.0.1",
EndIP = "127.0.0.2",
}
},
DestinationIPRanges =
{
new QosIPRange()
{
StartIP = "127.0.10.1",
EndIP = "127.0.10.2",
}
},
SourcePortRanges =
{
new QosPortRange()
{
Start = 10,
End = 11,
},new QosPortRange()
{
Start = 20,
End = 21,
}
},
DestinationPortRanges =
{
new QosPortRange()
{
Start = 15,
End = 15,
}
},
Protocol = ProtocolType.Tcp,
},new DscpQosDefinition()
{
Markings =
{
2
},
SourceIPRanges =
{
new QosIPRange()
{
StartIP = "12.0.0.1",
EndIP = "12.0.0.2",
}
},
DestinationIPRanges =
{
new QosIPRange()
{
StartIP = "12.0.10.1",
EndIP = "12.0.10.2",
}
},
SourcePortRanges =
{
new QosPortRange()
{
Start = 11,
End = 12,
}
},
DestinationPortRanges =
{
new QosPortRange()
{
Start = 51,
End = 52,
}
},
Protocol = ProtocolType.Udp,
}
},
                Location = new AzureLocation("eastus"),
            };
            ArmOperation<DscpConfigurationResource> lro = await dscpConfiguration.UpdateAsync(WaitUntil.Completed, data);
            DscpConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscpConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete DSCP Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDSCPConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/DscpConfigurationDelete.json
            // this example is just showing the usage of "DscpConfiguration_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscpConfigurationResource created on azure
            // for more information of creating DscpConfigurationResource, please refer to the document of DscpConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string dscpConfigurationName = "mydscpConfig";
            ResourceIdentifier dscpConfigurationResourceId = DscpConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dscpConfigurationName);
            DscpConfigurationResource dscpConfiguration = client.GetDscpConfigurationResource(dscpConfigurationResourceId);

            // invoke the operation
            await dscpConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Dscp Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDscpConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/DscpConfigurationGet.json
            // this example is just showing the usage of "DscpConfiguration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DscpConfigurationResource created on azure
            // for more information of creating DscpConfigurationResource, please refer to the document of DscpConfigurationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string dscpConfigurationName = "mydscpConfig";
            ResourceIdentifier dscpConfigurationResourceId = DscpConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, dscpConfigurationName);
            DscpConfigurationResource dscpConfiguration = client.GetDscpConfigurationResource(dscpConfigurationResourceId);

            // invoke the operation
            DscpConfigurationResource result = await dscpConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DscpConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all network interfaces
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDscpConfigurations_ListAllNetworkInterfaces()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/DscpConfigurationListAll.json
            // this example is just showing the usage of "DscpConfiguration_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DscpConfigurationResource item in subscriptionResource.GetDscpConfigurationsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DscpConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
