// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The service resource properties for patch operations.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServiceResourceUpdateProperties")]
    public partial class ServiceResourceUpdateProperties : ServiceResourcePropertiesBase
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResourceUpdateProperties
        /// class.
        /// </summary>
        public ServiceResourceUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResourceUpdateProperties
        /// class.
        /// </summary>
        /// <param name="placementConstraints">The placement constraints as a
        /// string. Placement constraints are boolean expressions on node
        /// properties and allow for restricting a service to particular nodes
        /// based on the service requirements. For example, to place a service
        /// on nodes where NodeType is blue specify the following: "NodeColor
        /// == blue)".</param>
        /// <param name="correlationScheme">A list that describes the
        /// correlation of the service with other services.</param>
        /// <param name="serviceLoadMetrics">The service load metrics is given
        /// as an array of ServiceLoadMetricDescription objects.</param>
        /// <param name="servicePlacementPolicies">A list that describes the
        /// correlation of the service with other services.</param>
        /// <param name="defaultMoveCost">Specifies the move cost for the
        /// service. Possible values include: 'Zero', 'Low', 'Medium',
        /// 'High'</param>
        public ServiceResourceUpdateProperties(string placementConstraints = default(string), IList<ServiceCorrelationDescription> correlationScheme = default(IList<ServiceCorrelationDescription>), IList<ServiceLoadMetricDescription> serviceLoadMetrics = default(IList<ServiceLoadMetricDescription>), IList<ServicePlacementPolicyDescription> servicePlacementPolicies = default(IList<ServicePlacementPolicyDescription>), string defaultMoveCost = default(string))
            : base(placementConstraints, correlationScheme, serviceLoadMetrics, servicePlacementPolicies, defaultMoveCost)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
