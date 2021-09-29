// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.DeviceUpdate.Models
{
    /// <summary> Deployment state. </summary>
    public readonly partial struct DeviceDeploymentState : IEquatable<DeviceDeploymentState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceDeploymentState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceDeploymentState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string InProgressValue = "InProgress";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string IncompatibleValue = "Incompatible";

        /// <summary> Deployment has completed with success. </summary>
        public static DeviceDeploymentState Succeeded { get; } = new DeviceDeploymentState(SucceededValue);
        /// <summary> Deployment is in progress. </summary>
        public static DeviceDeploymentState InProgress { get; } = new DeviceDeploymentState(InProgressValue);
        /// <summary> Deployment has completed with failure. </summary>
        public static DeviceDeploymentState Failed { get; } = new DeviceDeploymentState(FailedValue);
        /// <summary> Deployment was canceled. </summary>
        public static DeviceDeploymentState Canceled { get; } = new DeviceDeploymentState(CanceledValue);
        /// <summary> Deployment is not compatible with the device. </summary>
        public static DeviceDeploymentState Incompatible { get; } = new DeviceDeploymentState(IncompatibleValue);
        /// <summary> Determines if two <see cref="DeviceDeploymentState"/> values are the same. </summary>
        public static bool operator ==(DeviceDeploymentState left, DeviceDeploymentState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceDeploymentState"/> values are not the same. </summary>
        public static bool operator !=(DeviceDeploymentState left, DeviceDeploymentState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeviceDeploymentState"/>. </summary>
        public static implicit operator DeviceDeploymentState(string value) => new DeviceDeploymentState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceDeploymentState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceDeploymentState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
