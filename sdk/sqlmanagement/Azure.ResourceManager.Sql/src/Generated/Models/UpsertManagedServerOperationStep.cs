// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SqlManagementClient.Models
{
    /// <summary> The UpsertManagedServerOperationStep. </summary>
    public partial class UpsertManagedServerOperationStep
    {
        /// <summary> Initializes a new instance of UpsertManagedServerOperationStep. </summary>
        internal UpsertManagedServerOperationStep()
        {
        }

        /// <summary> Initializes a new instance of UpsertManagedServerOperationStep. </summary>
        /// <param name="order"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        internal UpsertManagedServerOperationStep(int? order, string name, UpsertManagedServerOperationStepStatus? status)
        {
            Order = order;
            Name = name;
            Status = status;
        }

        /// <summary> Gets the order. </summary>
        public int? Order { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the status. </summary>
        public UpsertManagedServerOperationStepStatus? Status { get; }
    }
}
