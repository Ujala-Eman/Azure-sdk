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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class ManagedDatabaseTablesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ManagedDatabaseTablesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagedDatabaseTablesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListBySchemaRequestUri(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListBySchemaRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseTableListResult>> ListBySchemaAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (managedInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (schemaName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(schemaName));
            }

            using var message = CreateListBySchemaRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseTableListResult> ListBySchema(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (managedInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (schemaName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(schemaName));
            }

            using var message = CreateListBySchemaRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get managed database table. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseTableData>> GetAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (managedInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (schemaName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(schemaName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
            if (tableName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(tableName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, tableName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseTableData.DeserializeDatabaseTableData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseTableData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get managed database table. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseTableData> Get(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (managedInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (schemaName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(schemaName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
            if (tableName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(tableName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, tableName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseTableData.DeserializeDatabaseTableData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseTableData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListBySchemaNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListBySchemaNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseTableListResult>> ListBySchemaNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (managedInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (schemaName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(schemaName));
            }

            using var message = CreateListBySchemaNextPageRequest(nextLink, subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List managed database tables. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="schemaName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseTableListResult> ListBySchemaNextPage(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (managedInstanceName == null)
            {
                throw new ArgumentNullException(nameof(managedInstanceName));
            }
            if (managedInstanceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(managedInstanceName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (databaseName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(databaseName));
            }
            if (schemaName == null)
            {
                throw new ArgumentNullException(nameof(schemaName));
            }
            if (schemaName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(schemaName));
            }

            using var message = CreateListBySchemaNextPageRequest(nextLink, subscriptionId, resourceGroupName, managedInstanceName, databaseName, schemaName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseTableListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseTableListResult.DeserializeDatabaseTableListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
