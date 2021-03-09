// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The HttpRequestParameter. </summary>
    public partial class HttpRequestParameter
    {
        /// <summary> Initializes a new instance of HttpRequestParameter. </summary>
        /// <param name="url"> HTTP URL. </param>
        /// <param name="httpHeader"> HTTP header. </param>
        /// <param name="httpMethod"> HTTP method. </param>
        /// <param name="payload"> HTTP reuqest body. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/>, <paramref name="httpHeader"/>, <paramref name="httpMethod"/>, or <paramref name="payload"/> is null. </exception>
        public HttpRequestParameter(string url, string httpHeader, string httpMethod, string payload)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (httpHeader == null)
            {
                throw new ArgumentNullException(nameof(httpHeader));
            }
            if (httpMethod == null)
            {
                throw new ArgumentNullException(nameof(httpMethod));
            }
            if (payload == null)
            {
                throw new ArgumentNullException(nameof(payload));
            }

            Url = url;
            HttpHeader = httpHeader;
            HttpMethod = httpMethod;
            Payload = payload;
        }

        /// <summary> HTTP URL. </summary>
        public string Url { get; set; }
        /// <summary> HTTP header. </summary>
        public string HttpHeader { get; set; }
        /// <summary> HTTP method. </summary>
        public string HttpMethod { get; set; }
        /// <summary> HTTP reuqest body. </summary>
        public string Payload { get; set; }
    }
}
