// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// Certificate resource payload.
    /// Please note <see cref="CertificateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContentCertificateProperties"/> and <see cref="KeyVaultCertificateProperties"/>.
    /// </summary>
    public partial class CertificateProperties
    {
        /// <summary> Initializes a new instance of CertificateProperties. </summary>
        public CertificateProperties()
        {
            DnsNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CertificateProperties. </summary>
        /// <param name="certificatePropertiesType"> The type of the certificate source. </param>
        /// <param name="thumbprint"> The thumbprint of certificate. </param>
        /// <param name="issuer"> The issuer of certificate. </param>
        /// <param name="issuedDate"> The issue date of certificate. </param>
        /// <param name="expirationDate"> The expiration date of certificate. </param>
        /// <param name="activateDate"> The activate date of certificate. </param>
        /// <param name="subjectName"> The subject name of certificate. </param>
        /// <param name="dnsNames"> The domain list of certificate. </param>
        internal CertificateProperties(string certificatePropertiesType, string thumbprint, string issuer, string issuedDate, string expirationDate, string activateDate, string subjectName, IReadOnlyList<string> dnsNames)
        {
            CertificatePropertiesType = certificatePropertiesType;
            Thumbprint = thumbprint;
            Issuer = issuer;
            IssuedDate = issuedDate;
            ExpirationDate = expirationDate;
            ActivateDate = activateDate;
            SubjectName = subjectName;
            DnsNames = dnsNames;
        }

        /// <summary> The type of the certificate source. </summary>
        internal string CertificatePropertiesType { get; set; }
        /// <summary> The thumbprint of certificate. </summary>
        public string Thumbprint { get; }
        /// <summary> The issuer of certificate. </summary>
        public string Issuer { get; }
        /// <summary> The issue date of certificate. </summary>
        public string IssuedDate { get; }
        /// <summary> The expiration date of certificate. </summary>
        public string ExpirationDate { get; }
        /// <summary> The activate date of certificate. </summary>
        public string ActivateDate { get; }
        /// <summary> The subject name of certificate. </summary>
        public string SubjectName { get; }
        /// <summary> The domain list of certificate. </summary>
        public IReadOnlyList<string> DnsNames { get; }
    }
}
