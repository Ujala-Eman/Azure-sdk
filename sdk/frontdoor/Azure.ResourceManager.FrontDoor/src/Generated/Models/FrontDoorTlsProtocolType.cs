// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the TLS extension protocol that is used for secure delivery. </summary>
    public readonly partial struct FrontDoorTlsProtocolType : IEquatable<FrontDoorTlsProtocolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorTlsProtocolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorTlsProtocolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerNameIndicationValue = "ServerNameIndication";

        /// <summary> ServerNameIndication. </summary>
        public static FrontDoorTlsProtocolType ServerNameIndication { get; } = new FrontDoorTlsProtocolType(ServerNameIndicationValue);
        /// <summary> Determines if two <see cref="FrontDoorTlsProtocolType"/> values are the same. </summary>
        public static bool operator ==(FrontDoorTlsProtocolType left, FrontDoorTlsProtocolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorTlsProtocolType"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorTlsProtocolType left, FrontDoorTlsProtocolType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FrontDoorTlsProtocolType"/>. </summary>
        public static implicit operator FrontDoorTlsProtocolType(string value) => new FrontDoorTlsProtocolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorTlsProtocolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorTlsProtocolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
