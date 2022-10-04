// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The PipelineSourceTriggerProperties. </summary>
    internal partial class PipelineSourceTriggerProperties
    {
        /// <summary> Initializes a new instance of PipelineSourceTriggerProperties. </summary>
        /// <param name="status"> The current status of the source trigger. </param>
        public PipelineSourceTriggerProperties(ContainerRegistryTriggerStatus status)
        {
            Status = status;
        }

        /// <summary> The current status of the source trigger. </summary>
        public ContainerRegistryTriggerStatus Status { get; set; }
    }
}
