// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// Allow crash dumps values.
    /// Serialized Name: AllowCrashDumpCollection
    /// </summary>
    public readonly partial struct SphereAllowCrashDumpCollectionStatus : IEquatable<SphereAllowCrashDumpCollectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SphereAllowCrashDumpCollectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SphereAllowCrashDumpCollectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary>
        /// Crash dump collection enabled
        /// Serialized Name: AllowCrashDumpCollection.Enabled
        /// </summary>
        public static SphereAllowCrashDumpCollectionStatus Enabled { get; } = new SphereAllowCrashDumpCollectionStatus(EnabledValue);
        /// <summary>
        /// Crash dump collection disabled
        /// Serialized Name: AllowCrashDumpCollection.Disabled
        /// </summary>
        public static SphereAllowCrashDumpCollectionStatus Disabled { get; } = new SphereAllowCrashDumpCollectionStatus(DisabledValue);
        /// <summary> Determines if two <see cref="SphereAllowCrashDumpCollectionStatus"/> values are the same. </summary>
        public static bool operator ==(SphereAllowCrashDumpCollectionStatus left, SphereAllowCrashDumpCollectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SphereAllowCrashDumpCollectionStatus"/> values are not the same. </summary>
        public static bool operator !=(SphereAllowCrashDumpCollectionStatus left, SphereAllowCrashDumpCollectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SphereAllowCrashDumpCollectionStatus"/>. </summary>
        public static implicit operator SphereAllowCrashDumpCollectionStatus(string value) => new SphereAllowCrashDumpCollectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SphereAllowCrashDumpCollectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SphereAllowCrashDumpCollectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
