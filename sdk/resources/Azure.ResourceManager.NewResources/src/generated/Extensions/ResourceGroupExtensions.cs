// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region ManagementLockObjects
        /// <summary> Gets an object representing a ManagementLockObjectResourceGroupsContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ManagementLockObjectResourceGroupsContainer" /> object. </returns>
        public static ManagementLockObjectResourceGroupsContainer GetManagementLockObjects(this ResourceGroupOperations resourceGroup)
        {
            return new ManagementLockObjectResourceGroupsContainer(resourceGroup);
        }
        #endregion

        #region Applications
        /// <summary> Gets an object representing a ApplicationContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ApplicationContainer" /> object. </returns>
        public static ApplicationContainer GetApplications(this ResourceGroupOperations resourceGroup)
        {
            return new ApplicationContainer(resourceGroup);
        }
        #endregion

        #region ApplicationDefinitions
        /// <summary> Gets an object representing a ApplicationDefinitionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ApplicationDefinitionContainer" /> object. </returns>
        public static ApplicationDefinitionContainer GetApplicationDefinitions(this ResourceGroupOperations resourceGroup)
        {
            return new ApplicationDefinitionContainer(resourceGroup);
        }
        #endregion

        #region PolicyAssignment
        private static PolicyAssignmentsRestOperations GetPolicyAssignmentsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new PolicyAssignmentsRestOperations(clientDiagnostics, pipeline, endpoint);
        }

        /// <summary> Lists the PolicyAssignment for this Azure.ResourceManager.Core.ResourceGroupOperations. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<PolicyAssignment> ListPolicyAssignment(this ResourceGroupOperations resourceGroup, CancellationToken cancellationToken = default)
        {
            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPolicyAssignmentsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                var result = ListForResourceGroup(clientDiagnostics, restOperations, resourceGroup.Id.SubscriptionId, resourceGroup.Id.ResourceGroupName);
                return new PhWrappingPageable<PolicyAssignmentData, PolicyAssignment>(
                result,
                s => new PolicyAssignment(resourceGroup, s));
            }
            );
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains policy assignments. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <returns> A collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        private static Pageable<PolicyAssignmentData> ListForResourceGroup(ClientDiagnostics clientDiagnostics, PolicyAssignmentsRestOperations restOperations, string subscriptionId, string resourceGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyAssignmentData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = restOperations.ListForResourceGroup(subscriptionId, resourceGroupName, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyAssignmentData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = restOperations.ListNextPage(nextLink, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains policy assignments. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <returns> An async collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        private static AsyncPageable<PolicyAssignmentData> ListForResourceGroupAsync(ClientDiagnostics clientDiagnostics, PolicyAssignmentsRestOperations restOperations, string subscriptionId, string resourceGroupName, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            async Task<Page<PolicyAssignmentData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await restOperations.ListForResourceGroupAsync(subscriptionId, resourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyAssignmentData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await restOperations.ListNextPageAsync(nextLink, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }
        #endregion
    }
}
