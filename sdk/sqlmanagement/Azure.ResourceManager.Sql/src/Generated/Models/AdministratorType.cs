// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> Type of the sever administrator. </summary>
    public readonly partial struct AdministratorType : IEquatable<AdministratorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdministratorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdministratorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveDirectoryValue = "ActiveDirectory";

        /// <summary> ActiveDirectory. </summary>
        public static AdministratorType ActiveDirectory { get; } = new AdministratorType(ActiveDirectoryValue);
        /// <summary> Determines if two <see cref="AdministratorType"/> values are the same. </summary>
        public static bool operator ==(AdministratorType left, AdministratorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdministratorType"/> values are not the same. </summary>
        public static bool operator !=(AdministratorType left, AdministratorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AdministratorType"/>. </summary>
        public static implicit operator AdministratorType(string value) => new AdministratorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdministratorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdministratorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
