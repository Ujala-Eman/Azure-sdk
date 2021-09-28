// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application billing details definition. </summary>
    public partial class ApplicationBillingDetailsDefinition
    {
        /// <summary> Initializes a new instance of ApplicationBillingDetailsDefinition. </summary>
        internal ApplicationBillingDetailsDefinition()
        {
        }

        /// <summary> Initializes a new instance of ApplicationBillingDetailsDefinition. </summary>
        /// <param name="resourceUsageId"> The managed application resource usage Id. </param>
        internal ApplicationBillingDetailsDefinition(string resourceUsageId)
        {
            ResourceUsageId = resourceUsageId;
        }

        /// <summary> The managed application resource usage Id. </summary>
        public string ResourceUsageId { get; }
    }
}
