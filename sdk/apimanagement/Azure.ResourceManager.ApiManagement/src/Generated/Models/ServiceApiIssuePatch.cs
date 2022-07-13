// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Issue update Parameters. </summary>
    public partial class ServiceApiIssuePatch
    {
        /// <summary> Initializes a new instance of ServiceApiIssuePatch. </summary>
        public ServiceApiIssuePatch()
        {
        }

        /// <summary> Date and time when the issue was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Status of the issue. </summary>
        public State? State { get; set; }
        /// <summary> A resource identifier for the API the issue was created for. </summary>
        public string ApiId { get; set; }
        /// <summary> The issue title. </summary>
        public string Title { get; set; }
        /// <summary> Text describing the issue. </summary>
        public string Description { get; set; }
        /// <summary> A resource identifier for the user created the issue. </summary>
        public string UserId { get; set; }
    }
}
