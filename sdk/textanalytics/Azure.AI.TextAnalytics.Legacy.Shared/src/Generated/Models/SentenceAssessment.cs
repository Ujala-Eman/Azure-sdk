// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The SentenceAssessment. </summary>
    internal partial class SentenceAssessment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SentenceAssessment"/>. </summary>
        /// <param name="sentiment"> Assessment sentiment in the sentence. </param>
        /// <param name="confidenceScores"> Assessment sentiment confidence scores in the sentence. </param>
        /// <param name="offset"> The assessment offset from the start of the sentence. </param>
        /// <param name="length"> The length of the assessment. </param>
        /// <param name="text"> The assessment text detected. </param>
        /// <param name="isNegated"> The indicator representing if the assessment is negated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="confidenceScores"/> or <paramref name="text"/> is null. </exception>
        internal SentenceAssessment(TokenSentimentValue sentiment, TargetConfidenceScoreLabel confidenceScores, int offset, int length, string text, bool isNegated)
        {
            Argument.AssertNotNull(confidenceScores, nameof(confidenceScores));
            Argument.AssertNotNull(text, nameof(text));

            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Text = text;
            IsNegated = isNegated;
        }

        /// <summary> Initializes a new instance of <see cref="SentenceAssessment"/>. </summary>
        /// <param name="sentiment"> Assessment sentiment in the sentence. </param>
        /// <param name="confidenceScores"> Assessment sentiment confidence scores in the sentence. </param>
        /// <param name="offset"> The assessment offset from the start of the sentence. </param>
        /// <param name="length"> The length of the assessment. </param>
        /// <param name="text"> The assessment text detected. </param>
        /// <param name="isNegated"> The indicator representing if the assessment is negated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SentenceAssessment(TokenSentimentValue sentiment, TargetConfidenceScoreLabel confidenceScores, int offset, int length, string text, bool isNegated, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Text = text;
            IsNegated = isNegated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SentenceAssessment"/> for deserialization. </summary>
        internal SentenceAssessment()
        {
        }

        /// <summary> Assessment sentiment in the sentence. </summary>
        public TokenSentimentValue Sentiment { get; }
        /// <summary> Assessment sentiment confidence scores in the sentence. </summary>
        public TargetConfidenceScoreLabel ConfidenceScores { get; }
        /// <summary> The assessment offset from the start of the sentence. </summary>
        public int Offset { get; }
        /// <summary> The length of the assessment. </summary>
        public int Length { get; }
        /// <summary> The assessment text detected. </summary>
        public string Text { get; }
        /// <summary> The indicator representing if the assessment is negated. </summary>
        public bool IsNegated { get; }
    }
}
