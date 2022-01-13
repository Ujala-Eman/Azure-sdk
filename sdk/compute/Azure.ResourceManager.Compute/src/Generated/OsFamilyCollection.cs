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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of OsFamily and their operations over its parent. </summary>
    public partial class OsFamilyCollection : ArmCollection, IEnumerable<OsFamily>, IAsyncEnumerable<OsFamily>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _cloudServiceOperatingSystemsRestClient;
        private readonly string _location;

        /// <summary> Initializes a new instance of the <see cref="OsFamilyCollection"/> class for mocking. </summary>
        protected OsFamilyCollection()
        {
        }

        /// <summary> Initializes a new instance of OsFamilyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="location"> Name of the location that the OS families pertain to. </param>
        internal OsFamilyCollection(ArmResource parent, string location) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _cloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _location = location;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: CloudServiceOperatingSystems_GetOSFamily
        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<OsFamily> Get(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, _location, osFamilyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OsFamily(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: CloudServiceOperatingSystems_GetOSFamily
        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<OsFamily>> GetAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, _location, osFamilyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OsFamily(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<OsFamily> GetIfExists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, _location, osFamilyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<OsFamily>(null, response.GetRawResponse())
                    : Response.FromValue(new OsFamily(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<OsFamily>> GetIfExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, _location, osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<OsFamily>(null, response.GetRawResponse())
                    : Response.FromValue(new OsFamily(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<bool> Exists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(osFamilyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (osFamilyName == null)
            {
                throw new ArgumentNullException(nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: CloudServiceOperatingSystems_ListOSFamilies
        /// <summary> Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OsFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OsFamily> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OsFamily> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.ListOSFamilies(Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OsFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OsFamily> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPage(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OsFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: CloudServiceOperatingSystems_ListOSFamilies
        /// <summary> Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OsFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OsFamily> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OsFamily>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.ListOSFamiliesAsync(Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OsFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OsFamily>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPageAsync(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OsFamily(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="OsFamily" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OsFamily.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OsFamily" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OsFamilyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OsFamily.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OsFamily> IEnumerable<OsFamily>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OsFamily> IAsyncEnumerable<OsFamily>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, OsFamily, OsFamilyData> Construct() { }
    }
}
