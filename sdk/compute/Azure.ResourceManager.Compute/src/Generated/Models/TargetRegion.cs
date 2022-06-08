// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the target region information. </summary>
    public partial class TargetRegion
    {
        /// <summary> Initializes a new instance of <see cref="TargetRegion"/>. </summary>
        /// <param name="name"> The name of the region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public TargetRegion(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="TargetRegion"/>. </summary>
        /// <param name="name"> The name of the region. </param>
        /// <param name="regionalReplicaCount"> The number of replicas of the Image Version to be created per region. This property is updatable. </param>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to store the image. This property is not updatable. </param>
        /// <param name="encryption"> Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact. </param>
        internal TargetRegion(string name, int? regionalReplicaCount, StorageAccountType? storageAccountType, EncryptionImages encryption)
        {
            Name = name;
            RegionalReplicaCount = regionalReplicaCount;
            StorageAccountType = storageAccountType;
            Encryption = encryption;
        }

        /// <summary> The name of the region. </summary>
        public string Name { get; set; }
        /// <summary> The number of replicas of the Image Version to be created per region. This property is updatable. </summary>
        public int? RegionalReplicaCount { get; set; }
        /// <summary> Specifies the storage account type to be used to store the image. This property is not updatable. </summary>
        public StorageAccountType? StorageAccountType { get; set; }
        /// <summary> Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact. </summary>
        public EncryptionImages Encryption { get; set; }
    }
}
