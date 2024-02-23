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
    internal partial class JobStepExecutionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of JobStepExecutionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public JobStepExecutionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByJobExecutionRequestUri(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin, DateTimeOffset? createTimeMax, DateTimeOffset? endTimeMin, DateTimeOffset? endTimeMax, bool? isActive, int? skip, int? top)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/executions/", false);
            uri.AppendPath(jobExecutionId, true);
            uri.AppendPath("/steps", false);
            if (createTimeMin != null)
            {
                uri.AppendQuery("createTimeMin", createTimeMin.Value, "O", true);
            }
            if (createTimeMax != null)
            {
                uri.AppendQuery("createTimeMax", createTimeMax.Value, "O", true);
            }
            if (endTimeMin != null)
            {
                uri.AppendQuery("endTimeMin", endTimeMin.Value, "O", true);
            }
            if (endTimeMax != null)
            {
                uri.AppendQuery("endTimeMax", endTimeMax.Value, "O", true);
            }
            if (isActive != null)
            {
                uri.AppendQuery("isActive", isActive.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByJobExecutionRequest(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin, DateTimeOffset? createTimeMax, DateTimeOffset? endTimeMin, DateTimeOffset? endTimeMax, bool? isActive, int? skip, int? top)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/executions/", false);
            uri.AppendPath(jobExecutionId, true);
            uri.AppendPath("/steps", false);
            if (createTimeMin != null)
            {
                uri.AppendQuery("createTimeMin", createTimeMin.Value, "O", true);
            }
            if (createTimeMax != null)
            {
                uri.AppendQuery("createTimeMax", createTimeMax.Value, "O", true);
            }
            if (endTimeMin != null)
            {
                uri.AppendQuery("endTimeMin", endTimeMin.Value, "O", true);
            }
            if (endTimeMax != null)
            {
                uri.AppendQuery("endTimeMax", endTimeMax.Value, "O", true);
            }
            if (isActive != null)
            {
                uri.AppendQuery("isActive", isActive.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the step executions of a job execution. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<JobExecutionListResult>> ListByJobExecutionAsync(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
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
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobAgentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (jobName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobName));
            }

            using var message = CreateListByJobExecutionRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobExecutionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobExecutionListResult.DeserializeJobExecutionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the step executions of a job execution. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<JobExecutionListResult> ListByJobExecution(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
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
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobAgentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (jobName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobName));
            }

            using var message = CreateListByJobExecutionRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobExecutionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobExecutionListResult.DeserializeJobExecutionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/executions/", false);
            uri.AppendPath(jobExecutionId, true);
            uri.AppendPath("/steps/", false);
            uri.AppendPath(stepName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName)
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
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/jobAgents/", false);
            uri.AppendPath(jobAgentName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/executions/", false);
            uri.AppendPath(jobExecutionId, true);
            uri.AppendPath("/steps/", false);
            uri.AppendPath(stepName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a step execution of a job execution. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The unique id of the job execution. </param>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, <paramref name="jobName"/> or <paramref name="stepName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, <paramref name="jobName"/> or <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SqlServerJobExecutionData>> GetAsync(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName, CancellationToken cancellationToken = default)
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
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobAgentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (jobName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobName));
            }
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }
            if (stepName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(stepName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, stepName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlServerJobExecutionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SqlServerJobExecutionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a step execution of a job execution. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The unique id of the job execution. </param>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, <paramref name="jobName"/> or <paramref name="stepName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, <paramref name="jobName"/> or <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SqlServerJobExecutionData> Get(string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, string stepName, CancellationToken cancellationToken = default)
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
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobAgentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (jobName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobName));
            }
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }
            if (stepName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(stepName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, stepName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SqlServerJobExecutionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SqlServerJobExecutionData.DeserializeSqlServerJobExecutionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SqlServerJobExecutionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByJobExecutionNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin, DateTimeOffset? createTimeMax, DateTimeOffset? endTimeMin, DateTimeOffset? endTimeMax, bool? isActive, int? skip, int? top)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByJobExecutionNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin, DateTimeOffset? createTimeMax, DateTimeOffset? endTimeMin, DateTimeOffset? endTimeMax, bool? isActive, int? skip, int? top)
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

        /// <summary> Lists the step executions of a job execution. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<JobExecutionListResult>> ListByJobExecutionNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
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
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobAgentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (jobName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobName));
            }

            using var message = CreateListByJobExecutionNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobExecutionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JobExecutionListResult.DeserializeJobExecutionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the step executions of a job execution. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<JobExecutionListResult> ListByJobExecutionNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
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
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (serverName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobAgentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }
            if (jobName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(jobName));
            }

            using var message = CreateListByJobExecutionNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JobExecutionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JobExecutionListResult.DeserializeJobExecutionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
