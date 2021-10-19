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
        private static readonly string[] AuthorizationScopes = { "https://dev.azuresynapse.net/.default" };
        private readonly TokenCredential _tokenCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of RoleDefinitionsClient for mocking. </summary>
        protected RoleDefinitionsClient()
        {
        }

        /// <summary> Initializes a new instance of RoleDefinitionsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public RoleDefinitionsClient(Uri endpoint, TokenCredential credential, AccessControlClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new AccessControlClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> List role definitions. </summary>
        /// <param name="options"> The request options. </param>
        /// <param name="isBuiltIn"> Is a Synapse Built-In Role or not. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId,
        ///   name: string,
        ///   isBuiltIn: boolean,
        ///   description: string,
        ///   permissions: [
        ///     {
        ///       actions: [string],
        ///       notActions: [string],
        ///       dataActions: [string],
        ///       notDataActions: [string]
        ///     }
        ///   ],
        ///   scopes: [string],
        ///   availabilityStatus: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetRoleDefinitionsAsync(RequestOptions options, bool? isBuiltIn = null, string scope = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitions");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionsRequest(isBuiltIn, scope);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List role definitions. </summary>
        /// <param name="options"> The request options. </param>
        /// <param name="isBuiltIn"> Is a Synapse Built-In Role or not. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId,
        ///   name: string,
        ///   isBuiltIn: boolean,
        ///   description: string,
        ///   permissions: [
        ///     {
        ///       actions: [string],
        ///       notActions: [string],
        ///       dataActions: [string],
        ///       notDataActions: [string]
        ///     }
        ///   ],
        ///   scopes: [string],
        ///   availabilityStatus: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetRoleDefinitions(RequestOptions options, bool? isBuiltIn = null, string scope = null)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitions");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionsRequest(isBuiltIn, scope);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role definition by role definition Id. </summary>
        /// <param name="roleDefinitionId"> Synapse Built-In Role Definition Id. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId,
        ///   name: string,
        ///   isBuiltIn: boolean,
        ///   description: string,
        ///   permissions: [
        ///     {
        ///       actions: [string],
        ///       notActions: [string],
        ///       dataActions: [string],
        ///       notDataActions: [string]
        ///     }
        ///   ],
        ///   scopes: [string],
        ///   availabilityStatus: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetRoleDefinitionByIdAsync(string roleDefinitionId, RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitionById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionByIdRequest(roleDefinitionId);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role definition by role definition Id. </summary>
        /// <param name="roleDefinitionId"> Synapse Built-In Role Definition Id. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   id: SynapseRoleDefinitionId,
        ///   name: string,
        ///   isBuiltIn: boolean,
        ///   description: string,
        ///   permissions: [
        ///     {
        ///       actions: [string],
        ///       notActions: [string],
        ///       dataActions: [string],
        ///       notDataActions: [string]
        ///     }
        ///   ],
        ///   scopes: [string],
        ///   availabilityStatus: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetRoleDefinitionById(string roleDefinitionId, RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetRoleDefinitionById");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetRoleDefinitionByIdRequest(roleDefinitionId);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List rbac scopes. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetScopesAsync(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetScopes");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetScopesRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List rbac scopes. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorResponse],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetScopes(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope0 = _clientDiagnostics.CreateScope("RoleDefinitionsClient.GetScopes");
            scope0.Start();
            try
            {
                using HttpMessage message = CreateGetScopesRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetRoleDefinitionsRequest(bool? isBuiltIn, string scope)
        {
            var message = _pipeline.CreateMessage();
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
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetRoleDefinitionByIdRequest(string roleDefinitionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/roleDefinitions/", false);
            uri.AppendPath(roleDefinitionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetScopesRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rbacScopes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
