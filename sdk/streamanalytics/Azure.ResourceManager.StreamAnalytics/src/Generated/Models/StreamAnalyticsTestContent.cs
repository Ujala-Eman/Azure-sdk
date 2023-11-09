// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> A stream analytics input. </summary>
    public partial class StreamAnalyticsTestContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="input"> The stream analytics input to test. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public StreamAnalyticsTestContent(StreamingJobInputData input)
        {
            Argument.AssertNotNull(input, nameof(input));

            Input = input;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="input"> The stream analytics input to test. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsTestContent(StreamingJobInputData input, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestContent"/> for deserialization. </summary>
        internal StreamAnalyticsTestContent()
        {
        }

        /// <summary> The stream analytics input to test. </summary>
        public StreamingJobInputData Input { get; }
    }
}
