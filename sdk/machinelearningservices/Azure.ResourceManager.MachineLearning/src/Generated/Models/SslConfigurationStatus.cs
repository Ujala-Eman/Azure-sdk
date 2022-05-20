// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enable or disable ssl for scoring. </summary>
    public readonly partial struct SslConfigurationStatus : IEquatable<SslConfigurationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SslConfigurationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SslConfigurationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";
        private const string AutoValue = "Auto";

        /// <summary> Disabled. </summary>
        public static SslConfigurationStatus Disabled { get; } = new SslConfigurationStatus(DisabledValue);
        /// <summary> Enabled. </summary>
        public static SslConfigurationStatus Enabled { get; } = new SslConfigurationStatus(EnabledValue);
        /// <summary> Auto. </summary>
        public static SslConfigurationStatus Auto { get; } = new SslConfigurationStatus(AutoValue);
        /// <summary> Determines if two <see cref="SslConfigurationStatus"/> values are the same. </summary>
        public static bool operator ==(SslConfigurationStatus left, SslConfigurationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SslConfigurationStatus"/> values are not the same. </summary>
        public static bool operator !=(SslConfigurationStatus left, SslConfigurationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SslConfigurationStatus"/>. </summary>
        public static implicit operator SslConfigurationStatus(string value) => new SslConfigurationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SslConfigurationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SslConfigurationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
