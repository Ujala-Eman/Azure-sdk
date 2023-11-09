// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The Job Definition resource. </summary>
    public partial class JobDefinitionPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JobDefinitionPatch"/>. </summary>
        public JobDefinitionPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JobDefinitionPatch"/>. </summary>
        /// <param name="description"> A description for the Job Definition. </param>
        /// <param name="copyMode"> Strategy to use for copy. </param>
        /// <param name="agentName"> Name of the Agent to assign for new Job Runs of this Job Definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobDefinitionPatch(string description, StorageMoverCopyMode? copyMode, string agentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            CopyMode = copyMode;
            AgentName = agentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A description for the Job Definition. </summary>
        public string Description { get; set; }
        /// <summary> Strategy to use for copy. </summary>
        public StorageMoverCopyMode? CopyMode { get; set; }
        /// <summary> Name of the Agent to assign for new Job Runs of this Job Definition. </summary>
        public string AgentName { get; set; }
    }
}
