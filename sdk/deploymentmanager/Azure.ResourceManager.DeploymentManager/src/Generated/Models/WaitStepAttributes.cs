// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> The parameters for the wait step. </summary>
    public partial class WaitStepAttributes
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WaitStepAttributes"/>. </summary>
        /// <param name="duration"> The duration in ISO 8601 format of how long the wait should be. </param>
        public WaitStepAttributes(TimeSpan duration)
        {
            Duration = duration;
        }

        /// <summary> Initializes a new instance of <see cref="WaitStepAttributes"/>. </summary>
        /// <param name="duration"> The duration in ISO 8601 format of how long the wait should be. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WaitStepAttributes(TimeSpan duration, Dictionary<string, BinaryData> rawData)
        {
            Duration = duration;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="WaitStepAttributes"/> for deserialization. </summary>
        internal WaitStepAttributes()
        {
        }

        /// <summary> The duration in ISO 8601 format of how long the wait should be. </summary>
        public TimeSpan Duration { get; set; }
    }
}
