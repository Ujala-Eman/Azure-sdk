// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.SelfHelp
{
    internal partial class DiagnosticsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DiagnosticsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DiagnosticsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateRequestUri(string scope, string diagnosticsResourceName, SelfHelpDiagnosticData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/diagnostics/", false);
            uri.AppendPath(diagnosticsResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string scope, string diagnosticsResourceName, SelfHelpDiagnosticData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/diagnostics/", false);
            uri.AppendPath(diagnosticsResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a diagnostic for the specific resource using solutionId and requiredInputs* from discovery solutions. &lt;br/&gt;Diagnostics tells you precisely the root cause of the issue and the steps to address it. You can get diagnostics once you discover the relevant solution for your Azure issue. &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="data"> The required request body for this insightResource invocation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="diagnosticsResourceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string scope, string diagnosticsResourceName, SelfHelpDiagnosticData data, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (diagnosticsResourceName == null)
            {
                throw new ArgumentNullException(nameof(diagnosticsResourceName));
            }
            if (diagnosticsResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(diagnosticsResourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateRequest(scope, diagnosticsResourceName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a diagnostic for the specific resource using solutionId and requiredInputs* from discovery solutions. &lt;br/&gt;Diagnostics tells you precisely the root cause of the issue and the steps to address it. You can get diagnostics once you discover the relevant solution for your Azure issue. &lt;br/&gt;&lt;br/&gt; &lt;b&gt;Note: &lt;/b&gt; requiredInputs’ from Discovery solutions response must be passed via ‘additionalParameters’ as an input to Diagnostics API. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="data"> The required request body for this insightResource invocation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="diagnosticsResourceName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string scope, string diagnosticsResourceName, SelfHelpDiagnosticData data, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (diagnosticsResourceName == null)
            {
                throw new ArgumentNullException(nameof(diagnosticsResourceName));
            }
            if (diagnosticsResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(diagnosticsResourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateRequest(scope, diagnosticsResourceName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string scope, string diagnosticsResourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/diagnostics/", false);
            uri.AppendPath(diagnosticsResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string scope, string diagnosticsResourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Help/diagnostics/", false);
            uri.AppendPath(diagnosticsResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="diagnosticsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SelfHelpDiagnosticData>> GetAsync(string scope, string diagnosticsResourceName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (diagnosticsResourceName == null)
            {
                throw new ArgumentNullException(nameof(diagnosticsResourceName));
            }
            if (diagnosticsResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(diagnosticsResourceName));
            }

            using var message = CreateGetRequest(scope, diagnosticsResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SelfHelpDiagnosticData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SelfHelpDiagnosticData.DeserializeSelfHelpDiagnosticData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SelfHelpDiagnosticData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the diagnostics using the 'diagnosticsResourceName' you chose while creating the diagnostic. </summary>
        /// <param name="scope"> This is an extension resource provider and only resource level extension is supported at the moment. </param>
        /// <param name="diagnosticsResourceName"> Unique resource name for insight resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="diagnosticsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SelfHelpDiagnosticData> Get(string scope, string diagnosticsResourceName, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (diagnosticsResourceName == null)
            {
                throw new ArgumentNullException(nameof(diagnosticsResourceName));
            }
            if (diagnosticsResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(diagnosticsResourceName));
            }

            using var message = CreateGetRequest(scope, diagnosticsResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SelfHelpDiagnosticData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SelfHelpDiagnosticData.DeserializeSelfHelpDiagnosticData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SelfHelpDiagnosticData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
