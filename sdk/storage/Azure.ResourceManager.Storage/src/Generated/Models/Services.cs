// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f). </summary>
    public readonly partial struct Services : IEquatable<Services>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Services"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Services(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BValue = "b";
        private const string QValue = "q";
        private const string TValue = "t";
        private const string FValue = "f";

        /// <summary> b. </summary>
        public static Services B { get; } = new Services(BValue);
        /// <summary> q. </summary>
        public static Services Q { get; } = new Services(QValue);
        /// <summary> t. </summary>
        public static Services T { get; } = new Services(TValue);
        /// <summary> f. </summary>
        public static Services F { get; } = new Services(FValue);
        /// <summary> Determines if two <see cref="Services"/> values are the same. </summary>
        public static bool operator ==(Services left, Services right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Services"/> values are not the same. </summary>
        public static bool operator !=(Services left, Services right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Services"/>. </summary>
        public static implicit operator Services(string value) => new Services(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Services other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Services other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
