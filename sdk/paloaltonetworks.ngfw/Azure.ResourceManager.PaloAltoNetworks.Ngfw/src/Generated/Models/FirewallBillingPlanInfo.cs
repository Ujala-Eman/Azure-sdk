// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Billing plan information. </summary>
    public partial class FirewallBillingPlanInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirewallBillingPlanInfo"/>. </summary>
        /// <param name="billingCycle"> different billing cycles like MONTHLY/WEEKLY. </param>
        /// <param name="planId"> plan id as published by Liftr.PAN. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="planId"/> is null. </exception>
        public FirewallBillingPlanInfo(FirewallBillingCycle billingCycle, string planId)
        {
            Argument.AssertNotNull(planId, nameof(planId));

            BillingCycle = billingCycle;
            PlanId = planId;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallBillingPlanInfo"/>. </summary>
        /// <param name="usageType"> different usage type like PAYG/COMMITTED. </param>
        /// <param name="billingCycle"> different billing cycles like MONTHLY/WEEKLY. </param>
        /// <param name="planId"> plan id as published by Liftr.PAN. </param>
        /// <param name="effectiveOn"> date when plan was applied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallBillingPlanInfo(FirewallBillingPlanUsageType? usageType, FirewallBillingCycle billingCycle, string planId, DateTimeOffset? effectiveOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UsageType = usageType;
            BillingCycle = billingCycle;
            PlanId = planId;
            EffectiveOn = effectiveOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallBillingPlanInfo"/> for deserialization. </summary>
        internal FirewallBillingPlanInfo()
        {
        }

        /// <summary> different usage type like PAYG/COMMITTED. </summary>
        public FirewallBillingPlanUsageType? UsageType { get; set; }
        /// <summary> different billing cycles like MONTHLY/WEEKLY. </summary>
        public FirewallBillingCycle BillingCycle { get; set; }
        /// <summary> plan id as published by Liftr.PAN. </summary>
        public string PlanId { get; set; }
        /// <summary> date when plan was applied. </summary>
        public DateTimeOffset? EffectiveOn { get; }
    }
}
