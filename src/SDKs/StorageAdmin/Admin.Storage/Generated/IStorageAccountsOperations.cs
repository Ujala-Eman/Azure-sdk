// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StorageAccountsOperations operations.
    /// </summary>
    public partial interface IStorageAccountsOperations
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='farmId'>
        /// Th name of the farm.
        /// </param>
        /// <param name='accountId'>
        /// The name of the storage account.
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
        Task<AzureOperationResponse> UndeleteWithHttpMessagesAsync(string resourceGroupName, string farmId, string accountId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='tenantId'>
        /// The tenant id.
        /// </param>
        /// <param name='farmId'>
        /// Th name of the farm.
        /// </param>
        /// <param name='accountId'>
        /// The name of the storage account.
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
        Task<AzureOperationResponse<StorageAccountSyncResult>> SynchronizeAllWithHttpMessagesAsync(string tenantId, string farmId, string accountId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='tenantSubscriptionId'>
        /// The tenant subscription id.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
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
        Task<AzureOperationResponse<StorageAccountSyncResult>> SynchronizeWithHttpMessagesAsync(string tenantSubscriptionId, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='farmId'>
        /// Th name of the farm.
        /// </param>
        /// <param name='filter'>
        /// TODO
        /// </param>
        /// <param name='summary'>
        /// TODO
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
        Task<AzureOperationResponse<IList<StorageAccountModel>>> ListWithHttpMessagesAsync(string resourceGroupName, string farmId, string filter, bool summary, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a specific storage account
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='farmId'>
        /// Th name of the farm.
        /// </param>
        /// <param name='accountId'>
        /// The name of the storage account.
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
        Task<AzureOperationResponse<StorageAccountModel>> GetWithHttpMessagesAsync(string resourceGroupName, string farmId, string accountId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
