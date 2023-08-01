// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Enum to indicate current buildout status of the region. </summary>
    public readonly partial struct CosmosDBStatus : IEquatable<CosmosDBStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UninitializedValue = "Uninitialized";
        private const string InitializingValue = "Initializing";
        private const string InternallyReadyValue = "InternallyReady";
        private const string OnlineValue = "Online";
        private const string DeletingValue = "Deleting";

        /// <summary> Uninitialized. </summary>
        public static CosmosDBStatus Uninitialized { get; } = new CosmosDBStatus(UninitializedValue);
        /// <summary> Initializing. </summary>
        public static CosmosDBStatus Initializing { get; } = new CosmosDBStatus(InitializingValue);
        /// <summary> InternallyReady. </summary>
        public static CosmosDBStatus InternallyReady { get; } = new CosmosDBStatus(InternallyReadyValue);
        /// <summary> Online. </summary>
        public static CosmosDBStatus Online { get; } = new CosmosDBStatus(OnlineValue);
        /// <summary> Deleting. </summary>
        public static CosmosDBStatus Deleting { get; } = new CosmosDBStatus(DeletingValue);
        /// <summary> Determines if two <see cref="CosmosDBStatus"/> values are the same. </summary>
        public static bool operator ==(CosmosDBStatus left, CosmosDBStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBStatus"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBStatus left, CosmosDBStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBStatus"/>. </summary>
        public static implicit operator CosmosDBStatus(string value) => new CosmosDBStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
