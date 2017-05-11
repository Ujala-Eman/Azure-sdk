// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ReplicationFabricsOperations operations.
    /// </summary>
    public partial interface IReplicationFabricsOperations
    {
        /// <summary>
        /// Renews certificate for the fabric.
        /// </summary>
        /// Renews the connection certificate for the ASR replication fabric.
        /// <param name='fabricName'>
        /// fabric name to renew certs for.
        /// </param>
        /// <param name='renewCertificate'>
        /// Renew certificate input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> RenewCertificateWithHttpMessagesAsync(string fabricName, RenewCertificateInput renewCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Renews certificate for the fabric.
        /// </summary>
        /// Renews the connection certificate for the ASR replication fabric.
        /// <param name='fabricName'>
        /// fabric name to renew certs for.
        /// </param>
        /// <param name='renewCertificate'>
        /// Renew certificate input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginRenewCertificateWithHttpMessagesAsync(string fabricName, RenewCertificateInput renewCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Tracks the Site async operation.
        /// </summary>
        /// Track the results of an asynchronous operation on the fabric
        /// <param name='fabricName'>
        /// Site name to work on.
        /// </param>
        /// <param name='jobName'>
        /// job id to track.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> GetOperationResultsWithHttpMessagesAsync(string fabricName, string jobName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Perform failover of the process server.
        /// </summary>
        /// The operation to move replications from a process server to
        /// another process server.
        /// <param name='fabricName'>
        /// The name of the fabric containing the process server.
        /// </param>
        /// <param name='failoverProcessServerRequest'>
        /// The input to the failover process
        /// server operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> ReassociateGatewayWithHttpMessagesAsync(string fabricName, FailoverProcessServerRequest failoverProcessServerRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Perform failover of the process server.
        /// </summary>
        /// The operation to move replications from a process server to
        /// another process server.
        /// <param name='fabricName'>
        /// The name of the fabric containing the process server.
        /// </param>
        /// <param name='failoverProcessServerRequest'>
        /// The input to the failover process
        /// server operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginReassociateGatewayWithHttpMessagesAsync(string fabricName, FailoverProcessServerRequest failoverProcessServerRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks the consistency of the ASR fabric.
        /// </summary>
        /// The operation to perform a consistency check on the fabric.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> CheckConsistencyWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks the consistency of the ASR fabric.
        /// </summary>
        /// The operation to perform a consistency check on the fabric.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginCheckConsistencyWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the site.
        /// </summary>
        /// The operation to delete or remove an Azure Site Recovery fabric.
        /// <param name='fabricName'>
        /// ASR fabric to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the site.
        /// </summary>
        /// The operation to delete or remove an Azure Site Recovery fabric.
        /// <param name='fabricName'>
        /// ASR fabric to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of an ASR fabric.
        /// </summary>
        /// Gets the details of an Azure Site Recovery fabric.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> GetWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an Azure Site Recoery fabric.
        /// </summary>
        /// The operation to create an Azure Site Recovery fabric (for e.g.
        /// Hyper-V site)
        /// <param name='fabricName'>
        /// Name of the ASR fabric.
        /// </param>
        /// <param name='input'>
        /// Fabric creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> CreateWithHttpMessagesAsync(string fabricName, FabricCreationInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an Azure Site Recoery fabric.
        /// </summary>
        /// The operation to create an Azure Site Recovery fabric (for e.g.
        /// Hyper-V site)
        /// <param name='fabricName'>
        /// Name of the ASR fabric.
        /// </param>
        /// <param name='input'>
        /// Fabric creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Fabric>> BeginCreateWithHttpMessagesAsync(string fabricName, FabricCreationInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges the site.
        /// </summary>
        /// The operation to purge(force delete) an Azure Site Recovery fabric.
        /// <param name='fabricName'>
        /// ASR fabric to purge.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PurgeWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purges the site.
        /// </summary>
        /// The operation to purge(force delete) an Azure Site Recovery fabric.
        /// <param name='fabricName'>
        /// ASR fabric to purge.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPurgeWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of ASR fabrics
        /// </summary>
        /// Gets a list of the Azure Site Recovery fabrics in the vault.
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Fabric>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of ASR fabrics
        /// </summary>
        /// Gets a list of the Azure Site Recovery fabrics in the vault.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Fabric>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
