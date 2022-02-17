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

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdSecret and their operations over its parent. </summary>
    public partial class AfdSecretCollection : ArmCollection, IEnumerable<AfdSecret>, IAsyncEnumerable<AfdSecret>
    {
        private readonly ClientDiagnostics _afdSecretClientDiagnostics;
        private readonly AfdSecretsRestOperations _afdSecretRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdSecretCollection"/> class for mocking. </summary>
        protected AfdSecretCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdSecretCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AfdSecretCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdSecretClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", AfdSecret.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(AfdSecret.ResourceType, out string afdSecretApiVersion);
            _afdSecretRestClient = new AfdSecretsRestOperations(_afdSecretClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdSecretApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Secret within the specified profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="secret"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="secret"/> is null. </exception>
        public async virtual Task<ArmOperation<AfdSecret>> CreateOrUpdateAsync(bool waitForCompletion, string secretName, AfdSecretData secret, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdSecretRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdSecret>(new AfdSecretOperationSource(Client), _afdSecretClientDiagnostics, Pipeline, _afdSecretRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Creates a new Secret within the specified profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="secret"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="secret"/> is null. </exception>
        public virtual ArmOperation<AfdSecret> CreateOrUpdate(bool waitForCompletion, string secretName, AfdSecretData secret, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdSecretRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret, cancellationToken);
                var operation = new CdnArmOperation<AfdSecret>(new AfdSecretOperationSource(Client), _afdSecretClientDiagnostics, Pipeline, _afdSecretRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Gets an existing Secret within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Get
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<AfdSecret>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdSecretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdSecretClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdSecret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing Secret within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Get
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<AfdSecret> Get(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.Get");
            scope.Start();
            try
            {
                var response = _afdSecretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw _afdSecretClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdSecret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists existing AzureFrontDoor secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets
        /// Operation Id: AfdSecrets_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdSecret> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdSecret>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecretRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdSecret>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecretRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists existing AzureFrontDoor secrets.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets
        /// Operation Id: AfdSecrets_ListByProfile
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdSecret> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdSecret> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecretRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdSecret> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecretRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Get
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Get
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<bool> Exists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(secretName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Get
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<AfdSecret>> GetIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdSecretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdSecret>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}
        /// Operation Id: AfdSecrets_Get
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<AfdSecret> GetIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _afdSecretClientDiagnostics.CreateScope("AfdSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdSecretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdSecret>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecret(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AfdSecret> IEnumerable<AfdSecret>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdSecret> IAsyncEnumerable<AfdSecret>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
