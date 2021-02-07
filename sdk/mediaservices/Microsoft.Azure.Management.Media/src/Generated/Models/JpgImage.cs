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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the properties for producing a series of JPEG images from the
    /// input video.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.JpgImage")]
    public partial class JpgImage : Image
    {
        /// <summary>
        /// Initializes a new instance of the JpgImage class.
        /// </summary>
        public JpgImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JpgImage class.
        /// </summary>
        /// <param name="start">The position in the input video from where to
        /// start generating thumbnails. The value can be in ISO 8601 format
        /// (For example, PT05S to start at 5 seconds), or a frame count (For
        /// example, 10 to start at the 10th frame), or a relative value to
        /// stream duration (For example, 10% to start at 10% of stream
        /// duration). Also supports a macro {Best}, which tells the encoder to
        /// select the best thumbnail from the first few seconds of the video
        /// and will only produce one thumbnail, no matter what other settings
        /// are for Step and Range. The default value is macro {Best}.</param>
        /// <param name="label">An optional label for the codec. The label can
        /// be used to control muxing behavior.</param>
        /// <param name="keyFrameInterval">The distance between two key frames.
        /// The value should be non-zero in the range [0.5, 20] seconds,
        /// specified in ISO 8601 format. The default is 2 seconds(PT2S). Note
        /// that this setting is ignored if VideoSyncMode.Passthrough is set,
        /// where the KeyFrameInterval value will follow the input source
        /// setting.</param>
        /// <param name="stretchMode">The resizing mode - how the input video
        /// will be resized to fit the desired output resolution(s). Default is
        /// AutoSize. Possible values include: 'None', 'AutoSize',
        /// 'AutoFit'</param>
        /// <param name="syncMode">The Video Sync Mode. Possible values
        /// include: 'Auto', 'Passthrough', 'Cfr', 'Vfr'</param>
        /// <param name="step">The intervals at which thumbnails are generated.
        /// The value can be in ISO 8601 format (For example, PT05S for one
        /// image every 5 seconds), or a frame count (For example, 30 for one
        /// image every 30 frames), or a relative value to stream duration (For
        /// example, 10% for one image every 10% of stream duration). Note:
        /// Step value will affect the first generated thumbnail, which may not
        /// be exactly the one specified at transform preset start time. This
        /// is due to the encoder, which tries to select the best thumbnail
        /// between start time and Step position from start time as the first
        /// output. As the default value is 10%, it means if stream has long
        /// duration, the first generated thumbnail might be far away from the
        /// one specified at start time. Try to select reasonable value for
        /// Step if the first thumbnail is expected close to start time, or set
        /// Range value at 1 if only one thumbnail is needed at start
        /// time.</param>
        /// <param name="range">The position relative to transform preset start
        /// time in the input video at which to stop generating thumbnails. The
        /// value can be in ISO 8601 format (For example, PT5M30S to stop at 5
        /// minutes and 30 seconds from start time), or a frame count (For
        /// example, 300 to stop at the 300th frame from the frame at start
        /// time. If this value is 1, it means only producing one thumbnail at
        /// start time), or a relative value to the stream duration (For
        /// example, 50% to stop at half of stream duration from start time).
        /// The default value is 100%, which means to stop at the end of the
        /// stream.</param>
        /// <param name="layers">A collection of output JPEG image layers to be
        /// produced by the encoder.</param>
        /// <param name="spriteColumn">Sets the number of columns used in
        /// thumbnail sprite image.  The number of rows are automatically
        /// calculated and a VTT file is generated with the coordinate mappings
        /// for each thumbnail in the sprite. Note: this value should be a
        /// positive integer and a proper value is recommended so that the
        /// output image resolution will not go beyond JPEG maximum pixel
        /// resolution limit 65535x65535.</param>
        public JpgImage(string start, string label = default(string), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?), VideoSyncMode? syncMode = default(VideoSyncMode?), string step = default(string), string range = default(string), IList<JpgLayer> layers = default(IList<JpgLayer>), int? spriteColumn = default(int?))
            : base(start, label, keyFrameInterval, stretchMode, syncMode, step, range)
        {
            Layers = layers;
            SpriteColumn = spriteColumn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of output JPEG image layers to be
        /// produced by the encoder.
        /// </summary>
        [JsonProperty(PropertyName = "layers")]
        public IList<JpgLayer> Layers { get; set; }

        /// <summary>
        /// Gets or sets sets the number of columns used in thumbnail sprite
        /// image.  The number of rows are automatically calculated and a VTT
        /// file is generated with the coordinate mappings for each thumbnail
        /// in the sprite. Note: this value should be a positive integer and a
        /// proper value is recommended so that the output image resolution
        /// will not go beyond JPEG maximum pixel resolution limit 65535x65535.
        /// </summary>
        [JsonProperty(PropertyName = "spriteColumn")]
        public int? SpriteColumn { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
