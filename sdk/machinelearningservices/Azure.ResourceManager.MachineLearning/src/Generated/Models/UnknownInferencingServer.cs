// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownInferencingServer. </summary>
    internal partial class UnknownInferencingServer : InferencingServer
    {
        /// <summary> Initializes a new instance of UnknownInferencingServer. </summary>
        /// <param name="serverType"> [Required] Inferencing server type for various targets. </param>
        internal UnknownInferencingServer(InferencingServerType serverType) : base(serverType)
        {
            ServerType = serverType;
        }
    }
}
