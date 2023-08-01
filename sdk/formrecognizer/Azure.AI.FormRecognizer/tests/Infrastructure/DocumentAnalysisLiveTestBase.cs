﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Core.TestFramework.Models;

namespace Azure.AI.FormRecognizer.DocumentAnalysis.Tests
{
    [ClientTestFixture(
        DocumentAnalysisClientOptions.ServiceVersion.V2022_08_31,
        DocumentAnalysisClientOptions.ServiceVersion.V2023_02_28_Preview)]
    public class DocumentAnalysisLiveTestBase : RecordedTestBase<DocumentAnalysisTestEnvironment>
    {
        /// <summary>
        /// The version of the REST API to test against.  This will be passed
        /// to the .ctor via ClientTestFixture's values.
        /// </summary>
        protected readonly DocumentAnalysisClientOptions.ServiceVersion _serviceVersion;

        public DocumentAnalysisLiveTestBase(bool isAsync, DocumentAnalysisClientOptions.ServiceVersion serviceVersion)
            : base(isAsync)
        {
            _serviceVersion = serviceVersion;

            ServiceVersionString = _serviceVersion switch
            {
                DocumentAnalysisClientOptions.ServiceVersion.V2022_08_31 => "2022-08-31",
                DocumentAnalysisClientOptions.ServiceVersion.V2023_02_28_Preview => "2023-02-28-preview",
                _ => null
            };

            JsonPathSanitizers.Add("$..accessToken");
            BodyKeySanitizers.Add(new BodyKeySanitizer("https://sanitized.blob.core.windows.net") { JsonPath = "$..containerUrl" });
            SanitizedHeaders.Add(Constants.AuthorizationHeader);
        }

        protected string ServiceVersionString { get; }

        /// <summary>
        /// Creates a <see cref="DocumentAnalysisClient" /> with the endpoint and API key provided via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <param name="useTokenCredential">Whether or not to use a <see cref="TokenCredential"/> to authenticate. An <see cref="AzureKeyCredential"/> is used by default.</param>
        /// <param name="apiKey">The API key to use for authentication. Defaults to <see cref="DocumentAnalysisTestEnvironment.ApiKey"/>.</param>
        /// <returns>The instrumented <see cref="DocumentAnalysisClient" />.</returns>
        protected DocumentAnalysisClient CreateDocumentAnalysisClient(bool useTokenCredential = false, string apiKey = default) => CreateDocumentAnalysisClient(out _, useTokenCredential, apiKey);

        /// <summary>
        /// Creates a <see cref="DocumentAnalysisClient" /> with the endpoint and API key provided via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <param name="nonInstrumentedClient">The non-instrumented version of the client to be used to resume LROs.</param>
        /// <param name="useTokenCredential">Whether or not to use a <see cref="TokenCredential"/> to authenticate. An <see cref="AzureKeyCredential"/> is used by default.</param>
        /// <param name="apiKey">The API key to use for authentication. Defaults to <see cref="DocumentAnalysisTestEnvironment.ApiKey"/>.</param>
        /// <returns>The instrumented <see cref="DocumentAnalysisClient" />.</returns>
        protected DocumentAnalysisClient CreateDocumentAnalysisClient(out DocumentAnalysisClient nonInstrumentedClient, bool useTokenCredential = false, string apiKey = default)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            var options = InstrumentClientOptions(new DocumentAnalysisClientOptions(_serviceVersion));

            if (useTokenCredential)
            {
                nonInstrumentedClient = new DocumentAnalysisClient(endpoint, TestEnvironment.Credential, options);
            }
            else
            {
                var credential = new AzureKeyCredential(apiKey ?? TestEnvironment.ApiKey);
                nonInstrumentedClient = new DocumentAnalysisClient(endpoint, credential, options);
            }

            return InstrumentClient(nonInstrumentedClient);
        }

        /// <summary>
        /// Creates a <see cref="DocumentModelAdministrationClient" /> with the endpoint and API key provided via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <param name="useTokenCredential">Whether or not to use a <see cref="TokenCredential"/> to authenticate. An <see cref="AzureKeyCredential"/> is used by default.</param>
        /// <param name="apiKey">The API key to use for authentication. Defaults to <see cref="DocumentAnalysisTestEnvironment.ApiKey"/>.</param>
        /// <returns>The instrumented <see cref="DocumentModelAdministrationClient" />.</returns>
        protected DocumentModelAdministrationClient CreateDocumentModelAdministrationClient(bool useTokenCredential = false, string apiKey = default) => CreateDocumentModelAdministrationClient(out _, useTokenCredential, apiKey);

