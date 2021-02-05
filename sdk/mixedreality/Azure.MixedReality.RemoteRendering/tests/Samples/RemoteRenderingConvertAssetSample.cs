﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.MixedReality.RemoteRendering.Tests.Samples
{
    // These tests assume that the storage account is accessible from the remote rendering account.
    // See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account
    // Since the roles can take a while to propagate, we do not live test these samples.

    public class RemoteRenderingConvertAssetSample : SamplesBase<RemoteRenderingTestEnvironment>
    {
        private readonly RemoteRenderingAccount _account;
        private readonly string _accountKey;
        private readonly Uri _serviceEndpoint;

        public RemoteRenderingConvertAssetSample()
        {
            _account = new RemoteRenderingAccount(new Guid(TestEnvironment.AccountId), TestEnvironment.AccountDomain);
            _accountKey = TestEnvironment.AccountKey;
            _serviceEndpoint = new Uri(TestEnvironment.ServiceEndpoint);
        }

        //[Test]
        public void ConvertSimpleAsset()
        {
            AzureKeyCredential accountKeyCredential = new AzureKeyCredential(_accountKey);

            RemoteRenderingClient client = new RemoteRenderingClient(_serviceEndpoint, _account, accountKeyCredential);

            Uri storageUri = new Uri($"https://{TestEnvironment.StorageAccountName}.blob.core.windows.net/{TestEnvironment.BlobContainerName}");

            #region Snippet:StartAnAssetConversion

            AssetConversionInputOptions inputOptions = new AssetConversionInputOptions(storageUri, "box.fbx");
            AssetConversionOutputOptions outputOptions = new AssetConversionOutputOptions(storageUri);
            AssetConversionOptions conversionOptions = new AssetConversionOptions(inputOptions, outputOptions);

            // A randomly generated GUID is a good choice for a conversionId.
            string conversionId = Guid.NewGuid().ToString();

            AssetConversionOperation conversionOperation = client.StartConversion(conversionId, conversionOptions);

            #endregion Snippet:StartAnAssetConversion
            #region Snippet:QueryAssetConversion

            AssetConversion conversion = conversionOperation.WaitForCompletionAsync().Result;
            if (conversion.Status == AssetConversionStatus.Succeeded)
            {
                Console.WriteLine($"Conversion succeeded: Output written to {conversion.Output.OutputAssetUri}");
            }
            else if (conversion.Status == AssetConversionStatus.Failed)
            {
                Console.WriteLine($"Conversion failed: {conversion.Error.Code} {conversion.Error.Message}");
            }

            #endregion Snippet:QueryAssetConversion
        }

        //[Test]
        public void ConvertMoreComplexAsset()
        {
            AzureKeyCredential accountKeyCredential = new AzureKeyCredential(_accountKey);

            RemoteRenderingClient client = new RemoteRenderingClient(_serviceEndpoint, _account, accountKeyCredential);

            Uri inputStorageUri = new Uri($"https://{TestEnvironment.StorageAccountName}.blob.core.windows.net/{TestEnvironment.BlobContainerName}");
            Uri outputStorageUri = new Uri($"https://{TestEnvironment.StorageAccountName}.blob.core.windows.net/{TestEnvironment.BlobContainerName}");

            #region Snippet:StartAComplexAssetConversion
            AssetConversionInputOptions inputOptions = new AssetConversionInputOptions(inputStorageUri, "bicycle.gltf")
            {
                BlobPrefix = "Bicycle"
            };
            AssetConversionOutputOptions outputOptions = new AssetConversionOutputOptions(outputStorageUri)
            {
                BlobPrefix = "ConvertedBicycle"
            };
            AssetConversionOptions conversionOptions = new AssetConversionOptions(inputOptions, outputOptions);

            string conversionId = Guid.NewGuid().ToString();

            AssetConversionOperation conversionOperation = client.StartConversion(conversionId, conversionOptions);
            #endregion Snippet:StartAComplexAssetConversion

            AssetConversion conversion = conversionOperation.WaitForCompletionAsync().Result;
            if (conversion.Status == AssetConversionStatus.Succeeded)
            {
                Console.WriteLine($"Conversion succeeded: Output written to {conversion.Output.OutputAssetUri}");
            }
            else if (conversion.Status == AssetConversionStatus.Failed)
            {
                Console.WriteLine($"Conversion failed: {conversion.Error.Code} {conversion.Error.Message}");
            }
        }

        //[Test]
        public void GetConversions()
        {
            AzureKeyCredential accountKeyCredential = new AzureKeyCredential(_accountKey);

            RemoteRenderingClient client = new RemoteRenderingClient(_serviceEndpoint, _account, accountKeyCredential);

            Console.WriteLine("Successful conversions since yesterday:");
            #region Snippet:GetConversions

            foreach (var conversion in client.GetConversions())
            {
                if ((conversion.Status == AssetConversionStatus.Succeeded) && (conversion.CreatedOn > DateTimeOffset.Now.AddDays(-1)))
                {
                    Console.WriteLine($"output asset URI: {conversion.Output.OutputAssetUri}");
                }
            }

            #endregion Snippet:GetConversions
        }
    }
}
