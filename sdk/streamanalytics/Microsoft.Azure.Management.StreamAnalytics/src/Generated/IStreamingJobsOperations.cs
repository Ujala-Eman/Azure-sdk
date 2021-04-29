// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StreamingJobsOperations operations.
    /// </summary>
    public partial interface IStreamingJobsOperations
    {
        /// <summary>
        /// Creates a streaming job or replaces an already existing streaming
        /// job.
        /// </summary>
        /// <param name='streamingJob'>
        /// The definition of the streaming job that will be used to create a
        /// new streaming job or replace the existing one.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the streaming job. Omit this value to always overwrite
        /// the current record set. Specify the last-seen ETag value to prevent
        /// accidentally overwriting concurrent changes.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Set to '*' to allow a new streaming job to be created, but to
        /// prevent updating an existing record set. Other values will result
        /// in a 412 Pre-condition Failed response.
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
        Task<AzureOperationResponse<StreamingJob,StreamingJobsCreateOrReplaceHeaders>> CreateOrReplaceWithHttpMessagesAsync(StreamingJob streamingJob, string resourceGroupName, string jobName, string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing streaming job. This can be used to partially
        /// update (ie. update one or two properties) a streaming job without
        /// affecting the rest the job definition.
        /// </summary>
        /// <param name='streamingJob'>
        /// A streaming job object. The properties specified here will
        /// overwrite the corresponding properties in the existing streaming
        /// job (ie. Those properties will be updated). Any properties that are
        /// set to null here will mean that the corresponding property in the
        /// existing input will remain the same and not change as a result of
        /// this PATCH operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the streaming job. Omit this value to always overwrite
        /// the current record set. Specify the last-seen ETag value to prevent
        /// accidentally overwriting concurrent changes.
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
        Task<AzureOperationResponse<StreamingJob,StreamingJobsUpdateHeaders>> UpdateWithHttpMessagesAsync(StreamingJob streamingJob, string resourceGroupName, string jobName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a streaming job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets details about the specified streaming job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='expand'>
        /// The $expand OData query parameter. This is a comma-separated list
        /// of additional streaming job properties to include in the response,
        /// beyond the default set returned when this parameter is absent. The
        /// default set is all streaming job properties other than 'inputs',
        /// 'transformation', 'outputs', and 'functions'.
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
        Task<AzureOperationResponse<StreamingJob,StreamingJobsGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string jobName, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the streaming jobs in the specified resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='expand'>
        /// The $expand OData query parameter. This is a comma-separated list
        /// of additional streaming job properties to include in the response,
        /// beyond the default set returned when this parameter is absent. The
        /// default set is all streaming job properties other than 'inputs',
        /// 'transformation', 'outputs', and 'functions'.
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
        Task<AzureOperationResponse<IPage<StreamingJob>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the streaming jobs in the given subscription.
        /// </summary>
        /// <param name='expand'>
        /// The $expand OData query parameter. This is a comma-separated list
        /// of additional streaming job properties to include in the response,
        /// beyond the default set returned when this parameter is absent. The
        /// default set is all streaming job properties other than 'inputs',
        /// 'transformation', 'outputs', and 'functions'.
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
        Task<AzureOperationResponse<IPage<StreamingJob>>> ListWithHttpMessagesAsync(string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Starts a streaming job. Once a job is started it will start
        /// processing input events and produce output.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='startJobParameters'>
        /// Parameters applicable to a start streaming job operation.
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
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string jobName, StartStreamingJobParameters startJobParameters = default(StartStreamingJobParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stops a running streaming job. This will cause a running streaming
        /// job to stop processing input events and producing output.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
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
        Task<AzureOperationResponse> StopWithHttpMessagesAsync(string resourceGroupName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a streaming job or replaces an already existing streaming
        /// job.
        /// </summary>
        /// <param name='streamingJob'>
        /// The definition of the streaming job that will be used to create a
        /// new streaming job or replace the existing one.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='ifMatch'>
        /// The ETag of the streaming job. Omit this value to always overwrite
        /// the current record set. Specify the last-seen ETag value to prevent
        /// accidentally overwriting concurrent changes.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Set to '*' to allow a new streaming job to be created, but to
        /// prevent updating an existing record set. Other values will result
        /// in a 412 Pre-condition Failed response.
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
        Task<AzureOperationResponse<StreamingJob,StreamingJobsCreateOrReplaceHeaders>> BeginCreateOrReplaceWithHttpMessagesAsync(StreamingJob streamingJob, string resourceGroupName, string jobName, string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a streaming job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Starts a streaming job. Once a job is started it will start
        /// processing input events and produce output.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
        /// </param>
        /// <param name='startJobParameters'>
        /// Parameters applicable to a start streaming job operation.
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
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string jobName, StartStreamingJobParameters startJobParameters = default(StartStreamingJobParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stops a running streaming job. This will cause a running streaming
        /// job to stop processing input events and producing output.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='jobName'>
        /// The name of the streaming job.
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
        Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string resourceGroupName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the streaming jobs in the specified resource group.
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
        Task<AzureOperationResponse<IPage<StreamingJob>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the streaming jobs in the given subscription.
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
        Task<AzureOperationResponse<IPage<StreamingJob>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
