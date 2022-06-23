// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnectionsOperations operations.
    /// </summary>
    public partial interface IPrivateEndpointConnectionsOperations
    {
        /// <summary>
        /// List private endpoint connection properties.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the
        /// DigitalTwinsInstance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the DigitalTwinsInstance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnectionsResponse>> ListWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get private endpoint connection properties for the given private
        /// endpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the
        /// DigitalTwinsInstance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the DigitalTwinsInstance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete private endpoint connection with the specified name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the
        /// DigitalTwinsInstance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the DigitalTwinsInstance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the status of a private endpoint connection with the given
        /// name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the
        /// DigitalTwinsInstance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the DigitalTwinsInstance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='properties'>
        /// The connection properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, ConnectionProperties properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete private endpoint connection with the specified name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the
        /// DigitalTwinsInstance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the DigitalTwinsInstance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the status of a private endpoint connection with the given
        /// name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the
        /// DigitalTwinsInstance.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the DigitalTwinsInstance.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection.
        /// </param>
        /// <param name='properties'>
        /// The connection properties.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, ConnectionProperties properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
