// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of the base image dependency. </summary>
    public readonly partial struct BaseImageDependencyType : IEquatable<BaseImageDependencyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BaseImageDependencyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BaseImageDependencyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BuildTimeValue = "BuildTime";
        private const string RunTimeValue = "RunTime";

        /// <summary> BuildTime. </summary>
        public static BaseImageDependencyType BuildTime { get; } = new BaseImageDependencyType(BuildTimeValue);
        /// <summary> RunTime. </summary>
        public static BaseImageDependencyType RunTime { get; } = new BaseImageDependencyType(RunTimeValue);
        /// <summary> Determines if two <see cref="BaseImageDependencyType"/> values are the same. </summary>
        public static bool operator ==(BaseImageDependencyType left, BaseImageDependencyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BaseImageDependencyType"/> values are not the same. </summary>
        public static bool operator !=(BaseImageDependencyType left, BaseImageDependencyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BaseImageDependencyType"/>. </summary>
        public static implicit operator BaseImageDependencyType(string value) => new BaseImageDependencyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BaseImageDependencyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BaseImageDependencyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
