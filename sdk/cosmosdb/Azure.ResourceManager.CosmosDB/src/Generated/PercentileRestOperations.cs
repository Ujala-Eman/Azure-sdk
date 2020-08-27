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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal partial class PercentileRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PercentileRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public PercentileRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListMetricsRequest(string resourceGroupName, string accountName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/databaseAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/percentile/metrics", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            uri.AppendQuery("$filter", filter, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account. This url is only for PBS and Replication Latency data. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, or <paramref name="filter"/> is null. </exception>
        public async Task<Response<PercentileMetricListResult>> ListMetricsAsync(string resourceGroupName, string accountName, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            using var message = CreateListMetricsRequest(resourceGroupName, accountName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PercentileMetricListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PercentileMetricListResult.DeserializePercentileMetricListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account. This url is only for PBS and Replication Latency data. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, or <paramref name="filter"/> is null. </exception>
        public Response<PercentileMetricListResult> ListMetrics(string resourceGroupName, string accountName, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            using var message = CreateListMetricsRequest(resourceGroupName, accountName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PercentileMetricListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PercentileMetricListResult.DeserializePercentileMetricListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
