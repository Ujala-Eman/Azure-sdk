// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Trigger details. </summary>
    public partial class EdgeFileEventTrigger : DataBoxEdgeTriggerData
    {
        /// <summary> Initializes a new instance of <see cref="EdgeFileEventTrigger"/>. </summary>
        /// <param name="sourceInfo"> File event source details. </param>
        /// <param name="sinkInfo"> Role sink info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceInfo"/> or <paramref name="sinkInfo"/> is null. </exception>
        public EdgeFileEventTrigger(EdgeFileSourceInfo sourceInfo, DataBoxEdgeRoleSinkInfo sinkInfo)
        {
            Argument.AssertNotNull(sourceInfo, nameof(sourceInfo));
            Argument.AssertNotNull(sinkInfo, nameof(sinkInfo));

            SourceInfo = sourceInfo;
            SinkInfo = sinkInfo;
            Kind = TriggerEventType.FileEvent;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeFileEventTrigger"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Trigger Kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sourceInfo"> File event source details. </param>
        /// <param name="sinkInfo"> Role sink info. </param>
        /// <param name="customContextTag"> A custom context tag typically used to correlate the trigger against its usage. For example, if a periodic timer trigger is intended for certain specific IoT modules in the device, the tag can be the name or the image URL of the module. </param>
        internal EdgeFileEventTrigger(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggerEventType kind, IDictionary<string, BinaryData> serializedAdditionalRawData, EdgeFileSourceInfo sourceInfo, DataBoxEdgeRoleSinkInfo sinkInfo, string customContextTag) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            SourceInfo = sourceInfo;
            SinkInfo = sinkInfo;
            CustomContextTag = customContextTag;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeFileEventTrigger"/> for deserialization. </summary>
        internal EdgeFileEventTrigger()
        {
        }

        /// <summary> File event source details. </summary>
        internal EdgeFileSourceInfo SourceInfo { get; set; }
        /// <summary> File share ID. </summary>
        public ResourceIdentifier SourceInfoShareId
        {
            get => SourceInfo is null ? default : SourceInfo.ShareId;
            set => SourceInfo = new EdgeFileSourceInfo(value);
        }

        /// <summary> Role sink info. </summary>
        internal DataBoxEdgeRoleSinkInfo SinkInfo { get; set; }
        /// <summary> Compute role ID. </summary>
        public ResourceIdentifier SinkInfoRoleId
        {
            get => SinkInfo is null ? default : SinkInfo.RoleId;
            set => SinkInfo = new DataBoxEdgeRoleSinkInfo(value);
        }

        /// <summary> A custom context tag typically used to correlate the trigger against its usage. For example, if a periodic timer trigger is intended for certain specific IoT modules in the device, the tag can be the name or the image URL of the module. </summary>
        public string CustomContextTag { get; set; }
    }
}
