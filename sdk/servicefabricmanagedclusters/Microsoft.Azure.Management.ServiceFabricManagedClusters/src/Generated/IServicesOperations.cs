// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServicesOperations operations.
    /// </summary>
    public partial interface IServicesOperations
    {
        /// <summary>
        /// Gets a Service Fabric managed service resource.
        /// </summary>
        /// <remarks>
        /// Get a Service Fabric service resource created or in the process of
        /// being created in the Service Fabric managed application resource.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource in the format of
        /// {applicationName}~{serviceName}.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceResource>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a Service Fabric managed service resource.
        /// </summary>
        /// <remarks>
        /// Create or update a Service Fabric managed service resource with the
        /// specified name.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource in the format of
        /// {applicationName}~{serviceName}.
        /// </param>
        /// <param name='parameters'>
        /// The service resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the tags of a service resource of a given managed cluster.
        /// </summary>
        /// <remarks>
        /// Updates the tags of a service resource of a given managed cluster.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource in the format of
        /// {applicationName}~{serviceName}.
        /// </param>
        /// <param name='tags'>
        /// Service update parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, string serviceName, IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Service Fabric managed service resource.
        /// </summary>
        /// <remarks>
        /// Delete a Service Fabric managed service resource with the specified
        /// name.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource in the format of
        /// {applicationName}~{serviceName}.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of service resources created in the specified Service
        /// Fabric managed application resource.
        /// </summary>
        /// <remarks>
        /// Gets all service resources created or in the process of being
        /// created in the Service Fabric managed application resource.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ServiceResource>>> ListByApplicationsWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a Service Fabric managed service resource.
        /// </summary>
        /// <remarks>
        /// Create or update a Service Fabric managed service resource with the
        /// specified name.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource in the format of
        /// {applicationName}~{serviceName}.
        /// </param>
        /// <param name='parameters'>
        /// The service resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, string serviceName, ServiceResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Service Fabric managed service resource.
        /// </summary>
        /// <remarks>
        /// Delete a Service Fabric managed service resource with the specified
        /// name.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster resource.
        /// </param>
        /// <param name='applicationName'>
        /// The name of the application resource.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource in the format of
        /// {applicationName}~{serviceName}.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string applicationName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of service resources created in the specified Service
        /// Fabric managed application resource.
        /// </summary>
        /// <remarks>
        /// Gets all service resources created or in the process of being
        /// created in the Service Fabric managed application resource.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ServiceResource>>> ListByApplicationsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
