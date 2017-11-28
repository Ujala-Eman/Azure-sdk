// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ComputeNodeOperations operations.
    /// </summary>
    public partial interface IComputeNodeOperations
    {
        /// <summary>
        /// Adds a user account to the specified compute node.
        /// </summary>
        /// <remarks>
        /// You can add a user account to a node only when it is in the idle or
        /// running state.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the machine on which you want to create a user account.
        /// </param>
        /// <param name='user'>
        /// The user account to be created.
        /// </param>
        /// <param name='computeNodeAddUserOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeAddUserHeaders>> AddUserWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeUser user, ComputeNodeAddUserOptions computeNodeAddUserOptions = default(ComputeNodeAddUserOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a user account from the specified compute node.
        /// </summary>
        /// <remarks>
        /// You can delete a user account to a node only when it is in the idle
        /// or running state.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the machine on which you want to delete a user account.
        /// </param>
        /// <param name='userName'>
        /// The name of the user account to delete.
        /// </param>
        /// <param name='computeNodeDeleteUserOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeDeleteUserHeaders>> DeleteUserWithHttpMessagesAsync(string poolId, string nodeId, string userName, ComputeNodeDeleteUserOptions computeNodeDeleteUserOptions = default(ComputeNodeDeleteUserOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the password and expiration time of a user account on the
        /// specified compute node.
        /// </summary>
        /// <remarks>
        /// This operation replaces of all the updateable properties of the
        /// account. For example, if the expiryTime element is not specified,
        /// the current value is replaced with the default value, not left
        /// unmodified. You can update a user account on a node only when it is
        /// in the idle or running state.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the machine on which you want to update a user account.
        /// </param>
        /// <param name='userName'>
        /// The name of the user account to update.
        /// </param>
        /// <param name='nodeUpdateUserParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='computeNodeUpdateUserOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeUpdateUserHeaders>> UpdateUserWithHttpMessagesAsync(string poolId, string nodeId, string userName, NodeUpdateUserParameter nodeUpdateUserParameter, ComputeNodeUpdateUserOptions computeNodeUpdateUserOptions = default(ComputeNodeUpdateUserOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the specified compute node.
        /// </summary>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node that you want to get information about.
        /// </param>
        /// <param name='computeNodeGetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ComputeNode,ComputeNodeGetHeaders>> GetWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeGetOptions computeNodeGetOptions = default(ComputeNodeGetOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restarts the specified compute node.
        /// </summary>
        /// <remarks>
        /// You can restart a node only if it is in an idle or running state.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node that you want to restart.
        /// </param>
        /// <param name='nodeRebootOption'>
        /// When to reboot the compute node and what to do with currently
        /// running tasks. The default value is requeue. Possible values
        /// include: 'requeue', 'terminate', 'taskCompletion', 'retainedData'
        /// </param>
        /// <param name='computeNodeRebootOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeRebootHeaders>> RebootWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeRebootOption? nodeRebootOption = default(ComputeNodeRebootOption?), ComputeNodeRebootOptions computeNodeRebootOptions = default(ComputeNodeRebootOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reinstalls the operating system on the specified compute node.
        /// </summary>
        /// <remarks>
        /// You can reinstall the operating system on a node only if it is in
        /// an idle or running state. This API can be invoked only on pools
        /// created with the cloud service configuration property.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node that you want to restart.
        /// </param>
        /// <param name='nodeReimageOption'>
        /// When to reimage the compute node and what to do with currently
        /// running tasks. The default value is requeue. Possible values
        /// include: 'requeue', 'terminate', 'taskCompletion', 'retainedData'
        /// </param>
        /// <param name='computeNodeReimageOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeReimageHeaders>> ReimageWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeReimageOption? nodeReimageOption = default(ComputeNodeReimageOption?), ComputeNodeReimageOptions computeNodeReimageOptions = default(ComputeNodeReimageOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables task scheduling on the specified compute node.
        /// </summary>
        /// <remarks>
        /// You can disable task scheduling on a node only if its current
        /// scheduling state is enabled.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node on which you want to disable task
        /// scheduling.
        /// </param>
        /// <param name='nodeDisableSchedulingOption'>
        /// What to do with currently running tasks when disabling task
        /// scheduling on the compute node. The default value is requeue.
        /// Possible values include: 'requeue', 'terminate', 'taskCompletion'
        /// </param>
        /// <param name='computeNodeDisableSchedulingOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeDisableSchedulingHeaders>> DisableSchedulingWithHttpMessagesAsync(string poolId, string nodeId, DisableComputeNodeSchedulingOption? nodeDisableSchedulingOption = default(DisableComputeNodeSchedulingOption?), ComputeNodeDisableSchedulingOptions computeNodeDisableSchedulingOptions = default(ComputeNodeDisableSchedulingOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables task scheduling on the specified compute node.
        /// </summary>
        /// <remarks>
        /// You can enable task scheduling on a node only if its current
        /// scheduling state is disabled
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node on which you want to enable task
        /// scheduling.
        /// </param>
        /// <param name='computeNodeEnableSchedulingOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ComputeNodeEnableSchedulingHeaders>> EnableSchedulingWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeEnableSchedulingOptions computeNodeEnableSchedulingOptions = default(ComputeNodeEnableSchedulingOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the settings required for remote login to a compute node.
        /// </summary>
        /// <remarks>
        /// Before you can remotely login to a node using the remote login
        /// settings, you must create a user account on the node. This API can
        /// be invoked only on pools created with the virtual machine
        /// configuration property. For pools created with a cloud service
        /// configuration, see the GetRemoteDesktop API.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node for which to obtain the remote login
        /// settings.
        /// </param>
        /// <param name='computeNodeGetRemoteLoginSettingsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ComputeNodeGetRemoteLoginSettingsResult,ComputeNodeGetRemoteLoginSettingsHeaders>> GetRemoteLoginSettingsWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeGetRemoteLoginSettingsOptions computeNodeGetRemoteLoginSettingsOptions = default(ComputeNodeGetRemoteLoginSettingsOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Remote Desktop Protocol file for the specified compute
        /// node.
        /// </summary>
        /// <remarks>
        /// Before you can access a node by using the RDP file, you must create
        /// a user account on the node. This API can only be invoked on pools
        /// created with a cloud service configuration. For pools created with
        /// a virtual machine configuration, see the GetRemoteLoginSettings
        /// API.
        /// </remarks>
        /// <param name='poolId'>
        /// The ID of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The ID of the compute node for which you want to get the Remote
        /// Desktop Protocol file.
        /// </param>
        /// <param name='computeNodeGetRemoteDesktopOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Stream,ComputeNodeGetRemoteDesktopHeaders>> GetRemoteDesktopWithHttpMessagesAsync(string poolId, string nodeId, ComputeNodeGetRemoteDesktopOptions computeNodeGetRemoteDesktopOptions = default(ComputeNodeGetRemoteDesktopOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the compute nodes in the specified pool.
        /// </summary>
        /// <param name='poolId'>
        /// The ID of the pool from which you want to list nodes.
        /// </param>
        /// <param name='computeNodeListOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ComputeNode>,ComputeNodeListHeaders>> ListWithHttpMessagesAsync(string poolId, ComputeNodeListOptions computeNodeListOptions = default(ComputeNodeListOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the compute nodes in the specified pool.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='computeNodeListNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ComputeNode>,ComputeNodeListHeaders>> ListNextWithHttpMessagesAsync(string nextPageLink, ComputeNodeListNextOptions computeNodeListNextOptions = default(ComputeNodeListNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
