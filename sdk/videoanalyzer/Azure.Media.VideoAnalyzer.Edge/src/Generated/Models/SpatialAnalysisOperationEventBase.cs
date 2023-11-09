// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines the Azure Cognitive Services Spatial Analysis operation eventing configuration. </summary>
    public partial class SpatialAnalysisOperationEventBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisOperationEventBase"/>. </summary>
        public SpatialAnalysisOperationEventBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisOperationEventBase"/>. </summary>
        /// <param name="threshold"> The event threshold. </param>
        /// <param name="focus"> The operation focus type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SpatialAnalysisOperationEventBase(string threshold, SpatialAnalysisOperationFocus? focus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Threshold = threshold;
            Focus = focus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The event threshold. </summary>
        public string Threshold { get; set; }
        /// <summary> The operation focus type. </summary>
        public SpatialAnalysisOperationFocus? Focus { get; set; }
    }
}
