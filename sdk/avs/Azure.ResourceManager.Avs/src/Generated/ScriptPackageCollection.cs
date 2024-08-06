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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="ScriptPackageResource"/> and their operations.
    /// Each <see cref="ScriptPackageResource"/> in the collection will belong to the same instance of <see cref="PrivateCloudResource"/>.
    /// To get a <see cref="ScriptPackageCollection"/> instance call the GetScriptPackages method from an instance of <see cref="PrivateCloudResource"/>.
    /// </summary>
    public partial class ScriptPackageCollection : ArmCollection, IEnumerable<ScriptPackageResource>, IAsyncEnumerable<ScriptPackageResource>
    {
        private readonly ClientDiagnostics _scriptPackageClientDiagnostics;
        private readonly ScriptPackagesRestOperations _scriptPackageRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScriptPackageCollection"/> class for mocking. </summary>
        protected ScriptPackageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptPackageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScriptPackageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptPackageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ScriptPackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScriptPackageResource.ResourceType, out string scriptPackageApiVersion);
            _scriptPackageRestClient = new ScriptPackagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptPackageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a ScriptPackage
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptPackageName"> Name of the script package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptPackageName"/> is null. </exception>
        public virtual async Task<Response<ScriptPackageResource>> GetAsync(string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageCollection.Get");
            scope.Start();
            try
            {
                var response = await _scriptPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptPackageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ScriptPackage
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptPackageName"> Name of the script package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptPackageName"/> is null. </exception>
        public virtual Response<ScriptPackageResource> Get(string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageCollection.Get");
            scope.Start();
            try
            {
                var response = _scriptPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptPackageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List ScriptPackage resources by PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackage_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScriptPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScriptPackageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scriptPackageRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scriptPackageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScriptPackageResource(Client, ScriptPackageData.DeserializeScriptPackageData(e)), _scriptPackageClientDiagnostics, Pipeline, "ScriptPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ScriptPackage resources by PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackage_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScriptPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScriptPackageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scriptPackageRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scriptPackageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScriptPackageResource(Client, ScriptPackageData.DeserializeScriptPackageData(e)), _scriptPackageClientDiagnostics, Pipeline, "ScriptPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptPackageName"> Name of the script package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptPackageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scriptPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptPackageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptPackageName"> Name of the script package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptPackageName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = _scriptPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptPackageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptPackageName"> Name of the script package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptPackageName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScriptPackageResource>> GetIfExistsAsync(string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scriptPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptPackageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScriptPackageResource>(response.GetRawResponse());
                return Response.FromValue(new ScriptPackageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScriptPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptPackageName"> Name of the script package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptPackageName"/> is null. </exception>
        public virtual NullableResponse<ScriptPackageResource> GetIfExists(string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var scope = _scriptPackageClientDiagnostics.CreateScope("ScriptPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scriptPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, scriptPackageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScriptPackageResource>(response.GetRawResponse());
                return Response.FromValue(new ScriptPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScriptPackageResource> IEnumerable<ScriptPackageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScriptPackageResource> IAsyncEnumerable<ScriptPackageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
