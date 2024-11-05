// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration state. </summary>
    public readonly partial struct PostgreSqlMigrationState : IEquatable<PostgreSqlMigrationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlMigrationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string WaitingForUserActionValue = "WaitingForUserAction";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string ValidationFailedValue = "ValidationFailed";
        private const string CleaningUpValue = "CleaningUp";

        /// <summary> InProgress. </summary>
        public static PostgreSqlMigrationState InProgress { get; } = new PostgreSqlMigrationState(InProgressValue);
        /// <summary> WaitingForUserAction. </summary>
        public static PostgreSqlMigrationState WaitingForUserAction { get; } = new PostgreSqlMigrationState(WaitingForUserActionValue);
        /// <summary> Canceled. </summary>
        public static PostgreSqlMigrationState Canceled { get; } = new PostgreSqlMigrationState(CanceledValue);
        /// <summary> Failed. </summary>
        public static PostgreSqlMigrationState Failed { get; } = new PostgreSqlMigrationState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static PostgreSqlMigrationState Succeeded { get; } = new PostgreSqlMigrationState(SucceededValue);
        /// <summary> ValidationFailed. </summary>
        public static PostgreSqlMigrationState ValidationFailed { get; } = new PostgreSqlMigrationState(ValidationFailedValue);
        /// <summary> CleaningUp. </summary>
        public static PostgreSqlMigrationState CleaningUp { get; } = new PostgreSqlMigrationState(CleaningUpValue);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationState"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlMigrationState left, PostgreSqlMigrationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationState"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlMigrationState left, PostgreSqlMigrationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlMigrationState"/>. </summary>
        public static implicit operator PostgreSqlMigrationState(string value) => new PostgreSqlMigrationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlMigrationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlMigrationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
