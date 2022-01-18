// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceEnvironment and their operations over its parent. </summary>
    public partial class AppServiceEnvironmentCollection : ArmCollection, IEnumerable<AppServiceEnvironment>, IAsyncEnumerable<AppServiceEnvironment>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _appServiceEnvironmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceEnvironmentCollection"/> class for mocking. </summary>
        protected AppServiceEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceEnvironmentCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AppServiceEnvironmentCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(AppServiceEnvironment.ResourceType, out string apiVersion);
            _appServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceEnvironments_CreateOrUpdate
        /// <summary> Description for Create or update an App Service Environment. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="hostingEnvironmentEnvelope"> Configuration details of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostingEnvironmentEnvelope"/> is null. </exception>
        public virtual AppServiceEnvironmentCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string name, AppServiceEnvironmentData hostingEnvironmentEnvelope, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }
            if (hostingEnvironmentEnvelope == null)
            {
                throw new ArgumentNullException(nameof(hostingEnvironmentEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope, cancellationToken);
                var operation = new AppServiceEnvironmentCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceEnvironments_CreateOrUpdate
        /// <summary> Description for Create or update an App Service Environment. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="hostingEnvironmentEnvelope"> Configuration details of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostingEnvironmentEnvelope"/> is null. </exception>
        public async virtual Task<AppServiceEnvironmentCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string name, AppServiceEnvironmentData hostingEnvironmentEnvelope, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }
            if (hostingEnvironmentEnvelope == null)
            {
                throw new ArgumentNullException(nameof(hostingEnvironmentEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceEnvironmentCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _appServiceEnvironmentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, hostingEnvironmentEnvelope).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceEnvironments_Get
        /// <summary> Description for Get the properties of an App Service Environment. </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        public virtual Response<AppServiceEnvironment> Get(string name, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceEnvironments_Get
        /// <summary> Description for Get the properties of an App Service Environment. </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        public async virtual Task<Response<AppServiceEnvironment>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AppServiceEnvironment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        public virtual Response<AppServiceEnvironment> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceEnvironmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AppServiceEnvironment>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        public async virtual Task<Response<AppServiceEnvironment>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServiceEnvironmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AppServiceEnvironment>(null, response.GetRawResponse());
                return Response.FromValue(new AppServiceEnvironment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"Parameter {nameof(name)} cannot be null or empty", nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceEnvironments_ListByResourceGroup
        /// <summary> Description for Get all App Service Environments in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceEnvironment" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceEnvironment> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceEnvironment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceEnvironment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceEnvironmentsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: AppServiceEnvironments_ListByResourceGroup
        /// <summary> Description for Get all App Service Environments in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceEnvironment" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceEnvironment> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceEnvironment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceEnvironment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceEnvironmentsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceEnvironment(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AppServiceEnvironment" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AppServiceEnvironment.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AppServiceEnvironment" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AppServiceEnvironmentCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AppServiceEnvironment.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppServiceEnvironment> IEnumerable<AppServiceEnvironment>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceEnvironment> IAsyncEnumerable<AppServiceEnvironment>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AppServiceEnvironment, AppServiceEnvironmentData> Construct() { }
    }
}
