// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The PolicyExportFormat. </summary>
    public readonly partial struct PolicyExportFormat : IEquatable<PolicyExportFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyExportFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyExportFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string XmlValue = "xml";
        private const string RawxmlValue = "rawxml";

        /// <summary> The contents are inline and Content type is an XML document. </summary>
        public static PolicyExportFormat Xml { get; } = new PolicyExportFormat(XmlValue);
        /// <summary> The contents are inline and Content type is a non XML encoded policy document. </summary>
        public static PolicyExportFormat Rawxml { get; } = new PolicyExportFormat(RawxmlValue);
        /// <summary> Determines if two <see cref="PolicyExportFormat"/> values are the same. </summary>
        public static bool operator ==(PolicyExportFormat left, PolicyExportFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyExportFormat"/> values are not the same. </summary>
        public static bool operator !=(PolicyExportFormat left, PolicyExportFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyExportFormat"/>. </summary>
        public static implicit operator PolicyExportFormat(string value) => new PolicyExportFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyExportFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyExportFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
