// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object of optional configuration settings for encoder.
    /// </summary>
    public partial class PresetConfigurations
    {
        /// <summary>
        /// Initializes a new instance of the PresetConfigurations class.
        /// </summary>
        public PresetConfigurations()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PresetConfigurations class.
        /// </summary>
        /// <param name="complexity">Allows you to configure the encoder
        /// settings to control the balance between speed and quality. Example:
        /// set Complexity as Speed for faster encoding but less compression
        /// efficiency. Possible values include: 'Speed', 'Balanced',
        /// 'Quality'</param>
        /// <param name="interleaveOutput">Sets the interleave mode of the
        /// output to control how audio and video are stored in the container
        /// format. Example: set InterleavedOutput as NonInterleavedOutput to
        /// produce audio-only and video-only outputs in separate MP4 files.
        /// Possible values include: 'NonInterleavedOutput',
        /// 'InterleavedOutput'</param>
        /// <param name="keyFrameIntervalInSeconds">The key frame interval in
        /// seconds. Example: set KeyFrameIntervalInSeconds as 2 to reduce the
        /// playback buffering for some players.</param>
        /// <param name="maxBitrateBps">The maximum bitrate in bits per second
        /// (threshold for the top video layer). Example: set MaxBitrateBps as
        /// 6000000 to avoid producing very high bitrate outputs for contents
        /// with high complexity.</param>
        /// <param name="maxHeight">The maximum height of output video layers.
        /// Example: set MaxHeight as 720 to produce output layers up to 720P
        /// even if the input is 4K.</param>
        /// <param name="maxLayers">The maximum number of output video layers.
        /// Example: set MaxLayers as 4 to make sure at most 4 output layers
        /// are produced to control the overall cost of the encoding
        /// job.</param>
        /// <param name="minBitrateBps">The minimum bitrate in bits per second
        /// (threshold for the bottom video layer). Example: set MinBitrateBps
        /// as 200000 to have a bottom layer that covers users with low network
        /// bandwidth.</param>
        /// <param name="minHeight">The minimum height of output video layers.
        /// Example: set MinHeight as 360 to avoid output layers of smaller
        /// resolutions like 180P.</param>
        public PresetConfigurations(Complexity? complexity = default(Complexity?), InterleaveOutput? interleaveOutput = default(InterleaveOutput?), double? keyFrameIntervalInSeconds = default(double?), int? maxBitrateBps = default(int?), int? maxHeight = default(int?), int? maxLayers = default(int?), int? minBitrateBps = default(int?), int? minHeight = default(int?))
        {
            Complexity = complexity;
            InterleaveOutput = interleaveOutput;
            KeyFrameIntervalInSeconds = keyFrameIntervalInSeconds;
            MaxBitrateBps = maxBitrateBps;
            MaxHeight = maxHeight;
            MaxLayers = maxLayers;
            MinBitrateBps = minBitrateBps;
            MinHeight = minHeight;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allows you to configure the encoder settings to
        /// control the balance between speed and quality. Example: set
        /// Complexity as Speed for faster encoding but less compression
        /// efficiency. Possible values include: 'Speed', 'Balanced', 'Quality'
        /// </summary>
        [JsonProperty(PropertyName = "complexity")]
        public Complexity? Complexity { get; set; }

        /// <summary>
        /// Gets or sets sets the interleave mode of the output to control how
        /// audio and video are stored in the container format. Example: set
        /// InterleavedOutput as NonInterleavedOutput to produce audio-only and
        /// video-only outputs in separate MP4 files. Possible values include:
        /// 'NonInterleavedOutput', 'InterleavedOutput'
        /// </summary>
        [JsonProperty(PropertyName = "interleaveOutput")]
        public InterleaveOutput? InterleaveOutput { get; set; }

        /// <summary>
        /// Gets or sets the key frame interval in seconds. Example: set
        /// KeyFrameIntervalInSeconds as 2 to reduce the playback buffering for
        /// some players.
        /// </summary>
        [JsonProperty(PropertyName = "keyFrameIntervalInSeconds")]
        public double? KeyFrameIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the maximum bitrate in bits per second (threshold for
        /// the top video layer). Example: set MaxBitrateBps as 6000000 to
        /// avoid producing very high bitrate outputs for contents with high
        /// complexity.
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrateBps")]
        public int? MaxBitrateBps { get; set; }

        /// <summary>
        /// Gets or sets the maximum height of output video layers. Example:
        /// set MaxHeight as 720 to produce output layers up to 720P even if
        /// the input is 4K.
        /// </summary>
        [JsonProperty(PropertyName = "maxHeight")]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of output video layers. Example:
        /// set MaxLayers as 4 to make sure at most 4 output layers are
        /// produced to control the overall cost of the encoding job.
        /// </summary>
        [JsonProperty(PropertyName = "maxLayers")]
        public int? MaxLayers { get; set; }

        /// <summary>
        /// Gets or sets the minimum bitrate in bits per second (threshold for
        /// the bottom video layer). Example: set MinBitrateBps as 200000 to
        /// have a bottom layer that covers users with low network bandwidth.
        /// </summary>
        [JsonProperty(PropertyName = "minBitrateBps")]
        public int? MinBitrateBps { get; set; }

        /// <summary>
        /// Gets or sets the minimum height of output video layers. Example:
        /// set MinHeight as 360 to avoid output layers of smaller resolutions
        /// like 180P.
        /// </summary>
        [JsonProperty(PropertyName = "minHeight")]
        public int? MinHeight { get; set; }

    }
}
