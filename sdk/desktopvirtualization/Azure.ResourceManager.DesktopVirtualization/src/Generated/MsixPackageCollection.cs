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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="MsixPackageResource" /> and their operations.
    /// Each <see cref="MsixPackageResource" /> in the collection will belong to the same instance of <see cref="HostPoolResource" />.
    /// To get a <see cref="MsixPackageCollection" /> instance call the GetMsixPackages method from an instance of <see cref="HostPoolResource" />.
    /// </summary>
    public partial class MsixPackageCollection : ArmCollection, IEnumerable<MsixPackageResource>, IAsyncEnumerable<MsixPackageResource>
    {
        private readonly ClientDiagnostics _msixPackageMSIXPackagesClientDiagnostics;
        private readonly MsixPackagesRestOperations _msixPackageMSIXPackagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MsixPackageCollection"/> class for mocking. </summary>
        protected MsixPackageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MsixPackageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MsixPackageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _msixPackageMSIXPackagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", MsixPackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MsixPackageResource.ResourceType, out string msixPackageMSIXPackagesApiVersion);
            _msixPackageMSIXPackagesRestClient = new MsixPackagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, msixPackageMSIXPackagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HostPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HostPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a MSIX package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msixPackageFullName"> The version specific package full name of the MSIX package within specified hostpool. </param>
        /// <param name="data"> Object containing  MSIX Package definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="msixPackageFullName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="msixPackageFullName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MsixPackageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string msixPackageFullName, MsixPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(msixPackageFullName, nameof(msixPackageFullName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _msixPackageMSIXPackagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, msixPackageFullName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<MsixPackageResource>(Response.FromValue(new MsixPackageResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a MSIX package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msixPackageFullName"> The version specific package full name of the MSIX package within specified hostpool. </param>
        /// <param name="data"> Object containing  MSIX Package definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="msixPackageFullName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="msixPackageFullName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MsixPackageResource> CreateOrUpdate(WaitUntil waitUntil, string msixPackageFullName, MsixPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(msixPackageFullName, nameof(msixPackageFullName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _msixPackageMSIXPackagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, msixPackageFullName, data, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<MsixPackageResource>(Response.FromValue(new MsixPackageResource(Client, response), response.GetRawResponse()));
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
        /// Get a msixpackage.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="msixPackageFullName"> The version specific package full name of the MSIX package within specified hostpool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="msixPackageFullName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="msixPackageFullName"/> is null. </exception>
        public virtual async Task<Response<MsixPackageResource>> GetAsync(string msixPackageFullName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(msixPackageFullName, nameof(msixPackageFullName));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackageCollection.Get");
            scope.Start();
            try
            {
                var response = await _msixPackageMSIXPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, msixPackageFullName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MsixPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a msixpackage.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="msixPackageFullName"> The version specific package full name of the MSIX package within specified hostpool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="msixPackageFullName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="msixPackageFullName"/> is null. </exception>
        public virtual Response<MsixPackageResource> Get(string msixPackageFullName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(msixPackageFullName, nameof(msixPackageFullName));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackageCollection.Get");
            scope.Start();
            try
            {
                var response = _msixPackageMSIXPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, msixPackageFullName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MsixPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List MSIX packages in hostpool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MsixPackageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MsixPackageResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _msixPackageMSIXPackagesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _msixPackageMSIXPackagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MsixPackageResource(Client, MsixPackageData.DeserializeMsixPackageData(e)), _msixPackageMSIXPackagesClientDiagnostics, Pipeline, "MsixPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List MSIX packages in hostpool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MsixPackageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MsixPackageResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _msixPackageMSIXPackagesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _msixPackageMSIXPackagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MsixPackageResource(Client, MsixPackageData.DeserializeMsixPackageData(e)), _msixPackageMSIXPackagesClientDiagnostics, Pipeline, "MsixPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="msixPackageFullName"> The version specific package full name of the MSIX package within specified hostpool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="msixPackageFullName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="msixPackageFullName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string msixPackageFullName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(msixPackageFullName, nameof(msixPackageFullName));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _msixPackageMSIXPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, msixPackageFullName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MSIXPackages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="msixPackageFullName"> The version specific package full name of the MSIX package within specified hostpool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="msixPackageFullName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="msixPackageFullName"/> is null. </exception>
        public virtual Response<bool> Exists(string msixPackageFullName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(msixPackageFullName, nameof(msixPackageFullName));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = _msixPackageMSIXPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, msixPackageFullName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MsixPackageResource> IEnumerable<MsixPackageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MsixPackageResource> IAsyncEnumerable<MsixPackageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
