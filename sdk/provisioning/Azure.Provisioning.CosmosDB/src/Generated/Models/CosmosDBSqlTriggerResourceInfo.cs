// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Cosmos DB SQL trigger resource object.
/// </summary>
public partial class CosmosDBSqlTriggerResourceInfo : ProvisioningConstruct
{
    /// <summary>
    /// Name of the Cosmos DB SQL trigger.
    /// </summary>
    public BicepValue<string> TriggerName { get => _triggerName; set => _triggerName.Assign(value); }
    private readonly BicepValue<string> _triggerName;

    /// <summary>
    /// Body of the Trigger.
    /// </summary>
    public BicepValue<string> Body { get => _body; set => _body.Assign(value); }
    private readonly BicepValue<string> _body;

    /// <summary>
    /// Type of the Trigger.
    /// </summary>
    public BicepValue<CosmosDBSqlTriggerType> TriggerType { get => _triggerType; set => _triggerType.Assign(value); }
    private readonly BicepValue<CosmosDBSqlTriggerType> _triggerType;

    /// <summary>
    /// The operation the trigger is associated with.
    /// </summary>
    public BicepValue<CosmosDBSqlTriggerOperation> TriggerOperation { get => _triggerOperation; set => _triggerOperation.Assign(value); }
    private readonly BicepValue<CosmosDBSqlTriggerOperation> _triggerOperation;

    /// <summary>
    /// Creates a new CosmosDBSqlTriggerResourceInfo.
    /// </summary>
    public CosmosDBSqlTriggerResourceInfo()
    {
        _triggerName = BicepValue<string>.DefineProperty(this, "TriggerName", ["id"]);
        _body = BicepValue<string>.DefineProperty(this, "Body", ["body"]);
        _triggerType = BicepValue<CosmosDBSqlTriggerType>.DefineProperty(this, "TriggerType", ["triggerType"]);
        _triggerOperation = BicepValue<CosmosDBSqlTriggerOperation>.DefineProperty(this, "TriggerOperation", ["triggerOperation"]);
    }
}
