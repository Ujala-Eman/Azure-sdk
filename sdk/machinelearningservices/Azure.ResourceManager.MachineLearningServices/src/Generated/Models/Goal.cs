// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Defines supported metric goals for hyperparameter tuning. </summary>
    public readonly partial struct Goal : IEquatable<Goal>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Goal"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Goal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MinimizeValue = "Minimize";
        private const string MaximizeValue = "Maximize";

        /// <summary> Minimize. </summary>
        public static Goal Minimize { get; } = new Goal(MinimizeValue);
        /// <summary> Maximize. </summary>
        public static Goal Maximize { get; } = new Goal(MaximizeValue);
        /// <summary> Determines if two <see cref="Goal"/> values are the same. </summary>
        public static bool operator ==(Goal left, Goal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Goal"/> values are not the same. </summary>
        public static bool operator !=(Goal left, Goal right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Goal"/>. </summary>
        public static implicit operator Goal(string value) => new Goal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Goal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Goal other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
