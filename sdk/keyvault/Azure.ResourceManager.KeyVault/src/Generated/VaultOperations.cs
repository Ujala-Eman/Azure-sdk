// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the operations that can be performed over a specific Vault. </summary>
    public partial class VaultOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, Vault>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private VaultsRestOperations _restClient { get; }
        private PrivateLinkResourcesRestOperations _privateLinkResourcesRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="VaultOperations"/> class for mocking. </summary>
        protected VaultOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VaultOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal VaultOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VaultsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KeyVault/vaults";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<Vault>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Vault(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<Vault> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new Vault(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<VaultsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VaultsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public VaultsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VaultsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Update a key vault in the specified subscription. </summary>
        /// <param name="tags"> The tags that will be assigned to the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VaultData>> UpdateAsync(IDictionary<string, string> tags = null, VaultPatchProperties properties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.Update");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Name, tags, properties, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a key vault in the specified subscription. </summary>
        /// <param name="tags"> The tags that will be assigned to the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VaultData> Update(IDictionary<string, string> tags = null, VaultPatchProperties properties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.Update");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Name, tags, properties, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedVault>> GetDeletedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.GetDeleted");
            scope.Start();
            try
            {
                var response = await _restClient.GetDeletedAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedVault> GetDeleted(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.GetDeleted");
            scope.Start();
            try
            {
                var response = _restClient.GetDeleted(Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="name"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultOperations.CheckNameAvailability");
            scope.Start();
            try
            {
                var response = await _restClient.CheckNameAvailabilityAsync(name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="name"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailability(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultOperations.CheckNameAvailability");
            scope.Start();
            try
            {
                var response = _restClient.CheckNameAvailability(name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources supported for the key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<PrivateLinkResource>>> ListPrivateLinkResourcesByVaultAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.ListPrivateLinkResourcesByVault");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.ListByVaultAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources supported for the key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<PrivateLinkResource>> ListPrivateLinkResourcesByVault(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.ListPrivateLinkResourcesByVault");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.ListByVault(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PurgeDeletedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.PurgeDeleted");
            scope.Start();
            try
            {
                var operation = await StartPurgeDeletedAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PurgeDeleted(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.PurgeDeleted");
            scope.Start();
            try
            {
                var operation = StartPurgeDeleted(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<VaultsPurgeDeletedOperation> StartPurgeDeletedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.StartPurgeDeleted");
            scope.Start();
            try
            {
                var response = await _restClient.PurgeDeletedAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VaultsPurgeDeletedOperation(_clientDiagnostics, Pipeline, _restClient.CreatePurgeDeletedRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public VaultsPurgeDeletedOperation StartPurgeDeleted(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VaultOperations.StartPurgeDeleted");
            scope.Start();
            try
            {
                var response = _restClient.PurgeDeleted(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VaultsPurgeDeletedOperation(_clientDiagnostics, Pipeline, _restClient.CreatePurgeDeletedRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of PrivateEndpointConnections in the Vault. </summary>
        /// <returns> An object representing collection of PrivateEndpointConnections and their operations over a Vault. </returns>
        public PrivateEndpointConnectionContainer GetPrivateEndpointConnections()
        {
            return new PrivateEndpointConnectionContainer(this);
        }
    }
}
