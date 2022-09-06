// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Indicates the indexing mode. </summary>
    public readonly partial struct CosmosDBIndexingMode : IEquatable<CosmosDBIndexingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBIndexingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBIndexingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConsistentValue = "consistent";
        private const string LazyValue = "lazy";
        private const string NoneValue = "none";

        /// <summary> consistent. </summary>
        public static CosmosDBIndexingMode Consistent { get; } = new CosmosDBIndexingMode(ConsistentValue);
        /// <summary> lazy. </summary>
        public static CosmosDBIndexingMode Lazy { get; } = new CosmosDBIndexingMode(LazyValue);
        /// <summary> none. </summary>
        public static CosmosDBIndexingMode None { get; } = new CosmosDBIndexingMode(NoneValue);
        /// <summary> Determines if two <see cref="CosmosDBIndexingMode"/> values are the same. </summary>
        public static bool operator ==(CosmosDBIndexingMode left, CosmosDBIndexingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBIndexingMode"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBIndexingMode left, CosmosDBIndexingMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBIndexingMode"/>. </summary>
        public static implicit operator CosmosDBIndexingMode(string value) => new CosmosDBIndexingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBIndexingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBIndexingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
