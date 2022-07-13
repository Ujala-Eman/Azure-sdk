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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CloudServiceRoleInstancesOperations operations.
    /// </summary>
    public partial interface ICloudServiceRoleInstancesOperations
    {
        /// <summary>
        /// Deletes a role instance from a cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a role instance from a cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
        /// </param>
        /// <param name='expand'>
        /// The expand expression to apply to the operation. 'UserData' is not
        /// supported for cloud services. Possible values include:
        /// 'instanceView', 'userData'
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
        Task<AzureOperationResponse<RoleInstance>> GetWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, InstanceViewTypes? expand = default(InstanceViewTypes?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves information about the run-time state of a role instance
        /// in a cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse<RoleInstanceInstanceView>> GetInstanceViewWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all role instances in a cloud service. Use
        /// nextLink property in the response to get the next page of role
        /// instances. Do this till nextLink is null to fetch all the role
        /// instances.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
        /// </param>
        /// <param name='expand'>
        /// The expand expression to apply to the operation. 'UserData' is not
        /// supported for cloud services. Possible values include:
        /// 'instanceView', 'userData'
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
        Task<AzureOperationResponse<IPage<RoleInstance>>> ListWithHttpMessagesAsync(string resourceGroupName, string cloudServiceName, InstanceViewTypes? expand = default(InstanceViewTypes?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Reboot Role Instance asynchronous operation requests a reboot
        /// of a role instance in the cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> RestartWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Reimage Role Instance asynchronous operation reinstalls the
        /// operating system on instances of web roles or worker roles.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> ReimageWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Rebuild Role Instance asynchronous operation reinstalls the
        /// operating system on instances of web roles or worker roles and
        /// initializes the storage resources that are used by them. If you do
        /// not want to initialize storage resources, you can use Reimage Role
        /// Instance.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> RebuildWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a remote desktop file for a role instance in a cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse<Stream>> GetRemoteDesktopFileWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a role instance from a cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Reboot Role Instance asynchronous operation requests a reboot
        /// of a role instance in the cloud service.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> BeginRestartWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Reimage Role Instance asynchronous operation reinstalls the
        /// operating system on instances of web roles or worker roles.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> BeginReimageWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Rebuild Role Instance asynchronous operation reinstalls the
        /// operating system on instances of web roles or worker roles and
        /// initializes the storage resources that are used by them. If you do
        /// not want to initialize storage resources, you can use Reimage Role
        /// Instance.
        /// </summary>
        /// <param name='roleInstanceName'>
        /// Name of the role instance.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Name of the cloud service.
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
        Task<AzureOperationResponse> BeginRebuildWithHttpMessagesAsync(string roleInstanceName, string resourceGroupName, string cloudServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all role instances in a cloud service. Use
        /// nextLink property in the response to get the next page of role
        /// instances. Do this till nextLink is null to fetch all the role
        /// instances.
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
        Task<AzureOperationResponse<IPage<RoleInstance>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
