// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Translation request.
    /// Requesting format 'json' will result on only the 'text' field being set.
    /// For more output data use 'verbose_json.
    /// </summary>
    public partial class AudioTranslationOptions
    {
        /// <summary> Initializes a new instance of AudioTranslationOptions. </summary>
        /// <param name="file"> The audio file to translate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        public AudioTranslationOptions(BinaryData file)
        {
            Argument.AssertNotNull(file, nameof(file));

            File = file;
        }

        /// <summary> Initializes a new instance of AudioTranslationOptions. </summary>
        /// <param name="file"> The audio file to translate. </param>
        /// <param name="prompt"> An optional text to guide the model's style or continue a previous audio segment. The prompt should be in English. </param>
        /// <param name="responseFormat"> The format of the transcription output, in one of these options: json, text, srt, verbose_json, or vtt. </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1.
        /// Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit.
        /// </param>
        internal AudioTranslationOptions(BinaryData file, string prompt, AudioTranscriptionFormat? responseFormat, float? temperature)
        {
            File = file;
            Prompt = prompt;
            ResponseFormat = responseFormat;
            Temperature = temperature;
        }
        /// <summary> An optional text to guide the model's style or continue a previous audio segment. The prompt should be in English. </summary>
        public string Prompt { get; set; }
        /// <summary> The format of the transcription output, in one of these options: json, text, srt, verbose_json, or vtt. </summary>
        public AudioTranscriptionFormat? ResponseFormat { get; set; }
        /// <summary>
        /// The sampling temperature, between 0 and 1.
        /// Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// If set to 0, the model will use log probability to automatically increase the temperature until certain thresholds are hit.
        /// </summary>
        public float? Temperature { get; set; }
    }
}
