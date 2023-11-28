// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseWorkspace data model.
    /// A workspace
    /// </summary>
    public partial class SynapseWorkspaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SynapseWorkspaceData(AzureLocation location) : base(location)
        {
            ConnectivityEndpoints = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<SynapsePrivateEndpointConnectionData>();
            ExtraProperties = new ChangeTrackingDictionary<string, BinaryData>();
            Settings = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity of the workspace. Current supported identity types: None, SystemAssigned, SystemAssigned,UserAssigned. </param>
        /// <param name="defaultDataLakeStorage"> Workspace default data lake storage account details. </param>
        /// <param name="sqlAdministratorLoginPassword"> SQL administrator login password. </param>
        /// <param name="managedResourceGroupName"> Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="sqlAdministratorLogin"> Login for workspace SQL active directory administrator. </param>
        /// <param name="virtualNetworkProfile"> Virtual Network profile. </param>
        /// <param name="connectivityEndpoints"> Connectivity endpoints. </param>
        /// <param name="managedVirtualNetwork"> Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the workspace. </param>
        /// <param name="encryption"> The encryption details of the workspace. </param>
        /// <param name="workspaceUid"> The workspace unique identifier. </param>
        /// <param name="extraProperties"> Workspace level configs and feature flags. </param>
        /// <param name="managedVirtualNetworkSettings"> Managed Virtual Network Settings. </param>
        /// <param name="workspaceRepositoryConfiguration"> Git integration settings. </param>
        /// <param name="purviewConfiguration"> Purview Configuration. </param>
        /// <param name="adlaResourceId"> The ADLA resource ID. </param>
        /// <param name="publicNetworkAccess"> Enable or Disable public network access to workspace. </param>
        /// <param name="cspWorkspaceAdminProperties"> Initial workspace AAD admin properties for a CSP subscription. </param>
        /// <param name="settings"> Workspace settings. </param>
        /// <param name="isAadOnlyAuthenticationEnabled"> Enable or Disable AzureADOnlyAuthentication on All Workspace subresource. </param>
        /// <param name="isTrustedServiceBypassEnabled"> Is trustedServiceBypassEnabled for the workspace. </param>
        internal SynapseWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, SynapseDataLakeStorageAccountDetails defaultDataLakeStorage, string sqlAdministratorLoginPassword, string managedResourceGroupName, string provisioningState, string sqlAdministratorLogin, VirtualNetworkProfile virtualNetworkProfile, IDictionary<string, string> connectivityEndpoints, string managedVirtualNetwork, IList<SynapsePrivateEndpointConnectionData> privateEndpointConnections, SynapseEncryptionDetails encryption, Guid? workspaceUid, IReadOnlyDictionary<string, BinaryData> extraProperties, SynapseManagedVirtualNetworkSettings managedVirtualNetworkSettings, SynapseWorkspaceRepositoryConfiguration workspaceRepositoryConfiguration, PurviewConfiguration purviewConfiguration, ResourceIdentifier adlaResourceId, WorkspacePublicNetworkAccess? publicNetworkAccess, CspWorkspaceAdminProperties cspWorkspaceAdminProperties, IReadOnlyDictionary<string, BinaryData> settings, bool? isAadOnlyAuthenticationEnabled, bool? isTrustedServiceBypassEnabled) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            DefaultDataLakeStorage = defaultDataLakeStorage;
            SqlAdministratorLoginPassword = sqlAdministratorLoginPassword;
            ManagedResourceGroupName = managedResourceGroupName;
            ProvisioningState = provisioningState;
            SqlAdministratorLogin = sqlAdministratorLogin;
            VirtualNetworkProfile = virtualNetworkProfile;
            ConnectivityEndpoints = connectivityEndpoints;
            ManagedVirtualNetwork = managedVirtualNetwork;
            PrivateEndpointConnections = privateEndpointConnections;
            Encryption = encryption;
            WorkspaceUid = workspaceUid;
            ExtraProperties = extraProperties;
            ManagedVirtualNetworkSettings = managedVirtualNetworkSettings;
            WorkspaceRepositoryConfiguration = workspaceRepositoryConfiguration;
            PurviewConfiguration = purviewConfiguration;
            AdlaResourceId = adlaResourceId;
            PublicNetworkAccess = publicNetworkAccess;
            CspWorkspaceAdminProperties = cspWorkspaceAdminProperties;
            Settings = settings;
            IsAadOnlyAuthenticationEnabled = isAadOnlyAuthenticationEnabled;
            IsTrustedServiceBypassEnabled = isTrustedServiceBypassEnabled;
        }

        /// <summary> Identity of the workspace. Current supported identity types: None, SystemAssigned, SystemAssigned,UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Workspace default data lake storage account details. </summary>
        public SynapseDataLakeStorageAccountDetails DefaultDataLakeStorage { get; set; }
        /// <summary> SQL administrator login password. </summary>
        public string SqlAdministratorLoginPassword { get; set; }
        /// <summary> Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'. </summary>
        public string ManagedResourceGroupName { get; set; }
        /// <summary> Resource provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Login for workspace SQL active directory administrator. </summary>
        public string SqlAdministratorLogin { get; set; }
        /// <summary> Virtual Network profile. </summary>
        internal VirtualNetworkProfile VirtualNetworkProfile { get; set; }
        /// <summary> Subnet ID used for computes in workspace. </summary>
        public string VirtualNetworkComputeSubnetId
        {
            get => VirtualNetworkProfile is null ? default : VirtualNetworkProfile.ComputeSubnetId;
            set
            {
                if (VirtualNetworkProfile is null)
                    VirtualNetworkProfile = new VirtualNetworkProfile();
                VirtualNetworkProfile.ComputeSubnetId = value;
            }
        }

        /// <summary> Connectivity endpoints. </summary>
        public IDictionary<string, string> ConnectivityEndpoints { get; }
        /// <summary> Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user. </summary>
        public string ManagedVirtualNetwork { get; set; }
        /// <summary> Private endpoint connections to the workspace. </summary>
        public IList<SynapsePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The encryption details of the workspace. </summary>
        public SynapseEncryptionDetails Encryption { get; set; }
        /// <summary> The workspace unique identifier. </summary>
        public Guid? WorkspaceUid { get; }
        /// <summary>
        /// Workspace level configs and feature flags
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> ExtraProperties { get; }
        /// <summary> Managed Virtual Network Settings. </summary>
        public SynapseManagedVirtualNetworkSettings ManagedVirtualNetworkSettings { get; set; }
        /// <summary> Git integration settings. </summary>
        public SynapseWorkspaceRepositoryConfiguration WorkspaceRepositoryConfiguration { get; set; }
        /// <summary> Purview Configuration. </summary>
        internal PurviewConfiguration PurviewConfiguration { get; set; }
        /// <summary> Purview Resource ID. </summary>
        public ResourceIdentifier PurviewResourceId
        {
            get => PurviewConfiguration is null ? default : PurviewConfiguration.PurviewResourceId;
            set
            {
                if (PurviewConfiguration is null)
                    PurviewConfiguration = new PurviewConfiguration();
                PurviewConfiguration.PurviewResourceId = value;
            }
        }

        /// <summary> The ADLA resource ID. </summary>
        public ResourceIdentifier AdlaResourceId { get; }
        /// <summary> Enable or Disable public network access to workspace. </summary>
        public WorkspacePublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Initial workspace AAD admin properties for a CSP subscription. </summary>
        internal CspWorkspaceAdminProperties CspWorkspaceAdminProperties { get; set; }
        /// <summary> AAD object ID of initial workspace admin. </summary>
        public Guid? InitialWorkspaceAdminObjectId
        {
            get => CspWorkspaceAdminProperties is null ? default : CspWorkspaceAdminProperties.InitialWorkspaceAdminObjectId;
            set
            {
                if (CspWorkspaceAdminProperties is null)
                    CspWorkspaceAdminProperties = new CspWorkspaceAdminProperties();
                CspWorkspaceAdminProperties.InitialWorkspaceAdminObjectId = value;
            }
        }

        /// <summary>
        /// Workspace settings
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> Settings { get; }
        /// <summary> Enable or Disable AzureADOnlyAuthentication on All Workspace subresource. </summary>
        public bool? IsAadOnlyAuthenticationEnabled { get; set; }
        /// <summary> Is trustedServiceBypassEnabled for the workspace. </summary>
        public bool? IsTrustedServiceBypassEnabled { get; set; }
    }
}
