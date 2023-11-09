// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The PiiTaskParameters. </summary>
    internal partial class PiiTaskParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PiiTaskParameters"/>. </summary>
        public PiiTaskParameters()
        {
            PiiCategories = new ChangeTrackingList<PiiEntityLegacyCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="PiiTaskParameters"/>. </summary>
        /// <param name="domain"></param>
        /// <param name="modelVersion"></param>
        /// <param name="loggingOptOut"></param>
        /// <param name="piiCategories"> (Optional) describes the PII categories to return. </param>
        /// <param name="stringIndexType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PiiTaskParameters(PiiTaskParametersDomain? domain, string modelVersion, bool? loggingOptOut, IList<PiiEntityLegacyCategory> piiCategories, StringIndexType? stringIndexType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domain = domain;
            ModelVersion = modelVersion;
            LoggingOptOut = loggingOptOut;
            PiiCategories = piiCategories;
            StringIndexType = stringIndexType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the domain. </summary>
        public PiiTaskParametersDomain? Domain { get; set; }
        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
