// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Specifies a tool the model should use. Use to force the model to call a specific tool. </summary>
    public partial class AgentsNamedToolChoice
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

        /// <summary> Initializes a new instance of <see cref="AgentsNamedToolChoice"/>. </summary>
        /// <param name="type"> the type of tool. If type is `function`, the function name must be set. </param>
        public AgentsNamedToolChoice(AgentsNamedToolChoiceType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="AgentsNamedToolChoice"/>. </summary>
        /// <param name="type"> the type of tool. If type is `function`, the function name must be set. </param>
        /// <param name="function"> The name of the function to call. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentsNamedToolChoice(AgentsNamedToolChoiceType type, FunctionName function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Function = function;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AgentsNamedToolChoice"/> for deserialization. </summary>
        internal AgentsNamedToolChoice()
        {
        }

        /// <summary> the type of tool. If type is `function`, the function name must be set. </summary>
        public AgentsNamedToolChoiceType Type { get; set; }
        /// <summary> The name of the function to call. </summary>
        public FunctionName Function { get; set; }
    }
}
