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
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a PartnerNamespacePrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PartnerNamespacePrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPartnerNamespacePrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetPartnerNamespacePrivateLinkResource method.
    /// </summary>
    public partial class PartnerNamespacePrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PartnerNamespacePrivateLinkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string parentName, string privateLinkResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/partnerNamespaces/{parentName}/privateLinkResources/{privateLinkResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _privateLinkResourcesRestClient;
        private readonly EventGridPrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespacePrivateLinkResource"/> class for mocking. </summary>
        protected PartnerNamespacePrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PartnerNamespacePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PartnerNamespacePrivateLinkResource(ArmClient client, EventGridPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespacePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PartnerNamespacePrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/partnerNamespaces/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventGridPrivateLinkResourceData Data
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
        /// Get properties of a private link resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual async Task<Response<EventGridPrivateLinkResourceData>> GetAsync(string parentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a private link resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual Response<EventGridPrivateLinkResourceData> Get(string parentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
