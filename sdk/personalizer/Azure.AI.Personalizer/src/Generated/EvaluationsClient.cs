// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Personalizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Personalizer
{
    /// <summary> The Evaluations service client. </summary>
    internal partial class EvaluationsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal EvaluationsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of EvaluationsClient for mocking. </summary>
        protected EvaluationsClient()
        {
        }

        /// <summary> Initializes a new instance of EvaluationsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public EvaluationsClient(string endpoint, TokenCredential credential, PersonalizerClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://cognitiveservices.azure.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new EvaluationsRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of EvaluationsClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public EvaluationsClient(string endpoint, AzureKeyCredential credential, PersonalizerClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PersonalizerClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "Ocp-Apim-Subscription-Key"));
            RestClient = new EvaluationsRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of EvaluationsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        internal EvaluationsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new EvaluationsRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Delete the Offline Evaluation associated with the Id. </summary>
        /// <param name="evaluationId"> Id of the Offline Evaluation to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string evaluationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(evaluationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the Offline Evaluation associated with the Id. </summary>
        /// <param name="evaluationId"> Id of the Offline Evaluation to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string evaluationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(evaluationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the Offline Evaluation associated with the Id. </summary>
        /// <param name="evaluationId"> Id of the Offline Evaluation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PersonalizerEvaluation>> GetAsync(string evaluationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(evaluationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the Offline Evaluation associated with the Id. </summary>
        /// <param name="evaluationId"> Id of the Offline Evaluation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PersonalizerEvaluation> Get(string evaluationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(evaluationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List of all Offline Evaluations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<PersonalizerEvaluation>>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List of all Offline Evaluations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<PersonalizerEvaluation>> List(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.List");
            scope.Start();
            try
            {
                return RestClient.List(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a new Offline Evaluation job. </summary>
        /// <param name="evaluation"> The Offline Evaluation job definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PersonalizerEvaluation>> CreateAsync(EvaluationContract evaluation, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(evaluation, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a new Offline Evaluation job. </summary>
        /// <param name="evaluation"> The Offline Evaluation job definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PersonalizerEvaluation> Create(EvaluationContract evaluation, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EvaluationsClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(evaluation, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
