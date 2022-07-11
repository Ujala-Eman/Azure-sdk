// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The edifact character set. </summary>
    public readonly partial struct EdifactCharacterSet : IEquatable<EdifactCharacterSet>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdifactCharacterSet"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdifactCharacterSet(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string UnobValue = "UNOB";
        private const string UnoaValue = "UNOA";
        private const string UnocValue = "UNOC";
        private const string UnodValue = "UNOD";
        private const string UnoeValue = "UNOE";
        private const string UnofValue = "UNOF";
        private const string UnogValue = "UNOG";
        private const string UnohValue = "UNOH";
        private const string UnoiValue = "UNOI";
        private const string UnojValue = "UNOJ";
        private const string UnokValue = "UNOK";
        private const string UnoxValue = "UNOX";
        private const string UnoyValue = "UNOY";
        private const string KecaValue = "KECA";

        /// <summary> NotSpecified. </summary>
        public static EdifactCharacterSet NotSpecified { get; } = new EdifactCharacterSet(NotSpecifiedValue);
        /// <summary> UNOB. </summary>
        public static EdifactCharacterSet Unob { get; } = new EdifactCharacterSet(UnobValue);
        /// <summary> UNOA. </summary>
        public static EdifactCharacterSet Unoa { get; } = new EdifactCharacterSet(UnoaValue);
        /// <summary> UNOC. </summary>
        public static EdifactCharacterSet Unoc { get; } = new EdifactCharacterSet(UnocValue);
        /// <summary> UNOD. </summary>
        public static EdifactCharacterSet Unod { get; } = new EdifactCharacterSet(UnodValue);
        /// <summary> UNOE. </summary>
        public static EdifactCharacterSet Unoe { get; } = new EdifactCharacterSet(UnoeValue);
        /// <summary> UNOF. </summary>
        public static EdifactCharacterSet Unof { get; } = new EdifactCharacterSet(UnofValue);
        /// <summary> UNOG. </summary>
        public static EdifactCharacterSet Unog { get; } = new EdifactCharacterSet(UnogValue);
        /// <summary> UNOH. </summary>
        public static EdifactCharacterSet Unoh { get; } = new EdifactCharacterSet(UnohValue);
        /// <summary> UNOI. </summary>
        public static EdifactCharacterSet Unoi { get; } = new EdifactCharacterSet(UnoiValue);
        /// <summary> UNOJ. </summary>
        public static EdifactCharacterSet Unoj { get; } = new EdifactCharacterSet(UnojValue);
        /// <summary> UNOK. </summary>
        public static EdifactCharacterSet Unok { get; } = new EdifactCharacterSet(UnokValue);
        /// <summary> UNOX. </summary>
        public static EdifactCharacterSet Unox { get; } = new EdifactCharacterSet(UnoxValue);
        /// <summary> UNOY. </summary>
        public static EdifactCharacterSet Unoy { get; } = new EdifactCharacterSet(UnoyValue);
        /// <summary> KECA. </summary>
        public static EdifactCharacterSet Keca { get; } = new EdifactCharacterSet(KecaValue);
        /// <summary> Determines if two <see cref="EdifactCharacterSet"/> values are the same. </summary>
        public static bool operator ==(EdifactCharacterSet left, EdifactCharacterSet right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdifactCharacterSet"/> values are not the same. </summary>
        public static bool operator !=(EdifactCharacterSet left, EdifactCharacterSet right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EdifactCharacterSet"/>. </summary>
        public static implicit operator EdifactCharacterSet(string value) => new EdifactCharacterSet(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdifactCharacterSet other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdifactCharacterSet other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
