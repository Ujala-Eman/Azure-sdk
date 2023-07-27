// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing the ScheduledAction data model.
    /// Scheduled action definition.
    /// </summary>
    public partial class ScheduledActionData : ResourceData
    {
        /// <summary> Initializes a new instance of ScheduledActionData. </summary>
        public ScheduledActionData()
        {
        }

        /// <summary> Initializes a new instance of ScheduledActionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Scheduled action name. </param>
        /// <param name="fileDestination"> Destination format of the view data. This is optional. </param>
        /// <param name="notification"> Notification properties based on scheduled action kind. </param>
        /// <param name="notificationEmail"> Email address of the point of contact that should get the unsubscribe requests and notification emails. </param>
        /// <param name="schedule"> Schedule of the scheduled action. </param>
        /// <param name="scope"> For private scheduled action(Create or Update), scope will be empty.&lt;br /&gt; For shared scheduled action(Create or Update By Scope), Cost Management scope can be 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope. </param>
        /// <param name="status"> Status of the scheduled action. </param>
        /// <param name="viewId"> Cost analysis viewId used for scheduled action. For example, '/providers/Microsoft.CostManagement/views/swaggerExample'. </param>
        /// <param name="eTag"> Resource Etag. For update calls, eTag is optional and can be specified to achieve optimistic concurrency. Fetch the resource's eTag by doing a 'GET' call first and then including the latest eTag as part of the request body or 'If-Match' header while performing the update. For create calls, eTag is not required. </param>
        /// <param name="kind"> Kind of the scheduled action. </param>
        internal ScheduledActionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, FileDestination fileDestination, NotificationProperties notification, string notificationEmail, ScheduleProperties schedule, ResourceIdentifier scope, ScheduledActionStatus? status, ResourceIdentifier viewId, ETag? eTag, ScheduledActionKind? kind) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            FileDestination = fileDestination;
            Notification = notification;
            NotificationEmail = notificationEmail;
            Schedule = schedule;
            Scope = scope;
            Status = status;
            ViewId = viewId;
            ETag = eTag;
            Kind = kind;
        }

        /// <summary> Scheduled action name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Destination format of the view data. This is optional. </summary>
        internal FileDestination FileDestination { get; set; }
        /// <summary> Destination of the view data. Currently only CSV format is supported. </summary>
        public IList<ScheduledActionFileFormat> FileFormats
        {
            get
            {
                if (FileDestination is null)
                    FileDestination = new FileDestination();
                return FileDestination.FileFormats;
            }
        }

        /// <summary> Notification properties based on scheduled action kind. </summary>
        public NotificationProperties Notification { get; set; }
        /// <summary> Email address of the point of contact that should get the unsubscribe requests and notification emails. </summary>
        public string NotificationEmail { get; set; }
        /// <summary> Schedule of the scheduled action. </summary>
        public ScheduleProperties Schedule { get; set; }
        /// <summary> For private scheduled action(Create or Update), scope will be empty.&lt;br /&gt; For shared scheduled action(Create or Update By Scope), Cost Management scope can be 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope. </summary>
        public ResourceIdentifier Scope { get; set; }
        /// <summary> Status of the scheduled action. </summary>
        public ScheduledActionStatus? Status { get; set; }
        /// <summary> Cost analysis viewId used for scheduled action. For example, '/providers/Microsoft.CostManagement/views/swaggerExample'. </summary>
        public ResourceIdentifier ViewId { get; set; }
        /// <summary> Resource Etag. For update calls, eTag is optional and can be specified to achieve optimistic concurrency. Fetch the resource's eTag by doing a 'GET' call first and then including the latest eTag as part of the request body or 'If-Match' header while performing the update. For create calls, eTag is not required. </summary>
        public ETag? ETag { get; }
        /// <summary> Kind of the scheduled action. </summary>
        public ScheduledActionKind? Kind { get; set; }
    }
}
