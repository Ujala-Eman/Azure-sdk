// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SchedulerCurrentState. </summary>
    public readonly partial struct SchedulerCurrentState : IEquatable<SchedulerCurrentState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SchedulerCurrentState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SchedulerCurrentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueuedValue = "Queued";
        private const string ScheduledValue = "Scheduled";
        private const string EndedValue = "Ended";

        /// <summary> Queued. </summary>
        public static SchedulerCurrentState Queued { get; } = new SchedulerCurrentState(QueuedValue);
        /// <summary> Scheduled. </summary>
        public static SchedulerCurrentState Scheduled { get; } = new SchedulerCurrentState(ScheduledValue);
        /// <summary> Ended. </summary>
        public static SchedulerCurrentState Ended { get; } = new SchedulerCurrentState(EndedValue);
        /// <summary> Determines if two <see cref="SchedulerCurrentState"/> values are the same. </summary>
        public static bool operator ==(SchedulerCurrentState left, SchedulerCurrentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SchedulerCurrentState"/> values are not the same. </summary>
        public static bool operator !=(SchedulerCurrentState left, SchedulerCurrentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SchedulerCurrentState"/>. </summary>
        public static implicit operator SchedulerCurrentState(string value) => new SchedulerCurrentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SchedulerCurrentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SchedulerCurrentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
