// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.Maps.Weather.Models
{
    /// <summary> The DailyDuration. </summary>
    public readonly partial struct DailyDuration : IEquatable<DailyDuration>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="DailyDuration"/>. </summary>
        public DailyDuration(int value)
        {
            _value = value;
        }

        private const int OneDayValue = 1;
        private const int TwoDaysValue = 2;
        private const int ThreeDaysValue = 3;
        private const int FourDaysValue = 4;
        private const int FiveDaysValue = 5;
        private const int SixDaysValue = 6;
        private const int SevenDaysValue = 7;

        /// <summary> 1 day. </summary>
        public static DailyDuration OneDay { get; } = new DailyDuration(OneDayValue);
        /// <summary> 2 days. </summary>
        public static DailyDuration TwoDays { get; } = new DailyDuration(TwoDaysValue);
        /// <summary> 3 days. </summary>
        public static DailyDuration ThreeDays { get; } = new DailyDuration(ThreeDaysValue);
        /// <summary> 4 days. </summary>
        public static DailyDuration FourDays { get; } = new DailyDuration(FourDaysValue);
        /// <summary> 5 days. </summary>
        public static DailyDuration FiveDays { get; } = new DailyDuration(FiveDaysValue);
        /// <summary> 6 days. </summary>
        public static DailyDuration SixDays { get; } = new DailyDuration(SixDaysValue);
        /// <summary> 7 days. </summary>
        public static DailyDuration SevenDays { get; } = new DailyDuration(SevenDaysValue);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="DailyDuration"/> values are the same. </summary>
        public static bool operator ==(DailyDuration left, DailyDuration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DailyDuration"/> values are not the same. </summary>
        public static bool operator !=(DailyDuration left, DailyDuration right) => !left.Equals(right);
        /// <summary> Converts a <see cref="int"/> to a <see cref="DailyDuration"/>. </summary>
        public static implicit operator DailyDuration(int value) => new DailyDuration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DailyDuration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DailyDuration other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
