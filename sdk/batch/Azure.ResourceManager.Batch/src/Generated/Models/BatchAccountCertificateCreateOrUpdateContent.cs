// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Contains information about a certificate. </summary>
    public partial class BatchAccountCertificateCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of BatchAccountCertificateCreateOrUpdateContent. </summary>
        public BatchAccountCertificateCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of BatchAccountCertificateCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thumbprintAlgorithm"> This must match the first portion of the certificate name. Currently required to be &apos;SHA1&apos;. </param>
        /// <param name="thumbprint"> This must match the thumbprint from the name. </param>
        /// <param name="format"> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </param>
        /// <param name="data"> The maximum size is 10KB. </param>
        /// <param name="password"> This must not be specified if the certificate format is Cer. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        internal BatchAccountCertificateCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string thumbprintAlgorithm, BinaryData thumbprint, BatchAccountCertificateFormat? format, BinaryData data, string password, ETag? etag) : base(id, name, resourceType, systemData)
        {
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Thumbprint = thumbprint;
            Format = format;
            Data = data;
            Password = password;
            ETag = etag;
        }

        /// <summary> This must match the first portion of the certificate name. Currently required to be &apos;SHA1&apos;. </summary>
        public string ThumbprintAlgorithm { get; set; }
        /// <summary>
        /// This must match the thumbprint from the name..
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
        /// <summary>
        /// The maximum size is 10KB..
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
        public BinaryData Data { get; set; }
        /// <summary> This must not be specified if the certificate format is Cer. </summary>
        public string Password { get; set; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
