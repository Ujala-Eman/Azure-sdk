// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Application definition artifact.
/// </summary>
public partial class ArmApplicationDefinitionArtifact : ProvisionableConstruct
{
    /// <summary>
    /// The managed application definition artifact name.
    /// </summary>
    public BicepValue<ArmApplicationDefinitionArtifactName> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<ArmApplicationDefinitionArtifactName>? _name;

    /// <summary>
    /// The managed application definition artifact blob uri.
    /// </summary>
    public BicepValue<Uri> Uri 
    {
        get { Initialize(); return _uri!; }
        set { Initialize(); _uri!.Assign(value); }
    }
    private BicepValue<Uri>? _uri;

    /// <summary>
    /// The managed application definition artifact type.
    /// </summary>
    public BicepValue<ArmApplicationArtifactType> ArtifactType 
    {
        get { Initialize(); return _artifactType!; }
        set { Initialize(); _artifactType!.Assign(value); }
    }
    private BicepValue<ArmApplicationArtifactType>? _artifactType;

    /// <summary>
    /// Creates a new ArmApplicationDefinitionArtifact.
    /// </summary>
    public ArmApplicationDefinitionArtifact()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ArmApplicationDefinitionArtifact.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<ArmApplicationDefinitionArtifactName>("Name", ["name"]);
        _uri = DefineProperty<Uri>("Uri", ["uri"]);
        _artifactType = DefineProperty<ArmApplicationArtifactType>("ArtifactType", ["type"]);
    }
}
