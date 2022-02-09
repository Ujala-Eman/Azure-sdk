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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of Application and their operations over its parent. </summary>
    public partial class ApplicationCollection : ArmCollection, IEnumerable<Application>, IAsyncEnumerable<Application>
    {
        private readonly ClientDiagnostics _applicationClientDiagnostics;
        private readonly ApplicationsRestOperations _applicationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationCollection"/> class for mocking. </summary>
        protected ApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", Application.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(Application.ResourceType, out string applicationApiVersion);
            _applicationRestClient = new ApplicationsRestOperations(_applicationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, applicationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ApplicationCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string applicationName, ApplicationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationCreateOrUpdateOperation(Client, _applicationClientDiagnostics, Pipeline, _applicationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationName, parameters).Request, response);
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

        /// <summary> Creates a new managed application. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ApplicationCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string applicationName, ApplicationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, applicationName, parameters, cancellationToken);
                var operation = new ApplicationCreateOrUpdateOperation(Client, _applicationClientDiagnostics, Pipeline, _applicationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, applicationName, parameters).Request, response);
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

        /// <summary> Gets the managed application. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public async virtual Task<Response<Application>> GetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _applicationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Application(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<Application> Get(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationName, cancellationToken);
                if (response.Value == null)
                    throw _applicationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Application(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the applications within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Application" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Application> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the applications within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Application" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Application> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Application> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(applicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public async virtual Task<Response<Application>> GetIfExistsAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _applicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Application>(null, response.GetRawResponse());
                return Response.FromValue(new Application(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        public virtual Response<Application> GetIfExists(string applicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationName, nameof(applicationName));

            using var scope = _applicationClientDiagnostics.CreateScope("ApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, applicationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Application>(null, response.GetRawResponse());
                return Response.FromValue(new Application(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Application> IEnumerable<Application>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Application> IAsyncEnumerable<Application>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
