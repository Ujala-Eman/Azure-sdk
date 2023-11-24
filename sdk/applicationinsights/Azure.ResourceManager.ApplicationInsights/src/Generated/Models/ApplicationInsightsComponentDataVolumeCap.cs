// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component daily data volume cap. </summary>
    public partial class ApplicationInsightsComponentDataVolumeCap
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

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentDataVolumeCap"/>. </summary>
        public ApplicationInsightsComponentDataVolumeCap()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentDataVolumeCap"/>. </summary>
        /// <param name="cap"> Daily data volume cap in GB. </param>
        /// <param name="resetTime"> Daily data volume cap UTC reset hour. </param>
        /// <param name="warningThreshold"> Reserved, not used for now. </param>
        /// <param name="isStopSendNotificationWhenHitThreshold"> Reserved, not used for now. </param>
        /// <param name="isStopSendNotificationWhenHitCap"> Do not send a notification email when the daily data volume cap is met. </param>
        /// <param name="maxHistoryCap"> Maximum daily data volume cap that the user can set for this component. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentDataVolumeCap(float? cap, int? resetTime, int? warningThreshold, bool? isStopSendNotificationWhenHitThreshold, bool? isStopSendNotificationWhenHitCap, float? maxHistoryCap, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Cap = cap;
            ResetTime = resetTime;
            WarningThreshold = warningThreshold;
            IsStopSendNotificationWhenHitThreshold = isStopSendNotificationWhenHitThreshold;
            IsStopSendNotificationWhenHitCap = isStopSendNotificationWhenHitCap;
            MaxHistoryCap = maxHistoryCap;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Daily data volume cap in GB. </summary>
        public float? Cap { get; set; }
        /// <summary> Daily data volume cap UTC reset hour. </summary>
        public int? ResetTime { get; }
        /// <summary> Reserved, not used for now. </summary>
        public int? WarningThreshold { get; set; }
        /// <summary> Reserved, not used for now. </summary>
        public bool? IsStopSendNotificationWhenHitThreshold { get; set; }
        /// <summary> Do not send a notification email when the daily data volume cap is met. </summary>
        public bool? IsStopSendNotificationWhenHitCap { get; set; }
        /// <summary> Maximum daily data volume cap that the user can set for this component. </summary>
        public float? MaxHistoryCap { get; }
    }
}
