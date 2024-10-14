// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridCompute.Models;

namespace Azure.ResourceManager.HybridCompute.Samples
{
    public partial class Sample_LicenseProfileResource
    {
        // Create or Update a License Profile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateALicenseProfile()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/licenseProfile/LicenseProfile_CreateOrUpdate.json
            // this example is just showing the usage of "LicenseProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LicenseProfileResource created on azure
            // for more information of creating LicenseProfileResource, please refer to the document of LicenseProfileResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier licenseProfileResourceId = LicenseProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            LicenseProfileResource licenseProfile = client.GetLicenseProfileResource(licenseProfileResourceId);

            // invoke the operation
            LicenseProfileData data = new LicenseProfileData(new AzureLocation("eastus2euap"))
            {
                SubscriptionStatus = LicenseProfileSubscriptionStatus.Enabled,
                ProductType = LicenseProfileProductType.WindowsServer,
                ProductFeatures =
{
new HybridComputeProductFeature()
{
Name = "Hotpatch",
SubscriptionStatus = LicenseProfileSubscriptionStatus.Enabled,
}
},
                AssignedLicense = "{LicenseResourceId}",
                SoftwareAssuranceCustomer = true,
            };
            ArmOperation<LicenseProfileResource> lro = await licenseProfile.CreateOrUpdateAsync(WaitUntil.Completed, data);
            LicenseProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LicenseProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a License Profile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateALicenseProfile()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/licenseProfile/LicenseProfile_Update.json
            // this example is just showing the usage of "LicenseProfiles_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LicenseProfileResource created on azure
            // for more information of creating LicenseProfileResource, please refer to the document of LicenseProfileResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier licenseProfileResourceId = LicenseProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            LicenseProfileResource licenseProfile = client.GetLicenseProfileResource(licenseProfileResourceId);

            // invoke the operation
            LicenseProfilePatch patch = new LicenseProfilePatch()
            {
                SubscriptionStatus = LicenseProfileSubscriptionStatusUpdate.Enable,
                ProductType = LicenseProfileProductType.WindowsServer,
                ProductFeatures =
{
new ProductFeatureUpdate()
{
Name = "Hotpatch",
SubscriptionStatus = LicenseProfileSubscriptionStatusUpdate.Enable,
}
},
                AssignedLicense = "{LicenseResourceId}",
                SoftwareAssuranceCustomer = true,
            };
            ArmOperation<LicenseProfileResource> lro = await licenseProfile.UpdateAsync(WaitUntil.Completed, patch);
            LicenseProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LicenseProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get License Profile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetLicenseProfile()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/licenseProfile/LicenseProfile_Get.json
            // this example is just showing the usage of "LicenseProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LicenseProfileResource created on azure
            // for more information of creating LicenseProfileResource, please refer to the document of LicenseProfileResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier licenseProfileResourceId = LicenseProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            LicenseProfileResource licenseProfile = client.GetLicenseProfileResource(licenseProfileResourceId);

            // invoke the operation
            LicenseProfileResource result = await licenseProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LicenseProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a License Profile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteALicenseProfile()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/stable/2024-07-10/examples/licenseProfile/LicenseProfile_Delete.json
            // this example is just showing the usage of "LicenseProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LicenseProfileResource created on azure
            // for more information of creating LicenseProfileResource, please refer to the document of LicenseProfileResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier licenseProfileResourceId = LicenseProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            LicenseProfileResource licenseProfile = client.GetLicenseProfileResource(licenseProfileResourceId);

            // invoke the operation
            await licenseProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
