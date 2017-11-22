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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ContainerServicesOperations.
    /// </summary>
    public static partial class ContainerServicesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of container services in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription. The
            /// operation returns properties of each container service including state,
            /// orchestrator, number of masters and agents, and FQDNs of masters and
            /// agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ContainerService> List(this IContainerServicesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of container services in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription. The
            /// operation returns properties of each container service including state,
            /// orchestrator, number of masters and agents, and FQDNs of masters and
            /// agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerService>> ListAsync(this IContainerServicesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a container service.
            /// </summary>
            /// <remarks>
            /// Creates or updates a container service with the specified configuration of
            /// orchestrator, masters, and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Container Service operation.
            /// </param>
            public static ContainerService CreateOrUpdate(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, ContainerService parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, containerServiceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a container service.
            /// </summary>
            /// <remarks>
            /// Creates or updates a container service with the specified configuration of
            /// orchestrator, masters, and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Container Service operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerService> CreateOrUpdateAsync(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, ContainerService parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, containerServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the properties of the specified container service.
            /// </summary>
            /// <remarks>
            /// Gets the properties of the specified container service in the specified
            /// subscription and resource group. The operation returns the properties
            /// including state, orchestrator, number of masters and agents, and FQDNs of
            /// masters and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            public static ContainerService Get(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName)
            {
                return operations.GetAsync(resourceGroupName, containerServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified container service.
            /// </summary>
            /// <remarks>
            /// Gets the properties of the specified container service in the specified
            /// subscription and resource group. The operation returns the properties
            /// including state, orchestrator, number of masters and agents, and FQDNs of
            /// masters and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerService> GetAsync(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, containerServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified container service.
            /// </summary>
            /// <remarks>
            /// Deletes the specified container service in the specified subscription and
            /// resource group. The operation does not delete other resources created as
            /// part of creating a container service, including storage accounts, VMs, and
            /// availability sets. All the other resources created with the container
            /// service are part of the same resource group and can be deleted
            /// individually.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            public static void Delete(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName)
            {
                operations.DeleteAsync(resourceGroupName, containerServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified container service.
            /// </summary>
            /// <remarks>
            /// Deletes the specified container service in the specified subscription and
            /// resource group. The operation does not delete other resources created as
            /// part of creating a container service, including storage accounts, VMs, and
            /// availability sets. All the other resources created with the container
            /// service are part of the same resource group and can be deleted
            /// individually.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, containerServiceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of container services in the specified resource group.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription and
            /// resource group. The operation returns properties of each container service
            /// including state, orchestrator, number of masters and agents, and FQDNs of
            /// masters and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ContainerService> ListByResourceGroup(this IContainerServicesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of container services in the specified resource group.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription and
            /// resource group. The operation returns properties of each container service
            /// including state, orchestrator, number of masters and agents, and FQDNs of
            /// masters and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerService>> ListByResourceGroupAsync(this IContainerServicesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a container service.
            /// </summary>
            /// <remarks>
            /// Creates or updates a container service with the specified configuration of
            /// orchestrator, masters, and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Container Service operation.
            /// </param>
            public static ContainerService BeginCreateOrUpdate(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, ContainerService parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, containerServiceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a container service.
            /// </summary>
            /// <remarks>
            /// Creates or updates a container service with the specified configuration of
            /// orchestrator, masters, and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update a Container Service operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerService> BeginCreateOrUpdateAsync(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, ContainerService parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, containerServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified container service.
            /// </summary>
            /// <remarks>
            /// Deletes the specified container service in the specified subscription and
            /// resource group. The operation does not delete other resources created as
            /// part of creating a container service, including storage accounts, VMs, and
            /// availability sets. All the other resources created with the container
            /// service are part of the same resource group and can be deleted
            /// individually.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            public static void BeginDelete(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, containerServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified container service.
            /// </summary>
            /// <remarks>
            /// Deletes the specified container service in the specified subscription and
            /// resource group. The operation does not delete other resources created as
            /// part of creating a container service, including storage accounts, VMs, and
            /// availability sets. All the other resources created with the container
            /// service are part of the same resource group and can be deleted
            /// individually.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='containerServiceName'>
            /// The name of the container service in the specified subscription and
            /// resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IContainerServicesOperations operations, string resourceGroupName, string containerServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, containerServiceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of container services in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription. The
            /// operation returns properties of each container service including state,
            /// orchestrator, number of masters and agents, and FQDNs of masters and
            /// agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ContainerService> ListNext(this IContainerServicesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of container services in the specified subscription.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription. The
            /// operation returns properties of each container service including state,
            /// orchestrator, number of masters and agents, and FQDNs of masters and
            /// agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerService>> ListNextAsync(this IContainerServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of container services in the specified resource group.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription and
            /// resource group. The operation returns properties of each container service
            /// including state, orchestrator, number of masters and agents, and FQDNs of
            /// masters and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ContainerService> ListByResourceGroupNext(this IContainerServicesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of container services in the specified resource group.
            /// </summary>
            /// <remarks>
            /// Gets a list of container services in the specified subscription and
            /// resource group. The operation returns properties of each container service
            /// including state, orchestrator, number of masters and agents, and FQDNs of
            /// masters and agents.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ContainerService>> ListByResourceGroupNextAsync(this IContainerServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
