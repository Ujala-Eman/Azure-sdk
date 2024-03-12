// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The text and associated annotations for a single item of assistant thread message content. </summary>
    internal partial class InternalMessageTextDetails
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

        /// <summary> Initializes a new instance of <see cref="InternalMessageTextDetails"/>. </summary>
        /// <param name="text"> The text data. </param>
        /// <param name="annotations"> A list of annotations associated with this text. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="annotations"/> is null. </exception>
        internal InternalMessageTextDetails(string text, IEnumerable<MessageTextAnnotation> annotations)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(annotations, nameof(annotations));

            Text = text;
            Annotations = annotations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InternalMessageTextDetails"/>. </summary>
        /// <param name="text"> The text data. </param>
        /// <param name="annotations"> A list of annotations associated with this text. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalMessageTextDetails(string text, IReadOnlyList<MessageTextAnnotation> annotations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Annotations = annotations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalMessageTextDetails"/> for deserialization. </summary>
        internal InternalMessageTextDetails()
        {
        }

        /// <summary> The text data. </summary>
        public string Text { get; }
        /// <summary>
        /// A list of annotations associated with this text.
        /// Please note <see cref="MessageTextAnnotation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageTextFileCitationAnnotation"/> and <see cref="MessageTextFilePathAnnotation"/>.
        /// </summary>
        public IReadOnlyList<MessageTextAnnotation> Annotations { get; }
    }
}
