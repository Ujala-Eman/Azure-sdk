// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Item Level kubernetes persistent volume target info for restore operation. </summary>
    public partial class KubernetesPVRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesPVRestoreCriteria"/>. </summary>
        public KubernetesPVRestoreCriteria()
        {
            ObjectType = "KubernetesPVRestoreCriteria";
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesPVRestoreCriteria"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="name"> Selected persistent volume claim name. </param>
        /// <param name="storageClassName"> Selected storage class name for restore operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesPVRestoreCriteria(string objectType, string name, string storageClassName, Dictionary<string, BinaryData> rawData) : base(objectType, rawData)
        {
            Name = name;
            StorageClassName = storageClassName;
            ObjectType = objectType ?? "KubernetesPVRestoreCriteria";
        }

        /// <summary> Selected persistent volume claim name. </summary>
        public string Name { get; set; }
        /// <summary> Selected storage class name for restore operation. </summary>
        public string StorageClassName { get; set; }
    }
}
