// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Specifies an OS SKU. This value must not be specified if OSType is Windows. </summary>
    public readonly partial struct ContainerServiceOSSku : IEquatable<ContainerServiceOSSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOSSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceOSSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UbuntuValue = "Ubuntu";
        private const string CblMarinerValue = "CBLMariner";

        /// <summary> Ubuntu. </summary>
        public static ContainerServiceOSSku Ubuntu { get; } = new ContainerServiceOSSku(UbuntuValue);
        /// <summary> CBLMariner. </summary>
        public static ContainerServiceOSSku CblMariner { get; } = new ContainerServiceOSSku(CblMarinerValue);
        /// <summary> Determines if two <see cref="ContainerServiceOSSku"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceOSSku left, ContainerServiceOSSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceOSSku"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceOSSku left, ContainerServiceOSSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServiceOSSku"/>. </summary>
        public static implicit operator ContainerServiceOSSku(string value) => new ContainerServiceOSSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceOSSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceOSSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
