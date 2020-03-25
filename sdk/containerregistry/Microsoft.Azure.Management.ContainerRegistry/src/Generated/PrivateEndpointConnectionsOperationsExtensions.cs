// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// Get the specified private endpoint connection associated with the container
            /// registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, registryName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified private endpoint connection associated with the container
            /// registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='privateEndpoint'>
            /// The resource of private endpoint.
            /// </param>
            /// <param name='privateLinkServiceConnectionState'>
            /// A collection of information about the state of the connection between
            /// service consumer and provider.
            /// </param>
            public static PrivateEndpointConnection CreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, PrivateEndpoint privateEndpoint = default(PrivateEndpoint), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, registryName, privateEndpointConnectionName, privateEndpoint, privateLinkServiceConnectionState).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='privateEndpoint'>
            /// The resource of private endpoint.
            /// </param>
            /// <param name='privateLinkServiceConnectionState'>
            /// A collection of information about the state of the connection between
            /// service consumer and provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PrivateEndpointConnection> CreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, PrivateEndpoint privateEndpoint = default(PrivateEndpoint), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, registryName, privateEndpointConnectionName, privateEndpoint, privateLinkServiceConnectionState, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all private endpoint connections in a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            public static IPage<PrivateEndpointConnection> List(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName)
            {
                return operations.ListAsync(resourceGroupName, registryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all private endpoint connections in a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<PrivateEndpointConnection>> ListAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='privateEndpoint'>
            /// The resource of private endpoint.
            /// </param>
            /// <param name='privateLinkServiceConnectionState'>
            /// A collection of information about the state of the connection between
            /// service consumer and provider.
            /// </param>
            public static PrivateEndpointConnection BeginCreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, PrivateEndpoint privateEndpoint = default(PrivateEndpoint), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, registryName, privateEndpointConnectionName, privateEndpoint, privateLinkServiceConnectionState).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='privateEndpoint'>
            /// The resource of private endpoint.
            /// </param>
            /// <param name='privateLinkServiceConnectionState'>
            /// A collection of information about the state of the connection between
            /// service consumer and provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PrivateEndpointConnection> BeginCreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, PrivateEndpoint privateEndpoint = default(PrivateEndpoint), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, registryName, privateEndpointConnectionName, privateEndpoint, privateLinkServiceConnectionState, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            public static void BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string registryName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all private endpoint connections in a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateEndpointConnection> ListNext(this IPrivateEndpointConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all private endpoint connections in a container registry.
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
            public static async System.Threading.Tasks.Task<IPage<PrivateEndpointConnection>> ListNextAsync(this IPrivateEndpointConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
