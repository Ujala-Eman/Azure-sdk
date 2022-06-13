// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.AccessControl
{
    /// <summary> The RoleDefinitions service client. </summary>
    public partial class RoleDefinitionsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://dev.azuresynapse.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of RoleDefinitionsClient for mocking. </summary>
        protected RoleDefinitionsClient()
        {
        }

        /// <summary> Initializes a new instance of RoleDefinitionsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RoleDefinitionsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new AccessControlClientOptions())
        {
        }

        /// <summary> Initializes a new instance of RoleDefinitionsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RoleDefinitionsClient(Uri endpoint, TokenCredential credential, AccessControlClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AccessControlClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> List role definitions. </summary>
        /// <param name="isBuiltIn"> Is a Synapse Built-In Role or not. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/AccessControlClient/RoleDefinitions/ListRoleDefinitions
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId, # Optional. <Description>Role Definition ID</Description>
        ///   name: string, # Optional. <Description>Name of the Synapse role</Description>
        ///   isBuiltIn: boolean, # Optional. <Description>Is a built-in role or not</Description>
        ///   description: string, # Optional. <Description>Description for the Synapse role</Description>
        ///   permissions: [
        ///     {
        ///       actions: [string], # Optional. <Description>List of actions</Description>
        ///       notActions: [string], # Optional. <Description>List of Not actions</Description>
        ///       dataActions: [string], # Optional. <Description>List of data actions</Description>
        ///       notDataActions: [string], # Optional. <Description>List of Not data actions</Description>
        ///     }
        ///   ], # Optional. <Description>Permissions for the Synapse role</Description>
        ///   scopes: [string], # Optional. <Description>Allowed scopes for the Synapse role</Description>
        ///   availabilityStatus: string, # Optional. <Description>Availability of the Synapse role</Description>
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetRoleDefinitionsAsync(bool? isBuiltIn = null, string scope = null, RequestContext context = null)
        {
            using var scope0 = ClientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitions");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionsRequest(isBuiltIn, scope, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List role definitions. </summary>
        /// <param name="isBuiltIn"> Is a Synapse Built-In Role or not. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/AccessControlClient/RoleDefinitions/ListRoleDefinitions
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId, # Optional. <Description>Role Definition ID</Description>
        ///   name: string, # Optional. <Description>Name of the Synapse role</Description>
        ///   isBuiltIn: boolean, # Optional. <Description>Is a built-in role or not</Description>
        ///   description: string, # Optional. <Description>Description for the Synapse role</Description>
        ///   permissions: [
        ///     {
        ///       actions: [string], # Optional. <Description>List of actions</Description>
        ///       notActions: [string], # Optional. <Description>List of Not actions</Description>
        ///       dataActions: [string], # Optional. <Description>List of data actions</Description>
        ///       notDataActions: [string], # Optional. <Description>List of Not data actions</Description>
        ///     }
        ///   ], # Optional. <Description>Permissions for the Synapse role</Description>
        ///   scopes: [string], # Optional. <Description>Allowed scopes for the Synapse role</Description>
        ///   availabilityStatus: string, # Optional. <Description>Availability of the Synapse role</Description>
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetRoleDefinitions(bool? isBuiltIn = null, string scope = null, RequestContext context = null)
        {
            using var scope0 = ClientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitions");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionsRequest(isBuiltIn, scope, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role definition by role definition Id. </summary>
        /// <param name="roleDefinitionId"> Synapse Built-In Role Definition Id. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/AccessControlClient/RoleDefinitions/GetRoleDefinitionById
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId, # Optional. <Description>Role Definition ID</Description>
        ///   name: string, # Optional. <Description>Name of the Synapse role</Description>
        ///   isBuiltIn: boolean, # Optional. <Description>Is a built-in role or not</Description>
        ///   description: string, # Optional. <Description>Description for the Synapse role</Description>
        ///   permissions: [
        ///     {
        ///       actions: [string], # Optional. <Description>List of actions</Description>
        ///       notActions: [string], # Optional. <Description>List of Not actions</Description>
        ///       dataActions: [string], # Optional. <Description>List of data actions</Description>
        ///       notDataActions: [string], # Optional. <Description>List of Not data actions</Description>
        ///     }
        ///   ], # Optional. <Description>Permissions for the Synapse role</Description>
        ///   scopes: [string], # Optional. <Description>Allowed scopes for the Synapse role</Description>
        ///   availabilityStatus: string, # Optional. <Description>Availability of the Synapse role</Description>
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetRoleDefinitionByIdAsync(string roleDefinitionId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope0 = ClientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitionById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionByIdRequest(roleDefinitionId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role definition by role definition Id. </summary>
        /// <param name="roleDefinitionId"> Synapse Built-In Role Definition Id. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleDefinitionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// Additional information can be found in the service REST API documentation:
        /// https://docs.microsoft.com/rest/api/AccessControlClient/RoleDefinitions/GetRoleDefinitionById
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId, # Optional. <Description>Role Definition ID</Description>
        ///   name: string, # Optional. <Description>Name of the Synapse role</Description>
        ///   isBuiltIn: boolean, # Optional. <Description>Is a built-in role or not</Description>
        ///   description: string, # Optional. <Description>Description for the Synapse role</Description>
        ///   permissions: [
        ///     {
        ///       actions: [string], # Optional. <Description>List of actions</Description>
        ///       notActions: [string], # Optional. <Description>List of Not actions</Description>
        ///       dataActions: [string], # Optional. <Description>List of data actions</Description>
        ///       notDataActions: [string], # Optional. <Description>List of Not data actions</Description>
        ///     }
        ///   ], # Optional. <Description>Permissions for the Synapse role</Description>
        ///   scopes: [string], # Optional. <Description>Allowed scopes for the Synapse role</Description>
        ///   availabilityStatus: string, # Optional. <Description>Availability of the Synapse role</Description>
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetRoleDefinitionById(string roleDefinitionId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));

            using var scope0 = ClientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitionById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionByIdRequest(roleDefinitionId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List rbac scopes. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetScopesAsync(RequestContext context = null)
        {
            using var scope0 = ClientDiagnostics.CreateScope("RoleDefinitionsClient.GetScopes");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetScopesRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List rbac scopes. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetScopes(RequestContext context = null)
        {
            using var scope0 = ClientDiagnostics.CreateScope("RoleDefinitionsClient.GetScopes");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetScopesRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetRoleDefinitionsRequest(bool? isBuiltIn, string scope, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleDefinitions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (isBuiltIn != null)
            {
                uri.AppendQuery("isBuiltIn", isBuiltIn.Value, true);
            }
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        internal HttpMessage CreateGetRoleDefinitionByIdRequest(string roleDefinitionId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleDefinitions/", false);
            uri.AppendPath(roleDefinitionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        internal HttpMessage CreateGetScopesRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rbacScopes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
