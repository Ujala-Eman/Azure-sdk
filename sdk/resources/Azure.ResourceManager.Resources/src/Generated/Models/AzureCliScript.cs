// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Object model for the Azure CLI script. </summary>
    public partial class AzureCliScript : ArmDeploymentScriptData
    {
        /// <summary> Initializes a new instance of <see cref="AzureCliScript"/>. </summary>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </param>
        /// <param name="azCliVersion"> Azure CLI module version to be used. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azCliVersion"/> is null. </exception>
        public AzureCliScript(AzureLocation location, TimeSpan retentionInterval, string azCliVersion) : base(location)
        {
            Argument.AssertNotNull(azCliVersion, nameof(azCliVersion));

            SupportingScriptUris = new ChangeTrackingList<Uri>();
            EnvironmentVariables = new ChangeTrackingList<ScriptEnvironmentVariable>();
            RetentionInterval = retentionInterval;
            AzCliVersion = azCliVersion;
            Kind = ScriptType.AzureCLI;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCliScript"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Optional property. Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="kind"> Type of the script. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="containerSettings"> Container settings. </param>
        /// <param name="storageAccountSettings"> Storage Account settings. </param>
        /// <param name="cleanupPreference"> The clean up preference when the script execution gets in a terminal state. Default setting is 'Always'. </param>
        /// <param name="provisioningState"> State of the script execution. This only appears in the response. </param>
        /// <param name="status"> Contains the results of script execution. </param>
        /// <param name="outputs"> List of script outputs. </param>
        /// <param name="primaryScriptUri"> Uri for the script. This is the entry point for the external script. </param>
        /// <param name="supportingScriptUris"> Supporting files for the external script. </param>
        /// <param name="scriptContent"> Script body. </param>
        /// <param name="arguments"> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location 'West US 2'. </param>
        /// <param name="environmentVariables"> The environment variables to pass over to the script. </param>
        /// <param name="forceUpdateTag"> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </param>
        /// <param name="retentionInterval"> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </param>
        /// <param name="timeout"> Maximum allowed script execution time specified in ISO 8601 format. Default value is P1D. </param>
        /// <param name="azCliVersion"> Azure CLI module version to be used. </param>
        internal AzureCliScript(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ArmDeploymentScriptManagedIdentity identity, AzureLocation location, IDictionary<string, string> tags, ScriptType kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ContainerConfiguration containerSettings, ScriptStorageConfiguration storageAccountSettings, ScriptCleanupOptions? cleanupPreference, ScriptProvisioningState? provisioningState, ScriptStatus status, BinaryData outputs, Uri primaryScriptUri, IList<Uri> supportingScriptUris, string scriptContent, string arguments, IList<ScriptEnvironmentVariable> environmentVariables, string forceUpdateTag, TimeSpan retentionInterval, TimeSpan? timeout, string azCliVersion) : base(id, name, resourceType, systemData, identity, location, tags, kind, serializedAdditionalRawData)
        {
            ContainerSettings = containerSettings;
            StorageAccountSettings = storageAccountSettings;
            CleanupPreference = cleanupPreference;
            ProvisioningState = provisioningState;
            Status = status;
            Outputs = outputs;
            PrimaryScriptUri = primaryScriptUri;
            SupportingScriptUris = supportingScriptUris;
            ScriptContent = scriptContent;
            Arguments = arguments;
            EnvironmentVariables = environmentVariables;
            ForceUpdateTag = forceUpdateTag;
            RetentionInterval = retentionInterval;
            Timeout = timeout;
            AzCliVersion = azCliVersion;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCliScript"/> for deserialization. </summary>
        internal AzureCliScript()
        {
        }

        /// <summary> Container settings. </summary>
        internal ContainerConfiguration ContainerSettings { get; set; }
        /// <summary> Container group name, if not specified then the name will get auto-generated. Not specifying a 'containerGroupName' indicates the system to generate a unique name which might end up flagging an Azure Policy as non-compliant. Use 'containerGroupName' when you have an Azure Policy that expects a specific naming convention or when you want to fully control the name. 'containerGroupName' property must be between 1 and 63 characters long, must contain only lowercase letters, numbers, and dashes and it cannot start or end with a dash and consecutive dashes are not allowed. To specify a 'containerGroupName', add the following object to properties: { "containerSettings": { "containerGroupName": "contoso-container" } }. If you do not want to specify a 'containerGroupName' then do not add 'containerSettings' property. </summary>
        public string ContainerGroupName
        {
            get => ContainerSettings is null ? default : ContainerSettings.ContainerGroupName;
            set
            {
                if (ContainerSettings is null)
                    ContainerSettings = new ContainerConfiguration();
                ContainerSettings.ContainerGroupName = value;
            }
        }

        /// <summary> Storage Account settings. </summary>
        public ScriptStorageConfiguration StorageAccountSettings { get; set; }
        /// <summary> The clean up preference when the script execution gets in a terminal state. Default setting is 'Always'. </summary>
        public ScriptCleanupOptions? CleanupPreference { get; set; }
        /// <summary> State of the script execution. This only appears in the response. </summary>
        public ScriptProvisioningState? ProvisioningState { get; }
        /// <summary> Contains the results of script execution. </summary>
        public ScriptStatus Status { get; }
        /// <summary>
        /// List of script outputs.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Outputs { get; }
        /// <summary> Uri for the script. This is the entry point for the external script. </summary>
        public Uri PrimaryScriptUri { get; set; }
        /// <summary> Supporting files for the external script. </summary>
        public IList<Uri> SupportingScriptUris { get; }
        /// <summary> Script body. </summary>
        public string ScriptContent { get; set; }
        /// <summary> Command line arguments to pass to the script. Arguments are separated by spaces. ex: -Name blue* -Location 'West US 2'. </summary>
        public string Arguments { get; set; }
        /// <summary> The environment variables to pass over to the script. </summary>
        public IList<ScriptEnvironmentVariable> EnvironmentVariables { get; }
        /// <summary> Gets or sets how the deployment script should be forced to execute even if the script resource has not changed. Can be current time stamp or a GUID. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> Interval for which the service retains the script resource after it reaches a terminal state. Resource will be deleted when this duration expires. Duration is based on ISO 8601 pattern (for example P1D means one day). </summary>
        public TimeSpan RetentionInterval { get; set; }
        /// <summary> Maximum allowed script execution time specified in ISO 8601 format. Default value is P1D. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Azure CLI module version to be used. </summary>
        public string AzCliVersion { get; set; }
    }
}
