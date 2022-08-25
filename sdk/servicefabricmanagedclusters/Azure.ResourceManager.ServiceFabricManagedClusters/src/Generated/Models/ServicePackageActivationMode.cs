// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The activation Mode of the service package. </summary>
    public readonly partial struct ServicePackageActivationMode : IEquatable<ServicePackageActivationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServicePackageActivationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServicePackageActivationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharedProcessValue = "SharedProcess";
        private const string ExclusiveProcessValue = "ExclusiveProcess";

        /// <summary> Indicates the application package activation mode will use shared process. </summary>
        public static ServicePackageActivationMode SharedProcess { get; } = new ServicePackageActivationMode(SharedProcessValue);
        /// <summary> Indicates the application package activation mode will use exclusive process. </summary>
        public static ServicePackageActivationMode ExclusiveProcess { get; } = new ServicePackageActivationMode(ExclusiveProcessValue);
        /// <summary> Determines if two <see cref="ServicePackageActivationMode"/> values are the same. </summary>
        public static bool operator ==(ServicePackageActivationMode left, ServicePackageActivationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServicePackageActivationMode"/> values are not the same. </summary>
        public static bool operator !=(ServicePackageActivationMode left, ServicePackageActivationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServicePackageActivationMode"/>. </summary>
        public static implicit operator ServicePackageActivationMode(string value) => new ServicePackageActivationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServicePackageActivationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServicePackageActivationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
