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
    /// <summary> A class representing collection of OSFamily and their operations over its parent. </summary>
    public partial class OSFamilyCollection : ArmCollection, IEnumerable<OSFamily>, IAsyncEnumerable<OSFamily>
    {
        private readonly ClientDiagnostics _osFamilyCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _osFamilyCloudServiceOperatingSystemsRestClient;
        private readonly string _location;

        /// <summary> Initializes a new instance of the <see cref="OSFamilyCollection"/> class for mocking. </summary>
        protected OSFamilyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OSFamilyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> Name of the location that the OS families pertain to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        internal OSFamilyCollection(ArmClient client, ResourceIdentifier id, string location) : base(client, id)
        {
            _location = location;
            _osFamilyCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", OSFamily.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(OSFamily.ResourceType, out string osFamilyCloudServiceOperatingSystemsApiVersion);
            _osFamilyCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(_osFamilyCloudServiceOperatingSystemsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, osFamilyCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSFamily
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<OSFamily>> GetAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = await _osFamilyCloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, _location, osFamilyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OSFamily(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a guest operating system family that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSFamily
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<OSFamily> Get(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.Get");
            scope.Start();
            try
            {
                var response = _osFamilyCloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, _location, osFamilyName, cancellationToken);
                if (response.Value == null)
                    throw _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSFamily(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies
        /// Operation Id: CloudServiceOperatingSystems_ListOSFamilies
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OSFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OSFamily> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OSFamily>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _osFamilyCloudServiceOperatingSystemsRestClient.ListOSFamiliesAsync(Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OSFamily>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _osFamilyCloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPageAsync(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all guest operating system families available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS Families. Do this till nextLink is null to fetch all the OS Families.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies
        /// Operation Id: CloudServiceOperatingSystems_ListOSFamilies
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OSFamily" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OSFamily> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OSFamily> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _osFamilyCloudServiceOperatingSystemsRestClient.ListOSFamilies(Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OSFamily> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _osFamilyCloudServiceOperatingSystemsRestClient.ListOSFamiliesNextPage(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSFamily(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSFamily
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSFamily
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<bool> Exists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSFamily
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public async virtual Task<Response<OSFamily>> GetIfExistsAsync(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _osFamilyCloudServiceOperatingSystemsRestClient.GetOSFamilyAsync(Id.SubscriptionId, _location, osFamilyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OSFamily>(null, response.GetRawResponse());
                return Response.FromValue(new OSFamily(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsFamilies/{osFamilyName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSFamily
        /// </summary>
        /// <param name="osFamilyName"> Name of the OS family. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osFamilyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamilyName"/> is null. </exception>
        public virtual Response<OSFamily> GetIfExists(string osFamilyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osFamilyName, nameof(osFamilyName));

            using var scope = _osFamilyCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSFamilyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _osFamilyCloudServiceOperatingSystemsRestClient.GetOSFamily(Id.SubscriptionId, _location, osFamilyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OSFamily>(null, response.GetRawResponse());
                return Response.FromValue(new OSFamily(Client, response.Value), response.GetRawResponse());
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
    }
}
