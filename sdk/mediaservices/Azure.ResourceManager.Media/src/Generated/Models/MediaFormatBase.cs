// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for output.
    /// Please note <see cref="MediaFormatBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
    /// </summary>
    public abstract partial class MediaFormatBase
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaFormatBase"/>. </summary>
        /// <param name="filenamePattern"> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filenamePattern"/> is null. </exception>
        protected MediaFormatBase(string filenamePattern)
        {
            Argument.AssertNotNull(filenamePattern, nameof(filenamePattern));

            FilenamePattern = filenamePattern;
        }

        /// <summary> Initializes a new instance of <see cref="MediaFormatBase"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="filenamePattern"> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaFormatBase(string odataType, string filenamePattern, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            FilenamePattern = filenamePattern;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaFormatBase"/> for deserialization. </summary>
        internal MediaFormatBase()
        {
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> The file naming pattern used for the creation of output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {AudioStream} - string "Audio" plus audio stream number(start from 1). {Bitrate} - The audio/video bitrate in kbps. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename. </summary>
        public string FilenamePattern { get; set; }
    }
}
