// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.CodeSigning
{
    /// <summary> Algorithms supported for signing. </summary>
    public readonly partial struct SignatureAlgorithm : IEquatable<SignatureAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SignatureAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignatureAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RS256Value = "RS256";
        private const string RS384Value = "RS384";
        private const string RS512Value = "RS512";
        private const string PS256Value = "PS256";
        private const string PS384Value = "PS384";
        private const string PS512Value = "PS512";
        private const string ES256Value = "ES256";
        private const string ES384Value = "ES384";
        private const string ES512Value = "ES512";
        private const string ES256KValue = "ES256K";

        /// <summary> RSASSA-PKCS1-v1_5 using SHA-256 hash algorithm. </summary>
        public static SignatureAlgorithm RS256 { get; } = new SignatureAlgorithm(RS256Value);
        /// <summary> RSASSA-PKCS1-v1_5 using SHA-384 hash algorithm. </summary>
        public static SignatureAlgorithm RS384 { get; } = new SignatureAlgorithm(RS384Value);
        /// <summary> RSASSA-PKCS1-v1_5 using SHA-512 hash algorithm. </summary>
        public static SignatureAlgorithm RS512 { get; } = new SignatureAlgorithm(RS512Value);
        /// <summary> RSASSA-PSS using SHA-256 hash algorithm. </summary>
        public static SignatureAlgorithm PS256 { get; } = new SignatureAlgorithm(PS256Value);
        /// <summary> RSASSA-PSS using SHA-384 hash algorithm. </summary>
        public static SignatureAlgorithm PS384 { get; } = new SignatureAlgorithm(PS384Value);
        /// <summary> RSASSA-PSS using SHA-512 hash algorithm. </summary>
        public static SignatureAlgorithm PS512 { get; } = new SignatureAlgorithm(PS512Value);
        /// <summary> ECDSA using P-256 and SHA-256 hash algorithm. </summary>
        public static SignatureAlgorithm ES256 { get; } = new SignatureAlgorithm(ES256Value);
        /// <summary> ECDSA using P-384 and SHA-384 hash algorithm. </summary>
        public static SignatureAlgorithm ES384 { get; } = new SignatureAlgorithm(ES384Value);
        /// <summary> ECDSA using P-521 and SHA-512 hash algorithm. </summary>
        public static SignatureAlgorithm ES512 { get; } = new SignatureAlgorithm(ES512Value);
        /// <summary> ECDSA using secp256k1 and SHA-256 hash algorithm. </summary>
        public static SignatureAlgorithm ES256K { get; } = new SignatureAlgorithm(ES256KValue);
        /// <summary> Determines if two <see cref="SignatureAlgorithm"/> values are the same. </summary>
        public static bool operator ==(SignatureAlgorithm left, SignatureAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SignatureAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(SignatureAlgorithm left, SignatureAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SignatureAlgorithm"/>. </summary>
        public static implicit operator SignatureAlgorithm(string value) => new SignatureAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignatureAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SignatureAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
