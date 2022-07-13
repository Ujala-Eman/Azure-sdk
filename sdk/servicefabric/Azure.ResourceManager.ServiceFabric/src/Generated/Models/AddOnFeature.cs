// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Available cluster add-on features. </summary>
    public readonly partial struct AddOnFeature : IEquatable<AddOnFeature>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AddOnFeature"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddOnFeature(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RepairManagerValue = "RepairManager";
        private const string DnsServiceValue = "DnsService";
        private const string BackupRestoreServiceValue = "BackupRestoreService";
        private const string ResourceMonitorServiceValue = "ResourceMonitorService";

        /// <summary> RepairManager. </summary>
        public static AddOnFeature RepairManager { get; } = new AddOnFeature(RepairManagerValue);
        /// <summary> DnsService. </summary>
        public static AddOnFeature DnsService { get; } = new AddOnFeature(DnsServiceValue);
        /// <summary> BackupRestoreService. </summary>
        public static AddOnFeature BackupRestoreService { get; } = new AddOnFeature(BackupRestoreServiceValue);
        /// <summary> ResourceMonitorService. </summary>
        public static AddOnFeature ResourceMonitorService { get; } = new AddOnFeature(ResourceMonitorServiceValue);
        /// <summary> Determines if two <see cref="AddOnFeature"/> values are the same. </summary>
        public static bool operator ==(AddOnFeature left, AddOnFeature right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddOnFeature"/> values are not the same. </summary>
        public static bool operator !=(AddOnFeature left, AddOnFeature right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddOnFeature"/>. </summary>
        public static implicit operator AddOnFeature(string value) => new AddOnFeature(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddOnFeature other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddOnFeature other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
