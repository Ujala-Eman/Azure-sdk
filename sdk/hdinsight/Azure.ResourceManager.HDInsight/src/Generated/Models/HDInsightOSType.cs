// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The type of operating system. </summary>
    public readonly partial struct HDInsightOSType : IEquatable<HDInsightOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";

        /// <summary> Windows. </summary>
        public static HDInsightOSType Windows { get; } = new HDInsightOSType(WindowsValue);
        /// <summary> Linux. </summary>
        public static HDInsightOSType Linux { get; } = new HDInsightOSType(LinuxValue);
        /// <summary> Determines if two <see cref="HDInsightOSType"/> values are the same. </summary>
        public static bool operator ==(HDInsightOSType left, HDInsightOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightOSType"/> values are not the same. </summary>
        public static bool operator !=(HDInsightOSType left, HDInsightOSType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightOSType"/>. </summary>
        public static implicit operator HDInsightOSType(string value) => new HDInsightOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
