// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Properties of the Spring Cloud Gateway Operator. </summary>
    public partial class GatewayOperatorProperties
    {
        /// <summary> Initializes a new instance of GatewayOperatorProperties. </summary>
        internal GatewayOperatorProperties()
        {
            Instances = new ChangeTrackingList<GatewayInstance>();
        }

        /// <summary> Initializes a new instance of GatewayOperatorProperties. </summary>
        /// <param name="resourceRequests"> The requested resource quantity for required CPU and Memory. </param>
        /// <param name="instances"> Collection of instances belong to Spring Cloud Gateway operator. </param>
        internal GatewayOperatorProperties(GatewayOperatorResourceRequests resourceRequests, IReadOnlyList<GatewayInstance> instances)
        {
            ResourceRequests = resourceRequests;
            Instances = instances;
        }

        /// <summary> The requested resource quantity for required CPU and Memory. </summary>
        public GatewayOperatorResourceRequests ResourceRequests { get; }
        /// <summary> Collection of instances belong to Spring Cloud Gateway operator. </summary>
        public IReadOnlyList<GatewayInstance> Instances { get; }
    }
}
