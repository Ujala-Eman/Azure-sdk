// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Allow or deny public network access for AKS. </summary>
    public readonly partial struct ContainerServicePublicNetworkAccess : IEquatable<ContainerServicePublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServicePublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServicePublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ContainerServicePublicNetworkAccess Enabled { get; } = new ContainerServicePublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ContainerServicePublicNetworkAccess Disabled { get; } = new ContainerServicePublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="ContainerServicePublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(ContainerServicePublicNetworkAccess left, ContainerServicePublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServicePublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(ContainerServicePublicNetworkAccess left, ContainerServicePublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServicePublicNetworkAccess"/>. </summary>
        public static implicit operator ContainerServicePublicNetworkAccess(string value) => new ContainerServicePublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServicePublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServicePublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
