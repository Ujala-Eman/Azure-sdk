// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> The replication policy between two storage accounts. Multiple rules can be defined in one policy. </summary>
    public partial class ObjectReplicationPolicy : Resource
    {
        /// <summary> Initializes a new instance of ObjectReplicationPolicy. </summary>
        public ObjectReplicationPolicy()
        {
        }

        /// <summary> Initializes a new instance of ObjectReplicationPolicy. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="policyId"> A unique id for object replication policy. </param>
        /// <param name="enabledTime"> Indicates when the policy is enabled on the source account. </param>
        /// <param name="sourceAccount"> Required. Source account name. </param>
        /// <param name="destinationAccount"> Required. Destination account name. </param>
        /// <param name="rules"> The storage account object replication rules. </param>
        internal ObjectReplicationPolicy(string id, string name, string type, string policyId, DateTimeOffset? enabledTime, string sourceAccount, string destinationAccount, IList<ObjectReplicationPolicyRule> rules) : base(id, name, type)
        {
            PolicyId = policyId;
            EnabledTime = enabledTime;
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Rules = rules;
        }

        /// <summary> A unique id for object replication policy. </summary>
        public string PolicyId { get; }
        /// <summary> Indicates when the policy is enabled on the source account. </summary>
        public DateTimeOffset? EnabledTime { get; }
        /// <summary> Required. Source account name. </summary>
        public string SourceAccount { get; set; }
        /// <summary> Required. Destination account name. </summary>
        public string DestinationAccount { get; set; }
        /// <summary> The storage account object replication rules. </summary>
        public IList<ObjectReplicationPolicyRule> Rules { get; set; }
    }
}
