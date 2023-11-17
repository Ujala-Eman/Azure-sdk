// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The UnknownCertificateProperties. </summary>
    internal partial class UnknownCertificateProperties : AppPlatformCertificateProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCertificateProperties"/>. </summary>
        /// <param name="certificatePropertiesType"> The type of the certificate source. </param>
        /// <param name="thumbprint"> The thumbprint of certificate. </param>
        /// <param name="issuer"> The issuer of certificate. </param>
        /// <param name="issuedOn"> The issue date of certificate. </param>
        /// <param name="expireOn"> The expiration date of certificate. </param>
        /// <param name="activateOn"> The activate date of certificate. </param>
        /// <param name="subjectName"> The subject name of certificate. </param>
        /// <param name="dnsNames"> The domain list of certificate. </param>
        /// <param name="provisioningState"> Provisioning state of the Certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCertificateProperties(string certificatePropertiesType, string thumbprint, string issuer, DateTimeOffset? issuedOn, DateTimeOffset? expireOn, DateTimeOffset? activateOn, string subjectName, IReadOnlyList<string> dnsNames, AppPlatformCertificateProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(certificatePropertiesType, thumbprint, issuer, issuedOn, expireOn, activateOn, subjectName, dnsNames, provisioningState, serializedAdditionalRawData)
        {
            CertificatePropertiesType = certificatePropertiesType ?? "Unknown";
        }
    }
}
