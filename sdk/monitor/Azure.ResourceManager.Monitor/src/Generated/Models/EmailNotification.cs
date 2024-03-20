// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Email notification of an autoscale event. </summary>
    public partial class EmailNotification
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

        /// <summary> Initializes a new instance of <see cref="EmailNotification"/>. </summary>
        public EmailNotification()
        {
            CustomEmails = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EmailNotification"/>. </summary>
        /// <param name="sendToSubscriptionAdministrator"> a value indicating whether to send email to subscription administrator. </param>
        /// <param name="sendToSubscriptionCoAdministrators"> a value indicating whether to send email to subscription co-administrators. </param>
        /// <param name="customEmails"> the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EmailNotification(bool? sendToSubscriptionAdministrator, bool? sendToSubscriptionCoAdministrators, IList<string> customEmails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SendToSubscriptionAdministrator = sendToSubscriptionAdministrator;
            SendToSubscriptionCoAdministrators = sendToSubscriptionCoAdministrators;
            CustomEmails = customEmails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> a value indicating whether to send email to subscription administrator. </summary>
        public bool? SendToSubscriptionAdministrator { get; set; }
        /// <summary> a value indicating whether to send email to subscription co-administrators. </summary>
        public bool? SendToSubscriptionCoAdministrators { get; set; }
        /// <summary> the custom e-mails list. This value can be null or empty, in which case this attribute will be ignored. </summary>
        public IList<string> CustomEmails { get; }
    }
}
