// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> Specifies the ephemeral disk placement for operating system disk for all compute nodes (VMs) in the pool.  This property can be used by user in the request to choose which location the operating system should be in. e.g., cache disk space for Ephemeral OS disk provisioning. For more information on Ephemeral OS disk size requirements, please refer to Ephemeral OS disk size requirements for Windows VMs at https://docs.microsoft.com/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements and Linux VMs at https://docs.microsoft.com/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements. </summary>
    public readonly partial struct DiffDiskPlacement : IEquatable<DiffDiskPlacement>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiffDiskPlacement"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiffDiskPlacement(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CacheDiskValue = "cachedisk";

        /// <summary> The Ephemeral OS Disk is stored on the VM cache. </summary>
        public static DiffDiskPlacement CacheDisk { get; } = new DiffDiskPlacement(CacheDiskValue);
        /// <summary> Determines if two <see cref="DiffDiskPlacement"/> values are the same. </summary>
        public static bool operator ==(DiffDiskPlacement left, DiffDiskPlacement right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiffDiskPlacement"/> values are not the same. </summary>
        public static bool operator !=(DiffDiskPlacement left, DiffDiskPlacement right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiffDiskPlacement"/>. </summary>
        public static implicit operator DiffDiskPlacement(string value) => new DiffDiskPlacement(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiffDiskPlacement other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiffDiskPlacement other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
