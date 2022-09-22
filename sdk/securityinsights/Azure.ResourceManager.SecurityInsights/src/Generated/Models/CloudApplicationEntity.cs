// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a cloud application entity. </summary>
    public partial class CloudApplicationEntity : EntityData
    {
        /// <summary> Initializes a new instance of CloudApplicationEntity. </summary>
        public CloudApplicationEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = EntityKind.CloudApplication;
        }

        /// <summary> Initializes a new instance of CloudApplicationEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="appId"> The technical identifier of the application. </param>
        /// <param name="appName"> The name of the related cloud application. </param>
        /// <param name="instanceName"> The user defined instance name of the cloud application. It is often used to distinguish between several applications of the same type that a customer has. </param>
        internal CloudApplicationEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, int? appId, string appName, string instanceName) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AppId = appId;
            AppName = appName;
            InstanceName = instanceName;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The technical identifier of the application. </summary>
        public int? AppId { get; }
        /// <summary> The name of the related cloud application. </summary>
        public string AppName { get; }
        /// <summary> The user defined instance name of the cloud application. It is often used to distinguish between several applications of the same type that a customer has. </summary>
        public string InstanceName { get; }
    }
}
