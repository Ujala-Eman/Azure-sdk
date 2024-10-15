// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A string indicating what maskingMode to use to mask the personal information detected in the input text. </summary>
    public readonly partial struct PiiDetectionSkillMaskingMode : IEquatable<PiiDetectionSkillMaskingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PiiDetectionSkillMaskingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PiiDetectionSkillMaskingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string ReplaceValue = "replace";

        /// <summary> No masking occurs and the maskedText output will not be returned. </summary>
        public static PiiDetectionSkillMaskingMode None { get; } = new PiiDetectionSkillMaskingMode(NoneValue);
        /// <summary> Replaces the detected entities with the character given in the maskingCharacter parameter. The character will be repeated to the length of the detected entity so that the offsets will correctly correspond to both the input text as well as the output maskedText. </summary>
        public static PiiDetectionSkillMaskingMode Replace { get; } = new PiiDetectionSkillMaskingMode(ReplaceValue);
        /// <summary> Determines if two <see cref="PiiDetectionSkillMaskingMode"/> values are the same. </summary>
        public static bool operator ==(PiiDetectionSkillMaskingMode left, PiiDetectionSkillMaskingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PiiDetectionSkillMaskingMode"/> values are not the same. </summary>
        public static bool operator !=(PiiDetectionSkillMaskingMode left, PiiDetectionSkillMaskingMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PiiDetectionSkillMaskingMode"/>. </summary>
        public static implicit operator PiiDetectionSkillMaskingMode(string value) => new PiiDetectionSkillMaskingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PiiDetectionSkillMaskingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PiiDetectionSkillMaskingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
