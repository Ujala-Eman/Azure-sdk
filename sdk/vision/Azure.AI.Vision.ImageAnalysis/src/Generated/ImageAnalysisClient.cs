// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Vision.ImageAnalysis
{
    // Data plane generated client.
    /// <summary> The ImageAnalysis service client. </summary>
    public partial class ImageAnalysisClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ImageAnalysisClient for mocking. </summary>
        protected ImageAnalysisClient()
        {
        }

        /// <summary> Initializes a new instance of ImageAnalysisClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://&lt;resource-name&gt;.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ImageAnalysisClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new ImageAnalysisClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ImageAnalysisClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://&lt;resource-name&gt;.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ImageAnalysisClient(Uri endpoint, AzureKeyCredential credential, ImageAnalysisClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ImageAnalysisClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Performs a single Image Analysis operation. </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="imageContent"> The image to be analyzed. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="imageContent"/> is null. </exception>
        internal virtual async Task<Response<ImageAnalysisResult>> AnalyzeFromStreamAsync(IEnumerable<VisualFeatures> visualFeatures, BinaryData imageContent, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(imageContent, nameof(imageContent));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = RequestContentHelper.FromObject(imageContent);
            Response response = await AnalyzeFromStreamAsync(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context).ConfigureAwait(false);
            return Response.FromValue(ImageAnalysisResult.FromResponse(response), response);
        }

        /// <summary> Performs a single Image Analysis operation. </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="imageContent"> The image to be analyzed. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="imageContent"/> is null. </exception>
        internal virtual Response<ImageAnalysisResult> AnalyzeFromStream(IEnumerable<VisualFeatures> visualFeatures, BinaryData imageContent, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(imageContent, nameof(imageContent));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = RequestContentHelper.FromObject(imageContent);
            Response response = AnalyzeFromStream(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context);
            return Response.FromValue(ImageAnalysisResult.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Performs a single Image Analysis operation
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="AnalyzeFromStreamAsync(IEnumerable{VisualFeatures},BinaryData,string,bool?,IEnumerable{float},string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> AnalyzeFromStreamAsync(IEnumerable<VisualFeatures> visualFeatures, RequestContent content, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, RequestContext context = null)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ImageAnalysisClient.AnalyzeFromStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeFromStreamRequest(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Performs a single Image Analysis operation
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="AnalyzeFromStream(IEnumerable{VisualFeatures},BinaryData,string,bool?,IEnumerable{float},string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response AnalyzeFromStream(IEnumerable<VisualFeatures> visualFeatures, RequestContent content, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, RequestContext context = null)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ImageAnalysisClient.AnalyzeFromStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeFromStreamRequest(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Performs a single Image Analysis operation. </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="imageContent"> The image to be analyzed. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="imageContent"/> is null. </exception>
        internal virtual async Task<Response<ImageAnalysisResult>> AnalyzeFromUrlAsync(IEnumerable<VisualFeatures> visualFeatures, ImageUrl imageContent, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(imageContent, nameof(imageContent));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = imageContent.ToRequestContent();
            Response response = await AnalyzeFromUrlAsync(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context).ConfigureAwait(false);
            return Response.FromValue(ImageAnalysisResult.FromResponse(response), response);
        }

        /// <summary> Performs a single Image Analysis operation. </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="imageContent"> The image to be analyzed. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="imageContent"/> is null. </exception>
        internal virtual Response<ImageAnalysisResult> AnalyzeFromUrl(IEnumerable<VisualFeatures> visualFeatures, ImageUrl imageContent, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(imageContent, nameof(imageContent));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = imageContent.ToRequestContent();
            Response response = AnalyzeFromUrl(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context);
            return Response.FromValue(ImageAnalysisResult.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Performs a single Image Analysis operation
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="AnalyzeFromUrlAsync(IEnumerable{VisualFeatures},ImageUrl,string,bool?,IEnumerable{float},string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> AnalyzeFromUrlAsync(IEnumerable<VisualFeatures> visualFeatures, RequestContent content, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, RequestContext context = null)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ImageAnalysisClient.AnalyzeFromUrl");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeFromUrlRequest(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Performs a single Image Analysis operation
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="AnalyzeFromUrl(IEnumerable{VisualFeatures},ImageUrl,string,bool?,IEnumerable{float},string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="visualFeatures"> A string indicating what visual feature types to return. Multiple values should be comma-separated. Valid visual feature types include: Tags, Caption, DenseCaptions, Objects, Read, SmartCrops, People. At least one visual feature must be specified for Image Analysis. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="language"> The desired language for output generation. If this parameter is not specified, the default value is "en". See https://aka.ms/cv-languages for a list of supported languages. </param>
        /// <param name="genderNeutralCaption"> Boolean flag for enabling gender-neutral captioning for caption and denseCaptions features. If this parameter is not specified, the default value is "false". </param>
        /// <param name="smartCropsAspectRatios"> A list of aspect ratios to use for smartCrops feature. Aspect ratios are calculated by dividing the target crop width by the height. Supported values are between 0.75 and 1.8 (inclusive). Multiple values should be comma-separated. If this parameter is not specified, the service will return one crop suggestion with an aspect ratio it sees fit between 0.5 and 2.0 (inclusive). </param>
        /// <param name="modelVersion">
        /// The version of cloud AI-model used for analysis.
        /// The format is the following: 'latest' (default value) or 'YYYY-MM-DD' or 'YYYY-MM-DD-preview', where `YYYY`, `MM`, `DD` are the year, month and day.
        /// Only relevant when doing analysis with standard models. Not relevant when doing analysis with a custom-trained AI model.
        /// </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="visualFeatures"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response AnalyzeFromUrl(IEnumerable<VisualFeatures> visualFeatures, RequestContent content, string language = null, bool? genderNeutralCaption = null, IEnumerable<float> smartCropsAspectRatios = null, string modelVersion = null, RequestContext context = null)
        {
            Argument.AssertNotNull(visualFeatures, nameof(visualFeatures));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ImageAnalysisClient.AnalyzeFromUrl");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeFromUrlRequest(visualFeatures, content, language, genderNeutralCaption, smartCropsAspectRatios, modelVersion, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateAnalyzeFromStreamRequest(IEnumerable<VisualFeatures> visualFeatures, RequestContent content, string language, bool? genderNeutralCaption, IEnumerable<float> smartCropsAspectRatios, string modelVersion, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/computervision", false);
            uri.AppendPath("/imageanalysis:analyze", false);
            if (visualFeatures != null && Optional.IsCollectionDefined(visualFeatures))
            {
                uri.AppendQueryDelimited("features", visualFeatures, ",", true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            if (language != null)
            {
                uri.AppendQuery("language", language, true);
            }
            if (genderNeutralCaption != null)
            {
                uri.AppendQuery("gender-neutral-caption", genderNeutralCaption.Value, true);
            }
            if (smartCropsAspectRatios != null && Optional.IsCollectionDefined(smartCropsAspectRatios))
            {
                uri.AppendQueryDelimited("smartcrops-aspect-ratios", smartCropsAspectRatios, ",", true);
            }
            if (modelVersion != null)
            {
                uri.AppendQuery("model-version", modelVersion, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", "application/octet-stream");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateAnalyzeFromUrlRequest(IEnumerable<VisualFeatures> visualFeatures, RequestContent content, string language, bool? genderNeutralCaption, IEnumerable<float> smartCropsAspectRatios, string modelVersion, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/computervision", false);
            uri.AppendPath("/imageanalysis:analyze", false);
            if (visualFeatures != null && Optional.IsCollectionDefined(visualFeatures))
            {
                uri.AppendQueryDelimited("features", visualFeatures, ",", true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            if (language != null)
            {
                uri.AppendQuery("language", language, true);
            }
            if (genderNeutralCaption != null)
            {
                uri.AppendQuery("gender-neutral-caption", genderNeutralCaption.Value, true);
            }
            if (smartCropsAspectRatios != null && Optional.IsCollectionDefined(smartCropsAspectRatios))
            {
                uri.AppendQueryDelimited("smartcrops-aspect-ratios", smartCropsAspectRatios, ",", true);
            }
            if (modelVersion != null)
            {
                uri.AppendQuery("model-version", modelVersion, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
