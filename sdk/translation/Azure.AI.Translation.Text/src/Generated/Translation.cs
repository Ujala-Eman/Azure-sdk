// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Translation.Text
{
    /// <summary> Translation result. </summary>
    public partial class Translation
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

        /// <summary> Initializes a new instance of <see cref="Translation"/>. </summary>
        /// <param name="to"> A string representing the language code of the target language. </param>
        /// <param name="text"> A string giving the translated text. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> or <paramref name="text"/> is null. </exception>
        internal Translation(string to, string text)
        {
            Argument.AssertNotNull(to, nameof(to));
            Argument.AssertNotNull(text, nameof(text));

            To = to;
            Text = text;
        }

        /// <summary> Initializes a new instance of <see cref="Translation"/>. </summary>
        /// <param name="to"> A string representing the language code of the target language. </param>
        /// <param name="text"> A string giving the translated text. </param>
        /// <param name="transliteration"> An object giving the translated text in the script specified by the toScript parameter. </param>
        /// <param name="alignment"> Alignment information. </param>
        /// <param name="sentLen"> Sentence boundaries in the input and output texts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Translation(string to, string text, TransliteratedText transliteration, TranslatedTextAlignment alignment, SentenceLength sentLen, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            To = to;
            Text = text;
            Transliteration = transliteration;
            Alignment = alignment;
            SentLen = sentLen;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Translation"/> for deserialization. </summary>
        internal Translation()
        {
        }

        /// <summary> A string representing the language code of the target language. </summary>
        public string To { get; }
        /// <summary> A string giving the translated text. </summary>
        public string Text { get; }
        /// <summary> An object giving the translated text in the script specified by the toScript parameter. </summary>
        public TransliteratedText Transliteration { get; }
        /// <summary> Alignment information. </summary>
        public TranslatedTextAlignment Alignment { get; }
        /// <summary> Sentence boundaries in the input and output texts. </summary>
        public SentenceLength SentLen { get; }
    }
}
