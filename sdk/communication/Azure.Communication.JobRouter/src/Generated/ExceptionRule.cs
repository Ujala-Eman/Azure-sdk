// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> A rule that defines actions to execute upon a specific trigger. </summary>
    public partial class ExceptionRule
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

        /// <summary> Initializes a new instance of <see cref="ExceptionRule"/>. </summary>
        /// <param name="id"> Id of an exception rule. </param>
        /// <param name="trigger"> The trigger for this exception rule. </param>
        /// <param name="actions"> A collection of actions to perform once the exception is triggered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="trigger"/> or <paramref name="actions"/> is null. </exception>
        internal ExceptionRule(string id, ExceptionTrigger trigger, IEnumerable<ExceptionAction> actions)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(trigger, nameof(trigger));
            Argument.AssertNotNull(actions, nameof(actions));

            Id = id;
            Trigger = trigger;
            Actions = actions.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ExceptionRule"/>. </summary>
        /// <param name="id"> Id of an exception rule. </param>
        /// <param name="trigger"> The trigger for this exception rule. </param>
        /// <param name="actions"> A collection of actions to perform once the exception is triggered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExceptionRule(string id, ExceptionTrigger trigger, IList<ExceptionAction> actions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Trigger = trigger;
            Actions = actions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExceptionRule"/> for deserialization. </summary>
        internal ExceptionRule()
        {
        }

        /// <summary> Id of an exception rule. </summary>
        public string Id { get; }
        /// <summary>
        /// The trigger for this exception rule.
        /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
        /// </summary>
        public ExceptionTrigger Trigger { get; }
    }
}
