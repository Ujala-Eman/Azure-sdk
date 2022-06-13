// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Scanning
{
    /// <summary> The PurviewClassificationRule service client. </summary>
    public partial class PurviewClassificationRuleClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _classificationRuleName;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient for mocking. </summary>
        protected PurviewClassificationRuleClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.scan.purview.azure.com. </param>
        /// <param name="classificationRuleName"> The String to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="classificationRuleName"/> or <paramref name="credential"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="classificationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public PurviewClassificationRuleClient(Uri endpoint, string classificationRuleName, TokenCredential credential) : this(endpoint, classificationRuleName, credential, new PurviewScanningServiceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.scan.purview.azure.com. </param>
        /// <param name="classificationRuleName"> The String to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="classificationRuleName"/> or <paramref name="credential"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="classificationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public PurviewClassificationRuleClient(Uri endpoint, string classificationRuleName, TokenCredential credential, PurviewScanningServiceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNullOrEmpty(classificationRuleName, nameof(classificationRuleName));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PurviewScanningServiceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _classificationRuleName = classificationRuleName;
            _apiVersion = options.Version;
        }

        /// <summary> Get a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/GetProperties
        /// Schema for <c>SystemClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetPropertiesAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetProperties");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPropertiesRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/GetProperties
        /// Schema for <c>SystemClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetProperties(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetProperties");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPropertiesRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or Updates a classification rule. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/CreateOrUpdate
        /// Schema for <c>SystemClassificationRule Request Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Request Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>SystemClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateOrUpdateAsync(RequestContent content, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or Updates a classification rule. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/CreateOrUpdate
        /// Schema for <c>SystemClassificationRule Request Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Request Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>SystemClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response CreateOrUpdate(RequestContent content, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/Delete
        /// Schema for <c>SystemClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> DeleteAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/Delete
        /// Schema for <c>SystemClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: System, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// Schema for <c>CustomClassificationRule Response Body</c>:
        /// <code>{
        ///   kind: Custom, # Required.
        ///   id: string, # Optional.
        ///   name: string, # Optional.
        ///   properties: {
        ///     minimumPercentageMatch: number, # Optional.
        ///     classificationAction: &quot;Keep&quot; | &quot;Delete&quot;, # Optional.
        ///     dataPatterns: [
        ///       {
        ///         kind: &quot;Regex&quot;, # Required.
        ///       }
        ///     ], # Optional.
        ///     columnPatterns: [ClassificationRulePattern], # Optional.
        ///     description: string, # Optional.
        ///     version: number, # Optional.
        ///     classificationName: string, # Optional.
        ///     ruleStatus: &quot;Enabled&quot; | &quot;Disabled&quot;, # Optional.
        ///     createdAt: string (ISO 8601 Format), # Optional.
        ///     lastModifiedAt: string (ISO 8601 Format), # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Delete(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets Classification Action on a specific classification rule version. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. Allowed values: &quot;Keep&quot; | &quot;Delete&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/TagVersion
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   scanResultId: OperationResponseScanResultId, # Optional.
        ///   startTime: string (ISO 8601 Format), # Optional.
        ///   endTime: string (ISO 8601 Format), # Optional.
        ///   status: &quot;Accepted&quot; | &quot;InProgress&quot; | &quot;TransientFailure&quot; | &quot;Succeeded&quot; | &quot;Failed&quot; | &quot;Canceled&quot;, # Optional.
        ///   error: {
        ///     code: string, # Optional.
        ///     message: string, # Optional.
        ///     target: string, # Optional.
        ///     details: [
        ///       {
        ///         code: string, # Optional.
        ///         message: string, # Optional.
        ///         target: string, # Optional.
        ///         details: [ErrorInfo], # Optional.
        ///       }
        ///     ], # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> TagVersionAsync(int classificationRuleVersion, string action, RequestContext context = null)
        {
            Argument.AssertNotNull(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.TagVersion");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTagVersionRequest(classificationRuleVersion, action, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets Classification Action on a specific classification rule version. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. Allowed values: &quot;Keep&quot; | &quot;Delete&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/TagVersion
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   scanResultId: OperationResponseScanResultId, # Optional.
        ///   startTime: string (ISO 8601 Format), # Optional.
        ///   endTime: string (ISO 8601 Format), # Optional.
        ///   status: &quot;Accepted&quot; | &quot;InProgress&quot; | &quot;TransientFailure&quot; | &quot;Succeeded&quot; | &quot;Failed&quot; | &quot;Canceled&quot;, # Optional.
        ///   error: {
        ///     code: string, # Optional.
        ///     message: string, # Optional.
        ///     target: string, # Optional.
        ///     details: [
        ///       {
        ///         code: string, # Optional.
        ///         message: string, # Optional.
        ///         target: string, # Optional.
        ///         details: [ErrorInfo], # Optional.
        ///       }
        ///     ], # Optional.
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response TagVersion(int classificationRuleVersion, string action, RequestContext context = null)
        {
            Argument.AssertNotNull(action, nameof(action));

            using var scope = ClientDiagnostics.CreateScope("PurviewClassificationRuleClient.TagVersion");
            scope.Start();
            try
            {
                using HttpMessage message = CreateTagVersionRequest(classificationRuleVersion, action, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the rule versions of a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/GetVersions
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string, # Optional.
        ///       name: string, # Optional.
        ///       kind: &quot;System&quot; | &quot;Custom&quot;, # Required.
        ///     }
        ///   ], # Optional.
        ///   nextLink: string, # Optional.
        ///   count: number, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetVersionsAsync(RequestContext context = null)
        {
            return GetVersionsImplementationAsync("PurviewClassificationRuleClient.GetVersions", context);
        }

        private AsyncPageable<BinaryData> GetVersionsImplementationAsync(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetVersionsRequest(context)
                        : CreateGetVersionsNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Lists the rule versions of a classification rule. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/PurviewScanningService/PurviewClassificationRule/GetVersions
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       id: string, # Optional.
        ///       name: string, # Optional.
        ///       kind: &quot;System&quot; | &quot;Custom&quot;, # Required.
        ///     }
        ///   ], # Optional.
        ///   nextLink: string, # Optional.
        ///   count: number, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetVersions(RequestContext context = null)
        {
            return GetVersionsImplementation("PurviewClassificationRuleClient.GetVersions", context);
        }

        private Pageable<BinaryData> GetVersionsImplementation(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetVersionsRequest(context)
                        : CreateGetVersionsNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetPropertiesRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetVersionsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateTagVersionRequest(int classificationRuleVersion, string action, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(_classificationRuleName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(classificationRuleVersion, true);
            uri.AppendPath("/:tag", false);
            uri.AppendQuery("action", action, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetVersionsNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier200204;
        private static ResponseClassifier ResponseClassifier200204 => _responseClassifier200204 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 204 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
