// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    internal static class FormContentTypeExtensions
    {
        public static string ToSerialString(this FormContentType value) => value switch
        {
            FormContentType.Pdf => "application/pdf",
            FormContentType.Jpeg => "image/jpeg",
            FormContentType.Png => "image/png",
            FormContentType.Tiff => "image/tiff",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FormContentType value.")
        };

        public static FormContentType ToFormContentType(this string value)
        {
            if (string.Equals(value, "application/pdf", StringComparison.InvariantCultureIgnoreCase)) return FormContentType.Pdf;
            if (string.Equals(value, "image/jpeg", StringComparison.InvariantCultureIgnoreCase)) return FormContentType.Jpeg;
            if (string.Equals(value, "image/png", StringComparison.InvariantCultureIgnoreCase)) return FormContentType.Png;
            if (string.Equals(value, "image/tiff", StringComparison.InvariantCultureIgnoreCase)) return FormContentType.Tiff;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FormContentType value.");
        }
    }
}
