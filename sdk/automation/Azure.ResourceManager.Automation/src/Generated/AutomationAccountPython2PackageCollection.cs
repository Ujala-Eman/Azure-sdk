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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationAccountPython2PackageResource"/> and their operations.
    /// Each <see cref="AutomationAccountPython2PackageResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationAccountPython2PackageCollection"/> instance call the GetAutomationAccountPython2Packages method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationAccountPython2PackageCollection : ArmCollection, IEnumerable<AutomationAccountPython2PackageResource>, IAsyncEnumerable<AutomationAccountPython2PackageResource>
    {
        private readonly ClientDiagnostics _automationAccountPython2PackagePython2PackageClientDiagnostics;
        private readonly Python2PackageRestOperations _automationAccountPython2PackagePython2PackageRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountPython2PackageCollection"/> class for mocking. </summary>
        protected AutomationAccountPython2PackageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountPython2PackageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationAccountPython2PackageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationAccountPython2PackagePython2PackageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationAccountPython2PackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationAccountPython2PackageResource.ResourceType, out string automationAccountPython2PackagePython2PackageApiVersion);
            _automationAccountPython2PackagePython2PackageRestClient = new Python2PackageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationAccountPython2PackagePython2PackageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update the python 2 package identified by package name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packageName"> The name of python package. </param>
        /// <param name="content"> The create or update parameters for python package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationAccountPython2PackageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string packageName, AutomationAccountPython2PackageCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationAccountPython2PackagePython2PackageRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationAccountPython2PackageResource>(Response.FromValue(new AutomationAccountPython2PackageResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update the python 2 package identified by package name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packageName"> The name of python package. </param>
        /// <param name="content"> The create or update parameters for python package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationAccountPython2PackageResource> CreateOrUpdate(WaitUntil waitUntil, string packageName, AutomationAccountPython2PackageCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationAccountPython2PackagePython2PackageRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationAccountPython2PackageResource>(Response.FromValue(new AutomationAccountPython2PackageResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the python 2 package identified by package name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageName"> The python package name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> is null. </exception>
        public virtual async Task<Response<AutomationAccountPython2PackageResource>> GetAsync(string packageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationAccountPython2PackagePython2PackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPython2PackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the python 2 package identified by package name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageName"> The python package name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> is null. </exception>
        public virtual Response<AutomationAccountPython2PackageResource> Get(string packageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.Get");
            scope.Start();
            try
            {
                var response = _automationAccountPython2PackagePython2PackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPython2PackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of python 2 packages.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountPython2PackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationAccountPython2PackageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountPython2PackagePython2PackageRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountPython2PackagePython2PackageRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationAccountPython2PackageResource(Client, AutomationModuleData.DeserializeAutomationModuleData(e)), _automationAccountPython2PackagePython2PackageClientDiagnostics, Pipeline, "AutomationAccountPython2PackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of python 2 packages.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountPython2PackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationAccountPython2PackageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountPython2PackagePython2PackageRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountPython2PackagePython2PackageRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationAccountPython2PackageResource(Client, AutomationModuleData.DeserializeAutomationModuleData(e)), _automationAccountPython2PackagePython2PackageClientDiagnostics, Pipeline, "AutomationAccountPython2PackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageName"> The python package name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string packageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationAccountPython2PackagePython2PackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageName"> The python package name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> is null. </exception>
        public virtual Response<bool> Exists(string packageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationAccountPython2PackagePython2PackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageName"> The python package name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationAccountPython2PackageResource>> GetIfExistsAsync(string packageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationAccountPython2PackagePython2PackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationAccountPython2PackageResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPython2PackageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/python2Packages/{packageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Python2Package_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageName"> The python package name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageName"/> is null. </exception>
        public virtual NullableResponse<AutomationAccountPython2PackageResource> GetIfExists(string packageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageName, nameof(packageName));

            using var scope = _automationAccountPython2PackagePython2PackageClientDiagnostics.CreateScope("AutomationAccountPython2PackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationAccountPython2PackagePython2PackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationAccountPython2PackageResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPython2PackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationAccountPython2PackageResource> IEnumerable<AutomationAccountPython2PackageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationAccountPython2PackageResource> IAsyncEnumerable<AutomationAccountPython2PackageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
