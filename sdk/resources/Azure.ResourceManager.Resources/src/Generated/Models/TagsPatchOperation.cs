// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The operation type for the patch API. </summary>
    public readonly partial struct TagsPatchOperation : IEquatable<TagsPatchOperation>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TagsPatchOperation"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TagsPatchOperation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReplaceValue = "Replace";
        private const string MergeValue = "Merge";
        private const string DeleteValue = "Delete";

        /// <summary> The &apos;replace&apos; option replaces the entire set of existing tags with a new set. </summary>
        public static TagsPatchOperation Replace { get; } = new TagsPatchOperation(ReplaceValue);
        /// <summary> The &apos;merge&apos; option allows adding tags with new names and updating the values of tags with existing names. </summary>
        public static TagsPatchOperation Merge { get; } = new TagsPatchOperation(MergeValue);
        /// <summary> The &apos;delete&apos; option allows selectively deleting tags based on given names or name/value pairs. </summary>
        public static TagsPatchOperation Delete { get; } = new TagsPatchOperation(DeleteValue);
        /// <summary> Determines if two <see cref="TagsPatchOperation"/> values are the same. </summary>
        public static bool operator ==(TagsPatchOperation left, TagsPatchOperation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TagsPatchOperation"/> values are not the same. </summary>
        public static bool operator !=(TagsPatchOperation left, TagsPatchOperation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TagsPatchOperation"/>. </summary>
        public static implicit operator TagsPatchOperation(string value) => new TagsPatchOperation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TagsPatchOperation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TagsPatchOperation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
