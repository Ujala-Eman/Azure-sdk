// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// A collection of information about the state of the connection between
/// service consumer and provider.
/// </summary>
public partial class CognitiveServicesPrivateLinkServiceConnectionState : ProvisionableConstruct
{
    /// <summary>
    /// Indicates whether the connection has been Approved/Rejected/Removed by
    /// the owner of the service.
    /// </summary>
    public BicepValue<CognitiveServicesPrivateEndpointServiceConnectionStatus> Status { get => _status; set => _status.Assign(value); }
    private readonly BicepValue<CognitiveServicesPrivateEndpointServiceConnectionStatus> _status;

    /// <summary>
    /// The reason for approval/rejection of the connection.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// A message indicating if changes on the service provider require any
    /// updates on the consumer.
    /// </summary>
    public BicepValue<string> ActionsRequired { get => _actionsRequired; set => _actionsRequired.Assign(value); }
    private readonly BicepValue<string> _actionsRequired;

    /// <summary>
    /// Creates a new CognitiveServicesPrivateLinkServiceConnectionState.
    /// </summary>
    public CognitiveServicesPrivateLinkServiceConnectionState()
    {
        _status = BicepValue<CognitiveServicesPrivateEndpointServiceConnectionStatus>.DefineProperty(this, "Status", ["status"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _actionsRequired = BicepValue<string>.DefineProperty(this, "ActionsRequired", ["actionsRequired"]);
    }
}
