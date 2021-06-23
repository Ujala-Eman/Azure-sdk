// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CapacityReservationGroupsOperations.
    /// </summary>
    public static partial class CapacityReservationGroupsOperationsExtensions
    {
            /// <summary>
            /// Create or update a capacity reservation group. &lt;br&gt;&lt;br&gt; NOTE:
            /// Please refer https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Capacity Reservation Group.
            /// </param>
            public static CapacityReservationGroup CreateOrUpdate(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, CapacityReservationGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, capacityReservationGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a capacity reservation group. &lt;br&gt;&lt;br&gt; NOTE:
            /// Please refer https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Capacity Reservation Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservationGroup> CreateOrUpdateAsync(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, CapacityReservationGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an capacity reservation group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='tags'>
            /// Resource tags
            /// </param>
            public static CapacityReservationGroup Update(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, capacityReservationGroupName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an capacity reservation group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='tags'>
            /// Resource tags
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservationGroup> UpdateAsync(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a capacity reservation group.&lt;br&gt;&lt;br&gt; NOTE: Capacity
            /// Reservation group can only be deleted if all the capacity reservations
            /// under the reservation group and associated resources are disassociated from
            /// the reservation group first. Please refer
            /// https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            public static void Delete(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName)
            {
                operations.DeleteAsync(resourceGroupName, capacityReservationGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a capacity reservation group.&lt;br&gt;&lt;br&gt; NOTE: Capacity
            /// Reservation group can only be deleted if all the capacity reservations
            /// under the reservation group and associated resources are disassociated from
            /// the reservation group first. Please refer
            /// https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves information about a capacity reservation group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. 'InstanceView' will
            /// retrieve the list of instance views of the Capacity Reservations under the
            /// capacity reservation group. Possible values include: 'instanceView'
            /// </param>
            public static CapacityReservationGroup Get(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, CapacityReservationInstanceViewTypes? expand = default(CapacityReservationInstanceViewTypes?))
            {
                return operations.GetAsync(resourceGroupName, capacityReservationGroupName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a capacity reservation group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. 'InstanceView' will
            /// retrieve the list of instance views of the Capacity Reservations under the
            /// capacity reservation group. Possible values include: 'instanceView'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservationGroup> GetAsync(this ICapacityReservationGroupsOperations operations, string resourceGroupName, string capacityReservationGroupName, CapacityReservationInstanceViewTypes? expand = default(CapacityReservationInstanceViewTypes?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the specified resource
            /// group. Use the nextLink property in the response to get the next page of
            /// capacity reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'virtualMachineScaleSetVMs/$ref', 'virtualMachines/$ref'
            /// </param>
            public static IPage<CapacityReservationGroup> ListByResourceGroup(this ICapacityReservationGroupsOperations operations, string resourceGroupName, ExpandTypesForGetCapacityReservationGroups? expand = default(ExpandTypesForGetCapacityReservationGroups?))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the specified resource
            /// group. Use the nextLink property in the response to get the next page of
            /// capacity reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'virtualMachineScaleSetVMs/$ref', 'virtualMachines/$ref'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CapacityReservationGroup>> ListByResourceGroupAsync(this ICapacityReservationGroupsOperations operations, string resourceGroupName, ExpandTypesForGetCapacityReservationGroups? expand = default(ExpandTypesForGetCapacityReservationGroups?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the subscription. Use the
            /// nextLink property in the response to get the next page of capacity
            /// reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'virtualMachineScaleSetVMs/$ref', 'virtualMachines/$ref'
            /// </param>
            public static IPage<CapacityReservationGroup> ListBySubscription(this ICapacityReservationGroupsOperations operations, ExpandTypesForGetCapacityReservationGroups? expand = default(ExpandTypesForGetCapacityReservationGroups?))
            {
                return operations.ListBySubscriptionAsync(expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the subscription. Use the
            /// nextLink property in the response to get the next page of capacity
            /// reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'virtualMachineScaleSetVMs/$ref', 'virtualMachines/$ref'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CapacityReservationGroup>> ListBySubscriptionAsync(this ICapacityReservationGroupsOperations operations, ExpandTypesForGetCapacityReservationGroups? expand = default(ExpandTypesForGetCapacityReservationGroups?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the specified resource
            /// group. Use the nextLink property in the response to get the next page of
            /// capacity reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CapacityReservationGroup> ListByResourceGroupNext(this ICapacityReservationGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the specified resource
            /// group. Use the nextLink property in the response to get the next page of
            /// capacity reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CapacityReservationGroup>> ListByResourceGroupNextAsync(this ICapacityReservationGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the subscription. Use the
            /// nextLink property in the response to get the next page of capacity
            /// reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CapacityReservationGroup> ListBySubscriptionNext(this ICapacityReservationGroupsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the capacity reservation groups in the subscription. Use the
            /// nextLink property in the response to get the next page of capacity
            /// reservation groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CapacityReservationGroup>> ListBySubscriptionNextAsync(this ICapacityReservationGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
