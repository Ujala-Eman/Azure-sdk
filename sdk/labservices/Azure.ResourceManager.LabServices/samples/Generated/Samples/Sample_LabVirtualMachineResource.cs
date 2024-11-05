// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.LabServices.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.LabServices.Samples
{
    public partial class Sample_LabVirtualMachineResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualMachine()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/VirtualMachines/getVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineResource created on azure
            // for more information of creating LabVirtualMachineResource, please refer to the document of LabVirtualMachineResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            string virtualMachineName = "template";
            ResourceIdentifier labVirtualMachineResourceId = LabVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, virtualMachineName);
            LabVirtualMachineResource labVirtualMachine = client.GetLabVirtualMachineResource(labVirtualMachineResourceId);

            // invoke the operation
            LabVirtualMachineResource result = await labVirtualMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LabVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_StartVirtualMachine()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/VirtualMachines/startVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineResource created on azure
            // for more information of creating LabVirtualMachineResource, please refer to the document of LabVirtualMachineResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            string virtualMachineName = "template";
            ResourceIdentifier labVirtualMachineResourceId = LabVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, virtualMachineName);
            LabVirtualMachineResource labVirtualMachine = client.GetLabVirtualMachineResource(labVirtualMachineResourceId);

            // invoke the operation
            await labVirtualMachine.StartAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopVirtualMachine()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/VirtualMachines/stopVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineResource created on azure
            // for more information of creating LabVirtualMachineResource, please refer to the document of LabVirtualMachineResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            string virtualMachineName = "template";
            ResourceIdentifier labVirtualMachineResourceId = LabVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, virtualMachineName);
            LabVirtualMachineResource labVirtualMachine = client.GetLabVirtualMachineResource(labVirtualMachineResourceId);

            // invoke the operation
            await labVirtualMachine.StopAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Reimage_ReimageVirtualMachine()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/VirtualMachines/reimageVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Reimage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineResource created on azure
            // for more information of creating LabVirtualMachineResource, please refer to the document of LabVirtualMachineResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            string virtualMachineName = "template";
            ResourceIdentifier labVirtualMachineResourceId = LabVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, virtualMachineName);
            LabVirtualMachineResource labVirtualMachine = client.GetLabVirtualMachineResource(labVirtualMachineResourceId);

            // invoke the operation
            await labVirtualMachine.ReimageAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Redeploy_RedeployVirtualMachine()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/VirtualMachines/redeployVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Redeploy" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineResource created on azure
            // for more information of creating LabVirtualMachineResource, please refer to the document of LabVirtualMachineResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            string virtualMachineName = "template";
            ResourceIdentifier labVirtualMachineResourceId = LabVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, virtualMachineName);
            LabVirtualMachineResource labVirtualMachine = client.GetLabVirtualMachineResource(labVirtualMachineResourceId);

            // invoke the operation
            await labVirtualMachine.RedeployAsync(WaitUntil.Completed).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResetPassword_ResetPasswordVirtualMachine()
        {
            // Generated from example definition: specification/labservices/resource-manager/Microsoft.LabServices/stable/2022-08-01/examples/VirtualMachines/resetPasswordVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_ResetPassword" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LabVirtualMachineResource created on azure
            // for more information of creating LabVirtualMachineResource, please refer to the document of LabVirtualMachineResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string labName = "testlab";
            string virtualMachineName = "template";
            ResourceIdentifier labVirtualMachineResourceId = LabVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, virtualMachineName);
            LabVirtualMachineResource labVirtualMachine = client.GetLabVirtualMachineResource(labVirtualMachineResourceId);

            // invoke the operation
            LabVirtualMachineResetPasswordContent content = new LabVirtualMachineResetPasswordContent("example-username", "example-password");
            await labVirtualMachine.ResetPasswordAsync(WaitUntil.Completed, content).ConfigureAwait(false);

            Console.WriteLine("Succeeded");
        }
    }
}
