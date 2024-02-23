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
using Azure.ResourceManager.ManagementGroups.Models;

namespace Azure.ResourceManager.ManagementGroups
{
    internal partial class EntitiesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of EntitiesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public EntitiesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string skipToken, int? skip, int? top, string select, EntitySearchOption? search, string filter, EntityViewOption? view, string groupName, string cacheControl)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/getEntities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skiptoken", skipToken, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            if (search != null)
            {
                uri.AppendQuery("$search", search.Value.ToString(), true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (view != null)
            {
                uri.AppendQuery("$view", view.Value.ToString(), true);
            }
            if (groupName != null)
            {
                uri.AppendQuery("groupName", groupName, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string skipToken, int? skip, int? top, string select, EntitySearchOption? search, string filter, EntityViewOption? view, string groupName, string cacheControl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Management/getEntities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skiptoken", skipToken, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            if (search != null)
            {
                uri.AppendQuery("$search", search.Value.ToString(), true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (view != null)
            {
                uri.AppendQuery("$view", view.Value.ToString(), true);
            }
            if (groupName != null)
            {
                uri.AppendQuery("groupName", groupName, true);
            }
            request.Uri = uri;
            if (cacheControl != null)
            {
                request.Headers.Add("Cache-Control", cacheControl);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the authenticated user.
        ///
        /// </summary>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="skip"> Number of entities to skip over when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="select"> This parameter specifies the fields to include in the response. Can include any combination of Name,DisplayName,Type,ParentDisplayNameChain,ParentChain, e.g. '$select=Name,DisplayName,Type,ParentDisplayNameChain,ParentNameChain'. When specified the $select parameter can override select in $skipToken. </param>
        /// <param name="search">
        /// The $search parameter is used in conjunction with the $filter parameter to return three different outputs depending on the parameter passed in.
        /// With $search=AllowedParents the API will return the entity info of all groups that the requested entity will be able to reparent to as determined by the user's permissions.
        /// With $search=AllowedChildren the API will return the entity info of all entities that can be added as children of the requested entity.
        /// With $search=ParentAndFirstLevelChildren the API will return the parent and  first level of children that the user has either direct access to or indirect access via one of their descendants.
        /// With $search=ParentOnly the API will return only the group if the user has access to at least one of the descendants of the group.
        /// With $search=ChildrenOnly the API will return only the first level of children of the group entity info specified in $filter.  The user must have direct access to the children entities or one of it's descendants for it to show up in the results.
        /// </param>
        /// <param name="filter"> The filter parameter allows you to filter on the the name or display name fields. You can check for equality on the name field (e.g. name eq '{entityName}')  and you can check for substrings on either the name or display name fields(e.g. contains(name, '{substringToSearch}'), contains(displayName, '{substringToSearch')). Note that the '{entityName}' and '{substringToSearch}' fields are checked case insensitively. </param>
        /// <param name="view"> The view parameter allows clients to filter the type of data that is returned by the getEntities call. </param>
        /// <param name="groupName"> A filter which allows the get entities call to focus on a particular group (i.e. "$filter=name eq 'groupName'"). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<EntityListResult>> ListAsync(string skipToken = null, int? skip = null, int? top = null, string select = null, EntitySearchOption? search = null, string filter = null, EntityViewOption? view = null, string groupName = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(skipToken, skip, top, select, search, filter, view, groupName, cacheControl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EntityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EntityListResult.DeserializeEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the authenticated user.
        ///
        /// </summary>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="skip"> Number of entities to skip over when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="select"> This parameter specifies the fields to include in the response. Can include any combination of Name,DisplayName,Type,ParentDisplayNameChain,ParentChain, e.g. '$select=Name,DisplayName,Type,ParentDisplayNameChain,ParentNameChain'. When specified the $select parameter can override select in $skipToken. </param>
        /// <param name="search">
        /// The $search parameter is used in conjunction with the $filter parameter to return three different outputs depending on the parameter passed in.
        /// With $search=AllowedParents the API will return the entity info of all groups that the requested entity will be able to reparent to as determined by the user's permissions.
        /// With $search=AllowedChildren the API will return the entity info of all entities that can be added as children of the requested entity.
        /// With $search=ParentAndFirstLevelChildren the API will return the parent and  first level of children that the user has either direct access to or indirect access via one of their descendants.
        /// With $search=ParentOnly the API will return only the group if the user has access to at least one of the descendants of the group.
        /// With $search=ChildrenOnly the API will return only the first level of children of the group entity info specified in $filter.  The user must have direct access to the children entities or one of it's descendants for it to show up in the results.
        /// </param>
        /// <param name="filter"> The filter parameter allows you to filter on the the name or display name fields. You can check for equality on the name field (e.g. name eq '{entityName}')  and you can check for substrings on either the name or display name fields(e.g. contains(name, '{substringToSearch}'), contains(displayName, '{substringToSearch')). Note that the '{entityName}' and '{substringToSearch}' fields are checked case insensitively. </param>
        /// <param name="view"> The view parameter allows clients to filter the type of data that is returned by the getEntities call. </param>
        /// <param name="groupName"> A filter which allows the get entities call to focus on a particular group (i.e. "$filter=name eq 'groupName'"). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<EntityListResult> List(string skipToken = null, int? skip = null, int? top = null, string select = null, EntitySearchOption? search = null, string filter = null, EntityViewOption? view = null, string groupName = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(skipToken, skip, top, select, search, filter, view, groupName, cacheControl);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EntityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EntityListResult.DeserializeEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string skipToken, int? skip, int? top, string select, EntitySearchOption? search, string filter, EntityViewOption? view, string groupName, string cacheControl)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string skipToken, int? skip, int? top, string select, EntitySearchOption? search, string filter, EntityViewOption? view, string groupName, string cacheControl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (cacheControl != null)
            {
                request.Headers.Add("Cache-Control", cacheControl);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the authenticated user.
        ///
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="skip"> Number of entities to skip over when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="select"> This parameter specifies the fields to include in the response. Can include any combination of Name,DisplayName,Type,ParentDisplayNameChain,ParentChain, e.g. '$select=Name,DisplayName,Type,ParentDisplayNameChain,ParentNameChain'. When specified the $select parameter can override select in $skipToken. </param>
        /// <param name="search">
        /// The $search parameter is used in conjunction with the $filter parameter to return three different outputs depending on the parameter passed in.
        /// With $search=AllowedParents the API will return the entity info of all groups that the requested entity will be able to reparent to as determined by the user's permissions.
        /// With $search=AllowedChildren the API will return the entity info of all entities that can be added as children of the requested entity.
        /// With $search=ParentAndFirstLevelChildren the API will return the parent and  first level of children that the user has either direct access to or indirect access via one of their descendants.
        /// With $search=ParentOnly the API will return only the group if the user has access to at least one of the descendants of the group.
        /// With $search=ChildrenOnly the API will return only the first level of children of the group entity info specified in $filter.  The user must have direct access to the children entities or one of it's descendants for it to show up in the results.
        /// </param>
        /// <param name="filter"> The filter parameter allows you to filter on the the name or display name fields. You can check for equality on the name field (e.g. name eq '{entityName}')  and you can check for substrings on either the name or display name fields(e.g. contains(name, '{substringToSearch}'), contains(displayName, '{substringToSearch')). Note that the '{entityName}' and '{substringToSearch}' fields are checked case insensitively. </param>
        /// <param name="view"> The view parameter allows clients to filter the type of data that is returned by the getEntities call. </param>
        /// <param name="groupName"> A filter which allows the get entities call to focus on a particular group (i.e. "$filter=name eq 'groupName'"). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<EntityListResult>> ListNextPageAsync(string nextLink, string skipToken = null, int? skip = null, int? top = null, string select = null, EntitySearchOption? search = null, string filter = null, EntityViewOption? view = null, string groupName = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, skipToken, skip, top, select, search, filter, view, groupName, cacheControl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EntityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EntityListResult.DeserializeEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the authenticated user.
        ///
        /// </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="skip"> Number of entities to skip over when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="select"> This parameter specifies the fields to include in the response. Can include any combination of Name,DisplayName,Type,ParentDisplayNameChain,ParentChain, e.g. '$select=Name,DisplayName,Type,ParentDisplayNameChain,ParentNameChain'. When specified the $select parameter can override select in $skipToken. </param>
        /// <param name="search">
        /// The $search parameter is used in conjunction with the $filter parameter to return three different outputs depending on the parameter passed in.
        /// With $search=AllowedParents the API will return the entity info of all groups that the requested entity will be able to reparent to as determined by the user's permissions.
        /// With $search=AllowedChildren the API will return the entity info of all entities that can be added as children of the requested entity.
        /// With $search=ParentAndFirstLevelChildren the API will return the parent and  first level of children that the user has either direct access to or indirect access via one of their descendants.
        /// With $search=ParentOnly the API will return only the group if the user has access to at least one of the descendants of the group.
        /// With $search=ChildrenOnly the API will return only the first level of children of the group entity info specified in $filter.  The user must have direct access to the children entities or one of it's descendants for it to show up in the results.
        /// </param>
        /// <param name="filter"> The filter parameter allows you to filter on the the name or display name fields. You can check for equality on the name field (e.g. name eq '{entityName}')  and you can check for substrings on either the name or display name fields(e.g. contains(name, '{substringToSearch}'), contains(displayName, '{substringToSearch')). Note that the '{entityName}' and '{substringToSearch}' fields are checked case insensitively. </param>
        /// <param name="view"> The view parameter allows clients to filter the type of data that is returned by the getEntities call. </param>
        /// <param name="groupName"> A filter which allows the get entities call to focus on a particular group (i.e. "$filter=name eq 'groupName'"). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<EntityListResult> ListNextPage(string nextLink, string skipToken = null, int? skip = null, int? top = null, string select = null, EntitySearchOption? search = null, string filter = null, EntityViewOption? view = null, string groupName = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, skipToken, skip, top, select, search, filter, view, groupName, cacheControl);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EntityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EntityListResult.DeserializeEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
