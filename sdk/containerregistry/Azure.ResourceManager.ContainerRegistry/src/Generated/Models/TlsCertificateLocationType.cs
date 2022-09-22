// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of certificate location. </summary>
    public readonly partial struct TlsCertificateLocationType : IEquatable<TlsCertificateLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TlsCertificateLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TlsCertificateLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocalDirectoryValue = "LocalDirectory";

        /// <summary> LocalDirectory. </summary>
        public static TlsCertificateLocationType LocalDirectory { get; } = new TlsCertificateLocationType(LocalDirectoryValue);
        /// <summary> Determines if two <see cref="TlsCertificateLocationType"/> values are the same. </summary>
        public static bool operator ==(TlsCertificateLocationType left, TlsCertificateLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TlsCertificateLocationType"/> values are not the same. </summary>
        public static bool operator !=(TlsCertificateLocationType left, TlsCertificateLocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TlsCertificateLocationType"/>. </summary>
        public static implicit operator TlsCertificateLocationType(string value) => new TlsCertificateLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TlsCertificateLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TlsCertificateLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
