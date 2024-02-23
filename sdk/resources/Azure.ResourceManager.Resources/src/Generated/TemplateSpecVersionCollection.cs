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

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing a collection of <see cref="TemplateSpecVersionResource"/> and their operations.
    /// Each <see cref="TemplateSpecVersionResource"/> in the collection will belong to the same instance of <see cref="TemplateSpecResource"/>.
    /// To get a <see cref="TemplateSpecVersionCollection"/> instance call the GetTemplateSpecVersions method from an instance of <see cref="TemplateSpecResource"/>.
    /// </summary>
    public partial class TemplateSpecVersionCollection : ArmCollection, IEnumerable<TemplateSpecVersionResource>, IAsyncEnumerable<TemplateSpecVersionResource>
    {
        private readonly ClientDiagnostics _templateSpecVersionClientDiagnostics;
        private readonly TemplateSpecVersionsRestOperations _templateSpecVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TemplateSpecVersionCollection"/> class for mocking. </summary>
        protected TemplateSpecVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TemplateSpecVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TemplateSpecVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _templateSpecVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", TemplateSpecVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TemplateSpecVersionResource.ResourceType, out string templateSpecVersionApiVersion);
            _templateSpecVersionRestClient = new TemplateSpecVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, templateSpecVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TemplateSpecResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TemplateSpecResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Template Spec version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="data"> Template Spec Version supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TemplateSpecVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string templateSpecVersion, TemplateSpecVersionData data, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, data, cancellationToken).ConfigureAwait(false);
                var uri = _templateSpecVersionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ResourcesArmOperation<TemplateSpecVersionResource>(Response.FromValue(new TemplateSpecVersionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a Template Spec version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="data"> Template Spec Version supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TemplateSpecVersionResource> CreateOrUpdate(WaitUntil waitUntil, string templateSpecVersion, TemplateSpecVersionData data, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _templateSpecVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, data, cancellationToken);
                var uri = _templateSpecVersionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ResourcesArmOperation<TemplateSpecVersionResource>(Response.FromValue(new TemplateSpecVersionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a Template Spec version from a specific Template Spec.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual async Task<Response<TemplateSpecVersionResource>> GetAsync(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TemplateSpecVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Template Spec version from a specific Template Spec.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual Response<TemplateSpecVersionResource> Get(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _templateSpecVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TemplateSpecVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the Template Spec versions in the specified Template Spec.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TemplateSpecVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TemplateSpecVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _templateSpecVersionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _templateSpecVersionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TemplateSpecVersionResource(Client, TemplateSpecVersionData.DeserializeTemplateSpecVersionData(e)), _templateSpecVersionClientDiagnostics, Pipeline, "TemplateSpecVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the Template Spec versions in the specified Template Spec.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TemplateSpecVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TemplateSpecVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _templateSpecVersionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _templateSpecVersionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TemplateSpecVersionResource(Client, TemplateSpecVersionData.DeserializeTemplateSpecVersionData(e)), _templateSpecVersionClientDiagnostics, Pipeline, "TemplateSpecVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual Response<bool> Exists(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _templateSpecVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual async Task<NullableResponse<TemplateSpecVersionResource>> GetIfExistsAsync(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _templateSpecVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TemplateSpecVersionResource>(response.GetRawResponse());
                return Response.FromValue(new TemplateSpecVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}/versions/{templateSpecVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecVersion"/> is null. </exception>
        public virtual NullableResponse<TemplateSpecVersionResource> GetIfExists(string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(templateSpecVersion));
            }

            using var scope = _templateSpecVersionClientDiagnostics.CreateScope("TemplateSpecVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _templateSpecVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, templateSpecVersion, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TemplateSpecVersionResource>(response.GetRawResponse());
                return Response.FromValue(new TemplateSpecVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TemplateSpecVersionResource> IEnumerable<TemplateSpecVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TemplateSpecVersionResource> IAsyncEnumerable<TemplateSpecVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
