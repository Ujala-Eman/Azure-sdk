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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningFeatureResource"/> and their operations.
    /// Each <see cref="MachineLearningFeatureResource"/> in the collection will belong to the same instance of <see cref="MachineLearningFeatureSetVersionResource"/>.
    /// To get a <see cref="MachineLearningFeatureCollection"/> instance call the GetMachineLearningFeatures method from an instance of <see cref="MachineLearningFeatureSetVersionResource"/>.
    /// </summary>
    public partial class MachineLearningFeatureCollection : ArmCollection, IEnumerable<MachineLearningFeatureResource>, IAsyncEnumerable<MachineLearningFeatureResource>
    {
        private readonly ClientDiagnostics _machineLearningFeatureFeaturesClientDiagnostics;
        private readonly FeaturesRestOperations _machineLearningFeatureFeaturesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningFeatureCollection"/> class for mocking. </summary>
        protected MachineLearningFeatureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningFeatureCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningFeatureCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningFeatureFeaturesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningFeatureResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningFeatureResource.ResourceType, out string machineLearningFeatureFeaturesApiVersion);
            _machineLearningFeatureFeaturesRestClient = new FeaturesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningFeatureFeaturesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningFeatureSetVersionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningFeatureSetVersionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get feature.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningFeatureResource>> GetAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _machineLearningFeatureFeaturesClientDiagnostics.CreateScope("MachineLearningFeatureCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureFeaturesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, featureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get feature.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<MachineLearningFeatureResource> Get(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _machineLearningFeatureFeaturesClientDiagnostics.CreateScope("MachineLearningFeatureCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureFeaturesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, featureName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Features.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureName"> feature name. </param>
        /// <param name="description"> Description of the featureset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningFeatureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningFeatureResource> GetAllAsync(string skip = null, string tags = null, string featureName = null, string description = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningFeatureFeaturesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, tags, featureName, description);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningFeatureFeaturesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, tags, featureName, description);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningFeatureResource(Client, MachineLearningFeatureData.DeserializeMachineLearningFeatureData(e)), _machineLearningFeatureFeaturesClientDiagnostics, Pipeline, "MachineLearningFeatureCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Features.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureName"> feature name. </param>
        /// <param name="description"> Description of the featureset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningFeatureResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningFeatureResource> GetAll(string skip = null, string tags = null, string featureName = null, string description = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningFeatureFeaturesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, tags, featureName, description);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningFeatureFeaturesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, tags, featureName, description);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningFeatureResource(Client, MachineLearningFeatureData.DeserializeMachineLearningFeatureData(e)), _machineLearningFeatureFeaturesClientDiagnostics, Pipeline, "MachineLearningFeatureCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _machineLearningFeatureFeaturesClientDiagnostics.CreateScope("MachineLearningFeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureFeaturesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, featureName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<bool> Exists(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _machineLearningFeatureFeaturesClientDiagnostics.CreateScope("MachineLearningFeatureCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureFeaturesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, featureName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningFeatureResource>> GetIfExistsAsync(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _machineLearningFeatureFeaturesClientDiagnostics.CreateScope("MachineLearningFeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureFeaturesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, featureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningFeatureResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeatureResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningFeatureResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual NullableResponse<MachineLearningFeatureResource> GetIfExists(string featureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(featureName, nameof(featureName));

            using var scope = _machineLearningFeatureFeaturesClientDiagnostics.CreateScope("MachineLearningFeatureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureFeaturesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, featureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningFeatureResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningFeatureResource> IEnumerable<MachineLearningFeatureResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningFeatureResource> IAsyncEnumerable<MachineLearningFeatureResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
