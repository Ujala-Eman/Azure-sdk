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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedServerDnsAliasResource"/> and their operations.
    /// Each <see cref="ManagedServerDnsAliasResource"/> in the collection will belong to the same instance of <see cref="ManagedInstanceResource"/>.
    /// To get a <see cref="ManagedServerDnsAliasCollection"/> instance call the GetManagedServerDnsAliases method from an instance of <see cref="ManagedInstanceResource"/>.
    /// </summary>
    public partial class ManagedServerDnsAliasCollection : ArmCollection, IEnumerable<ManagedServerDnsAliasResource>, IAsyncEnumerable<ManagedServerDnsAliasResource>
    {
        private readonly ClientDiagnostics _managedServerDnsAliasClientDiagnostics;
        private readonly ManagedServerDnsAliasesRestOperations _managedServerDnsAliasRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedServerDnsAliasCollection"/> class for mocking. </summary>
        protected ManagedServerDnsAliasCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServerDnsAliasCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedServerDnsAliasCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedServerDnsAliasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedServerDnsAliasResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedServerDnsAliasResource.ResourceType, out string managedServerDnsAliasApiVersion);
            _managedServerDnsAliasRestClient = new ManagedServerDnsAliasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedServerDnsAliasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a managed server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="content"> The ManagedServerDnsAliasCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedServerDnsAliasResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dnsAliasName, ManagedServerDnsAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, content, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedServerDnsAliasResource>(new ManagedServerDnsAliasOperationSource(Client), _managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a managed server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="content"> The ManagedServerDnsAliasCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ManagedServerDnsAliasResource> CreateOrUpdate(WaitUntil waitUntil, string dnsAliasName, ManagedServerDnsAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, content, cancellationToken);
                var operation = new SqlArmOperation<ManagedServerDnsAliasResource>(new ManagedServerDnsAliasOperationSource(Client), _managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<Response<ManagedServerDnsAliasResource>> GetAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<ManagedServerDnsAliasResource> Get(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed server DNS aliases for a managed server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_ListByManagedInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedServerDnsAliasResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedServerDnsAliasResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedServerDnsAliasRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedServerDnsAliasRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedServerDnsAliasResource(Client, ManagedServerDnsAliasData.DeserializeManagedServerDnsAliasData(e)), _managedServerDnsAliasClientDiagnostics, Pipeline, "ManagedServerDnsAliasCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed server DNS aliases for a managed server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_ListByManagedInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedServerDnsAliasResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedServerDnsAliasResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedServerDnsAliasRestClient.CreateListByManagedInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedServerDnsAliasRestClient.CreateListByManagedInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ManagedServerDnsAliasResource(Client, ManagedServerDnsAliasData.DeserializeManagedServerDnsAliasData(e)), _managedServerDnsAliasClientDiagnostics, Pipeline, "ManagedServerDnsAliasCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<bool> Exists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedServerDnsAliasResource>> GetIfExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedServerDnsAliasResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual NullableResponse<ManagedServerDnsAliasResource> GetIfExists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedServerDnsAliasResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedServerDnsAliasResource> IEnumerable<ManagedServerDnsAliasResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedServerDnsAliasResource> IAsyncEnumerable<ManagedServerDnsAliasResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
