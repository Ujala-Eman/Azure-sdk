// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> Audio transcription task type. </summary>
    internal readonly partial struct AudioTranscriptionTask : IEquatable<AudioTranscriptionTask>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AudioTranscriptionTask"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AudioTranscriptionTask(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TranscribeValue = "transcribe";
        private const string TranslateValue = "translate";

        /// <summary> Value for a transcription task. </summary>
        public static AudioTranscriptionTask Transcribe { get; } = new AudioTranscriptionTask(TranscribeValue);
        /// <summary> Value for a translation task. </summary>
        public static AudioTranscriptionTask Translate { get; } = new AudioTranscriptionTask(TranslateValue);
        /// <summary> Determines if two <see cref="AudioTranscriptionTask"/> values are the same. </summary>
        public static bool operator ==(AudioTranscriptionTask left, AudioTranscriptionTask right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AudioTranscriptionTask"/> values are not the same. </summary>
        public static bool operator !=(AudioTranscriptionTask left, AudioTranscriptionTask right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AudioTranscriptionTask"/>. </summary>
        public static implicit operator AudioTranscriptionTask(string value) => new AudioTranscriptionTask(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AudioTranscriptionTask other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AudioTranscriptionTask other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
