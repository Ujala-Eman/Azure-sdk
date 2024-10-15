// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The HTTP method to use. </summary>
    public readonly partial struct NetworkHttpConfigurationMethod : IEquatable<NetworkHttpConfigurationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkHttpConfigurationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkHttpConfigurationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GetValue = "Get";
        private const string PostValue = "Post";

        /// <summary> Get. </summary>
        public static NetworkHttpConfigurationMethod Get { get; } = new NetworkHttpConfigurationMethod(GetValue);
        /// <summary> Post. </summary>
        public static NetworkHttpConfigurationMethod Post { get; } = new NetworkHttpConfigurationMethod(PostValue);
        /// <summary> Determines if two <see cref="NetworkHttpConfigurationMethod"/> values are the same. </summary>
        public static bool operator ==(NetworkHttpConfigurationMethod left, NetworkHttpConfigurationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkHttpConfigurationMethod"/> values are not the same. </summary>
        public static bool operator !=(NetworkHttpConfigurationMethod left, NetworkHttpConfigurationMethod right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkHttpConfigurationMethod"/>. </summary>
        public static implicit operator NetworkHttpConfigurationMethod(string value) => new NetworkHttpConfigurationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkHttpConfigurationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkHttpConfigurationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
