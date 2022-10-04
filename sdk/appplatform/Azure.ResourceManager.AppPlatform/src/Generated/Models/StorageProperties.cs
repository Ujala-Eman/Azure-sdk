// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// Storage resource payload.
    /// Please note <see cref="StorageProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="StorageAccount"/>.
    /// </summary>
    public abstract partial class StorageProperties
    {
        /// <summary> Initializes a new instance of StorageProperties. </summary>
        protected StorageProperties()
        {
        }

        /// <summary> Initializes a new instance of StorageProperties. </summary>
        /// <param name="storageType"> The type of the storage. </param>
        internal StorageProperties(StorageType storageType)
        {
            StorageType = storageType;
        }

        /// <summary> The type of the storage. </summary>
        internal StorageType StorageType { get; set; }
    }
}
