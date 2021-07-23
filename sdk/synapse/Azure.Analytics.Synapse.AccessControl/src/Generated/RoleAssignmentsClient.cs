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
    /// <summary> The RoleAssignments service client. </summary>
    public partial class RoleAssignmentsClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://dev.azuresynapse.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of RoleAssignmentsClient for mocking. </summary>
        protected RoleAssignmentsClient()
        {
        }

        /// <summary> Initializes a new instance of RoleAssignmentsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RoleAssignmentsClient(Uri endpoint, TokenCredential credential, AccessControlClientOptions options = null)
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
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Check if the given principalId has access to perform list of actions at a given scope. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>subject</term>
        ///     <term>SubjectInfo</term>
        ///     <term>Yes</term>
        ///     <term> Subject details. </term>
        ///   </item>
        ///   <item>
        ///     <term>actions</term>
        ///     <term>RequiredAction[]</term>
        ///     <term>Yes</term>
        ///     <term> List of actions. </term>
        ///   </item>
        ///   <item>
        ///     <term>scope</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Scope at which the check access is done. </term>
        ///   </item>
        /// </list>
        /// Schema for <c>SubjectInfo</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>principalId</term>
        ///     <term>SubjectInfoPrincipalId</term>
        ///     <term>Yes</term>
        ///     <term> Principal Id. </term>
        ///   </item>
        ///   <item>
        ///     <term>groupIds</term>
        ///     <term>SubjectInfoGroupIdsItem[]</term>
        ///     <term></term>
        ///     <term> List of group Ids that the principalId is part of. </term>
        ///   </item>
        /// </list>
        /// Schema for <c>RequiredAction</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Action Id. </term>
        ///   </item>
        ///   <item>
        ///     <term>isDataAction</term>
        ///     <term>boolean</term>
        ///     <term>Yes</term>
        ///     <term> Is a data action or not. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CheckPrincipalAccessAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCheckPrincipalAccessRequest(content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CheckPrincipalAccess");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check if the given principalId has access to perform list of actions at a given scope. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>subject</term>
        ///     <term>SubjectInfo</term>
        ///     <term>Yes</term>
        ///     <term> Subject details. </term>
        ///   </item>
        ///   <item>
        ///     <term>actions</term>
        ///     <term>RequiredAction[]</term>
        ///     <term>Yes</term>
        ///     <term> List of actions. </term>
        ///   </item>
        ///   <item>
        ///     <term>scope</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Scope at which the check access is done. </term>
        ///   </item>
        /// </list>
        /// Schema for <c>SubjectInfo</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>principalId</term>
        ///     <term>SubjectInfoPrincipalId</term>
        ///     <term>Yes</term>
        ///     <term> Principal Id. </term>
        ///   </item>
        ///   <item>
        ///     <term>groupIds</term>
        ///     <term>SubjectInfoGroupIdsItem[]</term>
        ///     <term></term>
        ///     <term> List of group Ids that the principalId is part of. </term>
        ///   </item>
        /// </list>
        /// Schema for <c>RequiredAction</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Action Id. </term>
        ///   </item>
        ///   <item>
        ///     <term>isDataAction</term>
        ///     <term>boolean</term>
        ///     <term>Yes</term>
        ///     <term> Is a data action or not. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CheckPrincipalAccess(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCheckPrincipalAccessRequest(content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CheckPrincipalAccess");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CheckPrincipalAccess"/> and <see cref="CheckPrincipalAccessAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCheckPrincipalAccessRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/checkAccessSynapseRbac", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> List role assignments. </summary>
        /// <param name="roleId"> Synapse Built-In Role Id. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> ListRoleAssignmentsAsync(string roleId = null, string principalId = null, string scope = null, string continuationToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateListRoleAssignmentsRequest(roleId, principalId, scope, continuationToken, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.ListRoleAssignments");
            scope0.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> List role assignments. </summary>
        /// <param name="roleId"> Synapse Built-In Role Id. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response ListRoleAssignments(string roleId = null, string principalId = null, string scope = null, string continuationToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateListRoleAssignmentsRequest(roleId, principalId, scope, continuationToken, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.ListRoleAssignments");
            scope0.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="ListRoleAssignments"/> and <see cref="ListRoleAssignmentsAsync"/> operations. </summary>
        /// <param name="roleId"> Synapse Built-In Role Id. </param>
        /// <param name="principalId"> Object ID of the AAD principal or security-group. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="continuationToken"> Continuation token. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateListRoleAssignmentsRequest(string roleId = null, string principalId = null, string scope = null, string continuationToken = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/roleAssignments", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (roleId != null)
            {
                uri.AppendQuery("roleId", roleId, true);
            }
            if (principalId != null)
            {
                uri.AppendQuery("principalId", principalId, true);
            }
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            request.Uri = uri;
            if (continuationToken != null)
            {
                request.Headers.Add("x-ms-continuation", continuationToken);
            }
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Create role assignment. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>roleId</term>
        ///     <term>RoleAssignmentRequestRoleId</term>
        ///     <term>Yes</term>
        ///     <term> Role ID of the Synapse Built-In Role. </term>
        ///   </item>
        ///   <item>
        ///     <term>principalId</term>
        ///     <term>RoleAssignmentRequestPrincipalId</term>
        ///     <term>Yes</term>
        ///     <term> Object ID of the AAD principal or security-group. </term>
        ///   </item>
        ///   <item>
        ///     <term>scope</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Scope at which the role assignment is created. </term>
        ///   </item>
        ///   <item>
        ///     <term>principalType</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Type of the principal Id: User, Group or ServicePrincipal. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateRoleAssignmentAsync(string roleAssignmentId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateRoleAssignmentRequest(roleAssignmentId, content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CreateRoleAssignment");
            scope0.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create role assignment. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>roleId</term>
        ///     <term>RoleAssignmentRequestRoleId</term>
        ///     <term>Yes</term>
        ///     <term> Role ID of the Synapse Built-In Role. </term>
        ///   </item>
        ///   <item>
        ///     <term>principalId</term>
        ///     <term>RoleAssignmentRequestPrincipalId</term>
        ///     <term>Yes</term>
        ///     <term> Object ID of the AAD principal or security-group. </term>
        ///   </item>
        ///   <item>
        ///     <term>scope</term>
        ///     <term>string</term>
        ///     <term>Yes</term>
        ///     <term> Scope at which the role assignment is created. </term>
        ///   </item>
        ///   <item>
        ///     <term>principalType</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term> Type of the principal Id: User, Group or ServicePrincipal. </term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateRoleAssignment(string roleAssignmentId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateRoleAssignmentRequest(roleAssignmentId, content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.CreateRoleAssignment");
            scope0.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CreateRoleAssignment"/> and <see cref="CreateRoleAssignmentAsync"/> operations. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCreateRoleAssignmentRequest(string roleAssignmentId, RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/roleAssignments/", false);
            uri.AppendPath(roleAssignmentId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Get role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetRoleAssignmentByIdAsync(string roleAssignmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateGetRoleAssignmentByIdRequest(roleAssignmentId, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.GetRoleAssignmentById");
            scope0.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Get role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetRoleAssignmentById(string roleAssignmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateGetRoleAssignmentByIdRequest(roleAssignmentId, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.GetRoleAssignmentById");
            scope0.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetRoleAssignmentById"/> and <see cref="GetRoleAssignmentByIdAsync"/> operations. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetRoleAssignmentByIdRequest(string roleAssignmentId, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/roleAssignments/", false);
            uri.AppendPath(roleAssignmentId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Delete role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteRoleAssignmentByIdAsync(string roleAssignmentId, string scope = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateDeleteRoleAssignmentByIdRequest(roleAssignmentId, scope, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.DeleteRoleAssignmentById");
            scope0.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 204:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Delete role assignment by role assignment Id. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response DeleteRoleAssignmentById(string roleAssignmentId, string scope = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateDeleteRoleAssignmentByIdRequest(roleAssignmentId, scope, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope0 = _clientDiagnostics.CreateScope("RoleAssignmentsClient.DeleteRoleAssignmentById");
            scope0.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 204:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="DeleteRoleAssignmentById"/> and <see cref="DeleteRoleAssignmentByIdAsync"/> operations. </summary>
        /// <param name="roleAssignmentId"> The ID of the role assignment. </param>
        /// <param name="scope"> Scope of the Synapse Built-in Role. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateDeleteRoleAssignmentByIdRequest(string roleAssignmentId, string scope = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/roleAssignments/", false);
            uri.AppendPath(roleAssignmentId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            if (scope != null)
            {
                uri.AppendQuery("scope", scope, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }
    }
}
