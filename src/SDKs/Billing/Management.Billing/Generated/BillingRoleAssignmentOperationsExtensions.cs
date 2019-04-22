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
    /// Extension methods for BillingRoleAssignmentOperations.
    /// </summary>
    public static partial class BillingRoleAssignmentOperationsExtensions
    {
            /// <summary>
            /// Get the role assignment for the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment GetByBillingAccount(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingRoleAssignmentName)
            {
                return operations.GetByBillingAccountAsync(billingAccountName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignment for the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> GetByBillingAccountAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingAccountWithHttpMessagesAsync(billingAccountName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the role assignment on this billing account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment DeleteByBillingAccountName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingRoleAssignmentName)
            {
                return operations.DeleteByBillingAccountNameAsync(billingAccountName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the role assignment on this billing account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> DeleteByBillingAccountNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByBillingAccountNameWithHttpMessagesAsync(billingAccountName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the role assignment for the caller on the invoice Section
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment GetByInvoiceSectionName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName)
            {
                return operations.GetByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignment for the caller on the invoice Section
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> GetByInvoiceSectionNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the role assignment on the invoice Section
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment DeleteByInvoiceSectionName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName)
            {
                return operations.DeleteByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the role assignment on the invoice Section
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> DeleteByInvoiceSectionNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the role assignment for the caller on the Billing Profile
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment GetByBillingProfileName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName, string billingRoleAssignmentName)
            {
                return operations.GetByBillingProfileNameAsync(billingAccountName, billingProfileName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignment for the caller on the Billing Profile
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> GetByBillingProfileNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the role assignment on this Billing Profile
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment DeleteByBillingProfileName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName, string billingRoleAssignmentName)
            {
                return operations.DeleteByBillingProfileNameAsync(billingAccountName, billingProfileName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the role assignment on this Billing Profile
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
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> DeleteByBillingProfileNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the role assignments on the Billing Account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            public static BillingRoleAssignmentListResult ListByBillingAccountName(this IBillingRoleAssignmentOperations operations, string billingAccountName)
            {
                return operations.ListByBillingAccountNameAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignments on the Billing Account
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
            public static async Task<BillingRoleAssignmentListResult> ListByBillingAccountNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNameWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to add a role assignment to a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            public static BillingRoleAssignmentListResult AddByBillingAccountName(this IBillingRoleAssignmentOperations operations, string billingAccountName)
            {
                return operations.AddByBillingAccountNameAsync(billingAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to add a role assignment to a billing account.
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
            public static async Task<BillingRoleAssignmentListResult> AddByBillingAccountNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddByBillingAccountNameWithHttpMessagesAsync(billingAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the role assignments on the invoice Section
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
            public static BillingRoleAssignmentListResult ListByInvoiceSectionName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.ListByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignments on the invoice Section
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
            public static async Task<BillingRoleAssignmentListResult> ListByInvoiceSectionNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to add a role assignment to a invoice Section.
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
            public static BillingRoleAssignmentListResult AddByInvoiceSectionName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.AddByInvoiceSectionNameAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to add a role assignment to a invoice Section.
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
            public static async Task<BillingRoleAssignmentListResult> AddByInvoiceSectionNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddByInvoiceSectionNameWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the role assignments on the Billing Profile
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
            public static BillingRoleAssignmentListResult ListByBillingProfileName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.ListByBillingProfileNameAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignments on the Billing Profile
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
            public static async Task<BillingRoleAssignmentListResult> ListByBillingProfileNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to add a role assignment to a billing profile.
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
            public static BillingRoleAssignmentListResult AddByBillingProfileName(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName)
            {
                return operations.AddByBillingProfileNameAsync(billingAccountName, billingProfileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to add a role assignment to a billing profile.
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
            public static async Task<BillingRoleAssignmentListResult> AddByBillingProfileNameAsync(this IBillingRoleAssignmentOperations operations, string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddByBillingProfileNameWithHttpMessagesAsync(billingAccountName, billingProfileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
