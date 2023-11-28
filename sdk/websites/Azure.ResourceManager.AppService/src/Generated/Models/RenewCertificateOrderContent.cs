// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing certificate renew request. </summary>
    public partial class RenewCertificateOrderContent : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RenewCertificateOrderContent"/>. </summary>
        public RenewCertificateOrderContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RenewCertificateOrderContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="keySize"> Certificate Key Size. </param>
        /// <param name="csr"> Csr to be used for re-key operation. </param>
        /// <param name="isPrivateKeyExternal"> Should we change the ASC type (from managed private key to external private key and vice versa). </param>
        /// <param name="kind"> Kind of resource. </param>
        internal RenewCertificateOrderContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? keySize, string csr, bool? isPrivateKeyExternal, string kind) : base(id, name, resourceType, systemData)
        {
            KeySize = keySize;
            Csr = csr;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            Kind = kind;
        }

        /// <summary> Certificate Key Size. </summary>
        public int? KeySize { get; set; }
        /// <summary> Csr to be used for re-key operation. </summary>
        public string Csr { get; set; }
        /// <summary> Should we change the ASC type (from managed private key to external private key and vice versa). </summary>
        public bool? IsPrivateKeyExternal { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
