// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace SqlManagementClient.Models
{
    /// <summary> The differential backup interval in hours. This is how many interval hours between each differential backup will be supported. This is only applicable to live databases but not dropped databases. </summary>
    public readonly partial struct DiffBackupIntervalInHours : IEquatable<DiffBackupIntervalInHours>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="DiffBackupIntervalInHours"/>. </summary>
        public DiffBackupIntervalInHours(int value)
        {
            _value = value;
        }

        private const int TwelveValue = 12;
        private const int TwentyFourValue = 24;

        /// <summary> 12. </summary>
        public static DiffBackupIntervalInHours Twelve { get; } = new DiffBackupIntervalInHours(TwelveValue);
        /// <summary> 24. </summary>
        public static DiffBackupIntervalInHours TwentyFour { get; } = new DiffBackupIntervalInHours(TwentyFourValue);
        /// <summary> Determines if two <see cref="DiffBackupIntervalInHours"/> values are the same. </summary>
        public static bool operator ==(DiffBackupIntervalInHours left, DiffBackupIntervalInHours right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiffBackupIntervalInHours"/> values are not the same. </summary>
        public static bool operator !=(DiffBackupIntervalInHours left, DiffBackupIntervalInHours right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiffBackupIntervalInHours"/>. </summary>
        public static implicit operator DiffBackupIntervalInHours(int value) => new DiffBackupIntervalInHours(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiffBackupIntervalInHours other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiffBackupIntervalInHours other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
