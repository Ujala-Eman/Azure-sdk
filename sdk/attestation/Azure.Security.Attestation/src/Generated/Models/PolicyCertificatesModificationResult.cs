// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.Attestation
{
    /// <summary> The result of a policy certificate modification. </summary>
    public partial class PolicyCertificatesModificationResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicyCertificatesModificationResult"/>. </summary>
        public PolicyCertificatesModificationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyCertificatesModificationResult"/>. </summary>
        /// <param name="certificateThumbprint"> Hex encoded SHA1 Hash of the binary representation certificate which was added or removed. </param>
        /// <param name="certificateResolution"> The result of the operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyCertificatesModificationResult(string certificateThumbprint, PolicyCertificateResolution? certificateResolution, Dictionary<string, BinaryData> rawData)
        {
            CertificateThumbprint = certificateThumbprint;
            CertificateResolution = certificateResolution;
            _rawData = rawData;
        }

        /// <summary> Hex encoded SHA1 Hash of the binary representation certificate which was added or removed. </summary>
        public string CertificateThumbprint { get; set; }
        /// <summary> The result of the operation. </summary>
        public PolicyCertificateResolution? CertificateResolution { get; set; }
    }
}
