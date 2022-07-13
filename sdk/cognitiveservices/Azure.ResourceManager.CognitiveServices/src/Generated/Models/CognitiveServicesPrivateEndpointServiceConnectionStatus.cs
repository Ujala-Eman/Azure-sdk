// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct CognitiveServicesPrivateEndpointServiceConnectionStatus : IEquatable<CognitiveServicesPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CognitiveServicesPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static CognitiveServicesPrivateEndpointServiceConnectionStatus Pending { get; } = new CognitiveServicesPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static CognitiveServicesPrivateEndpointServiceConnectionStatus Approved { get; } = new CognitiveServicesPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static CognitiveServicesPrivateEndpointServiceConnectionStatus Rejected { get; } = new CognitiveServicesPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="CognitiveServicesPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(CognitiveServicesPrivateEndpointServiceConnectionStatus left, CognitiveServicesPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CognitiveServicesPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(CognitiveServicesPrivateEndpointServiceConnectionStatus left, CognitiveServicesPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CognitiveServicesPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator CognitiveServicesPrivateEndpointServiceConnectionStatus(string value) => new CognitiveServicesPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CognitiveServicesPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CognitiveServicesPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
