// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The recurrence frequency. </summary>
    public readonly partial struct LogicWorkflowTriggerRecurrenceFrequency : IEquatable<LogicWorkflowTriggerRecurrenceFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowTriggerRecurrenceFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicWorkflowTriggerRecurrenceFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string SecondValue = "Second";
        private const string MinuteValue = "Minute";
        private const string HourValue = "Hour";
        private const string DayValue = "Day";
        private const string WeekValue = "Week";
        private const string MonthValue = "Month";
        private const string YearValue = "Year";

        /// <summary> NotSpecified. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency NotSpecified { get; } = new LogicWorkflowTriggerRecurrenceFrequency(NotSpecifiedValue);
        /// <summary> Second. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Second { get; } = new LogicWorkflowTriggerRecurrenceFrequency(SecondValue);
        /// <summary> Minute. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Minute { get; } = new LogicWorkflowTriggerRecurrenceFrequency(MinuteValue);
        /// <summary> Hour. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Hour { get; } = new LogicWorkflowTriggerRecurrenceFrequency(HourValue);
        /// <summary> Day. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Day { get; } = new LogicWorkflowTriggerRecurrenceFrequency(DayValue);
        /// <summary> Week. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Week { get; } = new LogicWorkflowTriggerRecurrenceFrequency(WeekValue);
        /// <summary> Month. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Month { get; } = new LogicWorkflowTriggerRecurrenceFrequency(MonthValue);
        /// <summary> Year. </summary>
        public static LogicWorkflowTriggerRecurrenceFrequency Year { get; } = new LogicWorkflowTriggerRecurrenceFrequency(YearValue);
        /// <summary> Determines if two <see cref="LogicWorkflowTriggerRecurrenceFrequency"/> values are the same. </summary>
        public static bool operator ==(LogicWorkflowTriggerRecurrenceFrequency left, LogicWorkflowTriggerRecurrenceFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicWorkflowTriggerRecurrenceFrequency"/> values are not the same. </summary>
        public static bool operator !=(LogicWorkflowTriggerRecurrenceFrequency left, LogicWorkflowTriggerRecurrenceFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogicWorkflowTriggerRecurrenceFrequency"/>. </summary>
        public static implicit operator LogicWorkflowTriggerRecurrenceFrequency(string value) => new LogicWorkflowTriggerRecurrenceFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicWorkflowTriggerRecurrenceFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicWorkflowTriggerRecurrenceFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
