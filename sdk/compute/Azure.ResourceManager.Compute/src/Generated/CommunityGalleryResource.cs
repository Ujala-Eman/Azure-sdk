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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A Class representing a CommunityGallery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CommunityGalleryResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCommunityGalleryResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetCommunityGallery method.
    /// </summary>
    public partial class CommunityGalleryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CommunityGalleryResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string publicGalleryName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _communityGalleryClientDiagnostics;
        private readonly CommunityGalleriesRestOperations _communityGalleryRestClient;
        private readonly CommunityGalleryData _data;

        /// <summary> Initializes a new instance of the <see cref="CommunityGalleryResource"/> class for mocking. </summary>
        protected CommunityGalleryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CommunityGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CommunityGalleryResource(ArmClient client, CommunityGalleryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CommunityGalleryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CommunityGalleryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _communityGalleryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string communityGalleryApiVersion);
            _communityGalleryRestClient = new CommunityGalleriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, communityGalleryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/communityGalleries";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CommunityGalleryData Data
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

        /// <summary> Gets a collection of CommunityGalleryImageResources in the CommunityGallery. </summary>
        /// <returns> An object representing collection of CommunityGalleryImageResources and their operations over a CommunityGalleryImageResource. </returns>
        public virtual CommunityGalleryImageCollection GetCommunityGalleryImages()
        {
            return GetCachedClient(client => new CommunityGalleryImageCollection(client, Id));
        }

        /// <summary>
        /// Get a community gallery image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CommunityGalleryImageResource>> GetCommunityGalleryImageAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            return await GetCommunityGalleryImages().GetAsync(galleryImageName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a community gallery image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CommunityGalleryImageResource> GetCommunityGalleryImage(string galleryImageName, CancellationToken cancellationToken = default)
        {
            return GetCommunityGalleryImages().Get(galleryImageName, cancellationToken);
        }

        /// <summary>
        /// Get a community gallery by gallery public name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CommunityGalleryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryResource.Get");
            scope.Start();
            try
            {
                var response = await _communityGalleryRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name);
                return Response.FromValue(new CommunityGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a community gallery by gallery public name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunityGalleries_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CommunityGalleryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _communityGalleryClientDiagnostics.CreateScope("CommunityGalleryResource.Get");
            scope.Start();
            try
            {
                var response = _communityGalleryRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                response.Value.Id = CreateResourceIdentifier(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name);
                return Response.FromValue(new CommunityGalleryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
