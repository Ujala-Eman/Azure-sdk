// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ScaleUnitNodesOperations operations.
    /// </summary>
    public partial interface IScaleUnitNodesOperations
    {
        /// <summary>
        /// Shutdown a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ShutdownWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Power off a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PowerOffWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Power on a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PowerOnWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start maintenance mode for a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StartMaintenanceModeWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop maintenance mode for a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StopMaintenanceModeWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Repairs a node of the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
        /// </param>
        /// <param name='bareMetalNode'>
        /// Description of a node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RepairWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, BareMetalNodeDescription bareMetalNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return the requested scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        Task<AzureOperationResponse<ScaleUnitNode>> GetWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all scale unit nodes in a location.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
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
        Task<AzureOperationResponse<IPage<ScaleUnitNode>>> ListWithHttpMessagesAsync(string resourceGroupName, string location, ODataQuery<ScaleUnitNode> odataQuery = default(ODataQuery<ScaleUnitNode>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Shutdown a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginShutdownWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Power off a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginPowerOffWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Power on a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginPowerOnWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start maintenance mode for a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStartMaintenanceModeWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop maintenance mode for a scale unit node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStopMaintenanceModeWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Repairs a node of the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='location'>
        /// Location of the resource.
        /// </param>
        /// <param name='scaleUnitNode'>
        /// Name of the scale unit node.
        /// </param>
        /// <param name='bareMetalNode'>
        /// Description of a node.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginRepairWithHttpMessagesAsync(string resourceGroupName, string location, string scaleUnitNode, BareMetalNodeDescription bareMetalNode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all scale unit nodes in a location.
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
        Task<AzureOperationResponse<IPage<ScaleUnitNode>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
