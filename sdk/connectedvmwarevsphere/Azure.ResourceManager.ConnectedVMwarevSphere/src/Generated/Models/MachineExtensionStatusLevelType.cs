// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> The level code. </summary>
    public readonly partial struct MachineExtensionStatusLevelType : IEquatable<MachineExtensionStatusLevelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineExtensionStatusLevelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineExtensionStatusLevelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InfoValue = "Info";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";

        /// <summary> Info. </summary>
        public static MachineExtensionStatusLevelType Info { get; } = new MachineExtensionStatusLevelType(InfoValue);
        /// <summary> Warning. </summary>
        public static MachineExtensionStatusLevelType Warning { get; } = new MachineExtensionStatusLevelType(WarningValue);
        /// <summary> Error. </summary>
        public static MachineExtensionStatusLevelType Error { get; } = new MachineExtensionStatusLevelType(ErrorValue);
        /// <summary> Determines if two <see cref="MachineExtensionStatusLevelType"/> values are the same. </summary>
        public static bool operator ==(MachineExtensionStatusLevelType left, MachineExtensionStatusLevelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineExtensionStatusLevelType"/> values are not the same. </summary>
        public static bool operator !=(MachineExtensionStatusLevelType left, MachineExtensionStatusLevelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineExtensionStatusLevelType"/>. </summary>
        public static implicit operator MachineExtensionStatusLevelType(string value) => new MachineExtensionStatusLevelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineExtensionStatusLevelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineExtensionStatusLevelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
