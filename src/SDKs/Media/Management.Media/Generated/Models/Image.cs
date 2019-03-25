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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the basic properties for generating thumbnails from the input
    /// video
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.Image")]
    public partial class Image : Video
    {
        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        public Image()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        /// <param name="start">The position in the input video from where to
        /// start generating thumbnails. The value can be in absolute timestamp
        /// (ISO 8601, e.g: PT05S), or a frame count (For example, 10 for the
        /// 10th frame), or a relative value (For example, 1%). Also supports a
        /// macro {Best}, which tells the encoder to select the best thumbnail
        /// from the first few seconds of the video.</param>
        /// <param name="label">An optional label for the codec. The label can
        /// be used to control muxing behavior.</param>
        /// <param name="keyFrameInterval">The distance between two key frames,
        /// thereby defining a group of pictures (GOP). The value should be a
        /// non-zero integer in the range [1, 30] seconds, specified in ISO
        /// 8601 format. The default is 2 seconds (PT2S).</param>
        /// <param name="stretchMode">The resizing mode - how the input video
        /// will be resized to fit the desired output resolution(s). Default is
        /// AutoSize. Possible values include: 'None', 'AutoSize',
        /// 'AutoFit'</param>
        /// <param name="step">The intervals at which thumbnails are generated.
        /// The value can be in absolute timestamp (ISO 8601, e.g: PT05S for
        /// one image every 5 seconds), or a frame count (For example, 30 for
        /// every 30 frames), or a relative value (For example, 1%).</param>
        /// <param name="range">The position in the input video at which to
        /// stop generating thumbnails. The value can be in absolute timestamp
        /// (ISO 8601, e.g: PT5M30S to stop at 5 minutes and 30 seconds), or a
        /// frame count (For example, 300 to stop at the 300th frame), or a
        /// relative value (For example, 100%).</param>
        public Image(string start, string label = default(string), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), string stretchMode = default(string), string step = default(string), string range = default(string))
            : base(label, keyFrameInterval, stretchMode)
        {
            Start = start;
            Step = step;
            Range = range;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the position in the input video from where to start
        /// generating thumbnails. The value can be in absolute timestamp (ISO
        /// 8601, e.g: PT05S), or a frame count (For example, 10 for the 10th
        /// frame), or a relative value (For example, 1%). Also supports a
        /// macro {Best}, which tells the encoder to select the best thumbnail
        /// from the first few seconds of the video.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }

        /// <summary>
        /// Gets or sets the intervals at which thumbnails are generated. The
        /// value can be in absolute timestamp (ISO 8601, e.g: PT05S for one
        /// image every 5 seconds), or a frame count (For example, 30 for every
        /// 30 frames), or a relative value (For example, 1%).
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public string Step { get; set; }

        /// <summary>
        /// Gets or sets the position in the input video at which to stop
        /// generating thumbnails. The value can be in absolute timestamp (ISO
        /// 8601, e.g: PT5M30S to stop at 5 minutes and 30 seconds), or a frame
        /// count (For example, 300 to stop at the 300th frame), or a relative
        /// value (For example, 100%).
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        public string Range { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Start == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Start");
            }
        }
    }
}
