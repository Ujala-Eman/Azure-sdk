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

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A Class representing a PostgreSqlPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PostgreSqlPrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPostgreSqlPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServerResource" /> using the GetPostgreSqlPrivateLinkResource method.
    /// </summary>
    public partial class PostgreSqlPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PostgreSqlPrivateLinkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string groupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/privateLinkResources/{groupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _postgreSqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _postgreSqlPrivateLinkResourcePrivateLinkResourcesRestClient;
        private readonly PostgreSqlPrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlPrivateLinkResource"/> class for mocking. </summary>
        protected PostgreSqlPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PostgreSqlPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PostgreSqlPrivateLinkResource(ArmClient client, PostgreSqlPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PostgreSqlPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string postgreSqlPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _postgreSqlPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforPostgreSQL/servers/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PostgreSqlPrivateLinkResourceData Data
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
        /// Gets a private link resource for PostgreSQL server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PostgreSqlPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PostgreSqlPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource for PostgreSQL server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PostgreSqlPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("PostgreSqlPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
