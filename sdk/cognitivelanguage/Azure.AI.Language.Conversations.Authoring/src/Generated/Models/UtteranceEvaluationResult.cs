// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents the evaluation result for an utterance. </summary>
    public partial class UtteranceEvaluationResult
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

        /// <summary> Initializes a new instance of <see cref="UtteranceEvaluationResult"/>. </summary>
        /// <param name="language">
        /// Represents the utterance language. This is BCP-47 representation of a language.
        /// For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish
        /// etc.
        /// </param>
        /// <param name="entitiesResult"> Represents the entities results for the utterance. </param>
        /// <param name="intentsResult"> Represents the intents results for the utterance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="language"/>, <paramref name="entitiesResult"/> or <paramref name="intentsResult"/> is null. </exception>
        internal UtteranceEvaluationResult(string language, UtteranceEntitiesEvaluationResult entitiesResult, UtteranceIntentsEvaluationResult intentsResult)
        {
            Argument.AssertNotNull(language, nameof(language));
            Argument.AssertNotNull(entitiesResult, nameof(entitiesResult));
            Argument.AssertNotNull(intentsResult, nameof(intentsResult));

            Language = language;
            EntitiesResult = entitiesResult;
            IntentsResult = intentsResult;
        }

        /// <summary> Initializes a new instance of <see cref="UtteranceEvaluationResult"/>. </summary>
        /// <param name="text"> Represents the utterance text. </param>
        /// <param name="language">
        /// Represents the utterance language. This is BCP-47 representation of a language.
        /// For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish
        /// etc.
        /// </param>
        /// <param name="entitiesResult"> Represents the entities results for the utterance. </param>
        /// <param name="intentsResult"> Represents the intents results for the utterance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UtteranceEvaluationResult(string text, string language, UtteranceEntitiesEvaluationResult entitiesResult, UtteranceIntentsEvaluationResult intentsResult, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Language = language;
            EntitiesResult = entitiesResult;
            IntentsResult = intentsResult;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UtteranceEvaluationResult"/> for deserialization. </summary>
        internal UtteranceEvaluationResult()
        {
        }

        /// <summary> Represents the utterance text. </summary>
        public string Text { get; }
        /// <summary>
        /// Represents the utterance language. This is BCP-47 representation of a language.
        /// For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish
        /// etc.
        /// </summary>
        public string Language { get; }
        /// <summary> Represents the entities results for the utterance. </summary>
        public UtteranceEntitiesEvaluationResult EntitiesResult { get; }
        /// <summary> Represents the intents results for the utterance. </summary>
        public UtteranceIntentsEvaluationResult IntentsResult { get; }
    }
}
