// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Translation request.
    /// Requesting format 'json' will result on only the 'text' field being set.
    /// For more output data use 'verbose_json.
    /// </summary>
    public partial class AudioTranslationOptions
    {
        /// <summary>
        /// The audio file to translate.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData File { get; set; }

        /// <summary> Initializes a new instance of AudioTranslationOptions. </summary>
        public AudioTranslationOptions()
        {}

        internal string InternalModelName { get; set; }
    }
}
