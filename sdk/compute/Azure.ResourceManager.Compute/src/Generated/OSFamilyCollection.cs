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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of OSFamily and their operations over its parent. </summary>
    public partial class OSFamilyCollection : ArmCollection, IEnumerable<OSFamily>, IAsyncEnumerable<OSFamily>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _cloudServiceOperatingSystemsRestClient;
        private readonly string _location;

        /// <summary> Initializes a new instance of the <see cref="OSFamilyCollection"/> class for mocking. </summary>
        protected OSFamilyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OSFamilyCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="location"> Name of the location that the OS families pertain to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        internal OSFamilyCollection(ArmResource parent, string location) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(OSFamily.ResourceType, out string apiVersion);
            _cloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is null or empty. </exception>
        public virtual Response<OSFamily> Get(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(osFamilyName))
            {
                throw new ArgumentException($"Parameter {nameof(osFamilyName)} cannot be null or empty", nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, _location, osFamilyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSFamily(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service. </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is null or empty. </exception>
        public async virtual Task<Response<OSFamily>> GetAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(osFamilyName))
            {
                throw new ArgumentException($"Parameter {nameof(osFamilyName)} cannot be null or empty", nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, _location, osFamilyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OSFamily(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is null or empty. </exception>
        public virtual Response<OSFamily> GetIfExists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(osFamilyName))
            {
                throw new ArgumentException($"Parameter {nameof(osFamilyName)} cannot be null or empty", nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, _location, osFamilyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OSFamily>(null, response.GetRawResponse());
                return Response.FromValue(new OSFamily(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is null or empty. </exception>
        public async virtual Task<Response<OSFamily>> GetIfExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(osFamilyName))
            {
                throw new ArgumentException($"Parameter {nameof(osFamilyName)} cannot be null or empty", nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, _location, osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OSFamily>(null, response.GetRawResponse());
                return Response.FromValue(new OSFamily(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(osFamilyName))
            {
                throw new ArgumentException($"Parameter {nameof(osFamilyName)} cannot be null or empty", nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.Exists");
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
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(osFamilyName))
            {
                throw new ArgumentException($"Parameter {nameof(osFamilyName)} cannot be null or empty", nameof(osFamilyName));
            }

            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.Exists");
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

        /// <summary> Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OSFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OSFamily> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OSFamily> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.ListOSFamilies(Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OSFamily> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPage(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OSFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OSFamily> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OSFamily>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.ListOSFamiliesAsync(Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OSFamily>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPageAsync(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="OSFamily" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OSFamily.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="OSFamily" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OSFamilyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(OSFamily.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OSFamily> IEnumerable<OSFamily>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OSFamily> IAsyncEnumerable<OSFamily>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, OSFamily, OSFamilyData> Construct() { }
    }
}
