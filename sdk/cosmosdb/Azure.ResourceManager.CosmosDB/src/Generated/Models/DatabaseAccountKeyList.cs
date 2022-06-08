// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The access keys for the given database account. </summary>
    public partial class DatabaseAccountKeyList : DatabaseAccountReadOnlyKeyList
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseAccountKeyList"/>. </summary>
        internal DatabaseAccountKeyList()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseAccountKeyList"/>. </summary>
        /// <param name="primaryReadonlyMasterKey"> Base 64 encoded value of the primary read-only key. </param>
        /// <param name="secondaryReadonlyMasterKey"> Base 64 encoded value of the secondary read-only key. </param>
        /// <param name="primaryMasterKey"> Base 64 encoded value of the primary read-write key. </param>
        /// <param name="secondaryMasterKey"> Base 64 encoded value of the secondary read-write key. </param>
        internal DatabaseAccountKeyList(string primaryReadonlyMasterKey, string secondaryReadonlyMasterKey, string primaryMasterKey, string secondaryMasterKey) : base(primaryReadonlyMasterKey, secondaryReadonlyMasterKey)
        {
            PrimaryMasterKey = primaryMasterKey;
            SecondaryMasterKey = secondaryMasterKey;
        }

        /// <summary> Base 64 encoded value of the primary read-write key. </summary>
        public string PrimaryMasterKey { get; }
        /// <summary> Base 64 encoded value of the secondary read-write key. </summary>
        public string SecondaryMasterKey { get; }
    }
}
