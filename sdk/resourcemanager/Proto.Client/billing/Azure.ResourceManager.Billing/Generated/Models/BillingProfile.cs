// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> A billing profile. </summary>
    public partial class BillingProfile : Resource
    {
        /// <summary> Initializes a new instance of BillingProfile. </summary>
        public BillingProfile()
        {
            EnabledAzurePlans = new ChangeTrackingList<AzurePlan>();
            TargetClouds = new ChangeTrackingList<TargetCloud>();
        }

        /// <summary> Initializes a new instance of BillingProfile. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="displayName"> The name of the billing profile. </param>
        /// <param name="poNumber"> The purchase order name that will appear on the invoices generated for the billing profile. </param>
        /// <param name="billingRelationshipType"> Identifies which services and purchases are paid by a billing profile. </param>
        /// <param name="billTo"> Billing address. </param>
        /// <param name="indirectRelationshipInfo"> Identifies the billing profile that is linked to another billing profile in indirect purchase motion. </param>
        /// <param name="invoiceEmailOptIn"> Flag controlling whether the invoices for the billing profile are sent through email. </param>
        /// <param name="invoiceDay"> The day of the month when the invoice for the billing profile is generated. </param>
        /// <param name="currency"> The currency in which the charges for the billing profile are billed. </param>
        /// <param name="enabledAzurePlans"> Information about the enabled azure plans. </param>
        /// <param name="invoiceSections"> The invoice sections associated to the billing profile. By default this is not populated, unless it&apos;s specified in $expand. </param>
        /// <param name="hasReadAccess"> Indicates whether user has read access to the billing profile. </param>
        /// <param name="systemId"> The system generated unique identifier for a billing profile. </param>
        /// <param name="status"> The status of the billing profile. </param>
        /// <param name="statusReasonCode"> Reason for the specified billing profile status. </param>
        /// <param name="spendingLimit"> The billing profile spending limit. </param>
        /// <param name="targetClouds"> Identifies the cloud environments that are associated with a billing profile. This is a system managed optional field and gets updated as the billing profile gets associated with accounts in various clouds. </param>
        internal BillingProfile(string id, string name, string type, string displayName, string poNumber, BillingRelationshipType? billingRelationshipType, AddressDetails billTo, IndirectRelationshipInfo indirectRelationshipInfo, bool? invoiceEmailOptIn, int? invoiceDay, string currency, IList<AzurePlan> enabledAzurePlans, InvoiceSectionsOnExpand invoiceSections, bool? hasReadAccess, string systemId, BillingProfileStatus? status, StatusReasonCode? statusReasonCode, SpendingLimit? spendingLimit, IReadOnlyList<TargetCloud> targetClouds) : base(id, name, type)
        {
            DisplayName = displayName;
            PoNumber = poNumber;
            BillingRelationshipType = billingRelationshipType;
            BillTo = billTo;
            IndirectRelationshipInfo = indirectRelationshipInfo;
            InvoiceEmailOptIn = invoiceEmailOptIn;
            InvoiceDay = invoiceDay;
            Currency = currency;
            EnabledAzurePlans = enabledAzurePlans;
            InvoiceSections = invoiceSections;
            HasReadAccess = hasReadAccess;
            SystemId = systemId;
            Status = status;
            StatusReasonCode = statusReasonCode;
            SpendingLimit = spendingLimit;
            TargetClouds = targetClouds;
        }

        /// <summary> The name of the billing profile. </summary>
        public string DisplayName { get; set; }
        /// <summary> The purchase order name that will appear on the invoices generated for the billing profile. </summary>
        public string PoNumber { get; set; }
        /// <summary> Identifies which services and purchases are paid by a billing profile. </summary>
        public BillingRelationshipType? BillingRelationshipType { get; }
        /// <summary> Billing address. </summary>
        public AddressDetails BillTo { get; set; }
        /// <summary> Identifies the billing profile that is linked to another billing profile in indirect purchase motion. </summary>
        public IndirectRelationshipInfo IndirectRelationshipInfo { get; }
        /// <summary> Flag controlling whether the invoices for the billing profile are sent through email. </summary>
        public bool? InvoiceEmailOptIn { get; set; }
        /// <summary> The day of the month when the invoice for the billing profile is generated. </summary>
        public int? InvoiceDay { get; }
        /// <summary> The currency in which the charges for the billing profile are billed. </summary>
        public string Currency { get; }
        /// <summary> Information about the enabled azure plans. </summary>
        public IList<AzurePlan> EnabledAzurePlans { get; }
        /// <summary> The invoice sections associated to the billing profile. By default this is not populated, unless it&apos;s specified in $expand. </summary>
        public InvoiceSectionsOnExpand InvoiceSections { get; set; }
        /// <summary> Indicates whether user has read access to the billing profile. </summary>
        public bool? HasReadAccess { get; }
        /// <summary> The system generated unique identifier for a billing profile. </summary>
        public string SystemId { get; }
        /// <summary> The status of the billing profile. </summary>
        public BillingProfileStatus? Status { get; }
        /// <summary> Reason for the specified billing profile status. </summary>
        public StatusReasonCode? StatusReasonCode { get; }
        /// <summary> The billing profile spending limit. </summary>
        public SpendingLimit? SpendingLimit { get; }
        /// <summary> Identifies the cloud environments that are associated with a billing profile. This is a system managed optional field and gets updated as the billing profile gets associated with accounts in various clouds. </summary>
        public IReadOnlyList<TargetCloud> TargetClouds { get; }
    }
}
