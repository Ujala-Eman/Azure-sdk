// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Batch.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_BatchAccountCertificateCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCertificates()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateList.json
            // this example is just showing the usage of "Certificate_ListByBatchAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation and iterate over the result
            await foreach (BatchAccountCertificateResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchAccountCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCertificatesFilterAndSelect()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateListWithFilter.json
            // this example is just showing the usage of "Certificate_ListByBatchAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation and iterate over the result
            string select = "properties/format,properties/provisioningState";
            string filter = "properties/provisioningStateTransitionTime gt '2017-05-01' or properties/provisioningState eq 'Failed'";
            await foreach (BatchAccountCertificateResource item in collection.GetAllAsync(select: select, filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchAccountCertificateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateCertificateFull()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateCreate_Full.json
            // this example is just showing the usage of "Certificate_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            BatchAccountCertificateCreateOrUpdateContent content = new BatchAccountCertificateCreateOrUpdateContent()
            {
                ThumbprintAlgorithm = "sha1",
                ThumbprintString = "0a0e4f50d51beadeac1d35afc5116098e7902e6e",
                Format = BatchAccountCertificateFormat.Pfx,
                Data = BinaryData.FromString("\"MIIJsgIBAzCCCW4GCSqGSIb3DQE...\""),
                Password = "<ExamplePassword>",
            };
            ArmOperation<BatchAccountCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, content);
            BatchAccountCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateCertificateMinimalCer()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateCreate_MinimalCer.json
            // this example is just showing the usage of "Certificate_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            BatchAccountCertificateCreateOrUpdateContent content = new BatchAccountCertificateCreateOrUpdateContent()
            {
                Format = BatchAccountCertificateFormat.Cer,
                Data = BinaryData.FromString("\"MIICrjCCAZagAwI...\""),
            };
            ArmOperation<BatchAccountCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, content);
            BatchAccountCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateCertificateMinimalPfx()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateCreate_Minimal.json
            // this example is just showing the usage of "Certificate_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            BatchAccountCertificateCreateOrUpdateContent content = new BatchAccountCertificateCreateOrUpdateContent()
            {
                Data = BinaryData.FromString("\"MIIJsgIBAzCCCW4GCSqGSIb3DQE...\""),
                Password = "<ExamplePassword>",
            };
            ArmOperation<BatchAccountCertificateResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, content);
            BatchAccountCertificateResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCertificate()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateGet.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            BatchAccountCertificateResource result = await collection.GetAsync(certificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCertificate()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateGet.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            bool result = await collection.ExistsAsync(certificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCertificate()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateGet.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            NullableResponse<BatchAccountCertificateResource> response = await collection.GetIfExistsAsync(certificateName);
            BatchAccountCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchAccountCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetCertificateWithDeletionError()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateGetWithDeletionError.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            BatchAccountCertificateResource result = await collection.GetAsync(certificateName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetCertificateWithDeletionError()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateGetWithDeletionError.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            bool result = await collection.ExistsAsync(certificateName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetCertificateWithDeletionError()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/CertificateGetWithDeletionError.json
            // this example is just showing the usage of "Certificate_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this BatchAccountCertificateResource
            BatchAccountCertificateCollection collection = batchAccount.GetBatchAccountCertificates();

            // invoke the operation
            string certificateName = "sha1-0a0e4f50d51beadeac1d35afc5116098e7902e6e";
            NullableResponse<BatchAccountCertificateResource> response = await collection.GetIfExistsAsync(certificateName);
            BatchAccountCertificateResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchAccountCertificateData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
