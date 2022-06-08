// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> HTTPGet specifies the http request to perform. </summary>
    public partial class HttpRequestData
    {
        /// <summary> Initializes a new instance of <see cref="HttpRequestData"/>. </summary>
        /// <param name="port"> Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. </param>
        public HttpRequestData(int port)
        {
            HttpHeaders = new ChangeTrackingList<HttpHeaderData>();
            Port = port;
        }

        /// <summary> Initializes a new instance of <see cref="HttpRequestData"/>. </summary>
        /// <param name="host"> Host name to connect to, defaults to the pod IP. You probably want to set &quot;Host&quot; in httpHeaders instead. </param>
        /// <param name="httpHeaders"> Custom headers to set in the request. HTTP allows repeated headers. </param>
        /// <param name="path"> Path to access on the HTTP server. </param>
        /// <param name="port"> Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. </param>
        /// <param name="scheme"> Scheme to use for connecting to the host. Defaults to HTTP. </param>
        internal HttpRequestData(string host, IList<HttpHeaderData> httpHeaders, string path, int port, HttpScheme? scheme)
        {
            Host = host;
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
            Scheme = scheme;
        }

        /// <summary> Host name to connect to, defaults to the pod IP. You probably want to set &quot;Host&quot; in httpHeaders instead. </summary>
        public string Host { get; set; }
        /// <summary> Custom headers to set in the request. HTTP allows repeated headers. </summary>
        public IList<HttpHeaderData> HttpHeaders { get; }
        /// <summary> Path to access on the HTTP server. </summary>
        public string Path { get; set; }
        /// <summary> Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. </summary>
        public int Port { get; set; }
        /// <summary> Scheme to use for connecting to the host. Defaults to HTTP. </summary>
        public HttpScheme? Scheme { get; set; }
    }
}
