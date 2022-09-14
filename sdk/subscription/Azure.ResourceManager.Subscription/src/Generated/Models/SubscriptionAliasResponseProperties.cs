// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Put subscription creation result properties. </summary>
    public partial class SubscriptionAliasResponseProperties
    {
        /// <summary> Initializes a new instance of SubscriptionAliasResponseProperties. </summary>
        internal SubscriptionAliasResponseProperties()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SubscriptionAliasResponseProperties. </summary>
        /// <param name="subscriptionId"> Newly created subscription Id. </param>
        /// <param name="displayName"> The display name of the subscription. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="acceptOwnershipUri"> Url to accept ownership of the subscription. </param>
        /// <param name="acceptOwnershipState"> The accept ownership state of the resource. </param>
        /// <param name="billingScope">
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </param>
        /// <param name="workload"> The workload type of the subscription. It can be either Production or DevTest. </param>
        /// <param name="resellerId"> Reseller Id. </param>
        /// <param name="subscriptionOwnerId"> Owner Id of the subscription. </param>
        /// <param name="managementGroupId"> The Management Group Id. </param>
        /// <param name="createdTime"> Created Time. </param>
        /// <param name="tags"> Tags for the subscription. </param>
        internal SubscriptionAliasResponseProperties(string subscriptionId, string displayName, ProvisioningState? provisioningState, Uri acceptOwnershipUri, AcceptOwnership? acceptOwnershipState, string billingScope, Workload? workload, string resellerId, string subscriptionOwnerId, string managementGroupId, string createdTime, IReadOnlyDictionary<string, string> tags)
        {
            SubscriptionId = subscriptionId;
            DisplayName = displayName;
            ProvisioningState = provisioningState;
            AcceptOwnershipUri = acceptOwnershipUri;
            AcceptOwnershipState = acceptOwnershipState;
            BillingScope = billingScope;
            Workload = workload;
            ResellerId = resellerId;
            SubscriptionOwnerId = subscriptionOwnerId;
            ManagementGroupId = managementGroupId;
            CreatedTime = createdTime;
            Tags = tags;
        }

        /// <summary> Newly created subscription Id. </summary>
        public string SubscriptionId { get; }
        /// <summary> The display name of the subscription. </summary>
        public string DisplayName { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Url to accept ownership of the subscription. </summary>
        public Uri AcceptOwnershipUri { get; }
        /// <summary> The accept ownership state of the resource. </summary>
        public AcceptOwnership? AcceptOwnershipState { get; }
        /// <summary>
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </summary>
        public string BillingScope { get; }
        /// <summary> The workload type of the subscription. It can be either Production or DevTest. </summary>
        public Workload? Workload { get; }
        /// <summary> Reseller Id. </summary>
        public string ResellerId { get; }
        /// <summary> Owner Id of the subscription. </summary>
        public string SubscriptionOwnerId { get; }
        /// <summary> The Management Group Id. </summary>
        public string ManagementGroupId { get; }
        /// <summary> Created Time. </summary>
        public string CreatedTime { get; }
        /// <summary> Tags for the subscription. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
