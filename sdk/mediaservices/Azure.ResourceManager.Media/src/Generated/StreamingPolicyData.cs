// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class representing the StreamingPolicy data model. </summary>
    public partial class StreamingPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of StreamingPolicyData. </summary>
        public StreamingPolicyData()
        {
        }

        /// <summary> Initializes a new instance of StreamingPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Creation time of Streaming Policy. </param>
        /// <param name="defaultContentKeyPolicyName"> Default ContentKey used by current Streaming Policy. </param>
        /// <param name="envelopeEncryption"> Configuration of EnvelopeEncryption. </param>
        /// <param name="commonEncryptionCenc"> Configuration of CommonEncryptionCenc. </param>
        /// <param name="commonEncryptionCbcs"> Configuration of CommonEncryptionCbcs. </param>
        /// <param name="noEncryption"> Configurations of NoEncryption. </param>
        internal StreamingPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, string defaultContentKeyPolicyName, EnvelopeEncryption envelopeEncryption, CommonEncryptionCenc commonEncryptionCenc, CommonEncryptionCbcs commonEncryptionCbcs, NoEncryption noEncryption) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            DefaultContentKeyPolicyName = defaultContentKeyPolicyName;
            EnvelopeEncryption = envelopeEncryption;
            CommonEncryptionCenc = commonEncryptionCenc;
            CommonEncryptionCbcs = commonEncryptionCbcs;
            NoEncryption = noEncryption;
        }

        /// <summary> Creation time of Streaming Policy. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Default ContentKey used by current Streaming Policy. </summary>
        public string DefaultContentKeyPolicyName { get; set; }
        /// <summary> Configuration of EnvelopeEncryption. </summary>
        public EnvelopeEncryption EnvelopeEncryption { get; set; }
        /// <summary> Configuration of CommonEncryptionCenc. </summary>
        public CommonEncryptionCenc CommonEncryptionCenc { get; set; }
        /// <summary> Configuration of CommonEncryptionCbcs. </summary>
        public CommonEncryptionCbcs CommonEncryptionCbcs { get; set; }
        /// <summary> Configurations of NoEncryption. </summary>
        internal NoEncryption NoEncryption { get; set; }
        /// <summary> Representing supported protocols. </summary>
        public MediaEnabledProtocols NoEncryptionEnabledProtocols
        {
            get => NoEncryption is null ? default : NoEncryption.EnabledProtocols;
            set
            {
                if (NoEncryption is null)
                    NoEncryption = new NoEncryption();
                NoEncryption.EnabledProtocols = value;
            }
        }
    }
}
