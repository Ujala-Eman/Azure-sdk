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
    public partial class SiteSlotConfigAppSettingCollection : ArmCollection, IEnumerable<SiteSlotConfigAppSetting>, IAsyncEnumerable<SiteSlotConfigAppSetting>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigAppSettingCollection"/> class for mocking. </summary>
        protected SiteSlotConfigAppSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigAppSettingCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotConfigAppSettingCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteSlotConfigAppSetting.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/appsettings/{appSettingKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetAppSettingKeyVaultReferenceSlot
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is null or empty. </exception>
        public virtual Response<SiteSlotConfigAppSetting> Get(string appSettingKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appSettingKey))
            {
                throw new ArgumentException($"Parameter {nameof(appSettingKey)} cannot be null or empty", nameof(appSettingKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetAppSettingKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettingKey, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigAppSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/appsettings/{appSettingKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetAppSettingKeyVaultReferenceSlot
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is null or empty. </exception>
        public async virtual Task<Response<SiteSlotConfigAppSetting>> GetAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appSettingKey))
            {
                throw new ArgumentException($"Parameter {nameof(appSettingKey)} cannot be null or empty", nameof(appSettingKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetAppSettingKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettingKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotConfigAppSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is null or empty. </exception>
        public virtual Response<SiteSlotConfigAppSetting> GetIfExists(string appSettingKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appSettingKey))
            {
                throw new ArgumentException($"Parameter {nameof(appSettingKey)} cannot be null or empty", nameof(appSettingKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetAppSettingKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettingKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigAppSetting>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigAppSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is null or empty. </exception>
        public async virtual Task<Response<SiteSlotConfigAppSetting>> GetIfExistsAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appSettingKey))
            {
                throw new ArgumentException($"Parameter {nameof(appSettingKey)} cannot be null or empty", nameof(appSettingKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetAppSettingKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, appSettingKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigAppSetting>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigAppSetting(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string appSettingKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appSettingKey))
            {
                throw new ArgumentException($"Parameter {nameof(appSettingKey)} cannot be null or empty", nameof(appSettingKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(appSettingKey, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="appSettingKey"> App Setting key name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appSettingKey"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string appSettingKey, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(appSettingKey))
            {
                throw new ArgumentException($"Parameter {nameof(appSettingKey)} cannot be null or empty", nameof(appSettingKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(appSettingKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/appsettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetAppSettingsKeyVaultReferencesSlot
        /// <summary> Description for Gets the config reference app settings and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotConfigAppSetting" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotConfigAppSetting> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotConfigAppSetting> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetAppSettingsKeyVaultReferencesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigAppSetting(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotConfigAppSetting> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetAppSettingsKeyVaultReferencesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigAppSetting(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/appsettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetAppSettingsKeyVaultReferencesSlot
        /// <summary> Description for Gets the config reference app settings and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotConfigAppSetting" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotConfigAppSetting> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotConfigAppSetting>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetAppSettingsKeyVaultReferencesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigAppSetting(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotConfigAppSetting>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigAppSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetAppSettingsKeyVaultReferencesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigAppSetting(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotConfigAppSetting> IEnumerable<SiteSlotConfigAppSetting>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotConfigAppSetting> IAsyncEnumerable<SiteSlotConfigAppSetting>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteSlotConfigAppSetting, ApiKeyVaultReferenceData> Construct() { }
    }
}
