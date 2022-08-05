// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the move resource status. </summary>
    public partial class MoveResourcePropertiesMoveStatus : MoveResourceStatus
    {
        /// <summary> Initializes a new instance of MoveResourcePropertiesMoveStatus. </summary>
        internal MoveResourcePropertiesMoveStatus()
        {
        }

        /// <summary> Initializes a new instance of MoveResourcePropertiesMoveStatus. </summary>
        /// <param name="moveState"> Defines the MoveResource states. </param>
        /// <param name="jobStatus"> Defines the job status. </param>
        /// <param name="errors"> An error response from the azure resource mover service. </param>
        internal MoveResourcePropertiesMoveStatus(MoveResourceState? moveState, MoveResourceJobStatus jobStatus, MoveResourceError errors) : base(moveState, jobStatus, errors)
        {
        }
    }
}
