// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceAzureADOnlyAuthenticationResource" /> and their operations.
    /// Each <see cref="ManagedInstanceAzureADOnlyAuthenticationResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get a <see cref="ManagedInstanceAzureADOnlyAuthenticationCollection" /> instance call the GetManagedInstanceAzureADOnlyAuthentications method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class ManagedInstanceAzureADOnlyAuthenticationCollection : ArmCollection, IEnumerable<ManagedInstanceAzureADOnlyAuthenticationResource>, IAsyncEnumerable<ManagedInstanceAzureADOnlyAuthenticationResource>
    {
        private readonly ClientDiagnostics _managedInstanceAzureADOnlyAuthenticationClientDiagnostics;
        private readonly ManagedInstanceAzureADOnlyAuthenticationsRestOperations _managedInstanceAzureADOnlyAuthenticationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAzureADOnlyAuthenticationCollection"/> class for mocking. </summary>
        protected ManagedInstanceAzureADOnlyAuthenticationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceAzureADOnlyAuthenticationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceAzureADOnlyAuthenticationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceAzureADOnlyAuthenticationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceAzureADOnlyAuthenticationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceAzureADOnlyAuthenticationResource.ResourceType, out string managedInstanceAzureADOnlyAuthenticationApiVersion);
            _managedInstanceAzureADOnlyAuthenticationRestClient = new ManagedInstanceAzureADOnlyAuthenticationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceAzureADOnlyAuthenticationApiVersion);
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
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="data"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceAzureADOnlyAuthenticationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AuthenticationName authenticationName, ManagedInstanceAzureADOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceAzureADOnlyAuthenticationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceAzureADOnlyAuthenticationResource>(new ManagedInstanceAzureADOnlyAuthenticationOperationSource(Client), _managedInstanceAzureADOnlyAuthenticationClientDiagnostics, Pipeline, _managedInstanceAzureADOnlyAuthenticationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="data"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceAzureADOnlyAuthenticationResource> CreateOrUpdate(WaitUntil waitUntil, AuthenticationName authenticationName, ManagedInstanceAzureADOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceAzureADOnlyAuthenticationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceAzureADOnlyAuthenticationResource>(new ManagedInstanceAzureADOnlyAuthenticationOperationSource(Client), _managedInstanceAzureADOnlyAuthenticationClientDiagnostics, Pipeline, _managedInstanceAzureADOnlyAuthenticationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a specific Azure Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAzureADOnlyAuthenticationResource>> GetAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceAzureADOnlyAuthenticationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAzureADOnlyAuthenticationResource> Get(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceAzureADOnlyAuthenticationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server Azure Active Directory only authentications.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_ListByInstance
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceAzureADOnlyAuthenticationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceAzureADOnlyAuthenticationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceAzureADOnlyAuthenticationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceAzureADOnlyAuthenticationRestClient.ListByInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceAzureADOnlyAuthenticationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceAzureADOnlyAuthenticationRestClient.ListByInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of server Azure Active Directory only authentications.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_ListByInstance
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceAzureADOnlyAuthenticationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceAzureADOnlyAuthenticationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceAzureADOnlyAuthenticationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceAzureADOnlyAuthenticationRestClient.ListByInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceAzureADOnlyAuthenticationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceAzureADOnlyAuthenticationRestClient.ListByInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authenticationName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceAzureADOnlyAuthenticationResource>> GetIfExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceAzureADOnlyAuthenticationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceAzureADOnlyAuthenticationResource>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ManagedInstanceAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceAzureADOnlyAuthenticationResource> GetIfExists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceAzureADOnlyAuthenticationClientDiagnostics.CreateScope("ManagedInstanceAzureADOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceAzureADOnlyAuthenticationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceAzureADOnlyAuthenticationResource>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceAzureADOnlyAuthenticationResource> IEnumerable<ManagedInstanceAzureADOnlyAuthenticationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceAzureADOnlyAuthenticationResource> IAsyncEnumerable<ManagedInstanceAzureADOnlyAuthenticationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
