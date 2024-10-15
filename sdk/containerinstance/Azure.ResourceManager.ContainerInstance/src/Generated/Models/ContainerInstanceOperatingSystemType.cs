// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The operating system type required by the containers in the container group. </summary>
    public readonly partial struct ContainerInstanceOperatingSystemType : IEquatable<ContainerInstanceOperatingSystemType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerInstanceOperatingSystemType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerInstanceOperatingSystemType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";

        /// <summary> Windows. </summary>
        public static ContainerInstanceOperatingSystemType Windows { get; } = new ContainerInstanceOperatingSystemType(WindowsValue);
        /// <summary> Linux. </summary>
        public static ContainerInstanceOperatingSystemType Linux { get; } = new ContainerInstanceOperatingSystemType(LinuxValue);
        /// <summary> Determines if two <see cref="ContainerInstanceOperatingSystemType"/> values are the same. </summary>
        public static bool operator ==(ContainerInstanceOperatingSystemType left, ContainerInstanceOperatingSystemType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerInstanceOperatingSystemType"/> values are not the same. </summary>
        public static bool operator !=(ContainerInstanceOperatingSystemType left, ContainerInstanceOperatingSystemType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerInstanceOperatingSystemType"/>. </summary>
        public static implicit operator ContainerInstanceOperatingSystemType(string value) => new ContainerInstanceOperatingSystemType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerInstanceOperatingSystemType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerInstanceOperatingSystemType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
