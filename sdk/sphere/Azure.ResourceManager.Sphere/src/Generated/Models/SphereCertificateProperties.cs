// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// The properties of certificate
    /// Serialized Name: CertificateProperties
    /// </summary>
    public partial class SphereCertificateProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SphereCertificateProperties"/>. </summary>
        internal SphereCertificateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereCertificateProperties"/>. </summary>
        /// <param name="certificate">
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: CertificateProperties.certificate
        /// </param>
        /// <param name="status">
        /// The certificate status.
        /// Serialized Name: CertificateProperties.status
        /// </param>
        /// <param name="subject">
        /// The certificate subject.
        /// Serialized Name: CertificateProperties.subject
        /// </param>
        /// <param name="thumbprint">
        /// The certificate thumbprint.
        /// Serialized Name: CertificateProperties.thumbprint
        /// </param>
        /// <param name="expiryUtc">
        /// The certificate expiry date.
        /// Serialized Name: CertificateProperties.expiryUtc
        /// </param>
        /// <param name="notBeforeUtc">
        /// The certificate not before date.
        /// Serialized Name: CertificateProperties.notBeforeUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: CertificateProperties.provisioningState
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereCertificateProperties(string certificate, SphereCertificateStatus? status, string subject, string thumbprint, DateTimeOffset? expiryUtc, DateTimeOffset? notBeforeUtc, SphereProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Certificate = certificate;
            Status = status;
            Subject = subject;
            Thumbprint = thumbprint;
            ExpiryUtc = expiryUtc;
            NotBeforeUtc = notBeforeUtc;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: CertificateProperties.certificate
        /// </summary>
        public string Certificate { get; }
        /// <summary>
        /// The certificate status.
        /// Serialized Name: CertificateProperties.status
        /// </summary>
        public SphereCertificateStatus? Status { get; }
        /// <summary>
        /// The certificate subject.
        /// Serialized Name: CertificateProperties.subject
        /// </summary>
        public string Subject { get; }
        /// <summary>
        /// The certificate thumbprint.
        /// Serialized Name: CertificateProperties.thumbprint
        /// </summary>
        public string Thumbprint { get; }
        /// <summary>
        /// The certificate expiry date.
        /// Serialized Name: CertificateProperties.expiryUtc
        /// </summary>
        public DateTimeOffset? ExpiryUtc { get; }
        /// <summary>
        /// The certificate not before date.
        /// Serialized Name: CertificateProperties.notBeforeUtc
        /// </summary>
        public DateTimeOffset? NotBeforeUtc { get; }
        /// <summary>
        /// The status of the last operation.
        /// Serialized Name: CertificateProperties.provisioningState
        /// </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}
