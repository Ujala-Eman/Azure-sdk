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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdSecret and their operations over its parent. </summary>
    public partial class AfdSecretCollection : ArmCollection, IEnumerable<AfdSecret>, IAsyncEnumerable<AfdSecret>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdSecretsRestOperations _afdSecretsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdSecretCollection"/> class for mocking. </summary>
        protected AfdSecretCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdSecretCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdSecretCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(AfdSecret.ResourceType, out string apiVersion);
            _afdSecretsRestClient = new AfdSecretsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new Secret within the specified profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="secret"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secret"/> is null. </exception>
        public virtual AfdSecretCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string secretName, AfdSecretData secret, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdSecretsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret, cancellationToken);
                var operation = new AfdSecretCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _afdSecretsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret).Request, response);
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

        /// <summary> Creates a new Secret within the specified profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="secret"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secret"/> is null. </exception>
        public async virtual Task<AfdSecretCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string secretName, AfdSecretData secret, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }
            if (secret == null)
            {
                throw new ArgumentNullException(nameof(secret));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdSecretsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret, cancellationToken).ConfigureAwait(false);
                var operation = new AfdSecretCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _afdSecretsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, secret).Request, response);
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

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        public virtual Response<AfdSecret> Get(string secretName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.Get");
            scope.Start();
            try
            {
                var response = _afdSecretsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdSecret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing Secret within a profile. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        public async virtual Task<Response<AfdSecret>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdSecretsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdSecret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        public virtual Response<AfdSecret> GetIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdSecretsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdSecret>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        public async virtual Task<Response<AfdSecret>> GetIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdSecretsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdSecret>(null, response.GetRawResponse());
                return Response.FromValue(new AfdSecret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string secretName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.Exists");
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

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(secretName))
            {
                throw new ArgumentException($"Parameter {nameof(secretName)} cannot be null or empty", nameof(secretName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.Exists");
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

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdSecret> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdSecret> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecretsRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdSecret> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdSecretsRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists existing AzureFrontDoor secrets. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdSecret" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdSecret> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdSecret>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecretsRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdSecret>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdSecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdSecretsRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdSecret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
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

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AfdSecret, AfdSecretData> Construct() { }
    }
}
