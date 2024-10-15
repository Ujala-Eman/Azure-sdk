// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Enumeration of supported Text Analysis tasks. </summary>
    internal readonly partial struct AnalyzeTextTaskKind : IEquatable<AnalyzeTextTaskKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextTaskKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnalyzeTextTaskKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SentimentAnalysisValue = "SentimentAnalysis";
        private const string EntityRecognitionValue = "EntityRecognition";
        private const string PiiEntityRecognitionValue = "PiiEntityRecognition";
        private const string KeyPhraseExtractionValue = "KeyPhraseExtraction";
        private const string LanguageDetectionValue = "LanguageDetection";
        private const string EntityLinkingValue = "EntityLinking";

        /// <summary> SentimentAnalysis. </summary>
        public static AnalyzeTextTaskKind SentimentAnalysis { get; } = new AnalyzeTextTaskKind(SentimentAnalysisValue);
        /// <summary> EntityRecognition. </summary>
        public static AnalyzeTextTaskKind EntityRecognition { get; } = new AnalyzeTextTaskKind(EntityRecognitionValue);
        /// <summary> PiiEntityRecognition. </summary>
        public static AnalyzeTextTaskKind PiiEntityRecognition { get; } = new AnalyzeTextTaskKind(PiiEntityRecognitionValue);
        /// <summary> KeyPhraseExtraction. </summary>
        public static AnalyzeTextTaskKind KeyPhraseExtraction { get; } = new AnalyzeTextTaskKind(KeyPhraseExtractionValue);
        /// <summary> LanguageDetection. </summary>
        public static AnalyzeTextTaskKind LanguageDetection { get; } = new AnalyzeTextTaskKind(LanguageDetectionValue);
        /// <summary> EntityLinking. </summary>
        public static AnalyzeTextTaskKind EntityLinking { get; } = new AnalyzeTextTaskKind(EntityLinkingValue);
        /// <summary> Determines if two <see cref="AnalyzeTextTaskKind"/> values are the same. </summary>
        public static bool operator ==(AnalyzeTextTaskKind left, AnalyzeTextTaskKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyzeTextTaskKind"/> values are not the same. </summary>
        public static bool operator !=(AnalyzeTextTaskKind left, AnalyzeTextTaskKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AnalyzeTextTaskKind"/>. </summary>
        public static implicit operator AnalyzeTextTaskKind(string value) => new AnalyzeTextTaskKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyzeTextTaskKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyzeTextTaskKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
