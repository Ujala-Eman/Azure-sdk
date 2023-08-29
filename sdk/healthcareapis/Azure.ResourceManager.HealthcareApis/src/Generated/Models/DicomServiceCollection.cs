// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The collection of Dicom Services. </summary>
    internal partial class DicomServiceCollection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DicomServiceCollection"/>. </summary>
        internal DicomServiceCollection()
        {
            Value = new ChangeTrackingList<DicomServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="DicomServiceCollection"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of Dicom Services. </param>
        /// <param name="value"> The list of Dicom Services. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DicomServiceCollection(string nextLink, IReadOnlyList<DicomServiceData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of Dicom Services. </summary>
        public string NextLink { get; }
        /// <summary> The list of Dicom Services. </summary>
        public IReadOnlyList<DicomServiceData> Value { get; }
    }
}
