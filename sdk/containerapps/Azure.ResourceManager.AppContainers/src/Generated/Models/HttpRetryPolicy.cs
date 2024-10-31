// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Policy that defines http request retry conditions. </summary>
    public partial class HttpRetryPolicy
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HttpRetryPolicy"/>. </summary>
        public HttpRetryPolicy()
        {
            Headers = new ChangeTrackingList<HeaderMatch>();
            HttpStatusCodes = new ChangeTrackingList<int>();
            Errors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HttpRetryPolicy"/>. </summary>
        /// <param name="maxRetries"> Maximum number of times a request will retry. </param>
        /// <param name="headers"> Headers that must be present for a request to be retried. </param>
        /// <param name="httpStatusCodes"> Additional http status codes that can trigger a retry. </param>
        /// <param name="errors"> Errors that can trigger a retry. </param>
        /// <param name="initialDelayInMilliseconds"> Initial delay, in milliseconds, before retrying a request. </param>
        /// <param name="maxIntervalInMilliseconds"> Maximum interval, in milliseconds, between retries. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HttpRetryPolicy(int? maxRetries, IList<HeaderMatch> headers, IList<int> httpStatusCodes, IList<string> errors, long? initialDelayInMilliseconds, long? maxIntervalInMilliseconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxRetries = maxRetries;
            Headers = headers;
            HttpStatusCodes = httpStatusCodes;
            Errors = errors;
            InitialDelayInMilliseconds = initialDelayInMilliseconds;
            MaxIntervalInMilliseconds = maxIntervalInMilliseconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Maximum number of times a request will retry. </summary>
        [WirePath("maxRetries")]
        public int? MaxRetries { get; set; }
        /// <summary> Headers that must be present for a request to be retried. </summary>
        [WirePath("matches.headers")]
        public IList<HeaderMatch> Headers { get; }
        /// <summary> Additional http status codes that can trigger a retry. </summary>
        [WirePath("matches.httpStatusCodes")]
        public IList<int> HttpStatusCodes { get; }
        /// <summary> Errors that can trigger a retry. </summary>
        [WirePath("matches.errors")]
        public IList<string> Errors { get; }
        /// <summary> Initial delay, in milliseconds, before retrying a request. </summary>
        [WirePath("retryBackOff.initialDelayInMilliseconds")]
        public long? InitialDelayInMilliseconds { get; set; }
        /// <summary> Maximum interval, in milliseconds, between retries. </summary>
        [WirePath("retryBackOff.maxIntervalInMilliseconds")]
        public long? MaxIntervalInMilliseconds { get; set; }
    }
}
