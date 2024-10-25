// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the Azure Active directory provider.
/// </summary>
public partial class ContainerAppAzureActiveDirectoryConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// &lt;code&gt;false&lt;/code&gt; if the Azure Active Directory provider
    /// should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// The configuration settings of the Azure Active Directory app
    /// registration.
    /// </summary>
    public BicepValue<ContainerAppAzureActiveDirectoryRegistrationConfiguration> Registration { get => _registration; set => _registration.Assign(value); }
    private readonly BicepValue<ContainerAppAzureActiveDirectoryRegistrationConfiguration> _registration;

    /// <summary>
    /// The configuration settings of the Azure Active Directory login flow.
    /// </summary>
    public BicepValue<ContainerAppAzureActiveDirectoryLoginConfiguration> Login { get => _login; set => _login.Assign(value); }
    private readonly BicepValue<ContainerAppAzureActiveDirectoryLoginConfiguration> _login;

    /// <summary>
    /// The configuration settings of the Azure Active Directory token
    /// validation flow.
    /// </summary>
    public BicepValue<ContainerAppAzureActiveDirectoryValidationConfiguration> Validation { get => _validation; set => _validation.Assign(value); }
    private readonly BicepValue<ContainerAppAzureActiveDirectoryValidationConfiguration> _validation;

    /// <summary>
    /// Gets a value indicating whether the Azure AD configuration was
    /// auto-provisioned using 1st party tooling.             This is an
    /// internal flag primarily intended to support the Azure Management
    /// Portal. Users should not             read or write to this property.
    /// </summary>
    public BicepValue<bool> IsAutoProvisioned { get => _isAutoProvisioned; set => _isAutoProvisioned.Assign(value); }
    private readonly BicepValue<bool> _isAutoProvisioned;

    /// <summary>
    /// Creates a new ContainerAppAzureActiveDirectoryConfiguration.
    /// </summary>
    public ContainerAppAzureActiveDirectoryConfiguration()
    {
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _registration = BicepValue<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.DefineProperty(this, "Registration", ["registration"]);
        _login = BicepValue<ContainerAppAzureActiveDirectoryLoginConfiguration>.DefineProperty(this, "Login", ["login"]);
        _validation = BicepValue<ContainerAppAzureActiveDirectoryValidationConfiguration>.DefineProperty(this, "Validation", ["validation"]);
        _isAutoProvisioned = BicepValue<bool>.DefineProperty(this, "IsAutoProvisioned", ["isAutoProvisioned"]);
    }
}
