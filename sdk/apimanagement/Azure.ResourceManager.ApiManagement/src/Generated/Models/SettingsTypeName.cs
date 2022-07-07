// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The SettingsTypeName. </summary>
    public readonly partial struct SettingsTypeName : IEquatable<SettingsTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SettingsTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SettingsTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "public";

        /// <summary> public. </summary>
        public static SettingsTypeName Public { get; } = new SettingsTypeName(PublicValue);
        /// <summary> Determines if two <see cref="SettingsTypeName"/> values are the same. </summary>
        public static bool operator ==(SettingsTypeName left, SettingsTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SettingsTypeName"/> values are not the same. </summary>
        public static bool operator !=(SettingsTypeName left, SettingsTypeName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SettingsTypeName"/>. </summary>
        public static implicit operator SettingsTypeName(string value) => new SettingsTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SettingsTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SettingsTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
