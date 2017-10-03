// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearningCompute
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OperationalizationClustersOperations operations.
    /// </summary>
    public partial interface IOperationalizationClustersOperations
    {
        /// <summary>
        /// Create or update an operationalization cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update an Operationalization
        /// cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseWrapperException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationalizationCluster>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, OperationalizationCluster parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the
        /// credentials are not returned by this call. Call ListKeys to get
        /// them.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseWrapperException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationalizationCluster>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The PATCH operation can be used to update only the tags for a
        /// cluster. Use PUT operation to update other properties.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to patch the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseWrapperException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationalizationCluster>> UpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, OperationalizationClusterUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseWrapperException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<OperationalizationClustersDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the credentials for the specified cluster such as Storage, ACR
        /// and ACS credentials. This is a long running operation because it
        /// fetches keys from dependencies.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationalizationClusterCredentials>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks if updates are available for system services in the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckSystemServicesUpdatesAvailableResponse>> CheckSystemServicesUpdatesAvailableWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates system services in a cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<UpdateSystemServicesResponse,OperationalizationClustersUpdateSystemServicesHeaders>> UpdateSystemServicesWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the clusters in the specified resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='skiptoken'>
        /// Continuation token for pagination.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationalizationCluster>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, string skiptoken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// </summary>
        /// <param name='skiptoken'>
        /// Continuation token for pagination.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationalizationCluster>>> ListBySubscriptionIdWithHttpMessagesAsync(string skiptoken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an operationalization cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update an Operationalization
        /// cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseWrapperException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationalizationCluster>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, OperationalizationCluster parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseWrapperException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<OperationalizationClustersDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates system services in a cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group in which the cluster is located.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<UpdateSystemServicesResponse,OperationalizationClustersUpdateSystemServicesHeaders>> BeginUpdateSystemServicesWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the clusters in the specified resource group.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationalizationCluster>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OperationalizationCluster>>> ListBySubscriptionIdNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
