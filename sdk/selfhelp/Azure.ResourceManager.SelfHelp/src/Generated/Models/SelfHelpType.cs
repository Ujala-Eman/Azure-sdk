// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Type of Troubleshooting step. </summary>
    public readonly partial struct SelfHelpType : IEquatable<SelfHelpType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SelfHelpType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SelfHelpType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DecisionValue = "Decision";
        private const string SolutionValue = "Solution";
        private const string InsightValue = "Insight";
        private const string AutomatedCheckValue = "AutomatedCheck";
        private const string InputValue = "Input";

        /// <summary> Decision. </summary>
        public static SelfHelpType Decision { get; } = new SelfHelpType(DecisionValue);
        /// <summary> Solution. </summary>
        public static SelfHelpType Solution { get; } = new SelfHelpType(SolutionValue);
        /// <summary> Insight. </summary>
        public static SelfHelpType Insight { get; } = new SelfHelpType(InsightValue);
        /// <summary> AutomatedCheck. </summary>
        public static SelfHelpType AutomatedCheck { get; } = new SelfHelpType(AutomatedCheckValue);
        /// <summary> Input. </summary>
        public static SelfHelpType Input { get; } = new SelfHelpType(InputValue);
        /// <summary> Determines if two <see cref="SelfHelpType"/> values are the same. </summary>
        public static bool operator ==(SelfHelpType left, SelfHelpType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SelfHelpType"/> values are not the same. </summary>
        public static bool operator !=(SelfHelpType left, SelfHelpType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SelfHelpType"/>. </summary>
        public static implicit operator SelfHelpType(string value) => new SelfHelpType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SelfHelpType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SelfHelpType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
