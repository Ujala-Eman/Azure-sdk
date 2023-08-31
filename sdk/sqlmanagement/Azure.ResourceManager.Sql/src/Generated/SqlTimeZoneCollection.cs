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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlTimeZoneResource" /> and their operations.
    /// Each <see cref="SqlTimeZoneResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SqlTimeZoneCollection" /> instance call the GetSqlTimeZones method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SqlTimeZoneCollection : ArmCollection, IEnumerable<SqlTimeZoneResource>, IAsyncEnumerable<SqlTimeZoneResource>
    {
        private readonly ClientDiagnostics _sqlTimeZoneTimeZonesClientDiagnostics;
        private readonly TimeZonesRestOperations _sqlTimeZoneTimeZonesRestClient;
        private readonly AzureLocation _locationName;

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneCollection"/> class for mocking. </summary>
        protected SqlTimeZoneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The String to use. </param>
        internal SqlTimeZoneCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName) : base(client, id)
        {
            _locationName = locationName;
            _sqlTimeZoneTimeZonesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlTimeZoneResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlTimeZoneResource.ResourceType, out string sqlTimeZoneTimeZonesApiVersion);
            _sqlTimeZoneTimeZonesRestClient = new TimeZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlTimeZoneTimeZonesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a managed instance time zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual async Task<Response<SqlTimeZoneResource>> GetAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlTimeZoneTimeZonesRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), timeZoneId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed instance time zone.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<SqlTimeZoneResource> Get(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlTimeZoneTimeZonesRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), timeZoneId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of managed instance time zones by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlTimeZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlTimeZoneResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlTimeZoneTimeZonesRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlTimeZoneTimeZonesRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlTimeZoneResource(Client, SqlTimeZoneData.DeserializeSqlTimeZoneData(e)), _sqlTimeZoneTimeZonesClientDiagnostics, Pipeline, "SqlTimeZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of managed instance time zones by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlTimeZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlTimeZoneResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlTimeZoneTimeZonesRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlTimeZoneTimeZonesRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlTimeZoneResource(Client, SqlTimeZoneData.DeserializeSqlTimeZoneData(e)), _sqlTimeZoneTimeZonesClientDiagnostics, Pipeline, "SqlTimeZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlTimeZoneTimeZonesRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_locationName), timeZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TimeZones_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<bool> Exists(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlTimeZoneTimeZonesRestClient.Get(Id.SubscriptionId, new AzureLocation(_locationName), timeZoneId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlTimeZoneResource> IEnumerable<SqlTimeZoneResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlTimeZoneResource> IAsyncEnumerable<SqlTimeZoneResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
