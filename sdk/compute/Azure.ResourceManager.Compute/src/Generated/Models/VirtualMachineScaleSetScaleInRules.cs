// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The VirtualMachineScaleSetScaleInRules. </summary>
    public readonly partial struct VirtualMachineScaleSetScaleInRules : IEquatable<VirtualMachineScaleSetScaleInRules>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetScaleInRules"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineScaleSetScaleInRules(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string OldestVMValue = "OldestVM";
        private const string NewestVMValue = "NewestVM";

        /// <summary> Default. </summary>
        public static VirtualMachineScaleSetScaleInRules Default { get; } = new VirtualMachineScaleSetScaleInRules(DefaultValue);
        /// <summary> OldestVM. </summary>
        public static VirtualMachineScaleSetScaleInRules OldestVM { get; } = new VirtualMachineScaleSetScaleInRules(OldestVMValue);
        /// <summary> NewestVM. </summary>
        public static VirtualMachineScaleSetScaleInRules NewestVM { get; } = new VirtualMachineScaleSetScaleInRules(NewestVMValue);
        /// <summary> Determines if two <see cref="VirtualMachineScaleSetScaleInRules"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineScaleSetScaleInRules left, VirtualMachineScaleSetScaleInRules right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineScaleSetScaleInRules"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineScaleSetScaleInRules left, VirtualMachineScaleSetScaleInRules right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualMachineScaleSetScaleInRules"/>. </summary>
        public static implicit operator VirtualMachineScaleSetScaleInRules(string value) => new VirtualMachineScaleSetScaleInRules(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineScaleSetScaleInRules other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineScaleSetScaleInRules other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
