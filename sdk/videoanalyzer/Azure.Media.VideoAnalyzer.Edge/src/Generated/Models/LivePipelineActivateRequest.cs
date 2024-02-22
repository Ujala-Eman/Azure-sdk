// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Activates an existing live pipeline. </summary>
    public partial class LivePipelineActivateRequest : MethodRequestEmptyBodyBase
    {
        /// <summary> Initializes a new instance of <see cref="LivePipelineActivateRequest"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LivePipelineActivateRequest(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            MethodName = "livePipelineActivate";
        }

        /// <summary> Initializes a new instance of <see cref="LivePipelineActivateRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="name"> Resource name. </param>
        internal LivePipelineActivateRequest(string methodName, string apiVersion, string name) : base(methodName, apiVersion, name)
        {
            MethodName = methodName ?? "livePipelineActivate";
        }
    }
}
