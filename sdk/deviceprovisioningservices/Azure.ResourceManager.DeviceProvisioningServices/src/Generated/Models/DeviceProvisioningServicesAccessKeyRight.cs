// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Rights that this key has. </summary>
    public readonly partial struct DeviceProvisioningServicesAccessKeyRight : IEquatable<DeviceProvisioningServicesAccessKeyRight>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesAccessKeyRight"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceProvisioningServicesAccessKeyRight(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceConfigValue = "ServiceConfig";
        private const string EnrollmentReadValue = "EnrollmentRead";
        private const string EnrollmentWriteValue = "EnrollmentWrite";
        private const string DeviceConnectValue = "DeviceConnect";
        private const string RegistrationStatusReadValue = "RegistrationStatusRead";
        private const string RegistrationStatusWriteValue = "RegistrationStatusWrite";

        /// <summary> ServiceConfig. </summary>
        public static DeviceProvisioningServicesAccessKeyRight ServiceConfig { get; } = new DeviceProvisioningServicesAccessKeyRight(ServiceConfigValue);
        /// <summary> EnrollmentRead. </summary>
        public static DeviceProvisioningServicesAccessKeyRight EnrollmentRead { get; } = new DeviceProvisioningServicesAccessKeyRight(EnrollmentReadValue);
        /// <summary> EnrollmentWrite. </summary>
        public static DeviceProvisioningServicesAccessKeyRight EnrollmentWrite { get; } = new DeviceProvisioningServicesAccessKeyRight(EnrollmentWriteValue);
        /// <summary> DeviceConnect. </summary>
        public static DeviceProvisioningServicesAccessKeyRight DeviceConnect { get; } = new DeviceProvisioningServicesAccessKeyRight(DeviceConnectValue);
        /// <summary> RegistrationStatusRead. </summary>
        public static DeviceProvisioningServicesAccessKeyRight RegistrationStatusRead { get; } = new DeviceProvisioningServicesAccessKeyRight(RegistrationStatusReadValue);
        /// <summary> RegistrationStatusWrite. </summary>
        public static DeviceProvisioningServicesAccessKeyRight RegistrationStatusWrite { get; } = new DeviceProvisioningServicesAccessKeyRight(RegistrationStatusWriteValue);
        /// <summary> Determines if two <see cref="DeviceProvisioningServicesAccessKeyRight"/> values are the same. </summary>
        public static bool operator ==(DeviceProvisioningServicesAccessKeyRight left, DeviceProvisioningServicesAccessKeyRight right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceProvisioningServicesAccessKeyRight"/> values are not the same. </summary>
        public static bool operator !=(DeviceProvisioningServicesAccessKeyRight left, DeviceProvisioningServicesAccessKeyRight right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeviceProvisioningServicesAccessKeyRight"/>. </summary>
        public static implicit operator DeviceProvisioningServicesAccessKeyRight(string value) => new DeviceProvisioningServicesAccessKeyRight(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceProvisioningServicesAccessKeyRight other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceProvisioningServicesAccessKeyRight other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
