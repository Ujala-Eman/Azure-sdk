// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </summary>
    public partial class CdnManagedHttpsContent : CustomDomainHttpsContent
    {
        /// <summary> Initializes a new instance of <see cref="CdnManagedHttpsContent"/>. </summary>
        /// <param name="protocolType"> Defines the TLS extension protocol that is used for secure delivery. </param>
        /// <param name="certificateSourceParameters"> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateSourceParameters"/> is null. </exception>
        public CdnManagedHttpsContent(SecureDeliveryProtocolType protocolType, CdnCertificateSource certificateSourceParameters) : base(protocolType)
        {
            Argument.AssertNotNull(certificateSourceParameters, nameof(certificateSourceParameters));

            CertificateSourceParameters = certificateSourceParameters;
            CertificateSource = CertificateSource.Cdn;
        }

        /// <summary> Initializes a new instance of <see cref="CdnManagedHttpsContent"/>. </summary>
        /// <param name="certificateSource"> Defines the source of the SSL certificate. </param>
        /// <param name="protocolType"> Defines the TLS extension protocol that is used for secure delivery. </param>
        /// <param name="minimumTlsVersion"> TLS protocol version that will be used for Https. </param>
        /// <param name="certificateSourceParameters"> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnManagedHttpsContent(CertificateSource certificateSource, SecureDeliveryProtocolType protocolType, CdnMinimumTlsVersion? minimumTlsVersion, CdnCertificateSource certificateSourceParameters, Dictionary<string, BinaryData> rawData) : base(certificateSource, protocolType, minimumTlsVersion, rawData)
        {
            CertificateSourceParameters = certificateSourceParameters;
            CertificateSource = certificateSource;
        }

        /// <summary> Initializes a new instance of <see cref="CdnManagedHttpsContent"/> for deserialization. </summary>
        internal CdnManagedHttpsContent()
        {
        }

        /// <summary> Defines the certificate source parameters using CDN managed certificate for enabling SSL. </summary>
        public CdnCertificateSource CertificateSourceParameters { get; set; }
    }
}
