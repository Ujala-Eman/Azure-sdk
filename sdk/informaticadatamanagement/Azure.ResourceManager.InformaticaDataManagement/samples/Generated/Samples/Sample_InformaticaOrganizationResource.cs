// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.InformaticaDataManagement.Models;

namespace Azure.ResourceManager.InformaticaDataManagement.Samples
{
    public partial class Sample_InformaticaOrganizationResource
    {
        // Organizations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_OrganizationsGet()
        {
            // Generated from example definition: 2024-05-08/Organizations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "InformaticaOrganizationResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "Sg";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            InformaticaOrganizationResource result = await informaticaOrganization.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InformaticaOrganizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Organizations_Get_Min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_OrganizationsGetMin()
        {
            // Generated from example definition: 2024-05-08/Organizations_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "InformaticaOrganizationResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "q";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            InformaticaOrganizationResource result = await informaticaOrganization.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InformaticaOrganizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Organizations_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_OrganizationsUpdate()
        {
            // Generated from example definition: 2024-05-08/Organizations_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "InformaticaOrganizationResource_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "_-";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            InformaticaOrganizationPatch patch = new InformaticaOrganizationPatch()
            {
                Tags =
{
["key1918"] = "fbjvtuvzsghpl",
},
                Properties = new InformaticaOrganizationPropertiesUpdate()
                {
                    MarketplaceDetails = new InformaticaMarketplaceDetailsUpdate()
                    {
                        MarketplaceSubscriptionId = "szhyxzgjtssjmlguivepc",
                        OfferDetails = new InformaticaOfferDetailsUpdate()
                        {
                            PublisherId = "ktzfghsyjqbsswhltoaemgotmnorhdogvkaxplutbjjqzuepxizliynyakersobagvpwvpzwjtjjxigsqgcyqaahaxdijghnexliofhfjlqzjmmbvrhcvjxdodnexxizbgfhjopbwzjojxsluasnwwsgcajefglbcvzpaeblanhmurcculndtfwnfjyxol",
                            OfferId = "idaxbflabvjsippplyenvrpgeydsjxcmyubgukffkcdvlvrtwpdhnvdblxjsldiuswrchsibk",
                            PlanId = "giihvvnwdwzkfqrhkpqzbgfotzyixnsvmxzauseebillhslauglzfxzvzvts",
                            PlanName = "tfqjenotaewzdeerliteqxdawuqxhwdzbtiiimsaedrlsnbdoonnloakjtvnwhhrcyxxsgoachguthqvlahpjyofpoqpfacfmiaauawazkmxkjgvktbptojknzojtjrfzvbbjjkvstabqyaczxinijhoxrjukftsagpwgsvpmczopztmplipyufhuaumfx",
                            TermUnit = "nykqoplazujcwmfldntifjqrnx",
                            TermId = "eolmwogtgpdncqoigqcdomupwummaicwvdxgbskpdsmjizdfbdgbxbuekcpwmenqzbhqxpdnjtup",
                        },
                    },
                    UserDetails = new InformaticaUserDetailsUpdate()
                    {
                        FirstName = "qguqrmanyupoi",
                        LastName = "ugzg",
                        EmailAddress = "7_-46@13D--3.m-4x-.11.c-9-.DHLYFc",
                        Upn = "viwjrkn",
                        PhoneNumber = "uxa",
                    },
                    CompanyDetails = new InformaticaCompanyDetailsUpdate()
                    {
                        CompanyName = "xkrvbozrjcvappqeeyt",
                        OfficeAddress = "sfcx",
                        Country = "rvlzppgvopcw",
                        Domain = "dponvwnrdrnzahcurqssesukbsokdd",
                        Business = "mwqblnruflwpolgbxpqbqneve",
                        NumberOfEmployees = 22,
                    },
                    ExistingResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Informatica.DataManagement/organizations/org1/serverlessRuntimes/serverlessRuntimeName"),
                },
            };
            InformaticaOrganizationResource result = await informaticaOrganization.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InformaticaOrganizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Organizations_Update_Min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_OrganizationsUpdateMin()
        {
            // Generated from example definition: 2024-05-08/Organizations_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "InformaticaOrganizationResource_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "-";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            InformaticaOrganizationPatch patch = new InformaticaOrganizationPatch();
            InformaticaOrganizationResource result = await informaticaOrganization.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InformaticaOrganizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Organizations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_OrganizationsDelete()
        {
            // Generated from example definition: 2024-05-08/Organizations_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "InformaticaOrganizationResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "_";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            await informaticaOrganization.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Organizations_Delete_Min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_OrganizationsDeleteMin()
        {
            // Generated from example definition: 2024-05-08/Organizations_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "InformaticaOrganizationResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "_-";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            await informaticaOrganization.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Organizations_GetServerlessMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetServerlessMetadata_OrganizationsGetServerlessMetadata()
        {
            // Generated from example definition: 2024-05-08/Organizations_GetServerlessMetadata_MaximumSet_Gen.json
            // this example is just showing the usage of "Organizations_GetServerlessMetadata" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "3_UC";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            ServerlessMetadataResponse result = await informaticaOrganization.GetServerlessMetadataAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Organizations_GetServerlessMetadata_Min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetServerlessMetadata_OrganizationsGetServerlessMetadataMin()
        {
            // Generated from example definition: 2024-05-08/Organizations_GetServerlessMetadata_MinimumSet_Gen.json
            // this example is just showing the usage of "Organizations_GetServerlessMetadata" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "A";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            ServerlessMetadataResponse result = await informaticaOrganization.GetServerlessMetadataAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Organizations_GetAllServerlessRuntimes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllServerlessRuntimes_OrganizationsGetAllServerlessRuntimes()
        {
            // Generated from example definition: 2024-05-08/Organizations_GetAllServerlessRuntimes_MaximumSet_Gen.json
            // this example is just showing the usage of "Organizations_GetAllServerlessRuntimes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "t";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            InformaticaServerlessRuntimeResourceList result = await informaticaOrganization.GetAllServerlessRuntimesAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Organizations_GetAllServerlessRuntimes_Min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllServerlessRuntimes_OrganizationsGetAllServerlessRuntimesMin()
        {
            // Generated from example definition: 2024-05-08/Organizations_GetAllServerlessRuntimes_MinimumSet_Gen.json
            // this example is just showing the usage of "Organizations_GetAllServerlessRuntimes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this InformaticaOrganizationResource created on azure
            // for more information of creating InformaticaOrganizationResource, please refer to the document of InformaticaOrganizationResource
            string subscriptionId = "3599DA28-E346-4D9F-811E-189C0445F0FE";
            string resourceGroupName = "rgopenapi";
            string organizationName = "0";
            ResourceIdentifier informaticaOrganizationResourceId = InformaticaOrganizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, organizationName);
            InformaticaOrganizationResource informaticaOrganization = client.GetInformaticaOrganizationResource(informaticaOrganizationResourceId);

            // invoke the operation
            InformaticaServerlessRuntimeResourceList result = await informaticaOrganization.GetAllServerlessRuntimesAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
