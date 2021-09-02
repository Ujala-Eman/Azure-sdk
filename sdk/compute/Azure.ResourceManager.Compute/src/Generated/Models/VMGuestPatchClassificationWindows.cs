// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The VMGuestPatchClassificationWindows. </summary>
    public readonly partial struct VMGuestPatchClassificationWindows : IEquatable<VMGuestPatchClassificationWindows>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VMGuestPatchClassificationWindows"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VMGuestPatchClassificationWindows(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CriticalValue = "Critical";
        private const string SecurityValue = "Security";
        private const string UpdateRollUpValue = "UpdateRollUp";
        private const string FeaturePackValue = "FeaturePack";
        private const string ServicePackValue = "ServicePack";
        private const string DefinitionValue = "Definition";
        private const string ToolsValue = "Tools";
        private const string UpdatesValue = "Updates";

        /// <summary> Critical. </summary>
        public static VMGuestPatchClassificationWindows Critical { get; } = new VMGuestPatchClassificationWindows(CriticalValue);
        /// <summary> Security. </summary>
        public static VMGuestPatchClassificationWindows Security { get; } = new VMGuestPatchClassificationWindows(SecurityValue);
        /// <summary> UpdateRollUp. </summary>
        public static VMGuestPatchClassificationWindows UpdateRollUp { get; } = new VMGuestPatchClassificationWindows(UpdateRollUpValue);
        /// <summary> FeaturePack. </summary>
        public static VMGuestPatchClassificationWindows FeaturePack { get; } = new VMGuestPatchClassificationWindows(FeaturePackValue);
        /// <summary> ServicePack. </summary>
        public static VMGuestPatchClassificationWindows ServicePack { get; } = new VMGuestPatchClassificationWindows(ServicePackValue);
        /// <summary> Definition. </summary>
        public static VMGuestPatchClassificationWindows Definition { get; } = new VMGuestPatchClassificationWindows(DefinitionValue);
        /// <summary> Tools. </summary>
        public static VMGuestPatchClassificationWindows Tools { get; } = new VMGuestPatchClassificationWindows(ToolsValue);
        /// <summary> Updates. </summary>
        public static VMGuestPatchClassificationWindows Updates { get; } = new VMGuestPatchClassificationWindows(UpdatesValue);
        /// <summary> Determines if two <see cref="VMGuestPatchClassificationWindows"/> values are the same. </summary>
        public static bool operator ==(VMGuestPatchClassificationWindows left, VMGuestPatchClassificationWindows right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VMGuestPatchClassificationWindows"/> values are not the same. </summary>
        public static bool operator !=(VMGuestPatchClassificationWindows left, VMGuestPatchClassificationWindows right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VMGuestPatchClassificationWindows"/>. </summary>
        public static implicit operator VMGuestPatchClassificationWindows(string value) => new VMGuestPatchClassificationWindows(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VMGuestPatchClassificationWindows other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VMGuestPatchClassificationWindows other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
