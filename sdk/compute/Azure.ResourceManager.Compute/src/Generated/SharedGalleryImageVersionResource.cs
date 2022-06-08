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

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A Class representing a SharedGalleryImageVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SharedGalleryImageVersionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSharedGalleryImageVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SharedGalleryImageResource" /> using the GetSharedGalleryImageVersion method.
    /// </summary>
    public partial class SharedGalleryImageVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SharedGalleryImageVersionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string galleryUniqueName, string galleryImageName, string galleryImageVersionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sharedGalleryImageVersionClientDiagnostics;
        private readonly SharedGalleryImageVersionsRestOperations _sharedGalleryImageVersionRestClient;
        private readonly SharedGalleryImageVersionData _data;

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageVersionResource"/> class for mocking. </summary>
        protected SharedGalleryImageVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SharedGalleryImageVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SharedGalleryImageVersionResource(ArmClient client, SharedGalleryImageVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SharedGalleryImageVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SharedGalleryImageVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedGalleryImageVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sharedGalleryImageVersionApiVersion);
            _sharedGalleryImageVersionRestClient = new SharedGalleryImageVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedGalleryImageVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/sharedGalleries/images/versions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SharedGalleryImageVersionData Data
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

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: SharedGalleryImageVersions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SharedGalleryImageVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _sharedGalleryImageVersionRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a shared gallery image version by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: SharedGalleryImageVersions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SharedGalleryImageVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sharedGalleryImageVersionClientDiagnostics.CreateScope("SharedGalleryImageVersionResource.Get");
            scope.Start();
            try
            {
                var response = _sharedGalleryImageVersionRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                return Response.FromValue(new SharedGalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
