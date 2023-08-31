// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties to determine origin health using real requests/responses. </summary>
    public partial class ResponseBasedOriginErrorDetectionSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResponseBasedOriginErrorDetectionSettings"/>. </summary>
        public ResponseBasedOriginErrorDetectionSettings()
        {
            HttpErrorRanges = new ChangeTrackingList<HttpErrorRange>();
        }

        /// <summary> Initializes a new instance of <see cref="ResponseBasedOriginErrorDetectionSettings"/>. </summary>
        /// <param name="responseBasedDetectedErrorType"> Type of response errors for real user requests for which origin will be deemed unhealthy. </param>
        /// <param name="responseBasedFailoverThresholdPercentage"> The percentage of failed requests in the sample where failover should trigger. </param>
        /// <param name="httpErrorRanges"> The list of Http status code ranges that are considered as server errors for origin and it is marked as unhealthy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResponseBasedOriginErrorDetectionSettings(ResponseBasedDetectedErrorType? responseBasedDetectedErrorType, int? responseBasedFailoverThresholdPercentage, IList<HttpErrorRange> httpErrorRanges, Dictionary<string, BinaryData> rawData)
        {
            ResponseBasedDetectedErrorType = responseBasedDetectedErrorType;
            ResponseBasedFailoverThresholdPercentage = responseBasedFailoverThresholdPercentage;
            HttpErrorRanges = httpErrorRanges;
            _rawData = rawData;
        }

        /// <summary> Type of response errors for real user requests for which origin will be deemed unhealthy. </summary>
        public ResponseBasedDetectedErrorType? ResponseBasedDetectedErrorType { get; set; }
        /// <summary> The percentage of failed requests in the sample where failover should trigger. </summary>
        public int? ResponseBasedFailoverThresholdPercentage { get; set; }
        /// <summary> The list of Http status code ranges that are considered as server errors for origin and it is marked as unhealthy. </summary>
        public IList<HttpErrorRange> HttpErrorRanges { get; }
    }
}
