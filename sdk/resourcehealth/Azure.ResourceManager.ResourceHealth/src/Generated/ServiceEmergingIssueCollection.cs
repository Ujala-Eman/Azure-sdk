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
using Azure.ResourceManager.ResourceHealth.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceEmergingIssueResource"/> and their operations.
    /// Each <see cref="ServiceEmergingIssueResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="ServiceEmergingIssueCollection"/> instance call the GetServiceEmergingIssues method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class ServiceEmergingIssueCollection : ArmCollection, IEnumerable<ServiceEmergingIssueResource>, IAsyncEnumerable<ServiceEmergingIssueResource>
    {
        private readonly ClientDiagnostics _serviceEmergingIssueEmergingIssuesClientDiagnostics;
        private readonly EmergingIssuesRestOperations _serviceEmergingIssueEmergingIssuesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceEmergingIssueCollection"/> class for mocking. </summary>
        protected ServiceEmergingIssueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceEmergingIssueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceEmergingIssueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceEmergingIssueEmergingIssuesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ServiceEmergingIssueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceEmergingIssueResource.ResourceType, out string serviceEmergingIssueEmergingIssuesApiVersion);
            _serviceEmergingIssueEmergingIssuesRestClient = new EmergingIssuesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceEmergingIssueEmergingIssuesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets Azure services' emerging issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceEmergingIssueResource>> GetAsync(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceEmergingIssueEmergingIssuesClientDiagnostics.CreateScope("ServiceEmergingIssueCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceEmergingIssueEmergingIssuesRestClient.GetAsync(issueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEmergingIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets Azure services' emerging issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceEmergingIssueResource> Get(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceEmergingIssueEmergingIssuesClientDiagnostics.CreateScope("ServiceEmergingIssueCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceEmergingIssueEmergingIssuesRestClient.Get(issueName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEmergingIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Azure services' emerging issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceEmergingIssueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceEmergingIssueResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceEmergingIssueEmergingIssuesRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceEmergingIssueEmergingIssuesRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceEmergingIssueResource(Client, ServiceEmergingIssueData.DeserializeServiceEmergingIssueData(e)), _serviceEmergingIssueEmergingIssuesClientDiagnostics, Pipeline, "ServiceEmergingIssueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists Azure services' emerging issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceEmergingIssueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceEmergingIssueResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceEmergingIssueEmergingIssuesRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceEmergingIssueEmergingIssuesRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceEmergingIssueResource(Client, ServiceEmergingIssueData.DeserializeServiceEmergingIssueData(e)), _serviceEmergingIssueEmergingIssuesClientDiagnostics, Pipeline, "ServiceEmergingIssueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceEmergingIssueEmergingIssuesClientDiagnostics.CreateScope("ServiceEmergingIssueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceEmergingIssueEmergingIssuesRestClient.GetAsync(issueName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceEmergingIssueEmergingIssuesClientDiagnostics.CreateScope("ServiceEmergingIssueCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceEmergingIssueEmergingIssuesRestClient.Get(issueName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ServiceEmergingIssueResource>> GetIfExistsAsync(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceEmergingIssueEmergingIssuesClientDiagnostics.CreateScope("ServiceEmergingIssueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceEmergingIssueEmergingIssuesRestClient.GetAsync(issueName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceEmergingIssueResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceEmergingIssueResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ServiceEmergingIssueResource> GetIfExists(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceEmergingIssueEmergingIssuesClientDiagnostics.CreateScope("ServiceEmergingIssueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceEmergingIssueEmergingIssuesRestClient.Get(issueName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceEmergingIssueResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceEmergingIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceEmergingIssueResource> IEnumerable<ServiceEmergingIssueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceEmergingIssueResource> IAsyncEnumerable<ServiceEmergingIssueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
