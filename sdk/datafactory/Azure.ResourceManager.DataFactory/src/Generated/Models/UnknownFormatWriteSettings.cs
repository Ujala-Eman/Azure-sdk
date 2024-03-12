// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Unknown version of FormatWriteSettings. </summary>
    internal partial class UnknownFormatWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFormatWriteSettings"/>. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownFormatWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(formatWriteSettingsType, additionalProperties)
        {
            FormatWriteSettingsType = formatWriteSettingsType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFormatWriteSettings"/> for deserialization. </summary>
        internal UnknownFormatWriteSettings()
        {
        }
    }
}
