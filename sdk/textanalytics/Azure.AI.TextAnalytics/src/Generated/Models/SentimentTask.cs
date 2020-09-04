// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentimentTask. </summary>
    internal partial class SentimentTask : TextAnalyticsTask
    {
        /// <summary> Initializes a new instance of SentimentTask. </summary>
        /// <param name="enable"> . </param>
        public SentimentTask(bool enable) : base(enable)
        {
        }

        public SentimentTaskParameters Parameters { get; set; }
    }
}
