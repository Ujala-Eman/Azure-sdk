// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> The entity. </summary>
    public partial class EntityData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="EntityData"/>. </summary>
        internal EntityData()
        {
            ParentDisplayNameChain = new ChangeTrackingList<string>();
            ParentNameChain = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EntityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tenantId"> The AAD Tenant ID associated with the entity. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="displayName"> The friendly name of the management group. </param>
        /// <param name="parent"> (Optional) The ID of the parent management group. </param>
        /// <param name="permissions"> The users specific permissions to this item. </param>
        /// <param name="inheritedPermissions"> The users specific permissions to this item. </param>
        /// <param name="numberOfDescendants"> Number of Descendants. </param>
        /// <param name="numberOfChildren"> Number of children is the number of Groups and Subscriptions that are exactly one level underneath the current Group. </param>
        /// <param name="numberOfChildGroups"> Number of children is the number of Groups that are exactly one level underneath the current Group. </param>
        /// <param name="parentDisplayNameChain"> The parent display name chain from the root group to the immediate parent. </param>
        /// <param name="parentNameChain"> The parent name chain from the root group to the immediate parent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? tenantId, string displayName, SubResource parent, EntityPermission? permissions, EntityPermission? inheritedPermissions, int? numberOfDescendants, int? numberOfChildren, int? numberOfChildGroups, IReadOnlyList<string> parentDisplayNameChain, IReadOnlyList<string> parentNameChain, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TenantId = tenantId;
            DisplayName = displayName;
            Parent = parent;
            Permissions = permissions;
            InheritedPermissions = inheritedPermissions;
            NumberOfDescendants = numberOfDescendants;
            NumberOfChildren = numberOfChildren;
            NumberOfChildGroups = numberOfChildGroups;
            ParentDisplayNameChain = parentDisplayNameChain;
            ParentNameChain = parentNameChain;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The AAD Tenant ID associated with the entity. For example, 00000000-0000-0000-0000-000000000000. </summary>
        public Guid? TenantId { get; }
        /// <summary> The friendly name of the management group. </summary>
        public string DisplayName { get; }
        /// <summary> (Optional) The ID of the parent management group. </summary>
        internal SubResource Parent { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier ParentId
        {
            get => Parent?.Id;
        }

        /// <summary> The users specific permissions to this item. </summary>
        public EntityPermission? Permissions { get; }
        /// <summary> The users specific permissions to this item. </summary>
        public EntityPermission? InheritedPermissions { get; }
        /// <summary> Number of Descendants. </summary>
        public int? NumberOfDescendants { get; }
        /// <summary> Number of children is the number of Groups and Subscriptions that are exactly one level underneath the current Group. </summary>
        public int? NumberOfChildren { get; }
        /// <summary> Number of children is the number of Groups that are exactly one level underneath the current Group. </summary>
        public int? NumberOfChildGroups { get; }
        /// <summary> The parent display name chain from the root group to the immediate parent. </summary>
        public IReadOnlyList<string> ParentDisplayNameChain { get; }
        /// <summary> The parent name chain from the root group to the immediate parent. </summary>
        public IReadOnlyList<string> ParentNameChain { get; }
    }
}
