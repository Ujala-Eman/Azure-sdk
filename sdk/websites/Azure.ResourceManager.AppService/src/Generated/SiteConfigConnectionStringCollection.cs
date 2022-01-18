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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of ApiKeyVaultReference and their operations over its parent. </summary>
    public partial class SiteConfigConnectionStringCollection : ArmCollection, IEnumerable<SiteConfigConnectionString>, IAsyncEnumerable<SiteConfigConnectionString>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigConnectionStringCollection"/> class for mocking. </summary>
        protected SiteConfigConnectionStringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigConnectionStringCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteConfigConnectionStringCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteConfigConnectionString.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReference
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is null or empty. </exception>
        public virtual Response<SiteConfigConnectionString> Get(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(connectionStringKey))
            {
                throw new ArgumentException($"Parameter {nameof(connectionStringKey)} cannot be null or empty", nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings/{connectionStringKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReference
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is null or empty. </exception>
        public async virtual Task<Response<SiteConfigConnectionString>> GetAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(connectionStringKey))
            {
                throw new ArgumentException($"Parameter {nameof(connectionStringKey)} cannot be null or empty", nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is null or empty. </exception>
        public virtual Response<SiteConfigConnectionString> GetIfExists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(connectionStringKey))
            {
                throw new ArgumentException($"Parameter {nameof(connectionStringKey)} cannot be null or empty", nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteConfigConnectionString>(null, response.GetRawResponse());
                return Response.FromValue(new SiteConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is null or empty. </exception>
        public async virtual Task<Response<SiteConfigConnectionString>> GetIfExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(connectionStringKey))
            {
                throw new ArgumentException($"Parameter {nameof(connectionStringKey)} cannot be null or empty", nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteConfigConnectionString>(null, response.GetRawResponse());
                return Response.FromValue(new SiteConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(connectionStringKey))
            {
                throw new ArgumentException($"Parameter {nameof(connectionStringKey)} cannot be null or empty", nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionStringKey, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionStringKey"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(connectionStringKey))
            {
                throw new ArgumentException($"Parameter {nameof(connectionStringKey)} cannot be null or empty", nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReferences
        /// <summary> Description for Gets the config reference app settings and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteConfigConnectionString" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteConfigConnectionString> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteConfigConnectionString> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReferences(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteConfigConnectionString> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/connectionstrings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReferences
        /// <summary> Description for Gets the config reference app settings and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteConfigConnectionString" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteConfigConnectionString> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteConfigConnectionString>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteConfigConnectionString>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteConfigConnectionString> IEnumerable<SiteConfigConnectionString>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteConfigConnectionString> IAsyncEnumerable<SiteConfigConnectionString>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteConfigConnectionString, ApiKeyVaultReferenceData> Construct() { }
    }
}
