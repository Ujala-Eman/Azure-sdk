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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_DiskImageCollection
    {
        // Create a virtual machine image from a blob with DiskEncryptionSet resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromABlobWithDiskEncryptionSetResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromABlobWithDiskEncryptionSet.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        BlobUri = new Uri("https://mystorageaccount.blob.core.windows.net/osimages/osimage.vhd"),
                        DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/{existing-diskEncryptionSet-name}"),
                    },
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image from a blob.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromABlob()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromABlob.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        BlobUri = new Uri("https://mystorageaccount.blob.core.windows.net/osimages/osimage.vhd"),
                    },
                    ZoneResilient = true,
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image from a managed disk with DiskEncryptionSet resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromAManagedDiskWithDiskEncryptionSetResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromAManagedDiskWithDiskEncryptionSet.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        SnapshotId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot"),
                        DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/{existing-diskEncryptionSet-name}"),
                    },
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image from a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromAManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromAManagedDisk.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        ManagedDiskId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/myManagedDisk"),
                    },
                    ZoneResilient = true,
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image from a snapshot with DiskEncryptionSet resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromASnapshotWithDiskEncryptionSetResource()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromASnapshotWithDiskEncryptionSet.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        ManagedDiskId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/myManagedDisk"),
                        DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSets/{existing-diskEncryptionSet-name}"),
                    },
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image from a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromASnapshot.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        SnapshotId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot"),
                    },
                    ZoneResilient = false,
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image from an existing virtual machine.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageFromAnExistingVirtualMachine()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_CreateFromAVM.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                SourceVirtualMachineId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVM"),
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image that includes a data disk from a blob.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageThatIncludesADataDiskFromABlob()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_Create_DataDiskFromABlobIncluded.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        BlobUri = new Uri("https://mystorageaccount.blob.core.windows.net/osimages/osimage.vhd"),
                    },
                    DataDisks =
{
new ImageDataDisk(1)
{
BlobUri = new Uri("https://mystorageaccount.blob.core.windows.net/dataimages/dataimage.vhd"),
}
},
                    ZoneResilient = false,
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image that includes a data disk from a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageThatIncludesADataDiskFromAManagedDisk()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_Create_DataDiskFromAManagedDiskIncluded.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        ManagedDiskId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/myManagedDisk"),
                    },
                    DataDisks =
{
new ImageDataDisk(1)
{
ManagedDiskId = new ResourceIdentifier("subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/myManagedDisk2"),
}
},
                    ZoneResilient = false,
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a virtual machine image that includes a data disk from a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAVirtualMachineImageThatIncludesADataDiskFromASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_Create_DataDiskFromASnapshotIncluded.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        SnapshotId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot"),
                    },
                    DataDisks =
{
new ImageDataDisk(1)
{
SnapshotId = new ResourceIdentifier("subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot2"),
}
},
                    ZoneResilient = true,
                },
            };
            ArmOperation<DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a virtual machine image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutAVirtualMachineImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_Get.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            DiskImageResource result = await collection.GetAsync(imageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a virtual machine image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetInformationAboutAVirtualMachineImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_Get.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            bool result = await collection.ExistsAsync(imageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List all virtual machine images in a resource group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllVirtualMachineImagesInAResourceGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/imageExamples/Image_ListByResourceGroup.json
            // this example is just showing the usage of "Images_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation and iterate over the result
            await foreach (DiskImageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiskImageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
