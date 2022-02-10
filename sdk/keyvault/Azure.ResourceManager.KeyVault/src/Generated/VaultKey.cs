// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A Class representing a VaultKey along with the instance operations that can be performed on it. </summary>
    public partial class VaultKey : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VaultKey"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string keyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _vaultKeyKeysClientDiagnostics;
        private readonly KeysRestOperations _vaultKeyKeysRestClient;
        private readonly KeyData _data;

        /// <summary> Initializes a new instance of the <see cref="VaultKey"/> class for mocking. </summary>
        protected VaultKey()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VaultKey"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VaultKey(ArmClient client, KeyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VaultKey"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VaultKey(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vaultKeyKeysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string vaultKeyKeysApiVersion);
            _vaultKeyKeysRestClient = new KeysRestOperations(_vaultKeyKeysClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vaultKeyKeysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KeyVault/vaults/keys";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual KeyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of VaultKeyVersions in the VaultKeyVersion. </summary>
        /// <returns> An object representing collection of VaultKeyVersions and their operations over a VaultKeyVersion. </returns>
        public virtual VaultKeyVersionCollection GetVaultKeyVersions()
        {
            return new VaultKeyVersionCollection(Client, Id);
        }

        /// <summary>
        /// Gets the current version of the specified key from the specified key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VaultKey>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKey.Get");
            scope.Start();
            try
            {
                var response = await _vaultKeyKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _vaultKeyKeysClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VaultKey(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the current version of the specified key from the specified key vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// Operation Id: Keys_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VaultKey> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _vaultKeyKeysClientDiagnostics.CreateScope("VaultKey.Get");
            scope.Start();
            try
            {
                var response = _vaultKeyKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _vaultKeyKeysClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultKey(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
