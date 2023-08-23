// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> The RouterJobStatusSelector. </summary>
    public readonly partial struct RouterJobStatusSelector : IEquatable<RouterJobStatusSelector>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouterJobStatusSelector"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouterJobStatusSelector(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "all";
        private const string PendingClassificationValue = "pendingClassification";
        private const string QueuedValue = "queued";
        private const string AssignedValue = "assigned";
        private const string CompletedValue = "completed";
        private const string ClosedValue = "closed";
        private const string CancelledValue = "cancelled";
        private const string ClassificationFailedValue = "classificationFailed";
        private const string CreatedValue = "created";
        private const string PendingScheduleValue = "pendingSchedule";
        private const string ScheduledValue = "scheduled";
        private const string ScheduleFailedValue = "scheduleFailed";
        private const string WaitingForActivationValue = "waitingForActivation";
        private const string ActiveValue = "active";

        /// <summary> all. </summary>
        public static RouterJobStatusSelector All { get; } = new RouterJobStatusSelector(AllValue);
        /// <summary> pendingClassification. </summary>
        public static RouterJobStatusSelector PendingClassification { get; } = new RouterJobStatusSelector(PendingClassificationValue);
        /// <summary> queued. </summary>
        public static RouterJobStatusSelector Queued { get; } = new RouterJobStatusSelector(QueuedValue);
        /// <summary> assigned. </summary>
        public static RouterJobStatusSelector Assigned { get; } = new RouterJobStatusSelector(AssignedValue);
        /// <summary> completed. </summary>
        public static RouterJobStatusSelector Completed { get; } = new RouterJobStatusSelector(CompletedValue);
        /// <summary> closed. </summary>
        public static RouterJobStatusSelector Closed { get; } = new RouterJobStatusSelector(ClosedValue);
        /// <summary> cancelled. </summary>
        public static RouterJobStatusSelector Cancelled { get; } = new RouterJobStatusSelector(CancelledValue);
        /// <summary> classificationFailed. </summary>
        public static RouterJobStatusSelector ClassificationFailed { get; } = new RouterJobStatusSelector(ClassificationFailedValue);
        /// <summary> created. </summary>
        public static RouterJobStatusSelector Created { get; } = new RouterJobStatusSelector(CreatedValue);
        /// <summary> pendingSchedule. </summary>
        public static RouterJobStatusSelector PendingSchedule { get; } = new RouterJobStatusSelector(PendingScheduleValue);
        /// <summary> scheduled. </summary>
        public static RouterJobStatusSelector Scheduled { get; } = new RouterJobStatusSelector(ScheduledValue);
        /// <summary> scheduleFailed. </summary>
        public static RouterJobStatusSelector ScheduleFailed { get; } = new RouterJobStatusSelector(ScheduleFailedValue);
        /// <summary> waitingForActivation. </summary>
        public static RouterJobStatusSelector WaitingForActivation { get; } = new RouterJobStatusSelector(WaitingForActivationValue);
        /// <summary> active. </summary>
        public static RouterJobStatusSelector Active { get; } = new RouterJobStatusSelector(ActiveValue);
        /// <summary> Determines if two <see cref="RouterJobStatusSelector"/> values are the same. </summary>
        public static bool operator ==(RouterJobStatusSelector left, RouterJobStatusSelector right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouterJobStatusSelector"/> values are not the same. </summary>
        public static bool operator !=(RouterJobStatusSelector left, RouterJobStatusSelector right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouterJobStatusSelector"/>. </summary>
        public static implicit operator RouterJobStatusSelector(string value) => new RouterJobStatusSelector(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouterJobStatusSelector other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouterJobStatusSelector other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
