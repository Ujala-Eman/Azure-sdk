// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Request type document. </summary>
    internal partial class RequestDocumentIngress : DocumentIngress
    {
        /// <summary> Initializes a new instance of <see cref="RequestDocumentIngress"/>. </summary>
        public RequestDocumentIngress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RequestDocumentIngress"/>. </summary>
        /// <param name="documentType"> Telemetry type. Types not defined in enum will get replaced with a 'Unknown' type. </param>
        /// <param name="documentStreamIds"> An array of document streaming ids. Each id identifies a flow of documents customized by UX customers. </param>
        /// <param name="properties"> Collection of custom properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Name of the request, e.g., 'GET /values/{id}'. </param>
        /// <param name="url"> Request URL with all query string parameters. </param>
        /// <param name="responseCode"> Result of a request execution. For http requestss, it could be some HTTP status code. </param>
        /// <param name="duration"> Request duration in ISO 8601 duration format, i.e., P[n]Y[n]M[n]DT[n]H[n]M[n]S or P[n]W. </param>
        internal RequestDocumentIngress(DocumentIngressDocumentType? documentType, IList<string> documentStreamIds, IList<KeyValuePairString> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, string url, string responseCode, string duration) : base(documentType, documentStreamIds, properties, serializedAdditionalRawData)
        {
            Name = name;
            Url = url;
            ResponseCode = responseCode;
            Duration = duration;
        }

        /// <summary> Name of the request, e.g., 'GET /values/{id}'. </summary>
        public string Name { get; set; }
        /// <summary> Request URL with all query string parameters. </summary>
        public string Url { get; set; }
        /// <summary> Result of a request execution. For http requestss, it could be some HTTP status code. </summary>
        public string ResponseCode { get; set; }
        /// <summary> Request duration in ISO 8601 duration format, i.e., P[n]Y[n]M[n]DT[n]H[n]M[n]S or P[n]W. </summary>
        public string Duration { get; set; }
    }
}
