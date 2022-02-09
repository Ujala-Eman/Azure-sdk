// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Rl.Net;

namespace Azure.AI.Personalizer
{
    /// <summary> The Rank service client. </summary>
    internal partial class RankClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly bool _isLocalInference;
        private readonly RlNetProcessor _rlNetProcessor;
        internal RankRestClient RestClient { get; }

        /// <summary> Initializes a new instance of RankClient for mocking. </summary>
        protected RankClient()
        {
        }

        /// <summary> Initializes a new instance of RankClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RankClient(string endpoint, TokenCredential credential, PersonalizerClientOptions options = null)
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
            RestClient = new RankRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of PersonalizerClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="isLocalInference"> A flag to determine whether to use local inference. </param>
        /// <param name="configuration"> A configuration to use local reference. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RankClient(string endpoint, TokenCredential credential, bool isLocalInference = false, Configuration configuration = null, PersonalizerClientOptions options = null) :
            this(endpoint, credential, options)
        {
            _isLocalInference = isLocalInference;
            if (isLocalInference)
            {
                LiveModel liveModel = new LiveModel(configuration);
                liveModel.Init();
                _rlNetProcessor = new RlNetProcessor(liveModel);
            }
        }

        /// <summary> Initializes a new instance of RankClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RankClient(string endpoint, AzureKeyCredential credential, PersonalizerClientOptions options = null)
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
            RestClient = new RankRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of PersonalizerClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="isLocalInference"> A flag to determine whether to use local reference. </param>
        /// <param name="configuration"> A configuration to use local reference. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RankClient(string endpoint, AzureKeyCredential credential, bool isLocalInference = false, Configuration configuration = null, PersonalizerClientOptions options = null) :
            this(endpoint, credential, options)
        {
            _isLocalInference = isLocalInference;
            if (isLocalInference)
            {
                LiveModel liveModel = new LiveModel(configuration);
                liveModel.Init();
                _rlNetProcessor = new RlNetProcessor(liveModel);
            }

        }

        /// <summary> Initializes a new instance of RankClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint. </param>
        internal RankClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint)
        {
            RestClient = new RankRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Submit a Personalizer rank request. Receives a context and a list of actions. Returns which of the provided actions should be used by your application, in rewardActionId. </summary>
        /// <param name="rankRequest"> A Personalizer Rank request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PersonalizerRankResult>> RankAsync(PersonalizerRankOptions rankRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RankClient.Rank");
            scope.Start();
            try
            {
                if (_isLocalInference)
                {
                    return _rlNetProcessor.Rank(rankRequest);
                }
                else
                {
                    return await RestClient.RankAsync(rankRequest, cancellationToken).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a Personalizer rank request. Receives a context and a list of actions. Returns which of the provided actions should be used by your application, in rewardActionId. </summary>
        /// <param name="rankRequest"> A Personalizer Rank request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PersonalizerRankResult> Rank(PersonalizerRankOptions rankRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RankClient.Rank");
            scope.Start();
            try
            {
                return RestClient.Rank(rankRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
