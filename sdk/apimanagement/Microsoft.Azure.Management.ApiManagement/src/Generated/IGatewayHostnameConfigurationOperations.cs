// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GatewayHostnameConfigurationOperations operations.
    /// </summary>
    public partial interface IGatewayHostnameConfigurationOperations
    {
        /// <summary>
        /// Lists the collection of hostname configurations for the specified
        /// gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='top'>
        /// Number of records to return.
        /// </param>
        /// <param name='skip'>
        /// Number of records to skip.
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
        Task<AzureOperationResponse<IPage<GatewayHostnameConfigurationContract>>> ListByServiceWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks that hostname configuration entity specified by identifier
        /// exists for specified Gateway entity.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
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
        Task<AzureOperationHeaderResponse<GatewayHostnameConfigurationGetEntityTagHeaders>> GetEntityTagWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of the Gateway hostname configuration specified by
        /// its identifier.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
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
        Task<AzureOperationResponse<GatewayHostnameConfigurationContract,GatewayHostnameConfigurationGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates of updates hostname configuration for a Gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
        /// </param>
        /// <param name='parameters'>
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
        Task<AzureOperationResponse<GatewayHostnameConfigurationContract,GatewayHostnameConfigurationCreateOrUpdateHeaders>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, GatewayHostnameConfigurationContract parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified hostname configuration from the specified
        /// Gateway.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='gatewayId'>
        /// Gateway entity identifier. Must be unique in the current API
        /// Management service instance. Must not have value 'managed'
        /// </param>
        /// <param name='hcId'>
        /// Gateway hostname configuration identifier. Must be unique in the
        /// scope of parent Gateway entity.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string gatewayId, string hcId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the collection of hostname configurations for the specified
        /// gateway.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<GatewayHostnameConfigurationContract>>> ListByServiceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
