// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the an action and its status. </summary>
    public partial class ActionStatus
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

        /// <summary> Initializes a new instance of <see cref="ActionStatus"/>. </summary>
        internal ActionStatus()
        {
            Targets = new ChangeTrackingList<ExperimentExecutionActionTargetDetailsProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="ActionStatus"/>. </summary>
        /// <param name="actionName"> The name of the action status. </param>
        /// <param name="actionId"> The id of the action status. </param>
        /// <param name="status"> The status of the action. </param>
        /// <param name="startOn"> String that represents the start time of the action. </param>
        /// <param name="endOn"> String that represents the end time of the action. </param>
        /// <param name="targets"> The array of targets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ActionStatus(string actionName, string actionId, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<ExperimentExecutionActionTargetDetailsProperties> targets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionName = actionName;
            ActionId = actionId;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            Targets = targets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the action status. </summary>
        public string ActionName { get; }
        /// <summary> The id of the action status. </summary>
        public string ActionId { get; }
        /// <summary> The status of the action. </summary>
        public string Status { get; }
        /// <summary> String that represents the start time of the action. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> String that represents the end time of the action. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The array of targets. </summary>
        public IReadOnlyList<ExperimentExecutionActionTargetDetailsProperties> Targets { get; }
    }
}
