// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Data encryption type to depict if it is System Managed vs Azure Key vault. </summary>
    public readonly partial struct PostgreSqlFlexibleServerKeyType : IEquatable<PostgreSqlFlexibleServerKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemManagedValue = "SystemManaged";
        private const string AzureKeyVaultValue = "AzureKeyVault";

        /// <summary> SystemManaged. </summary>
        public static PostgreSqlFlexibleServerKeyType SystemManaged { get; } = new PostgreSqlFlexibleServerKeyType(SystemManagedValue);
        /// <summary> AzureKeyVault. </summary>
        public static PostgreSqlFlexibleServerKeyType AzureKeyVault { get; } = new PostgreSqlFlexibleServerKeyType(AzureKeyVaultValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerKeyType"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerKeyType left, PostgreSqlFlexibleServerKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerKeyType"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerKeyType left, PostgreSqlFlexibleServerKeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerKeyType"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerKeyType(string value) => new PostgreSqlFlexibleServerKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
