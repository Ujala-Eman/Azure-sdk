// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The host caching of the disk. Valid values are &apos;None&apos;, &apos;ReadOnly&apos;, and &apos;ReadWrite&apos;. </summary>
    public readonly partial struct SharedGalleryHostCaching : IEquatable<SharedGalleryHostCaching>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SharedGalleryHostCaching"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SharedGalleryHostCaching(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ReadOnlyValue = "ReadOnly";
        private const string ReadWriteValue = "ReadWrite";

        /// <summary> None. </summary>
        public static SharedGalleryHostCaching None { get; } = new SharedGalleryHostCaching(NoneValue);
        /// <summary> ReadOnly. </summary>
        public static SharedGalleryHostCaching ReadOnly { get; } = new SharedGalleryHostCaching(ReadOnlyValue);
        /// <summary> ReadWrite. </summary>
        public static SharedGalleryHostCaching ReadWrite { get; } = new SharedGalleryHostCaching(ReadWriteValue);
        /// <summary> Determines if two <see cref="SharedGalleryHostCaching"/> values are the same. </summary>
        public static bool operator ==(SharedGalleryHostCaching left, SharedGalleryHostCaching right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SharedGalleryHostCaching"/> values are not the same. </summary>
        public static bool operator !=(SharedGalleryHostCaching left, SharedGalleryHostCaching right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SharedGalleryHostCaching"/>. </summary>
        public static implicit operator SharedGalleryHostCaching(string value) => new SharedGalleryHostCaching(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SharedGalleryHostCaching other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SharedGalleryHostCaching other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
