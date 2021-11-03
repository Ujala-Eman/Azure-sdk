// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> Conflict resolution policy of the sync group. </summary>
    public readonly partial struct SyncConflictResolutionPolicy : IEquatable<SyncConflictResolutionPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyncConflictResolutionPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncConflictResolutionPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HubWinValue = "HubWin";
        private const string MemberWinValue = "MemberWin";

        /// <summary> HubWin. </summary>
        public static SyncConflictResolutionPolicy HubWin { get; } = new SyncConflictResolutionPolicy(HubWinValue);
        /// <summary> MemberWin. </summary>
        public static SyncConflictResolutionPolicy MemberWin { get; } = new SyncConflictResolutionPolicy(MemberWinValue);
        /// <summary> Determines if two <see cref="SyncConflictResolutionPolicy"/> values are the same. </summary>
        public static bool operator ==(SyncConflictResolutionPolicy left, SyncConflictResolutionPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncConflictResolutionPolicy"/> values are not the same. </summary>
        public static bool operator !=(SyncConflictResolutionPolicy left, SyncConflictResolutionPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SyncConflictResolutionPolicy"/>. </summary>
        public static implicit operator SyncConflictResolutionPolicy(string value) => new SyncConflictResolutionPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncConflictResolutionPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncConflictResolutionPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
