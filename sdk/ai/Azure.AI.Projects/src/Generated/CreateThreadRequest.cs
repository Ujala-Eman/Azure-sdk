// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> The CreateThreadRequest. </summary>
    internal partial class CreateThreadRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateThreadRequest"/>. </summary>
        internal CreateThreadRequest()
        {
            Messages = new ChangeTrackingList<ThreadMessageOptions>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateThreadRequest"/>. </summary>
        /// <param name="messages"> The initial messages to associate with the new thread. </param>
        /// <param name="toolResources">
        /// A set of resources that are made available to the agent's tools in this thread. The resources are specific to the
        /// type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires
        /// a list of vector store IDs.
        /// </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateThreadRequest(IReadOnlyList<ThreadMessageOptions> messages, ToolResources toolResources, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Messages = messages;
            ToolResources = toolResources;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The initial messages to associate with the new thread. </summary>
        public IReadOnlyList<ThreadMessageOptions> Messages { get; }
        /// <summary>
        /// A set of resources that are made available to the agent's tools in this thread. The resources are specific to the
        /// type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires
        /// a list of vector store IDs.
        /// </summary>
        public ToolResources ToolResources { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
