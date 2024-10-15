// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine whether PublicNetworkAccess is Enabled or Disabled. </summary>
    public readonly partial struct MachineLearningPublicNetworkAccessType : IEquatable<MachineLearningPublicNetworkAccessType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningPublicNetworkAccessType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningPublicNetworkAccessType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static MachineLearningPublicNetworkAccessType Enabled { get; } = new MachineLearningPublicNetworkAccessType(EnabledValue);
        /// <summary> Disabled. </summary>
        public static MachineLearningPublicNetworkAccessType Disabled { get; } = new MachineLearningPublicNetworkAccessType(DisabledValue);
        /// <summary> Determines if two <see cref="MachineLearningPublicNetworkAccessType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningPublicNetworkAccessType left, MachineLearningPublicNetworkAccessType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningPublicNetworkAccessType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningPublicNetworkAccessType left, MachineLearningPublicNetworkAccessType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningPublicNetworkAccessType"/>. </summary>
        public static implicit operator MachineLearningPublicNetworkAccessType(string value) => new MachineLearningPublicNetworkAccessType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningPublicNetworkAccessType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningPublicNetworkAccessType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
