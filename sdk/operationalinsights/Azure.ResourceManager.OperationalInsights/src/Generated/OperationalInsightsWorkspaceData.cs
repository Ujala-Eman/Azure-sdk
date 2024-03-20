// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing the OperationalInsightsWorkspace data model.
    /// The top level Workspace resource container.
    /// </summary>
    public partial class OperationalInsightsWorkspaceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public OperationalInsightsWorkspaceData(AzureLocation location) : base(location)
        {
            PrivateLinkScopedResources = new ChangeTrackingList<OperationalInsightsPrivateLinkScopedResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="etag"> The etag of the workspace. </param>
        /// <param name="provisioningState"> The provisioning state of the workspace. </param>
        /// <param name="customerId"> This is a read-only property. Represents the ID associated with the workspace. </param>
        /// <param name="sku"> The SKU of the workspace. </param>
        /// <param name="retentionInDays"> The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details. </param>
        /// <param name="workspaceCapping"> The daily volume cap for ingestion. </param>
        /// <param name="createdOn"> Workspace creation date. </param>
        /// <param name="modifiedOn"> Workspace modification date. </param>
        /// <param name="publicNetworkAccessForIngestion"> The network access type for accessing Log Analytics ingestion. </param>
        /// <param name="publicNetworkAccessForQuery"> The network access type for accessing Log Analytics query. </param>
        /// <param name="forceCmkForQuery"> Indicates whether customer managed storage is mandatory for query management. </param>
        /// <param name="privateLinkScopedResources"> List of linked private link scope resources. </param>
        /// <param name="features"> Workspace features. </param>
        /// <param name="defaultDataCollectionRuleResourceId"> The resource ID of the default Data Collection Rule to use for this workspace. Expected format is - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ETag? etag, OperationalInsightsWorkspaceEntityStatus? provisioningState, Guid? customerId, OperationalInsightsWorkspaceSku sku, int? retentionInDays, OperationalInsightsWorkspaceCapping workspaceCapping, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, OperationalInsightsPublicNetworkAccessType? publicNetworkAccessForIngestion, OperationalInsightsPublicNetworkAccessType? publicNetworkAccessForQuery, bool? forceCmkForQuery, IReadOnlyList<OperationalInsightsPrivateLinkScopedResourceInfo> privateLinkScopedResources, OperationalInsightsWorkspaceFeatures features, ResourceIdentifier defaultDataCollectionRuleResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ETag = etag;
            ProvisioningState = provisioningState;
            CustomerId = customerId;
            Sku = sku;
            RetentionInDays = retentionInDays;
            WorkspaceCapping = workspaceCapping;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            PublicNetworkAccessForIngestion = publicNetworkAccessForIngestion;
            PublicNetworkAccessForQuery = publicNetworkAccessForQuery;
            ForceCmkForQuery = forceCmkForQuery;
            PrivateLinkScopedResources = privateLinkScopedResources;
            Features = features;
            DefaultDataCollectionRuleResourceId = defaultDataCollectionRuleResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceData"/> for deserialization. </summary>
        internal OperationalInsightsWorkspaceData()
        {
        }

        /// <summary> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The etag of the workspace. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The provisioning state of the workspace. </summary>
        public OperationalInsightsWorkspaceEntityStatus? ProvisioningState { get; }
        /// <summary> This is a read-only property. Represents the ID associated with the workspace. </summary>
        public Guid? CustomerId { get; }
        /// <summary> The SKU of the workspace. </summary>
        public OperationalInsightsWorkspaceSku Sku { get; set; }
        /// <summary> The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details. </summary>
        public int? RetentionInDays { get; set; }
        /// <summary> The daily volume cap for ingestion. </summary>
        public OperationalInsightsWorkspaceCapping WorkspaceCapping { get; set; }
        /// <summary> Workspace creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Workspace modification date. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> The network access type for accessing Log Analytics ingestion. </summary>
        public OperationalInsightsPublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary> The network access type for accessing Log Analytics query. </summary>
        public OperationalInsightsPublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary> Indicates whether customer managed storage is mandatory for query management. </summary>
        public bool? ForceCmkForQuery { get; set; }
        /// <summary> List of linked private link scope resources. </summary>
        public IReadOnlyList<OperationalInsightsPrivateLinkScopedResourceInfo> PrivateLinkScopedResources { get; }
        /// <summary> Workspace features. </summary>
        public OperationalInsightsWorkspaceFeatures Features { get; set; }
        /// <summary> The resource ID of the default Data Collection Rule to use for this workspace. Expected format is - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}. </summary>
        public ResourceIdentifier DefaultDataCollectionRuleResourceId { get; set; }
    }
}
