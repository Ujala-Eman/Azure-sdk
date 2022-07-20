// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.ConfidentialLedger;

namespace Azure.Security.ConfidentialLedger.Certificate
{
    /// <summary> The ConfidentialLedgerCertificate service client. </summary>
    public partial class ConfidentialLedgerCertificateClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://confidential-ledger.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _certificateEndpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ConfidentialLedgerCertificateClient for mocking. </summary>
        protected ConfidentialLedgerCertificateClient()
        {
        }

        /// <summary> Gets identity information for a Confidential Ledger instance. </summary>
        /// <param name="ledgerId"> Id of the Confidential Ledger instance to get information for. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ledgerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>LedgerIdentityInformation</c>:
        /// <code>{
        ///   ledgerId: string, # Optional. Id for the ledger.
        ///   ledgerTlsCertificate: string, # Required. PEM-encoded certificate used for TLS by the Confidential Ledger.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetLedgerIdentityAsync(string ledgerId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(ledgerId, nameof(ledgerId));

            using var scope = ClientDiagnostics.CreateScope("ConfidentialLedgerCertificateClient.GetLedgerIdentity");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetLedgerIdentityRequest(ledgerId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets identity information for a Confidential Ledger instance. </summary>
        /// <param name="ledgerId"> Id of the Confidential Ledger instance to get information for. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ledgerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ledgerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>LedgerIdentityInformation</c>:
        /// <code>{
        ///   ledgerId: string, # Optional. Id for the ledger.
        ///   ledgerTlsCertificate: string, # Required. PEM-encoded certificate used for TLS by the Confidential Ledger.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetLedgerIdentity(string ledgerId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(ledgerId, nameof(ledgerId));

            using var scope = ClientDiagnostics.CreateScope("ConfidentialLedgerCertificateClient.GetLedgerIdentity");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetLedgerIdentityRequest(ledgerId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetLedgerIdentityRequest(string ledgerId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_certificateEndpoint);
            uri.AppendPath("/ledgerIdentity/", false);
            uri.AppendPath(ledgerId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
