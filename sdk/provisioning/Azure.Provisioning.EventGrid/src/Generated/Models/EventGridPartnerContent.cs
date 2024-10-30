// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the partner.
/// </summary>
public partial class EventGridPartnerContent : ProvisionableConstruct
{
    /// <summary>
    /// The immutableId of the corresponding partner registration.
    /// </summary>
    public BicepValue<Guid> PartnerRegistrationImmutableId 
    {
        get { Initialize(); return _partnerRegistrationImmutableId!; }
        set { Initialize(); _partnerRegistrationImmutableId!.Assign(value); }
    }
    private BicepValue<Guid>? _partnerRegistrationImmutableId;

    /// <summary>
    /// The partner name.
    /// </summary>
    public BicepValue<string> PartnerName 
    {
        get { Initialize(); return _partnerName!; }
        set { Initialize(); _partnerName!.Assign(value); }
    }
    private BicepValue<string>? _partnerName;

    /// <summary>
    /// Expiration time of the partner authorization. If this timer expires,
    /// any request from this partner to create, update or delete resources in
    /// subscriber&apos;s             context will fail. If specified, the
    /// allowed values are between 1 to the value of
    /// defaultMaximumExpirationTimeInDays specified in PartnerConfiguration.
    /// If not specified, the default value will be the value of
    /// defaultMaximumExpirationTimeInDays specified in PartnerConfiguration
    /// or 7 if this value is not specified.
    /// </summary>
    public BicepValue<DateTimeOffset> AuthorizationExpireOn 
    {
        get { Initialize(); return _authorizationExpireOn!; }
        set { Initialize(); _authorizationExpireOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _authorizationExpireOn;

    /// <summary>
    /// Creates a new EventGridPartnerContent.
    /// </summary>
    public EventGridPartnerContent()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventGridPartnerContent.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _partnerRegistrationImmutableId = DefineProperty<Guid>("PartnerRegistrationImmutableId", ["partnerRegistrationImmutableId"]);
        _partnerName = DefineProperty<string>("PartnerName", ["partnerName"]);
        _authorizationExpireOn = DefineProperty<DateTimeOffset>("AuthorizationExpireOn", ["authorizationExpirationTimeInUtc"]);
    }
}
