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
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    internal partial class ActivityLogAlertsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ActivityLogAlertsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public ActivityLogAlertsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
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

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string activityLogAlertName, ActivityLogAlertResource activityLogAlert)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/activityLogAlerts/", false);
            uri.AppendPath(activityLogAlertName, true);
            uri.AppendQuery("api-version", "2017-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(activityLogAlert);
            request.Content = content;
            return message;
        }

        /// <summary> Create a new activity log alert or update an existing one. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="activityLogAlert"> The activity log alert to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="activityLogAlertName"/>, or <paramref name="activityLogAlert"/> is null. </exception>
        public async Task<Response<ActivityLogAlertResource>> CreateOrUpdateAsync(string resourceGroupName, string activityLogAlertName, ActivityLogAlertResource activityLogAlert, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }
            if (activityLogAlert == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlert));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, activityLogAlertName, activityLogAlert);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ActivityLogAlertResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActivityLogAlertResource.DeserializeActivityLogAlertResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a new activity log alert or update an existing one. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="activityLogAlert"> The activity log alert to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="activityLogAlertName"/>, or <paramref name="activityLogAlert"/> is null. </exception>
        public Response<ActivityLogAlertResource> CreateOrUpdate(string resourceGroupName, string activityLogAlertName, ActivityLogAlertResource activityLogAlert, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }
            if (activityLogAlert == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlert));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, activityLogAlertName, activityLogAlert);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ActivityLogAlertResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActivityLogAlertResource.DeserializeActivityLogAlertResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string activityLogAlertName)
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
            uri.AppendPath("/providers/microsoft.insights/activityLogAlerts/", false);
            uri.AppendPath(activityLogAlertName, true);
            uri.AppendQuery("api-version", "2017-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get an activity log alert. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="activityLogAlertName"/> is null. </exception>
        public async Task<Response<ActivityLogAlertResource>> GetAsync(string resourceGroupName, string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var message = CreateGetRequest(resourceGroupName, activityLogAlertName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActivityLogAlertResource.DeserializeActivityLogAlertResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get an activity log alert. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="activityLogAlertName"/> is null. </exception>
        public Response<ActivityLogAlertResource> Get(string resourceGroupName, string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var message = CreateGetRequest(resourceGroupName, activityLogAlertName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActivityLogAlertResource.DeserializeActivityLogAlertResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string activityLogAlertName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/activityLogAlerts/", false);
            uri.AppendPath(activityLogAlertName, true);
            uri.AppendQuery("api-version", "2017-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete an activity log alert. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="activityLogAlertName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, activityLogAlertName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete an activity log alert. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="activityLogAlertName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string activityLogAlertName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, activityLogAlertName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string activityLogAlertName, ActivityLogAlertPatchBody activityLogAlertPatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/activityLogAlerts/", false);
            uri.AppendPath(activityLogAlertName, true);
            uri.AppendQuery("api-version", "2017-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(activityLogAlertPatch);
            request.Content = content;
            return message;
        }

        /// <summary> Updates an existing ActivityLogAlertResource&apos;s tags. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="activityLogAlertPatch"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="activityLogAlertName"/>, or <paramref name="activityLogAlertPatch"/> is null. </exception>
        public async Task<Response<ActivityLogAlertResource>> UpdateAsync(string resourceGroupName, string activityLogAlertName, ActivityLogAlertPatchBody activityLogAlertPatch, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }
            if (activityLogAlertPatch == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertPatch));
            }

            using var message = CreateUpdateRequest(resourceGroupName, activityLogAlertName, activityLogAlertPatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActivityLogAlertResource.DeserializeActivityLogAlertResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates an existing ActivityLogAlertResource&apos;s tags. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="activityLogAlertName"> The name of the activity log alert. </param>
        /// <param name="activityLogAlertPatch"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="activityLogAlertName"/>, or <paramref name="activityLogAlertPatch"/> is null. </exception>
        public Response<ActivityLogAlertResource> Update(string resourceGroupName, string activityLogAlertName, ActivityLogAlertPatchBody activityLogAlertPatch, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (activityLogAlertName == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertName));
            }
            if (activityLogAlertPatch == null)
            {
                throw new ArgumentNullException(nameof(activityLogAlertPatch));
            }

            using var message = CreateUpdateRequest(resourceGroupName, activityLogAlertName, activityLogAlertPatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActivityLogAlertResource.DeserializeActivityLogAlertResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionIdRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/activityLogAlerts", false);
            uri.AppendQuery("api-version", "2017-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a list of all activity log alerts in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ActivityLogAlertList>> ListBySubscriptionIdAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListBySubscriptionIdRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActivityLogAlertList.DeserializeActivityLogAlertList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a list of all activity log alerts in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ActivityLogAlertList> ListBySubscriptionId(CancellationToken cancellationToken = default)
        {
            using var message = CreateListBySubscriptionIdRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActivityLogAlertList.DeserializeActivityLogAlertList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string resourceGroupName)
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
            uri.AppendPath("/providers/microsoft.insights/activityLogAlerts", false);
            uri.AppendQuery("api-version", "2017-04-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a list of all activity log alerts in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<ActivityLogAlertList>> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActivityLogAlertList.DeserializeActivityLogAlertList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a list of all activity log alerts in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<ActivityLogAlertList> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActivityLogAlertList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActivityLogAlertList.DeserializeActivityLogAlertList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