        /// <summary>
        /// Creates a <see cref="DocumentModelAdministrationClient" /> with the endpoint and API key provided via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <param name="nonInstrumentedClient">The non-instrumented version of the client to be used to resume LROs.</param>
        /// <param name="useTokenCredential">Whether or not to use a <see cref="TokenCredential"/> to authenticate. An <see cref="AzureKeyCredential"/> is used by default.</param>
        /// <param name="apiKey">The API key to use for authentication. Defaults to <see cref="DocumentAnalysisTestEnvironment.ApiKey"/>.</param>
        /// <returns>The instrumented <see cref="DocumentModelAdministrationClient" />.</returns>
        protected DocumentModelAdministrationClient CreateDocumentModelAdministrationClient(out DocumentModelAdministrationClient nonInstrumentedClient, bool useTokenCredential = false, string apiKey = default)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            var options = InstrumentClientOptions(new DocumentAnalysisClientOptions(_serviceVersion));

            if (useTokenCredential)
            {
                nonInstrumentedClient = new DocumentModelAdministrationClient(endpoint, TestEnvironment.Credential, options);
            }
            else
            {
                var credential = new AzureKeyCredential(apiKey ?? TestEnvironment.ApiKey);
                nonInstrumentedClient = new DocumentModelAdministrationClient(endpoint, credential, options);
            }

            return InstrumentClient(nonInstrumentedClient);
        }

        /// <summary>
        /// Builds a document model and returns the associated <see cref="DisposableDocumentModel"/> instance.
        /// Upon disposal, the document model will be deleted.
        /// </summary>
        /// <param name="modelId">The identifier of the model.</param>
        /// <param name="containerType">The type of container to use for training.</param>
        /// <param name="options">A set of options to apply when configuring the request.</param>
        /// <returns>A <see cref="DisposableDocumentModel"/> instance from which the built model ID can be obtained.</returns>
        protected async Task<DisposableDocumentModel> BuildDisposableDocumentModelAsync(string modelId, ContainerType containerType = default, BuildDocumentModelOptions options = null)
        {
            var client = CreateDocumentModelAdministrationClient();

            string trainingFiles = containerType switch
            {
                ContainerType.Singleforms => TestEnvironment.BlobContainerSasUrl,
                ContainerType.MultipageFiles => TestEnvironment.MultipageBlobContainerSasUrl,
                ContainerType.SelectionMarks => TestEnvironment.SelectionMarkBlobContainerSasUrl,
                _ => TestEnvironment.BlobContainerSasUrl,
            };
            var trainingFilesUri = new Uri(trainingFiles);

            return await DisposableDocumentModel.BuildAsync(client, trainingFilesUri, DocumentBuildMode.Template, modelId, options);
        }

        /// <summary>
        /// Builds a document classifier and returns the associated <see cref="DisposableDocumentClassifier"/> instance.
        /// Upon disposal, the document classifier will be deleted.
        /// </summary>
        /// <param name="classifierId">The identifier of the classifier.</param>
        /// <param name="description">An optional classifier description.</param>
        /// <returns>A <see cref="DisposableDocumentClassifier"/> instance from which the built classifier can be obtained.</returns>
        protected async Task<DisposableDocumentClassifier> BuildDisposableDocumentClassifierAsync(string classifierId, string description = null)
        {
            var client = CreateDocumentModelAdministrationClient();
            var trainingFilesUri = new Uri(TestEnvironment.ClassifierTrainingSasUrl);
            var sourceA = new AzureBlobContentSource(trainingFilesUri) { Prefix = "IRS-1040-A/train" };
            var sourceB = new AzureBlobContentSource(trainingFilesUri) { Prefix = "IRS-1040-B/train" };
            var sourceC = new AzureBlobContentSource(trainingFilesUri) { Prefix = "IRS-1040-C/train" };
            var sourceD = new AzureBlobContentSource(trainingFilesUri) { Prefix = "IRS-1040-D/train" };
            var sourceE = new AzureBlobContentSource(trainingFilesUri) { Prefix = "IRS-1040-E/train" };

            var documentTypes = new Dictionary<string, ClassifierDocumentTypeDetails>()
            {
                { "IRS-1040-A", new ClassifierDocumentTypeDetails(sourceA) },
                { "IRS-1040-B", new ClassifierDocumentTypeDetails(sourceB) },
                { "IRS-1040-C", new ClassifierDocumentTypeDetails(sourceC) },
                { "IRS-1040-D", new ClassifierDocumentTypeDetails(sourceD) },
                { "IRS-1040-E", new ClassifierDocumentTypeDetails(sourceE) }
            };

            return await DisposableDocumentClassifier.BuildAsync(client, documentTypes, classifierId, description);
        }

        protected enum ContainerType
        {
            Singleforms,
            MultipageFiles,
            SelectionMarks
        }
    }
}
