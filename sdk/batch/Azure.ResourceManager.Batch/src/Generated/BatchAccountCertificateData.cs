// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary> A class representing the BatchAccountCertificate data model. </summary>
    public partial class BatchAccountCertificateData : ResourceData
    {
        /// <summary> Initializes a new instance of BatchAccountCertificateData. </summary>
        public BatchAccountCertificateData()
        {
        }

        /// <summary> Initializes a new instance of BatchAccountCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thumbprintAlgorithm"> This must match the first portion of the certificate name. Currently required to be &apos;SHA1&apos;. </param>
        /// <param name="thumbprint"> This must match the thumbprint from the name. </param>
        /// <param name="format"> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningStateTransitOn"> The time at which the certificate entered its current state. </param>
        /// <param name="previousProvisioningState"> The previous provisioned state of the resource. </param>
        /// <param name="previousProvisioningStateTransitOn"> The time at which the certificate entered its previous state. </param>
        /// <param name="publicData"> The public key of the certificate. </param>
        /// <param name="deleteCertificateError"> This is only returned when the certificate provisioningState is &apos;Failed&apos;. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        internal BatchAccountCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string thumbprintAlgorithm, BinaryData thumbprint, BatchAccountCertificateFormat? format, BatchAccountCertificateProvisioningState? provisioningState, DateTimeOffset? provisioningStateTransitOn, BatchAccountCertificateProvisioningState? previousProvisioningState, DateTimeOffset? previousProvisioningStateTransitOn, string publicData, ResponseError deleteCertificateError, ETag? etag) : base(id, name, resourceType, systemData)
        {
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Thumbprint = thumbprint;
            Format = format;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitOn = provisioningStateTransitOn;
            PreviousProvisioningState = previousProvisioningState;
            PreviousProvisioningStateTransitOn = previousProvisioningStateTransitOn;
            PublicData = publicData;
            DeleteCertificateError = deleteCertificateError;
            ETag = etag;
        }

        /// <summary> This must match the first portion of the certificate name. Currently required to be &apos;SHA1&apos;. </summary>
        public string ThumbprintAlgorithm { get; set; }
        /// <summary>
        /// This must match the thumbprint from the name.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Thumbprint { get; set; }
        /// <summary> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </summary>
        public BatchAccountCertificateFormat? Format { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public BatchAccountCertificateProvisioningState? ProvisioningState { get; }
        /// <summary> The time at which the certificate entered its current state. </summary>
        public DateTimeOffset? ProvisioningStateTransitOn { get; }
        /// <summary> The previous provisioned state of the resource. </summary>
        public BatchAccountCertificateProvisioningState? PreviousProvisioningState { get; }
        /// <summary> The time at which the certificate entered its previous state. </summary>
        public DateTimeOffset? PreviousProvisioningStateTransitOn { get; }
        /// <summary> The public key of the certificate. </summary>
        public string PublicData { get; }
        /// <summary> This is only returned when the certificate provisioningState is &apos;Failed&apos;. </summary>
        public ResponseError DeleteCertificateError { get; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
