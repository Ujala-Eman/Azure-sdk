// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MarketplaceOrdering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    // Simple Test 5

    /// <summary>
    /// MarketplaceAgreementsOperations operations.
    /// </summary>
    public partial interface IMarketplaceAgreementsOperations
    {
        /// <summary>
        /// Get marketplace terms.
        /// </summary>
        /// <param name='publisherId'>
        /// Publisher identifier string of image being deployed.
        /// </param>
        /// <param name='offerId'>
        /// Offer identifier string of image being deployed.
        /// </param>
        /// <param name='planId'>
        /// Plan identifier string of image being deployed.
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
        Task<AzureOperationResponse<AgreementTerms>> GetWithHttpMessagesAsync(string publisherId, string offerId, string planId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Save marketplace terms.
        /// </summary>
        /// <param name='publisherId'>
        /// Publisher identifier string of image being deployed.
        /// </param>
        /// <param name='offerId'>
        /// Offer identifier string of image being deployed.
        /// </param>
        /// <param name='planId'>
        /// Plan identifier string of image being deployed.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Marketplace Terms operation.
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
        Task<AzureOperationResponse<AgreementTerms>> CreateWithHttpMessagesAsync(string publisherId, string offerId, string planId, AgreementTerms parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sign marketplace terms.
        /// </summary>
        /// <param name='publisherId'>
        /// Publisher identifier string of image being deployed.
        /// </param>
        /// <param name='offerId'>
        /// Offer identifier string of image being deployed.
        /// </param>
        /// <param name='planId'>
        /// Plan identifier string of image being deployed.
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
        Task<AzureOperationResponse<AgreementTerms>> SignWithHttpMessagesAsync(string publisherId, string offerId, string planId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancel marketplace terms.
        /// </summary>
        /// <param name='publisherId'>
        /// Publisher identifier string of image being deployed.
        /// </param>
        /// <param name='offerId'>
        /// Offer identifier string of image being deployed.
        /// </param>
        /// <param name='planId'>
        /// Plan identifier string of image being deployed.
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
        Task<AzureOperationResponse<AgreementTerms>> CancelWithHttpMessagesAsync(string publisherId, string offerId, string planId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get marketplace agreement.
        /// </summary>
        /// <param name='publisherId'>
        /// Publisher identifier string of image being deployed.
        /// </param>
        /// <param name='offerId'>
        /// Offer identifier string of image being deployed.
        /// </param>
        /// <param name='planId'>
        /// Plan identifier string of image being deployed.
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
        Task<AzureOperationResponse<AgreementTerms>> GetAgreementWithHttpMessagesAsync(string publisherId, string offerId, string planId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List marketplace agreements in the subscription.
        /// </summary>
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
        Task<AzureOperationResponse<IList<AgreementTerms>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
