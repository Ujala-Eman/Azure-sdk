// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The provisioning state, which only appears in the response. </summary>
    public readonly partial struct GalleryProvisioningState : IEquatable<GalleryProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GalleryProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GalleryProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string DeletingValue = "Deleting";
        private const string MigratingValue = "Migrating";

        /// <summary> Creating. </summary>
        public static GalleryProvisioningState Creating { get; } = new GalleryProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static GalleryProvisioningState Updating { get; } = new GalleryProvisioningState(UpdatingValue);
        /// <summary> Failed. </summary>
        public static GalleryProvisioningState Failed { get; } = new GalleryProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static GalleryProvisioningState Succeeded { get; } = new GalleryProvisioningState(SucceededValue);
        /// <summary> Deleting. </summary>
        public static GalleryProvisioningState Deleting { get; } = new GalleryProvisioningState(DeletingValue);
        /// <summary> Migrating. </summary>
        public static GalleryProvisioningState Migrating { get; } = new GalleryProvisioningState(MigratingValue);
        /// <summary> Determines if two <see cref="GalleryProvisioningState"/> values are the same. </summary>
        public static bool operator ==(GalleryProvisioningState left, GalleryProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GalleryProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(GalleryProvisioningState left, GalleryProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GalleryProvisioningState"/>. </summary>
        public static implicit operator GalleryProvisioningState(string value) => new GalleryProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GalleryProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GalleryProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
