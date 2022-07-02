// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class representing the TaskRun data model. </summary>
    public partial class TaskRunData : ResourceData
    {
        /// <summary> Initializes a new instance of TaskRunData. </summary>
        public TaskRunData()
        {
        }

        /// <summary> Initializes a new instance of TaskRunData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="provisioningState"> The provisioning state of this task run. </param>
        /// <param name="runRequest">
        /// The request (parameters) for the run
        /// Please note <see cref="RunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DockerBuildRequest"/>, <see cref="EncodedTaskRunRequest"/>, <see cref="FileTaskRunRequest"/> and <see cref="TaskRunRequest"/>.
        /// </param>
        /// <param name="runResult"> The result of this task run. </param>
        /// <param name="forceUpdateTag"> How the run should be forced to rerun even if the run request configuration has not changed. </param>
        internal TaskRunData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IdentityProperties identity, AzureLocation? location, ProvisioningState? provisioningState, RunContent runRequest, RunData runResult, string forceUpdateTag) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            Location = location;
            ProvisioningState = provisioningState;
            RunRequest = runRequest;
            RunResult = runResult;
            ForceUpdateTag = forceUpdateTag;
        }

        /// <summary> Identity for the resource. </summary>
        public IdentityProperties Identity { get; set; }
        /// <summary> The location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The provisioning state of this task run. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// The request (parameters) for the run
        /// Please note <see cref="RunContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DockerBuildRequest"/>, <see cref="EncodedTaskRunRequest"/>, <see cref="FileTaskRunRequest"/> and <see cref="TaskRunRequest"/>.
        /// </summary>
        public RunContent RunRequest { get; set; }
        /// <summary> The result of this task run. </summary>
        public RunData RunResult { get; }
        /// <summary> How the run should be forced to rerun even if the run request configuration has not changed. </summary>
        public string ForceUpdateTag { get; set; }
    }
}
