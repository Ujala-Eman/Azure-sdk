// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Enum to indicate the mode of account creation. </summary>
    public readonly partial struct CosmosDBAccountCreateMode : IEquatable<CosmosDBAccountCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBAccountCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string RestoreValue = "Restore";

        /// <summary> Default. </summary>
        public static CosmosDBAccountCreateMode Default { get; } = new CosmosDBAccountCreateMode(DefaultValue);
        /// <summary> Restore. </summary>
        public static CosmosDBAccountCreateMode Restore { get; } = new CosmosDBAccountCreateMode(RestoreValue);
        /// <summary> Determines if two <see cref="CosmosDBAccountCreateMode"/> values are the same. </summary>
        public static bool operator ==(CosmosDBAccountCreateMode left, CosmosDBAccountCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBAccountCreateMode"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBAccountCreateMode left, CosmosDBAccountCreateMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CosmosDBAccountCreateMode"/>. </summary>
        public static implicit operator CosmosDBAccountCreateMode(string value) => new CosmosDBAccountCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBAccountCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBAccountCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
