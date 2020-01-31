// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotaRequestOperations.
    /// </summary>
    public static partial class QuotaRequestOperationsExtensions
    {
            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object Create(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch)
            {
                return operations.CreateAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateAsync(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object Update(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch)
            {
                return operations.UpdateAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateAsync(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object BeginCreate(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch)
            {
                return operations.BeginCreateAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> BeginCreateAsync(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object BeginUpdate(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch)
            {
                return operations.BeginUpdateAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a Quota Request for a resource provider at the specified location
            /// for the specific resource in the parameter.
            /// </summary>
            /// <remarks>
            /// Submits Quota change request for a resource provider for the specified
            /// location for the specific resource in the parameter. To use, first make a
            /// Get request to get quota information. This information consists of a list
            /// of resources and information regarding those resources. For all the
            /// resources in that list which require an update to their quotas, update
            /// their limit fields in the response from the Get request to their new
            /// values. Then, submit this updated JSON object to this quota request API.
            /// This will update the quota to the values specified. The location header in
            /// the response will be used to track the status of the quota request. Please
            /// check the provisioningState field in the response.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='resourceName'>
            /// The Resource name for the specific resource provider, such as SKU name for
            /// Microsoft.Compute, pool for Microsoft.Batch.
            /// </param>
            /// <param name='createQuotaRequest'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> BeginUpdateAsync(this IQuotaRequestOperations operations, string subscriptionId, string providerId, string location, string resourceName, CurrentQuotaLimitBase createQuotaRequest, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(subscriptionId, providerId, location, resourceName, createQuotaRequest, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
