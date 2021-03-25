// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Represents the livePipelineList request. </summary>
    public partial class LivePipelineListRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of LivePipelineListRequest. </summary>
        public LivePipelineListRequest()
        {
            MethodName = "livePipelineList";
        }

        /// <summary> Initializes a new instance of LivePipelineListRequest. </summary>
        /// <param name="methodName"> method name. </param>
        /// <param name="apiVersion"> api version. </param>
        internal LivePipelineListRequest(string methodName, string apiVersion) : base(methodName, apiVersion)
        {
            MethodName = methodName ?? "livePipelineList";
        }
    }
}
