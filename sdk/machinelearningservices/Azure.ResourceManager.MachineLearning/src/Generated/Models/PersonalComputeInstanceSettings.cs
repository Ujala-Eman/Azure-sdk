// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Settings for a personal compute instance. </summary>
    internal partial class PersonalComputeInstanceSettings
    {
        /// <summary> Initializes a new instance of <see cref="PersonalComputeInstanceSettings"/>. </summary>
        public PersonalComputeInstanceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PersonalComputeInstanceSettings"/>. </summary>
        /// <param name="assignedUser"> A user explicitly assigned to a personal compute instance. </param>
        internal PersonalComputeInstanceSettings(AssignedUser assignedUser)
        {
            AssignedUser = assignedUser;
        }

        /// <summary> A user explicitly assigned to a personal compute instance. </summary>
        public AssignedUser AssignedUser { get; set; }
    }
}
