// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    /// <summary> This is the request for hibernate. </summary>
    public partial class SubmitHibernateContent
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

        /// <summary> Initializes a new instance of <see cref="SubmitHibernateContent"/>. </summary>
        /// <param name="schedule"> The schedule for the request. </param>
        /// <param name="executionParameters"> The execution parameters for the request. </param>
        /// <param name="resources"> The resources for the request. </param>
        /// <param name="correlationId"> CorrelationId item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/>, <paramref name="executionParameters"/>, <paramref name="resources"/> or <paramref name="correlationId"/> is null. </exception>
        public SubmitHibernateContent(UserRequestSchedule schedule, ScheduledActionExecutionParameterDetail executionParameters, UserRequestResources resources, string correlationId)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(executionParameters, nameof(executionParameters));
            Argument.AssertNotNull(resources, nameof(resources));
            Argument.AssertNotNull(correlationId, nameof(correlationId));

            Schedule = schedule;
            ExecutionParameters = executionParameters;
            Resources = resources;
            CorrelationId = correlationId;
        }

        /// <summary> Initializes a new instance of <see cref="SubmitHibernateContent"/>. </summary>
        /// <param name="schedule"> The schedule for the request. </param>
        /// <param name="executionParameters"> The execution parameters for the request. </param>
        /// <param name="resources"> The resources for the request. </param>
        /// <param name="correlationId"> CorrelationId item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubmitHibernateContent(UserRequestSchedule schedule, ScheduledActionExecutionParameterDetail executionParameters, UserRequestResources resources, string correlationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Schedule = schedule;
            ExecutionParameters = executionParameters;
            Resources = resources;
            CorrelationId = correlationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SubmitHibernateContent"/> for deserialization. </summary>
        internal SubmitHibernateContent()
        {
        }

        /// <summary> The schedule for the request. </summary>
        public UserRequestSchedule Schedule { get; }
        /// <summary> The execution parameters for the request. </summary>
        public ScheduledActionExecutionParameterDetail ExecutionParameters { get; }
        /// <summary> The resources for the request. </summary>
        internal UserRequestResources Resources { get; }
        /// <summary> The resource ids used for the request. </summary>
        public IList<ResourceIdentifier> ResourcesIds
        {
            get => Resources?.Ids;
        }

        /// <summary> CorrelationId item. </summary>
        public string CorrelationId { get; }
    }
}
