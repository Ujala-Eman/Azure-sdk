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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of Profile and their operations over its parent. </summary>
    public partial class ProfileCollection : ArmCollection, IEnumerable<Profile>, IAsyncEnumerable<Profile>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ProfilesRestOperations _profilesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProfileCollection"/> class for mocking. </summary>
        protected ProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProfileCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ProfileCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Profile.ResourceType, out string apiVersion);
            _profilesRestClient = new ProfilesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new CDN profile with a profile name under the specified subscription and resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="profile"> Profile properties needed to create a new profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profile"/> is null. </exception>
        public virtual ProfileCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string profileName, ProfileData profile, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }
            if (profile == null)
            {
                throw new ArgumentNullException(nameof(profile));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _profilesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, profileName, profile, cancellationToken);
                var operation = new ProfileCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _profilesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, profileName, profile).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new CDN profile with a profile name under the specified subscription and resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="profile"> Profile properties needed to create a new profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profile"/> is null. </exception>
        public async virtual Task<ProfileCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string profileName, ProfileData profile, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }
            if (profile == null)
            {
                throw new ArgumentNullException(nameof(profile));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _profilesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, profile, cancellationToken).ConfigureAwait(false);
                var operation = new ProfileCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _profilesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, profileName, profile).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a CDN profile with the specified profile name under the specified subscription and resource group. </summary>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        public virtual Response<Profile> Get(string profileName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _profilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Profile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a CDN profile with the specified profile name under the specified subscription and resource group. </summary>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        public async virtual Task<Response<Profile>> GetAsync(string profileName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _profilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Profile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        public virtual Response<Profile> GetIfExists(string profileName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _profilesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Profile>(null, response.GetRawResponse());
                return Response.FromValue(new Profile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        public async virtual Task<Response<Profile>> GetIfExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _profilesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Profile>(null, response.GetRawResponse());
                return Response.FromValue(new Profile(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string profileName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(profileName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string profileName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(profileName))
            {
                throw new ArgumentException($"Parameter {nameof(profileName)} cannot be null or empty", nameof(profileName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(profileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the CDN profiles within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Profile" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Profile> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Profile> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _profilesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Profile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _profilesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the CDN profiles within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Profile" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Profile> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Profile>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _profilesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Profile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _profilesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Profile(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Profile" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Profile.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Profile" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfileCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Profile.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Profile> IEnumerable<Profile>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Profile> IAsyncEnumerable<Profile>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Profile, ProfileData> Construct() { }
    }
}
