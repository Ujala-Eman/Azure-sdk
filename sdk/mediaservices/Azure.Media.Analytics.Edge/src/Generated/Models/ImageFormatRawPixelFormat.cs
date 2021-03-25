// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> The pixel format that will be used to encode images. </summary>
    public readonly partial struct ImageFormatRawPixelFormat : IEquatable<ImageFormatRawPixelFormat>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ImageFormatRawPixelFormat"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageFormatRawPixelFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Yuv420PValue = "yuv420p";
        private const string Rgb565BeValue = "rgb565be";
        private const string Rgb565LeValue = "rgb565le";
        private const string Rgb555BeValue = "rgb555be";
        private const string Rgb555LeValue = "rgb555le";
        private const string Rgb24Value = "rgb24";
        private const string Bgr24Value = "bgr24";
        private const string ArgbValue = "argb";
        private const string RgbaValue = "rgba";
        private const string AbgrValue = "abgr";
        private const string BgraValue = "bgra";

        /// <summary> Planar YUV 4:2:0, 12bpp, (1 Cr and Cb sample per 2x2 Y samples). </summary>
        public static ImageFormatRawPixelFormat Yuv420P { get; } = new ImageFormatRawPixelFormat(Yuv420PValue);
        /// <summary> Packed RGB 5:6:5, 16bpp, (msb)   5R 6G 5B(lsb), big-endian. </summary>
        public static ImageFormatRawPixelFormat Rgb565Be { get; } = new ImageFormatRawPixelFormat(Rgb565BeValue);
        /// <summary> Packed RGB 5:6:5, 16bpp, (msb)   5R 6G 5B(lsb), little-endian. </summary>
        public static ImageFormatRawPixelFormat Rgb565Le { get; } = new ImageFormatRawPixelFormat(Rgb565LeValue);
        /// <summary> Packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), big-endian , X=unused/undefined. </summary>
        public static ImageFormatRawPixelFormat Rgb555Be { get; } = new ImageFormatRawPixelFormat(Rgb555BeValue);
        /// <summary> Packed RGB 5:5:5, 16bpp, (msb)1X 5R 5G 5B(lsb), little-endian, X=unused/undefined. </summary>
        public static ImageFormatRawPixelFormat Rgb555Le { get; } = new ImageFormatRawPixelFormat(Rgb555LeValue);
        /// <summary> Packed RGB 8:8:8, 24bpp, RGBRGB. </summary>
        public static ImageFormatRawPixelFormat Rgb24 { get; } = new ImageFormatRawPixelFormat(Rgb24Value);
        /// <summary> Packed RGB 8:8:8, 24bpp, BGRBGR. </summary>
        public static ImageFormatRawPixelFormat Bgr24 { get; } = new ImageFormatRawPixelFormat(Bgr24Value);
        /// <summary> Packed ARGB 8:8:8:8, 32bpp, ARGBARGB. </summary>
        public static ImageFormatRawPixelFormat Argb { get; } = new ImageFormatRawPixelFormat(ArgbValue);
        /// <summary> Packed RGBA 8:8:8:8, 32bpp, RGBARGBA. </summary>
        public static ImageFormatRawPixelFormat Rgba { get; } = new ImageFormatRawPixelFormat(RgbaValue);
        /// <summary> Packed ABGR 8:8:8:8, 32bpp, ABGRABGR. </summary>
        public static ImageFormatRawPixelFormat Abgr { get; } = new ImageFormatRawPixelFormat(AbgrValue);
        /// <summary> Packed BGRA 8:8:8:8, 32bpp, BGRABGRA. </summary>
        public static ImageFormatRawPixelFormat Bgra { get; } = new ImageFormatRawPixelFormat(BgraValue);
        /// <summary> Determines if two <see cref="ImageFormatRawPixelFormat"/> values are the same. </summary>
        public static bool operator ==(ImageFormatRawPixelFormat left, ImageFormatRawPixelFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageFormatRawPixelFormat"/> values are not the same. </summary>
        public static bool operator !=(ImageFormatRawPixelFormat left, ImageFormatRawPixelFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImageFormatRawPixelFormat"/>. </summary>
        public static implicit operator ImageFormatRawPixelFormat(string value) => new ImageFormatRawPixelFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageFormatRawPixelFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageFormatRawPixelFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
