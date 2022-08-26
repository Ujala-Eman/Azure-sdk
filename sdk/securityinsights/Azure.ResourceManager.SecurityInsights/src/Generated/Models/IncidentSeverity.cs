// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The severity of the incident. </summary>
    public readonly partial struct IncidentSeverity : IEquatable<IncidentSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IncidentSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IncidentSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HighValue = "High";
        private const string MediumValue = "Medium";
        private const string LowValue = "Low";
        private const string InformationalValue = "Informational";

        /// <summary> High severity. </summary>
        public static IncidentSeverity High { get; } = new IncidentSeverity(HighValue);
        /// <summary> Medium severity. </summary>
        public static IncidentSeverity Medium { get; } = new IncidentSeverity(MediumValue);
        /// <summary> Low severity. </summary>
        public static IncidentSeverity Low { get; } = new IncidentSeverity(LowValue);
        /// <summary> Informational severity. </summary>
        public static IncidentSeverity Informational { get; } = new IncidentSeverity(InformationalValue);
        /// <summary> Determines if two <see cref="IncidentSeverity"/> values are the same. </summary>
        public static bool operator ==(IncidentSeverity left, IncidentSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IncidentSeverity"/> values are not the same. </summary>
        public static bool operator !=(IncidentSeverity left, IncidentSeverity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IncidentSeverity"/>. </summary>
        public static implicit operator IncidentSeverity(string value) => new IncidentSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IncidentSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IncidentSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
