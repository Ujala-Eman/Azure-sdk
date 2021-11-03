// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> Link type (GEO, NAMED). </summary>
    public readonly partial struct ReplicationLinkType : IEquatable<ReplicationLinkType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicationLinkType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicationLinkType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GEOValue = "GEO";
        private const string NamedValue = "NAMED";

        /// <summary> GEO. </summary>
        public static ReplicationLinkType GEO { get; } = new ReplicationLinkType(GEOValue);
        /// <summary> NAMED. </summary>
        public static ReplicationLinkType Named { get; } = new ReplicationLinkType(NamedValue);
        /// <summary> Determines if two <see cref="ReplicationLinkType"/> values are the same. </summary>
        public static bool operator ==(ReplicationLinkType left, ReplicationLinkType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationLinkType"/> values are not the same. </summary>
        public static bool operator !=(ReplicationLinkType left, ReplicationLinkType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationLinkType"/>. </summary>
        public static implicit operator ReplicationLinkType(string value) => new ReplicationLinkType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationLinkType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationLinkType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
