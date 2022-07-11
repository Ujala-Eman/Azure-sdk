// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary> A class representing the ServiceResource data model. </summary>
    public partial class ServiceResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServiceResourceData. </summary>
        /// <param name="location"> The location. </param>
        public ServiceResourceData(AzureLocation location) : base(location)
        {
            CorrelationScheme = new ChangeTrackingList<ServiceCorrelationDescription>();
            ServiceLoadMetrics = new ChangeTrackingList<ServiceLoadMetricDescription>();
            ServicePlacementPolicies = new ChangeTrackingList<ServicePlacementPolicyDescription>();
        }

        /// <summary> Initializes a new instance of ServiceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="placementConstraints"> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: &quot;NodeColor == blue)&quot;. </param>
        /// <param name="correlationScheme"> A list that describes the correlation of the service with other services. </param>
        /// <param name="serviceLoadMetrics"> The service load metrics is given as an array of ServiceLoadMetricDescription objects. </param>
        /// <param name="servicePlacementPolicies"> A list that describes the correlation of the service with other services. </param>
        /// <param name="defaultMoveCost"> Specifies the move cost for the service. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="serviceKind"> The kind of service (Stateless or Stateful). </param>
        /// <param name="serviceTypeName"> The name of the service type. </param>
        /// <param name="partitionDescription">
        /// Describes how the service is partitioned.
        /// Please note <see cref="PartitionSchemeDescription"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionSchemeDescription"/>, <see cref="SingletonPartitionSchemeDescription"/> and <see cref="UniformInt64RangePartitionSchemeDescription"/>.
        /// </param>
        /// <param name="servicePackageActivationMode"> The activation Mode of the service package. </param>
        /// <param name="serviceDnsName"> Dns name used for the service. If this is specified, then the service can be accessed via its DNS name instead of service name. </param>
        /// <param name="etag"> Azure resource etag. </param>
        internal ServiceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string placementConstraints, IList<ServiceCorrelationDescription> correlationScheme, IList<ServiceLoadMetricDescription> serviceLoadMetrics, IList<ServicePlacementPolicyDescription> servicePlacementPolicies, MoveCost? defaultMoveCost, string provisioningState, ServiceKind? serviceKind, string serviceTypeName, PartitionSchemeDescription partitionDescription, ArmServicePackageActivationMode? servicePackageActivationMode, string serviceDnsName, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            PlacementConstraints = placementConstraints;
            CorrelationScheme = correlationScheme;
            ServiceLoadMetrics = serviceLoadMetrics;
            ServicePlacementPolicies = servicePlacementPolicies;
            DefaultMoveCost = defaultMoveCost;
            ProvisioningState = provisioningState;
            ServiceKind = serviceKind;
            ServiceTypeName = serviceTypeName;
            PartitionDescription = partitionDescription;
            ServicePackageActivationMode = servicePackageActivationMode;
            ServiceDnsName = serviceDnsName;
            ETag = etag;
        }

        /// <summary> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: &quot;NodeColor == blue)&quot;. </summary>
        public string PlacementConstraints { get; set; }
        /// <summary> A list that describes the correlation of the service with other services. </summary>
        public IList<ServiceCorrelationDescription> CorrelationScheme { get; }
        /// <summary> The service load metrics is given as an array of ServiceLoadMetricDescription objects. </summary>
        public IList<ServiceLoadMetricDescription> ServiceLoadMetrics { get; }
        /// <summary> A list that describes the correlation of the service with other services. </summary>
        public IList<ServicePlacementPolicyDescription> ServicePlacementPolicies { get; }
        /// <summary> Specifies the move cost for the service. </summary>
        public MoveCost? DefaultMoveCost { get; set; }
        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The kind of service (Stateless or Stateful). </summary>
        internal ServiceKind? ServiceKind { get; set; }
        /// <summary> The name of the service type. </summary>
        public string ServiceTypeName { get; set; }
        /// <summary>
        /// Describes how the service is partitioned.
        /// Please note <see cref="PartitionSchemeDescription"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionSchemeDescription"/>, <see cref="SingletonPartitionSchemeDescription"/> and <see cref="UniformInt64RangePartitionSchemeDescription"/>.
        /// </summary>
        public PartitionSchemeDescription PartitionDescription { get; set; }
        /// <summary> The activation Mode of the service package. </summary>
        public ArmServicePackageActivationMode? ServicePackageActivationMode { get; set; }
        /// <summary> Dns name used for the service. If this is specified, then the service can be accessed via its DNS name instead of service name. </summary>
        public string ServiceDnsName { get; set; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
