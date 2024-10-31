// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The type for the patch. </summary>
    public readonly partial struct PatchType : IEquatable<PatchType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PatchType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PatchType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FrameworkSecurityValue = "FrameworkSecurity";
        private const string OSSecurityValue = "OSSecurity";
        private const string FrameworkAndOSSecurityValue = "FrameworkAndOSSecurity";
        private const string OtherValue = "Other";

        /// <summary> FrameworkSecurity. </summary>
        public static PatchType FrameworkSecurity { get; } = new PatchType(FrameworkSecurityValue);
        /// <summary> OSSecurity. </summary>
        public static PatchType OSSecurity { get; } = new PatchType(OSSecurityValue);
        /// <summary> FrameworkAndOSSecurity. </summary>
        public static PatchType FrameworkAndOSSecurity { get; } = new PatchType(FrameworkAndOSSecurityValue);
        /// <summary> Other. </summary>
        public static PatchType Other { get; } = new PatchType(OtherValue);
        /// <summary> Determines if two <see cref="PatchType"/> values are the same. </summary>
        public static bool operator ==(PatchType left, PatchType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PatchType"/> values are not the same. </summary>
        public static bool operator !=(PatchType left, PatchType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PatchType"/>. </summary>
        public static implicit operator PatchType(string value) => new PatchType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PatchType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PatchType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
