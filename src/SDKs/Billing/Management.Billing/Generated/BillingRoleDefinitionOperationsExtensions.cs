// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingRoleDefinitionOperations.
    /// </summary>
    public static partial class BillingRoleDefinitionOperationsExtensions
    {
            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            public static BillingRoleDefinition GetByBillingAccountName(this IBillingRoleDefinitionOperations operations, string billingAccountName, string billingRoleDefinitionName)
            {
                return operations.GetByBillingAccountNameAsync(billingAccountName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetByBillingAccountNameAsync(this IBillingRoleDefinitionOperations operations, string billingAccountName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingAccountNameWithHttpMessagesAsync(billingAccountName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            public static BillingRoleDefinition GetByInvoiceSectionName(this IBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleDefinitionName)
            {
                return operations.GetByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetByInvoiceSectionNameAsync(this IBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            public static BillingRoleDefinition GetByBillingProfileName(this IBillingRoleDefinitionOperations operations, string billingAccountName, string billingProfileName, string billingRoleDefinitionName)
            {
                return operations.GetByBillingProfileNameAsync(billingAccountName, billingProfileName, billingRoleDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the role definition for a role
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='billingRoleDefinitionName'>
            /// role definition id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinition> GetByBillingProfileNameAsync(this IBillingRoleDefinitionOperations operations, string billingAccountName, string billingProfileName, string billingRoleDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, billingRoleDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definition for a billing account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            public static BillingRoleDefinitionListResult ListByBillingAccountName(this IBillingRoleDefinitionOperations operations, string billingAccountName)
            {
                return operations.ListByBillingAccountNameAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definition for a billing account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinitionListResult> ListByBillingAccountNameAsync(this IBillingRoleDefinitionOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNameWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definition for an invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static BillingRoleDefinitionListResult ListByInvoiceSectionName(this IBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.ListByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definition for an invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinitionListResult> ListByInvoiceSectionNameAsync(this IBillingRoleDefinitionOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the role definition for a Billing Profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            public static BillingRoleDefinitionListResult ListByBillingProfileName(this IBillingRoleDefinitionOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileNameAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the role definition for a Billing Profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleDefinitionListResult> ListByBillingProfileNameAsync(this IBillingRoleDefinitionOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
