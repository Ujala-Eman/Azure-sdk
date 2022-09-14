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

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary>
    /// A Class representing a MarketplaceRegistrationDefinition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MarketplaceRegistrationDefinitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMarketplaceRegistrationDefinitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetMarketplaceRegistrationDefinition method.
    /// </summary>
    public partial class MarketplaceRegistrationDefinitionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MarketplaceRegistrationDefinitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string marketplaceIdentifier)
        {
            var resourceId = $"{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _marketplaceRegistrationDefinitionClientDiagnostics;
        private readonly MarketplaceRegistrationDefinitionsRestOperations _marketplaceRegistrationDefinitionRestClient;
        private readonly MarketplaceRegistrationDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="MarketplaceRegistrationDefinitionResource"/> class for mocking. </summary>
        protected MarketplaceRegistrationDefinitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MarketplaceRegistrationDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MarketplaceRegistrationDefinitionResource(ArmClient client, MarketplaceRegistrationDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceRegistrationDefinitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MarketplaceRegistrationDefinitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceRegistrationDefinitionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string marketplaceRegistrationDefinitionApiVersion);
            _marketplaceRegistrationDefinitionRestClient = new MarketplaceRegistrationDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceRegistrationDefinitionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedServices/marketplaceRegistrationDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MarketplaceRegistrationDefinitionData Data
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
        /// Get the marketplace registration definition for the marketplace identifier.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}
        /// Operation Id: MarketplaceRegistrationDefinitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MarketplaceRegistrationDefinitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceRegistrationDefinitionRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceRegistrationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// Request Path: /{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}
        /// Operation Id: MarketplaceRegistrationDefinitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MarketplaceRegistrationDefinitionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceRegistrationDefinitionClientDiagnostics.CreateScope("MarketplaceRegistrationDefinitionResource.Get");
            scope.Start();
            try
            {
                var response = _marketplaceRegistrationDefinitionRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceRegistrationDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
