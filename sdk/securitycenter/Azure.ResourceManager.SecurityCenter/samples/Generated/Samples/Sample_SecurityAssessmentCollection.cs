// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityAssessmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateSecurityRecommendationTaskOnAResource()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/PutAssessment_example.json
            // this example is just showing the usage of "Assessments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "8bb8be0a-6010-4789-812f-e4d661c4ed0e";
            SecurityAssessmentCreateOrUpdateContent content = new SecurityAssessmentCreateOrUpdateContent
            {
                ResourceDetails = new AzureResourceDetails(),
                Status = new SecurityAssessmentStatus(SecurityAssessmentStatusCode.Healthy),
            };
            ArmOperation<SecurityAssessmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assessmentName, content);
            SecurityAssessmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAssessmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSecurityRecommendationTaskFromSecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/GetAssessment_example.json
            // this example is just showing the usage of "Assessments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "21300918-b2e3-0346-785f-c77ff57d243b";
            SecurityAssessmentResource result = await collection.GetAsync(assessmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAssessmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSecurityRecommendationTaskFromSecurityDataLocationWithExpandParameter()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/GetAssessmentWithExpand_example.json
            // this example is just showing the usage of "Assessments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "21300918-b2e3-0346-785f-c77ff57d243b";
            SecurityAssessmentODataExpand? expand = SecurityAssessmentODataExpand.Links;
            SecurityAssessmentResource result = await collection.GetAsync(assessmentName, expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAssessmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetSecurityRecommendationTaskFromSecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/GetAssessment_example.json
            // this example is just showing the usage of "Assessments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "21300918-b2e3-0346-785f-c77ff57d243b";
            bool result = await collection.ExistsAsync(assessmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetSecurityRecommendationTaskFromSecurityDataLocationWithExpandParameter()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/GetAssessmentWithExpand_example.json
            // this example is just showing the usage of "Assessments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "21300918-b2e3-0346-785f-c77ff57d243b";
            SecurityAssessmentODataExpand? expand = SecurityAssessmentODataExpand.Links;
            bool result = await collection.ExistsAsync(assessmentName, expand);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetSecurityRecommendationTaskFromSecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/GetAssessment_example.json
            // this example is just showing the usage of "Assessments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "21300918-b2e3-0346-785f-c77ff57d243b";
            NullableResponse<SecurityAssessmentResource> response = await collection.GetIfExistsAsync(assessmentName);
            SecurityAssessmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityAssessmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetSecurityRecommendationTaskFromSecurityDataLocationWithExpandParameter()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2021-06-01/examples/Assessments/GetAssessmentWithExpand_example.json
            // this example is just showing the usage of "Assessments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this SecurityAssessmentResource
            string resourceId = "subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.Compute/virtualMachineScaleSets/vmss2";
            SecurityAssessmentCollection collection = client.GetSecurityAssessments(new ResourceIdentifier(resourceId));

            // invoke the operation
            string assessmentName = "21300918-b2e3-0346-785f-c77ff57d243b";
            SecurityAssessmentODataExpand? expand = SecurityAssessmentODataExpand.Links;
            NullableResponse<SecurityAssessmentResource> response = await collection.GetIfExistsAsync(assessmentName, expand);
            SecurityAssessmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityAssessmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
