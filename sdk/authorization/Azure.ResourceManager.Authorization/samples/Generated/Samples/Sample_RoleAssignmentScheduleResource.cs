// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Samples
{
    public partial class Sample_RoleAssignmentScheduleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRoleAssignmentScheduleByName()
        {
            // Generated from example definition: specification/authorization/resource-manager/Microsoft.Authorization/stable/2020-10-01/examples/GetRoleAssignmentScheduleByName.json
            // this example is just showing the usage of "RoleAssignmentSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentScheduleResource created on azure
            // for more information of creating RoleAssignmentScheduleResource, please refer to the document of RoleAssignmentScheduleResource
            string scope = "providers/Microsoft.Subscription/subscriptions/dfa2a084-766f-4003-8ae1-c4aeb893a99f";
            string roleAssignmentScheduleName = "c9e264ff-3133-4776-a81a-ebc7c33c8ec6";
            ResourceIdentifier roleAssignmentScheduleResourceId = RoleAssignmentScheduleResource.CreateResourceIdentifier(scope, roleAssignmentScheduleName);
            RoleAssignmentScheduleResource roleAssignmentSchedule = client.GetRoleAssignmentScheduleResource(roleAssignmentScheduleResourceId);

            // invoke the operation
            RoleAssignmentScheduleResource result = await roleAssignmentSchedule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
