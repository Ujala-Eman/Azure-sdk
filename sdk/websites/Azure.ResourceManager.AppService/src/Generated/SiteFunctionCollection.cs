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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of FunctionEnvelope and their operations over its parent. </summary>
    public partial class SiteFunctionCollection : ArmCollection, IEnumerable<SiteFunction>, IAsyncEnumerable<SiteFunction>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteFunctionCollection"/> class for mocking. </summary>
        protected SiteFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteFunctionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteFunctionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteFunction.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateFunction
        /// <summary> Description for Create function for web site, or a deployment slot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="functionEnvelope"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionEnvelope"/> is null. </exception>
        public virtual SiteFunctionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string functionName, FunctionEnvelopeData functionEnvelope, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }
            if (functionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(functionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope, cancellationToken);
                var operation = new SiteFunctionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webAppsRestClient.CreateCreateFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateFunction
        /// <summary> Description for Create function for web site, or a deployment slot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="functionEnvelope"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionEnvelope"/> is null. </exception>
        public async virtual Task<SiteFunctionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string functionName, FunctionEnvelopeData functionEnvelope, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }
            if (functionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(functionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new SiteFunctionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webAppsRestClient.CreateCreateFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetFunction
        /// <summary> Description for Get function information by its ID for web site, or a deployment slot. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        public virtual Response<SiteFunction> Get(string functionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteFunction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetFunction
        /// <summary> Description for Get function information by its ID for web site, or a deployment slot. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        public async virtual Task<Response<SiteFunction>> GetAsync(string functionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteFunction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        public virtual Response<SiteFunction> GetIfExists(string functionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteFunction>(null, response.GetRawResponse());
                return Response.FromValue(new SiteFunction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        public async virtual Task<Response<SiteFunction>> GetIfExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteFunction>(null, response.GetRawResponse());
                return Response.FromValue(new SiteFunction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string functionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(functionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                throw new ArgumentException($"Parameter {nameof(functionName)} cannot be null or empty", nameof(functionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListFunctions
        /// <summary> Description for List the functions for a web site, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteFunction" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteFunction> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteFunction> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListFunctions(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteFunction> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListFunctionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListFunctions
        /// <summary> Description for List the functions for a web site, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteFunction" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteFunction> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteFunction>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListFunctionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteFunction>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListFunctionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteFunction> IEnumerable<SiteFunction>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteFunction> IAsyncEnumerable<SiteFunction>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteFunction, FunctionEnvelopeData> Construct() { }
    }
}
