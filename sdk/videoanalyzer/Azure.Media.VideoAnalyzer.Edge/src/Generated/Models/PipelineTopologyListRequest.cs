// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> List all existing pipeline topologies. </summary>
    public partial class PipelineTopologyListRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of <see cref="PipelineTopologyListRequest"/>. </summary>
        public PipelineTopologyListRequest()
        {
            MethodName = "pipelineTopologyList";
        }

        /// <summary> Initializes a new instance of <see cref="PipelineTopologyListRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineTopologyListRequest(string methodName, string apiVersion, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(methodName, apiVersion, serializedAdditionalRawData)
        {
            MethodName = methodName ?? "pipelineTopologyList";
        }
    }
}
