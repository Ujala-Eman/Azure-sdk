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

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceHealthMetadataEntityResource" /> and their operations.
    /// Each <see cref="ResourceHealthMetadataEntityResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="ResourceHealthMetadataEntityCollection" /> instance call the GetResourceHealthMetadataEntities method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class ResourceHealthMetadataEntityCollection : ArmCollection, IEnumerable<ResourceHealthMetadataEntityResource>, IAsyncEnumerable<ResourceHealthMetadataEntityResource>
    {
        private readonly ClientDiagnostics _resourceHealthMetadataEntityMetadataClientDiagnostics;
        private readonly MetadataRestOperations _resourceHealthMetadataEntityMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataEntityCollection"/> class for mocking. </summary>
        protected ResourceHealthMetadataEntityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthMetadataEntityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourceHealthMetadataEntityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceHealthMetadataEntityMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceHealthMetadataEntityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceHealthMetadataEntityResource.ResourceType, out string resourceHealthMetadataEntityMetadataApiVersion);
            _resourceHealthMetadataEntityMetadataRestClient = new MetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceHealthMetadataEntityMetadataApiVersion);
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
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<ResourceHealthMetadataEntityResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceHealthMetadataEntityMetadataRestClient.GetEntityAsync(name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthMetadataEntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<ResourceHealthMetadataEntityResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceHealthMetadataEntityMetadataRestClient.GetEntity(name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthMetadataEntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthMetadataEntityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthMetadataEntityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceHealthMetadataEntityMetadataRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceHealthMetadataEntityMetadataRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ResourceHealthMetadataEntityResource(Client, ResourceHealthMetadataEntityData.DeserializeResourceHealthMetadataEntityData(e)), _resourceHealthMetadataEntityMetadataClientDiagnostics, Pipeline, "ResourceHealthMetadataEntityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthMetadataEntityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthMetadataEntityResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceHealthMetadataEntityMetadataRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceHealthMetadataEntityMetadataRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ResourceHealthMetadataEntityResource(Client, ResourceHealthMetadataEntityData.DeserializeResourceHealthMetadataEntityData(e)), _resourceHealthMetadataEntityMetadataClientDiagnostics, Pipeline, "ResourceHealthMetadataEntityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceHealthMetadataEntityMetadataRestClient.GetEntityAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceHealthMetadataEntityMetadataRestClient.GetEntity(name, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceHealthMetadataEntityResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceHealthMetadataEntityMetadataRestClient.GetEntityAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceHealthMetadataEntityResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthMetadataEntityResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<ResourceHealthMetadataEntityResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _resourceHealthMetadataEntityMetadataClientDiagnostics.CreateScope("ResourceHealthMetadataEntityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceHealthMetadataEntityMetadataRestClient.GetEntity(name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceHealthMetadataEntityResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthMetadataEntityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceHealthMetadataEntityResource> IEnumerable<ResourceHealthMetadataEntityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceHealthMetadataEntityResource> IAsyncEnumerable<ResourceHealthMetadataEntityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
