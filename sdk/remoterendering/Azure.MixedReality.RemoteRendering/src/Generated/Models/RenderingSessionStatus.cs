// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The status of the rendering session. Terminal states are &apos;Error&apos;, &apos;Expired&apos;, and &apos;Stopped&apos;. </summary>
    public readonly partial struct RenderingSessionStatus : IEquatable<RenderingSessionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RenderingSessionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RenderingSessionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string ExpiredValue = "Expired";
        private const string StartingValue = "Starting";
        private const string ReadyValue = "Ready";
        private const string StoppedValue = "Stopped";

        /// <summary> The rendering session has encountered an error, and is unusable. This is a terminal state. </summary>
        public static RenderingSessionStatus Error { get; } = new RenderingSessionStatus(ErrorValue);
        /// <summary> The rendering session enters the &apos;Expired&apos; state when it has been in the &apos;Ready&apos; state longer than its lease time. This is a terminal state. </summary>
        public static RenderingSessionStatus Expired { get; } = new RenderingSessionStatus(ExpiredValue);
        /// <summary> The rendering session is starting, but not accepting incoming connections yet. </summary>
        public static RenderingSessionStatus Starting { get; } = new RenderingSessionStatus(StartingValue);
        /// <summary> The rendering session is ready for incoming connections. </summary>
        public static RenderingSessionStatus Ready { get; } = new RenderingSessionStatus(ReadyValue);
        /// <summary> The rendering session has been stopped with the &apos;Stop Session&apos; operation. This is a terminal state. </summary>
        public static RenderingSessionStatus Stopped { get; } = new RenderingSessionStatus(StoppedValue);
        /// <summary> Determines if two <see cref="RenderingSessionStatus"/> values are the same. </summary>
        public static bool operator ==(RenderingSessionStatus left, RenderingSessionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RenderingSessionStatus"/> values are not the same. </summary>
        public static bool operator !=(RenderingSessionStatus left, RenderingSessionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RenderingSessionStatus"/>. </summary>
        public static implicit operator RenderingSessionStatus(string value) => new RenderingSessionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RenderingSessionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RenderingSessionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
