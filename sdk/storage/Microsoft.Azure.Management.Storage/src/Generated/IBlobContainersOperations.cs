// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BlobContainersOperations operations.
    /// </summary>
    public partial interface IBlobContainersOperations
    {
        /// <summary>
        /// Lists all containers and does not support a prefix like data plane.
        /// Also SRP today does not return continuation token.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='maxpagesize'>
        /// Optional. Specified maximum number of containers that can be
        /// included in the list.
        /// </param>
        /// <param name='filter'>
        /// Optional. When specified, only container names starting with the
        /// filter will be listed.
        /// </param>
        /// <param name='include'>
        /// Optional, used to include the properties for soft deleted blob
        /// containers. Possible values include: 'deleted'
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
        Task<AzureOperationResponse<IPage<ListContainerItem>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, string maxpagesize = default(string), string filter = default(string), string include = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new container under the specified account as described by
        /// request body. The container resource includes metadata and
        /// properties for that container. It does not include a list of the
        /// blobs contained by the container.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='blobContainer'>
        /// Properties of the blob container to create.
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
        Task<AzureOperationResponse<BlobContainer>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, BlobContainer blobContainer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates container properties as specified in request body.
        /// Properties not mentioned in the request will be unchanged. Update
        /// fails if the specified container doesn't already exist.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='blobContainer'>
        /// Properties to update for the blob container.
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
        Task<AzureOperationResponse<BlobContainer>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, BlobContainer blobContainer, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets properties of a specified container.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
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
        Task<AzureOperationResponse<BlobContainer>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes specified container under its account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets legal hold tags. Setting the same tag results in an idempotent
        /// operation. SetLegalHold follows an append pattern and does not
        /// clear out the existing tags that are not specified in the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='tags'>
        /// Each tag should be 3 to 23 alphanumeric characters and is
        /// normalized to lower case at SRP.
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
        Task<AzureOperationResponse<LegalHold>> SetLegalHoldWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, IList<string> tags, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Clears legal hold tags. Clearing the same or non-existent tag
        /// results in an idempotent operation. ClearLegalHold clears out only
        /// the specified tags in the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='tags'>
        /// Each tag should be 3 to 23 alphanumeric characters and is
        /// normalized to lower case at SRP.
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
        Task<AzureOperationResponse<LegalHold>> ClearLegalHoldWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, IList<string> tags, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an unlocked immutability policy. ETag in
        /// If-Match is honored if given but not required for this operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='immutabilityPeriodSinceCreationInDays'>
        /// The immutability period for the blobs in the container since the
        /// policy creation, in days.
        /// </param>
        /// <param name='allowProtectedAppendWrites'>
        /// This property can only be changed for unlocked time-based retention
        /// policies. When enabled, new blocks can be written to an append blob
        /// while maintaining immutability protection and compliance. Only new
        /// blocks can be added and any existing blocks cannot be modified or
        /// deleted. This property cannot be changed with
        /// ExtendImmutabilityPolicy API
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
        Task<AzureOperationResponse<ImmutabilityPolicy,BlobContainersCreateOrUpdateImmutabilityPolicyHeaders>> CreateOrUpdateImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch = default(string), int? immutabilityPeriodSinceCreationInDays = default(int?), bool? allowProtectedAppendWrites = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the existing immutability policy along with the corresponding
        /// ETag in response headers and body.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
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
        Task<AzureOperationResponse<ImmutabilityPolicy,BlobContainersGetImmutabilityPolicyHeaders>> GetImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Aborts an unlocked immutability policy. The response of delete has
        /// immutabilityPeriodSinceCreationInDays set to 0. ETag in If-Match is
        /// required for this operation. Deleting a locked immutability policy
        /// is not allowed, only way is to delete the container after deleting
        /// all blobs inside the container.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
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
        Task<AzureOperationResponse<ImmutabilityPolicy,BlobContainersDeleteImmutabilityPolicyHeaders>> DeleteImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets the ImmutabilityPolicy to Locked state. The only action
        /// allowed on a Locked policy is ExtendImmutabilityPolicy action. ETag
        /// in If-Match is required for this operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
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
        Task<AzureOperationResponse<ImmutabilityPolicy,BlobContainersLockImmutabilityPolicyHeaders>> LockImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Extends the immutabilityPeriodSinceCreationInDays of a locked
        /// immutabilityPolicy. The only action allowed on a Locked policy will
        /// be this action. ETag in If-Match is required for this operation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='ifMatch'>
        /// The entity state (ETag) version of the immutability policy to
        /// update. A value of "*" can be used to apply the operation only if
        /// the immutability policy already exists. If omitted, this operation
        /// will always be applied.
        /// </param>
        /// <param name='immutabilityPeriodSinceCreationInDays'>
        /// The immutability period for the blobs in the container since the
        /// policy creation, in days.
        /// </param>
        /// <param name='allowProtectedAppendWrites'>
        /// This property can only be changed for unlocked time-based retention
        /// policies. When enabled, new blocks can be written to an append blob
        /// while maintaining immutability protection and compliance. Only new
        /// blocks can be added and any existing blocks cannot be modified or
        /// deleted. This property cannot be changed with
        /// ExtendImmutabilityPolicy API
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
        Task<AzureOperationResponse<ImmutabilityPolicy,BlobContainersExtendImmutabilityPolicyHeaders>> ExtendImmutabilityPolicyWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, string ifMatch, int? immutabilityPeriodSinceCreationInDays = default(int?), bool? allowProtectedAppendWrites = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Lease Container operation establishes and manages a lock on a
        /// container for delete operations. The lock duration can be 15 to 60
        /// seconds, or can be infinite.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='containerName'>
        /// The name of the blob container within the specified storage
        /// account. Blob container names must be between 3 and 63 characters
        /// in length and use numbers, lower-case letters and dash (-) only.
        /// Every dash (-) character must be immediately preceded and followed
        /// by a letter or number.
        /// </param>
        /// <param name='parameters'>
        /// Lease Container request body.
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
        Task<AzureOperationResponse<LeaseContainerResponse>> LeaseWithHttpMessagesAsync(string resourceGroupName, string accountName, string containerName, LeaseContainerRequest parameters = default(LeaseContainerRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all containers and does not support a prefix like data plane.
        /// Also SRP today does not return continuation token.
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
        Task<AzureOperationResponse<IPage<ListContainerItem>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
