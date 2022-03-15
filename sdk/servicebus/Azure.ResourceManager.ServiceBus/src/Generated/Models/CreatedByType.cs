// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The type of identity that created the resource. </summary>
    internal readonly partial struct CreatedByType : IEquatable<CreatedByType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreatedByType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreatedByType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UserValue = "User";
        private const string ApplicationValue = "Application";
        private const string ManagedIdentityValue = "ManagedIdentity";
        private const string KeyValue = "Key";

        /// <summary> User. </summary>
        public static CreatedByType User { get; } = new CreatedByType(UserValue);
        /// <summary> Application. </summary>
        public static CreatedByType Application { get; } = new CreatedByType(ApplicationValue);
        /// <summary> ManagedIdentity. </summary>
        public static CreatedByType ManagedIdentity { get; } = new CreatedByType(ManagedIdentityValue);
        /// <summary> Key. </summary>
        public static CreatedByType Key { get; } = new CreatedByType(KeyValue);
        /// <summary> Determines if two <see cref="CreatedByType"/> values are the same. </summary>
        public static bool operator ==(CreatedByType left, CreatedByType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreatedByType"/> values are not the same. </summary>
        public static bool operator !=(CreatedByType left, CreatedByType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreatedByType"/>. </summary>
        public static implicit operator CreatedByType(string value) => new CreatedByType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreatedByType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreatedByType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
