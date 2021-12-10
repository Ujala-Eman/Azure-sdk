// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.Catalog.Models
{
    /// <summary> Enum of the status of import csv operation. </summary>
    public readonly partial struct ImportCSVOperationStatus : IEquatable<ImportCSVOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImportCSVOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImportCSVOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string RunningValue = "Running";

        /// <summary> NotStarted. </summary>
        public static ImportCSVOperationStatus NotStarted { get; } = new ImportCSVOperationStatus(NotStartedValue);
        /// <summary> Succeeded. </summary>
        public static ImportCSVOperationStatus Succeeded { get; } = new ImportCSVOperationStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static ImportCSVOperationStatus Failed { get; } = new ImportCSVOperationStatus(FailedValue);
        /// <summary> Running. </summary>
        public static ImportCSVOperationStatus Running { get; } = new ImportCSVOperationStatus(RunningValue);
        /// <summary> Determines if two <see cref="ImportCSVOperationStatus"/> values are the same. </summary>
        public static bool operator ==(ImportCSVOperationStatus left, ImportCSVOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImportCSVOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(ImportCSVOperationStatus left, ImportCSVOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImportCSVOperationStatus"/>. </summary>
        public static implicit operator ImportCSVOperationStatus(string value) => new ImportCSVOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImportCSVOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImportCSVOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
