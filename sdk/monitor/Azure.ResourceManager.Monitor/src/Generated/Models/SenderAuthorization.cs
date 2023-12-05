// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> the authorization used by the user who has performed the operation that led to this event. This captures the RBAC properties of the event. These usually include the 'action', 'role' and the 'scope'. </summary>
    public partial class SenderAuthorization
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

        /// <summary> Initializes a new instance of <see cref="SenderAuthorization"/>. </summary>
        internal SenderAuthorization()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SenderAuthorization"/>. </summary>
        /// <param name="action"> the permissible actions. For instance: microsoft.support/supporttickets/write. </param>
        /// <param name="role"> the role of the user. For instance: Subscription Admin. </param>
        /// <param name="scope"> the scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SenderAuthorization(string action, string role, string scope, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            Role = role;
            Scope = scope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> the permissible actions. For instance: microsoft.support/supporttickets/write. </summary>
        public string Action { get; }
        /// <summary> the role of the user. For instance: Subscription Admin. </summary>
        public string Role { get; }
        /// <summary> the scope. </summary>
        public string Scope { get; }
    }
}
