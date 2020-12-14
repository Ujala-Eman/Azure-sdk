// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    // Some Manual Change

    /// <summary>
    /// EntitiesOperations operations.
    /// </summary>
    internal partial class EntitiesOperations : IServiceOperations<ManagementGroupsAPIClient>, IEntitiesOperations
    {
        /// <summary>
        /// Initializes a new instance of the EntitiesOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal EntitiesOperations(ManagementGroupsAPIClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the ManagementGroupsAPIClient
        /// </summary>
        public ManagementGroupsAPIClient Client { get; private set; }

        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the
        /// authenticated user.
        /// </summary>
        /// <param name='skiptoken'>
        /// Page continuation token is only used if a previous operation returned a
        /// partial result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a token parameter that specifies
        /// a starting point to use for subsequent calls.
        /// </param>
        /// <param name='skip'>
        /// Number of entities to skip over when retrieving results. Passing this in
        /// will override $skipToken.
        /// </param>
        /// <param name='top'>
        /// Number of elements to return when retrieving results. Passing this in will
        /// override $skipToken.
        /// </param>
        /// <param name='select'>
        /// This parameter specifies the fields to include in the response. Can include
        /// any combination of
        /// Name,DisplayName,Type,ParentDisplayNameChain,ParentChain, e.g.
        /// '$select=Name,DisplayName,Type,ParentDisplayNameChain,ParentNameChain'.
        /// When specified the $select parameter can override select in $skipToken.
        /// </param>
        /// <param name='search'>
        /// The $search parameter is used in conjunction with the $filter parameter to
        /// return three different outputs depending on the parameter passed in. With
        /// $search=AllowedParents the API will return the entity info of all groups
        /// that the requested entity will be able to reparent to as determined by the
        /// user's permissions. With $search=AllowedChildren the API will return the
        /// entity info of all entities that can be added as children of the requested
        /// entity. With $search=ParentAndFirstLevelChildren the API will return the
        /// parent and  first level of children that the user has either direct access
        /// to or indirect access via one of their descendants. Possible values
        /// include: 'AllowedParents', 'AllowedChildren', 'ParentAndFirstLevelChildren'
        /// </param>
        /// <param name='filter'>
        /// The filter parameter allows you to filter on the the name or display name
        /// fields. You can check for equality on the name field (e.g. name eq
        /// '{entityName}')  and you can check for substrings on either the name or
        /// display name fields(e.g. contains(name, '{substringToSearch}'),
        /// contains(displayName, '{substringToSearch')). Note that the '{entityName}'
        /// and '{substringToSearch}' fields are checked case insensitively.
        /// </param>
        /// <param name='view'>
        /// The view parameter allows clients to filter the type of data that is
        /// returned by the getEntities call. Possible values include: 'FullHierarchy',
        /// 'GroupsOnly', 'SubscriptionsOnly', 'Audit'
        /// </param>
        /// <param name='groupName'>
        /// A filter which allows the get entities call to focus on a particular group
        /// (i.e. "$filter=name eq 'groupName'")
        /// </param>
        /// <param name='cacheControl'>
        /// Indicates that the request shouldn't utilize any caches.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<IPage<EntityInfo>>> ListWithHttpMessagesAsync(string skiptoken = default(string), int? skip = default(int?), int? top = default(int?), string select = default(string), string search = default(string), string filter = default(string), string view = default(string), string groupName = default(string), string cacheControl = "no-cache", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (Client.ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.Client.ApiVersion");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("skiptoken", skiptoken);
                tracingParameters.Add("skip", skip);
                tracingParameters.Add("top", top);
                tracingParameters.Add("select", select);
                tracingParameters.Add("search", search);
                tracingParameters.Add("filter", filter);
                tracingParameters.Add("view", view);
                tracingParameters.Add("groupName", groupName);
                tracingParameters.Add("cacheControl", cacheControl);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "List", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "providers/Microsoft.Management/getEntities").ToString();
            List<string> _queryParameters = new List<string>();
            if (Client.ApiVersion != null)
            {
                _queryParameters.Add(string.Format("api-version={0}", System.Uri.EscapeDataString(Client.ApiVersion)));
            }
            if (skiptoken != null)
            {
                _queryParameters.Add(string.Format("$skiptoken={0}", System.Uri.EscapeDataString(skiptoken)));
            }
            if (skip != null)
            {
                _queryParameters.Add(string.Format("$skip={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(skip, Client.SerializationSettings).Trim('"'))));
            }
            if (top != null)
            {
                _queryParameters.Add(string.Format("$top={0}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(top, Client.SerializationSettings).Trim('"'))));
            }
            if (select != null)
            {
                _queryParameters.Add(string.Format("$select={0}", System.Uri.EscapeDataString(select)));
            }
            if (search != null)
            {
                _queryParameters.Add(string.Format("$search={0}", System.Uri.EscapeDataString(search)));
            }
            if (filter != null)
            {
                _queryParameters.Add(string.Format("$filter={0}", System.Uri.EscapeDataString(filter)));
            }
            if (view != null)
            {
                _queryParameters.Add(string.Format("$view={0}", System.Uri.EscapeDataString(view)));
            }
            if (groupName != null)
            {
                _queryParameters.Add(string.Format("groupName={0}", System.Uri.EscapeDataString(groupName)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (cacheControl != null)
            {
                if (_httpRequest.Headers.Contains("Cache-Control"))
                {
                    _httpRequest.Headers.Remove("Cache-Control");
                }
                _httpRequest.Headers.TryAddWithoutValidation("Cache-Control", cacheControl);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorResponseException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ErrorResponse _errorBody =  Rest.Serialization.SafeJsonConvert.DeserializeObject<ErrorResponse>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<IPage<EntityInfo>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<Page<EntityInfo>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the
        /// authenticated user.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cacheControl'>
        /// Indicates that the request shouldn't utilize any caches.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<IPage<EntityInfo>>> ListNextWithHttpMessagesAsync(string nextPageLink, string cacheControl = "no-cache", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (nextPageLink == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "nextPageLink");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("nextPageLink", nextPageLink);
                tracingParameters.Add("cacheControl", cacheControl);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "ListNext", tracingParameters);
            }
            // Construct URL
            string _url = "{nextLink}";
            _url = _url.Replace("{nextLink}", nextPageLink);
            List<string> _queryParameters = new List<string>();
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (cacheControl != null)
            {
                if (_httpRequest.Headers.Contains("Cache-Control"))
                {
                    _httpRequest.Headers.Remove("Cache-Control");
                }
                _httpRequest.Headers.TryAddWithoutValidation("Cache-Control", cacheControl);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorResponseException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    ErrorResponse _errorBody =  Rest.Serialization.SafeJsonConvert.DeserializeObject<ErrorResponse>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<IPage<EntityInfo>>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<Page<EntityInfo>>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
