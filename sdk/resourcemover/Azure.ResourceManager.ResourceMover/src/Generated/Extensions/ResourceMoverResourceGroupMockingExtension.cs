// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceMoverResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceMoverResourceGroupMockingExtension"/> class for mocking. </summary>
        protected ResourceMoverResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceMoverResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceMoverResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MoverResourceSetResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MoverResourceSetResources and their operations over a MoverResourceSetResource. </returns>
        public virtual MoverResourceSetCollection GetMoverResourceSets()
        {
            return GetCachedClient(Client => new MoverResourceSetCollection(Client, Id));
        }

        /// <summary>
        /// Gets the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<MoverResourceSetResource>> GetMoverResourceSetAsync(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            return await GetMoverResourceSets().GetAsync(moverResourceSetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<MoverResourceSetResource> GetMoverResourceSet(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            return GetMoverResourceSets().Get(moverResourceSetName, cancellationToken);
        }
    }
}
