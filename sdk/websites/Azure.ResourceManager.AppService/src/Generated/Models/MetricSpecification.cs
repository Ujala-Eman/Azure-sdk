// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Definition of a single resource metric. </summary>
    public partial class MetricSpecification
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MetricSpecification"/>. </summary>
        internal MetricSpecification()
        {
            Dimensions = new ChangeTrackingList<MetricDimension>();
            Availabilities = new ChangeTrackingList<MetricAvailability>();
            SupportedTimeGrainTypes = new ChangeTrackingList<string>();
            SupportedAggregationTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricSpecification"/>. </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="displayDescription"></param>
        /// <param name="unit"></param>
        /// <param name="aggregationType"></param>
        /// <param name="isInstanceLevelAggregationSupported"></param>
        /// <param name="isRegionalMdmAccountEnabled"></param>
        /// <param name="sourceMdmAccount"></param>
        /// <param name="sourceMdmNamespace"></param>
        /// <param name="metricFilterPattern"></param>
        /// <param name="fillGapWithZero"></param>
        /// <param name="isInternal"></param>
        /// <param name="dimensions"></param>
        /// <param name="category"></param>
        /// <param name="availabilities"></param>
        /// <param name="supportedTimeGrainTypes"></param>
        /// <param name="supportedAggregationTypes"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricSpecification(string name, string displayName, string displayDescription, string unit, string aggregationType, bool? isInstanceLevelAggregationSupported, bool? isRegionalMdmAccountEnabled, string sourceMdmAccount, string sourceMdmNamespace, string metricFilterPattern, bool? fillGapWithZero, bool? isInternal, IReadOnlyList<MetricDimension> dimensions, string category, IReadOnlyList<MetricAvailability> availabilities, IReadOnlyList<string> supportedTimeGrainTypes, IReadOnlyList<string> supportedAggregationTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            IsInstanceLevelAggregationSupported = isInstanceLevelAggregationSupported;
            IsRegionalMdmAccountEnabled = isRegionalMdmAccountEnabled;
            SourceMdmAccount = sourceMdmAccount;
            SourceMdmNamespace = sourceMdmNamespace;
            MetricFilterPattern = metricFilterPattern;
            FillGapWithZero = fillGapWithZero;
            IsInternal = isInternal;
            Dimensions = dimensions;
            Category = category;
            Availabilities = availabilities;
            SupportedTimeGrainTypes = supportedTimeGrainTypes;
            SupportedAggregationTypes = supportedAggregationTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets the display description. </summary>
        public string DisplayDescription { get; }
        /// <summary> Gets the unit. </summary>
        public string Unit { get; }
        /// <summary> Gets the aggregation type. </summary>
        public string AggregationType { get; }
        /// <summary> Gets the is instance level aggregation supported. </summary>
        public bool? IsInstanceLevelAggregationSupported { get; }
        /// <summary> Gets the is regional mdm account enabled. </summary>
        public bool? IsRegionalMdmAccountEnabled { get; }
        /// <summary> Gets the source mdm account. </summary>
        public string SourceMdmAccount { get; }
        /// <summary> Gets the source mdm namespace. </summary>
        public string SourceMdmNamespace { get; }
        /// <summary> Gets the metric filter pattern. </summary>
        public string MetricFilterPattern { get; }
        /// <summary> Gets the fill gap with zero. </summary>
        public bool? FillGapWithZero { get; }
        /// <summary> Gets the is internal. </summary>
        public bool? IsInternal { get; }
        /// <summary> Gets the dimensions. </summary>
        public IReadOnlyList<MetricDimension> Dimensions { get; }
        /// <summary> Gets the category. </summary>
        public string Category { get; }
        /// <summary> Gets the availabilities. </summary>
        public IReadOnlyList<MetricAvailability> Availabilities { get; }
        /// <summary> Gets the supported time grain types. </summary>
        public IReadOnlyList<string> SupportedTimeGrainTypes { get; }
        /// <summary> Gets the supported aggregation types. </summary>
        public IReadOnlyList<string> SupportedAggregationTypes { get; }
    }
}
