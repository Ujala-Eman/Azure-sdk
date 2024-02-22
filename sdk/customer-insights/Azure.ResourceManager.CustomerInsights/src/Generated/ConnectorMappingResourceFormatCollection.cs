// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="ConnectorMappingResourceFormatResource"/> and their operations.
    /// Each <see cref="ConnectorMappingResourceFormatResource"/> in the collection will belong to the same instance of <see cref="ConnectorResourceFormatResource"/>.
    /// To get a <see cref="ConnectorMappingResourceFormatCollection"/> instance call the GetConnectorMappingResourceFormats method from an instance of <see cref="ConnectorResourceFormatResource"/>.
    /// </summary>
    public partial class ConnectorMappingResourceFormatCollection : ArmCollection, IEnumerable<ConnectorMappingResourceFormatResource>, IAsyncEnumerable<ConnectorMappingResourceFormatResource>
    {
        private readonly ClientDiagnostics _connectorMappingResourceFormatConnectorMappingsClientDiagnostics;
        private readonly ConnectorMappingsRestOperations _connectorMappingResourceFormatConnectorMappingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConnectorMappingResourceFormatCollection"/> class for mocking. </summary>
        protected ConnectorMappingResourceFormatCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConnectorMappingResourceFormatCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConnectorMappingResourceFormatCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _connectorMappingResourceFormatConnectorMappingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ConnectorMappingResourceFormatResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConnectorMappingResourceFormatResource.ResourceType, out string connectorMappingResourceFormatConnectorMappingsApiVersion);
            _connectorMappingResourceFormatConnectorMappingsRestClient = new ConnectorMappingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, connectorMappingResourceFormatConnectorMappingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ConnectorResourceFormatResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ConnectorResourceFormatResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a connector mapping or updates an existing connector mapping in the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Connector Mapping operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConnectorMappingResourceFormatResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mappingName, ConnectorMappingResourceFormatData data, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _connectorMappingResourceFormatConnectorMappingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<ConnectorMappingResourceFormatResource>(Response.FromValue(new ConnectorMappingResourceFormatResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
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
        /// Creates a connector mapping or updates an existing connector mapping in the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate Connector Mapping operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConnectorMappingResourceFormatResource> CreateOrUpdate(WaitUntil waitUntil, string mappingName, ConnectorMappingResourceFormatData data, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _connectorMappingResourceFormatConnectorMappingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<ConnectorMappingResourceFormatResource>(Response.FromValue(new ConnectorMappingResourceFormatResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
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
        /// Gets a connector mapping in the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual async Task<Response<ConnectorMappingResourceFormatResource>> GetAsync(string mappingName, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = await _connectorMappingResourceFormatConnectorMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectorMappingResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a connector mapping in the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual Response<ConnectorMappingResourceFormatResource> Get(string mappingName, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.Get");
            scope.Start();
            try
            {
                var response = _connectorMappingResourceFormatConnectorMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectorMappingResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the connector mappings in the specified connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_ListByConnector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConnectorMappingResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConnectorMappingResourceFormatResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _connectorMappingResourceFormatConnectorMappingsRestClient.CreateListByConnectorRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _connectorMappingResourceFormatConnectorMappingsRestClient.CreateListByConnectorNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ConnectorMappingResourceFormatResource(Client, ConnectorMappingResourceFormatData.DeserializeConnectorMappingResourceFormatData(e)), _connectorMappingResourceFormatConnectorMappingsClientDiagnostics, Pipeline, "ConnectorMappingResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the connector mappings in the specified connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_ListByConnector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConnectorMappingResourceFormatResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConnectorMappingResourceFormatResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _connectorMappingResourceFormatConnectorMappingsRestClient.CreateListByConnectorRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _connectorMappingResourceFormatConnectorMappingsRestClient.CreateListByConnectorNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ConnectorMappingResourceFormatResource(Client, ConnectorMappingResourceFormatData.DeserializeConnectorMappingResourceFormatData(e)), _connectorMappingResourceFormatConnectorMappingsClientDiagnostics, Pipeline, "ConnectorMappingResourceFormatCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mappingName, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = await _connectorMappingResourceFormatConnectorMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual Response<bool> Exists(string mappingName, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.Exists");
            scope.Start();
            try
            {
                var response = _connectorMappingResourceFormatConnectorMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual async Task<NullableResponse<ConnectorMappingResourceFormatResource>> GetIfExistsAsync(string mappingName, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _connectorMappingResourceFormatConnectorMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ConnectorMappingResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new ConnectorMappingResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/connectors/{connectorName}/mappings/{mappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectorMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-04-26</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectorMappingResourceFormatResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mappingName"> The name of the connector mapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mappingName"/> is null. </exception>
        public virtual NullableResponse<ConnectorMappingResourceFormatResource> GetIfExists(string mappingName, CancellationToken cancellationToken = default)
        {
            if (mappingName == null)
            {
                throw new ArgumentNullException(nameof(mappingName));
            }
            if (mappingName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(mappingName));
            }

            using var scope = _connectorMappingResourceFormatConnectorMappingsClientDiagnostics.CreateScope("ConnectorMappingResourceFormatCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _connectorMappingResourceFormatConnectorMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, mappingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ConnectorMappingResourceFormatResource>(response.GetRawResponse());
                return Response.FromValue(new ConnectorMappingResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConnectorMappingResourceFormatResource> IEnumerable<ConnectorMappingResourceFormatResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConnectorMappingResourceFormatResource> IAsyncEnumerable<ConnectorMappingResourceFormatResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
