// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The custom domain assigned to this storage account. This can be set via Update. </summary>
    public partial class StorageCustomDomain
    {
        /// <summary> Initializes a new instance of StorageCustomDomain. </summary>
        /// <param name="name"> Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public StorageCustomDomain(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of StorageCustomDomain. </summary>
        /// <param name="name"> Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source. </param>
        /// <param name="useSubDomainName"> Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates. </param>
        internal StorageCustomDomain(string name, bool? useSubDomainName)
        {
            Name = name;
            UseSubDomainName = useSubDomainName;
        }

        /// <summary> Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source. </summary>
        public string Name { get; set; }
        /// <summary> Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates. </summary>
        public bool? UseSubDomainName { get; set; }
    }
}
